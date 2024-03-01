using NEA1.Forms.Login;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


                //if setup is complete
                if (NEA1.Properties.Settings.Default.SetupComplete)
                {
                    //create new login dialog
                    Login loginScreen = new Forms.Login.Login();

                    //show it to user
                    DialogResult result = loginScreen.ShowDialog();
                    //if correct user/pass
                    if (result == DialogResult.OK)
                    {
                        //load mainmenu with data of the loggeed in user
                        Application.Run(new MainMenu(loginScreen.loggedInUser));
                    }
                }
                else
                {
                    //run setup if not complete 
                    NEA1.Forms.Setup.Setup setupScreen = new NEA1.Forms.Setup.Setup();

                    DialogResult result = setupScreen.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        //load mainmenu with data of the loggeed in user
                        Application.Run(new MainMenu(setupScreen.LoggedInUser));
                    }

                }


        }
    }
}
