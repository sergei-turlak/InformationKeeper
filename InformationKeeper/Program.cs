using System;
using System.Windows.Forms;

namespace InformationKeeper
{
    static class Program
    {
        public static bool CycleEnabled { get; set; } = true;
        public static bool ShowLogin { get; set; } = true;
        public static bool ShowAuthorization { get; set; }
        public static bool ShowMain { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (CycleEnabled)
            {
                if (ShowLogin)
                    Application.Run(new LoginForm());
                if (ShowAuthorization)
                    Application.Run(new AuthorizationForm());
                if (ShowMain)
                    Application.Run(new MainForm());
            }
        }
    }
}
