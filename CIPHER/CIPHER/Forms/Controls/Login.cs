using CIPHER.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CIPHER.Forms.Controls
{
    public partial class Login : UserControl
    {

        // These sit at the top so the whole class can access them
        private string currentCodename = "";
        private bool isRootAccess = false;
        public Login()
        {
            InitializeComponent();

            // Force the cursor to start inside the box
            this.Load += (s, e) => richTextBox1.Focus();

            PrintToTerminal("CIPHER(TM) TERMINAL v4.0.2");
            PrintToTerminal("---------------------------------");
            richTextBox1.AppendText("Are you an Agent? (Y/N): ");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public enum LoginState
        {
            AskingIfAgent,
            AwaitingIdentity,
            AwaitingPassword
        }

        // Current state tracker
        private LoginState currentState = LoginState.AskingIfAgent;

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 1. Get the text the user just typed (the last line)
                string input = GetLastLine();

                // 2. Decide what to do based on our current State
                ProcessInput(input);

                // 3. Prevent the cursor from just going to a new line automatically
                e.Handled = true;
            }
        }

        private void ProcessInput(string fullLine)
        {
            // Use a helper to get just the user's part (the stuff after the ": ")
            string input = fullLine.Contains(": ") ? fullLine.Substring(fullLine.LastIndexOf(": ") + 2).Trim() : fullLine.Trim();
            AuthService authService = new AuthService();

            switch (currentState)
            {
                case LoginState.AskingIfAgent:
                    if (input.ToUpper() == "Y")
                    {
                        PrintToTerminal(""); // Moves to a new line
                        richTextBox1.AppendText("[SYSTEM]: PLEASE IDENTIFY: ");
                        currentState = LoginState.AwaitingIdentity;
                    }
                    break;

                case LoginState.AwaitingIdentity:
                    // Check if they used sudo
                    isRootAccess = input.StartsWith("sudo ");

                    // Save the codename (removing 'sudo ' if it exists)
                    currentCodename = input.Replace("sudo ", "").Trim();

                    PrintToTerminal("");
                    richTextBox1.AppendText("[SYSTEM]: ENTER ACCESS KEY: ");

                    richTextBox1.SelectionColor = Color.Black; // Hide typing
                    currentState = LoginState.AwaitingPassword;
                    break;

                case LoginState.AwaitingPassword:
                    string password = input;
                    richTextBox1.SelectionColor = Color.Lime;
                    

                    PrintToTerminal("\n[SYSTEM]: AUTHENTICATING...");

                    // Deconstructing the Tuple (bool isValid, string message, string role)
                    var (isValid, message, role) = authService.Login(currentCodename, password);

                    if (isValid)
                    {
                        PrintToTerminal($"[SUCCESS]: {message}");
                        PrintToTerminal($"[ROLE]: {role}");

                        // Use the 'role' or your 'isRootAccess' to decide which form to show
                        //LaunchDashboard(role);
                    }
                    else
                    {
                        PrintToTerminal($"[ERROR]: {message}");
                        // Reset state or give another try
                        PrintToTerminal("\n[SYSTEM]: PLEASE IDENTIFY: ");
                        currentState = LoginState.AwaitingIdentity;
                    }
                    break;
            }
        }

        private string GetLastInput(string prompt)
{
    string lastLine = GetLastLine();
    // This removes the "Are you an Agent? (Y/N): " part so we only get "Y"
    if (lastLine.Contains(": "))
    {
        return lastLine.Substring(lastLine.LastIndexOf(": ") + 2).Trim();
    }
    return lastLine.Trim();
}

        private string GetLastLine()
        {
            if (richTextBox1.Lines.Length > 0)
            {
                // Get the very last string in the Lines array
                return richTextBox1.Lines[richTextBox1.Lines.Length - 1];
            }
            return string.Empty;
        }

        private void PrintToTerminal(string text)
        {
            // Append the text to the end
            richTextBox1.AppendText(text + Environment.NewLine);

            // Reset color to Lime (in case we were hiding a password)
            richTextBox1.SelectionColor = Color.Lime;

            // Auto-scroll to the bottom
            richTextBox1.ScrollToCaret();
        }

        
    }
}
