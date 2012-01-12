using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TXL
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginFrm login = new LoginFrm();
            login.ShowDialog();

            if (login.eachfrm == true)
            {
                Application.Run(new MainFrm(login));
            }
        }
    }
}
