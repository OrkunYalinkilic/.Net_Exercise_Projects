using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy.WFUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool LK = LisansKontrol();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (LK)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new LisansEkran());
            }
        }

        static bool LisansKontrol() // Registry..
        {
            RegistryKey RK = Registry.CurrentUser.OpenSubKey("TelefonRehberi");
            if (RK != null)
            {
                string HDDSN = RK.GetValue("HardDiskSeriNumarasi").ToString();
                string MACADD = RK.GetValue("MACAddress").ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
