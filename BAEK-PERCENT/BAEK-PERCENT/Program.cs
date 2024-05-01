using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAEK_PERCENT.Class.Types;

namespace BAEK_PERCENT
{
    internal static class Program
    {
        private static MainFormManager mainFormManager;
        public static MainFormManager FormControl
        {
            get { return mainFormManager; }
        }


        // Make it readonly

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Database.DatabaseLayer.Connect();

            mainFormManager = new MainFormManager();
            mainFormManager.CurrentForm = mainFormManager.loginForm;

            Application.Run(mainFormManager);
        }
    }
}
