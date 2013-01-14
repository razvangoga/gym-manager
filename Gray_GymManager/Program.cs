using System;
using System.Collections.Generic;
using System.Windows.Forms;

using BLL.LoginLogic;
using DAL.Logic;
using GUI.LoginWindow;
using GUI.MainWindow;

namespace Gemini
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Settings.Load();
            while (!LoginLogic.ExitApplication)
            {
                //open login form for authetification
                Application.Run(new LoginForm());

                //if authentification is succesfull : open main form
                if (LoginLogic.LoginComplete)
                    Application.Run(new MainWindow());
            }
        }
    }
}