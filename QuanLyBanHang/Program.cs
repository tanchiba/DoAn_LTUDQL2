using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;

namespace QuanLyBanHang
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

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
<<<<<<< HEAD
            Application.Run(new frmDangNhap());
=======
            Application.Run(new frmHangHoa());
>>>>>>> 8c0376828db4b7832a39cd99438dd84d4d831cb9
        }
    }
}
