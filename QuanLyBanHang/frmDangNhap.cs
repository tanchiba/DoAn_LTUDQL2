using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Runtime.InteropServices;

namespace QuanLyBanHang
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);


        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            lblThongBaoLoi.Visible = true;
            SendMessage(txtTenDangNhap.Handle, EM_SETCUEBANNER, 0, "Tên đăng nhập...");
            SendMessage(txtMatKhau.Handle, EM_SETCUEBANNER, 0, "Nhập mật khẩu...");
        }
    }
}