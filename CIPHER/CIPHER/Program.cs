using CIPHER.Forms;
using CIPHER.Helpers;

namespace CIPHER
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Show login — blocks here until closed
            var auth = new AuthenticationForm();
            auth.ShowDialog();

            // After login — check who logged in
            if (SessionManager.IsLoggedIn)
            {
                if (SessionManager.isAdmin)
                    Application.Run(new AdminMainShell());
                else
                    Application.Run(new UserMainShell());
            }
        }
    }
}