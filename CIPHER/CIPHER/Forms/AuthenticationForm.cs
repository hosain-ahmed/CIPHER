using CIPHER.Helpers;
using CIPHER.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIPHER.Forms
{
    public partial class AuthenticationForm : Form
    {
        private enum TerminalState { AskType, LoginUser, LoginPass, RegUser, RegName, RegEmail, RegPass, Processing }
        private TerminalState currentState = TerminalState.AskType;

        private string tempUser = "";
        private string tempEmail = "";
        private string tempName = "";
        private string passwordBuffer = "";
        public AuthenticationForm()
        {
            InitializeComponent();
            SetupTerminalLook();
            StartBootSequence();
        }

        private void StartBootSequence()
        {
            rtbLogin.Clear();
            rtbLogin.SelectionColor = Color.Black;
            rtbLogin.AppendText("-------------------------------------------------------------------------------------\n");
            rtbLogin.AppendText(@"      ___                                      ___           ___           ___     
     /  /\           ___         ___          /  /\         /  /\         /  /\    
    /  /::\         /__/\       /  /\        /  /:/        /  /::\       /  /::\   
   /  /:/\:\        \__\:\     /  /::\      /  /:/        /  /:/\:\     /  /:/\:\  
  /  /:/  \:\       /  /::\   /  /:/\:\    /  /::\ ___   /  /::\ \:\   /  /::\ \:\ 
 /__/:/ \  \:\   __/  /:/\/  /  /::\ \:\  /__/:/\:\  /\ /__/:/\:\ \:\ /__/:/\:\_\:\
 \  \:\  \__\/  /__/\/:/~~  /__/:/\:\_\:\ \__\/  \:\/:/ \  \:\ \:\_\/ \__\/~|::\/:/
  \  \:\        \  \::/     \__\/  \:\/:/      \__\::/   \  \:\ \:\      |  |:|::/ 
   \  \:\        \  \:\          \  \::/       /  /:/     \  \:\_\/      |  |:|\/  
    \  \:\        \__\/           \__\/       /__/:/       \  \:\        |__|:|~   
     \__\/                                    \__\/         \__\/         \__\|    
");
            rtbLogin.AppendText("-------------------------------------------------------------------------------------\n");
            rtbLogin.AppendText("Version 1.0.0 - CIPHER Authentication Terminal\n");
            rtbLogin.AppendText("\n");
            rtbLogin.AppendText("\n");
            rtbLogin.AppendText("Are you a previous user? (Y/N): ");
            rtbLogin.AppendText("");
            currentState = TerminalState.AskType;
        }

        private void rtbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (currentState == TerminalState.LoginPass || currentState == TerminalState.RegPass)
            {
                if (!char.IsControl(e.KeyChar))
                {
                    passwordBuffer += e.KeyChar;
                    rtbLogin.AppendText("");
                    e.Handled = true;
                }
            }
        }

        private void SetupTerminalLook()
        {
            // Use the primary background from image_2d8b79.png
            rtbLogin.BackColor = Theme.BackgroundMain;
            rtbLogin.ForeColor = Theme.TextMain;
            rtbLogin.Font = new Font("Cascadia Code", 11, FontStyle.Regular);
        }

        private void rtbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                int lineStart = rtbLogin.GetFirstCharIndexOfCurrentLine();
                string currentLine = rtbLogin.Lines.Last();
                int promptIndex = currentLine.LastIndexOf(":") + 2;

                if (rtbLogin.SelectionStart <= lineStart + promptIndex)
                {
                    e.SuppressKeyPress = true; // Prevent backspace if at or before prompt
                }
                else if (currentState == TerminalState.LoginPass || currentState == TerminalState.RegPass)
                {
                    if (passwordBuffer.Length > 0)
                    {
                        passwordBuffer = passwordBuffer.Substring(0, passwordBuffer.Length - 1);
                    }
                }
                

            }
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the ding sound on enter
                ProcessInput();
            }
        }

        private void ProcessInput()
        {
            string lastLine = rtbLogin.Lines.Last();
            string input = ExtractInput(lastLine);
            rtbLogin.AppendText(Environment.NewLine);

            switch (currentState)
            {
                case TerminalState.AskType:
                    if (input.ToLower() == "y")
                    {
                        PrintPrompt("Username: ");
                        currentState = TerminalState.LoginUser;
                    }
                    else if (input.ToLower() == "n")
                    {
                        PrintPrompt("Choose a username: ");
                        currentState = TerminalState.RegUser;
                    }
                    else if(input.ToLower()== "exit"){
                        System.Environment.Exit(0);
                    }

                    else
                    {
                        PrintPrompt("Please enter Y or N: ");
                    }
                    break;
                case TerminalState.LoginUser:
                    tempUser = input;
                    passwordBuffer = "";
                    PrintPrompt("Password: ");
                    currentState = TerminalState.LoginPass;
                    break;
                case TerminalState.RegUser:
                    tempUser = input;
                    PrintPrompt("Full Name: ");
                    currentState = TerminalState.RegName;
                    break;

                case TerminalState.RegName:
                    tempName = input;
                    PrintPrompt("Email: ");
                    currentState = TerminalState.RegEmail;
                    break;
                case TerminalState.RegEmail:
                    tempEmail = input;
                    PrintPrompt("Choose a password: ");
                    currentState = TerminalState.RegPass;
                    break;
                case TerminalState.LoginPass:
                case TerminalState.RegPass:
                    ExecuteBackend();
                    break;
            }
        }

        private async void ExecuteBackend()
        {
            TerminalState previousState = currentState;
            currentState = TerminalState.Processing;

            rtbLogin.SelectionColor = Color.Green;
            rtbLogin.AppendText("CONTACTING DATABASE..." + Environment.NewLine);

            await Task.Delay(800);

            var auth = new AuthService();

            if (previousState == TerminalState.LoginPass)
            {
                // TEMPORARY DEBUG - remove before submission
                

                
                var (success, user, error) = auth.Login(tempUser, passwordBuffer);

                if (success)
                {
                    rtbLogin.AppendText($"WELCOME BACK AGENT : {user.Codename}" + Environment.NewLine);
                    await Task.Delay(1000);
                    
                    
                   
                    if (SessionManager.isAdmin)
                    {
                        var main = new AdminMainShell();
                        main.Show();
                    }
                    else                     {
                        var main = new UserMainShell();
                        main.Show();
                    }

                    this.Close();

                }
                else
                {
                    rtbLogin.AppendText($"ERROR: {error}" + Environment.NewLine);
                    await Task.Delay(1000);
                    StartBootSequence();
                }
            }
            else
            {
                var (success, error) = auth.Register(tempUser, tempName, tempEmail, passwordBuffer,1);
                if (success)
                {
                    rtbLogin.AppendText($"REGISTRATION SUCCESSFUL. WELCOME ABOARD, AGENT {tempUser}!" + Environment.NewLine);
                    await Task.Delay(1000);
                    StartBootSequence();
                }
                else
                {
                    rtbLogin.AppendText($"ERROR: {error}" + Environment.NewLine);
                    await Task.Delay(1000);
                    StartBootSequence();
                }
            }

            
        }

        private string ExtractInput(string line)
        {
            int colonIndex = line.LastIndexOf(":");
            return (colonIndex == -1) ? "" : line.Substring(colonIndex + 1).Trim();
        }

        private void PrintPrompt(string prompt)
        {
            rtbLogin.SelectionColor = Theme.MutedTeal;
            rtbLogin.SelectionFont = new Font(rtbLogin.Font, FontStyle.Bold);
            rtbLogin.AppendText(prompt);

            // Switch back to Primary Text for user typing
            rtbLogin.SelectionColor = Theme.TextMain;
            rtbLogin.SelectionFont = new Font(rtbLogin.Font, FontStyle.Regular);
        }
    }
}