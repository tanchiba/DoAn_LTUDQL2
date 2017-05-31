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
using QuanLyBanHang.AppData;
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
        QuanLyBanHangEntities dn = new QuanLyBanHangEntities();
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            lblThongBaoLoi.Visible = true;
            SendMessage(txtTenDangNhap.Handle, EM_SETCUEBANNER, 0, "Tên đăng nhập...");
            SendMessage(txtMatKhau.Handle, EM_SETCUEBANNER, 0, "Nhập mật khẩu...");
        }

       

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
            btnDangNhap.Enabled = false;
            if (txtTenDangNhap.Text == String.Empty)
            {
                lblThongBaoLoi.Visible = false;
                lblThongBaoLoi.ForeColor = Color.Red;
                lblThongBaoLoi.Text = "Vui lòng nhập username!";
                txtTenDangNhap.Enabled = true;
                //txtTenDangNhap.Fo = Brushes.Red;
                txtMatKhau.Enabled = true;
                btnDangNhap.Enabled = true;
            }
            else
            {
                if (txtMatKhau.Text == String.Empty)
                {
                    lblThongBaoLoi.Visible = false;
                    lblThongBaoLoi.ForeColor = Color.Red;
                    lblThongBaoLoi.Text = "Vui lòng nhập password!";
                    txtTenDangNhap.Enabled = true;
                    txtMatKhau.Enabled = true;
                    //pbxPassword.BorderBrush = Brushes.Red;
                    btnDangNhap.Enabled = true;
                }
                else
                {
                    foreach (var dntk in dn.SYS_USER)
                    {
                        if (dntk.UserName == txtTenDangNhap.Text && dntk.Password == txtMatKhau.Text)
                        {
                            frmSplashScreen spl = new frmSplashScreen();
                            this.Visible = false;
                            spl.ShowDialog();

                            this.Close();
                        }
                        else
                        {
                            lblThongBaoLoi.Visible = false;
                            lblThongBaoLoi.ForeColor = Color.Red;
                            lblThongBaoLoi.Text = "Forgot password!";
                            txtTenDangNhap.Enabled = true;
                            //txtUsername.BorderBrush = Brushes.Red;
                            txtMatKhau.Enabled = true;
                            //pbxPassword.BorderBrush = Brushes.Red;
                            btnDangNhap.Enabled = true;
                        }
                    }

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
            btnDangNhap.Enabled = false;
            if (txtTenDangNhap.Text == String.Empty)
            {
                lblThongBaoLoi.Visible = false;
                lblThongBaoLoi.ForeColor = Color.Red;
                lblThongBaoLoi.Text = "Vui lòng nhập username!";
                txtTenDangNhap.Enabled = true;
                //txtTenDangNhap.Fo = Brushes.Red;
                txtMatKhau.Enabled = true;
                btnDangNhap.Enabled = true;
            }
            else
            {
                if (txtMatKhau.Text == String.Empty)
                {
                    lblThongBaoLoi.Visible = false;
                    lblThongBaoLoi.ForeColor = Color.Red;
                    lblThongBaoLoi.Text = "Vui lòng nhập password!";
                    txtTenDangNhap.Enabled = true;
                    txtMatKhau.Enabled = true;
                    //pbxPassword.BorderBrush = Brushes.Red;
                    btnDangNhap.Enabled = true;
                }
                else
                {
                    foreach (var dntk in dn.SYS_USER)
                    {
                        if (dntk.UserName == txtTenDangNhap.Text && dntk.Password == txtMatKhau.Text)
                        {
                            frmSplashScreen spl = new frmSplashScreen();
                            this.Hide();
                            spl.ShowDialog();

                            this.Close();
                        }
                        else
                        {
                            lblThongBaoLoi.Visible = false;
                            lblThongBaoLoi.ForeColor = Color.Red;
                            lblThongBaoLoi.Text = "Forgot password!";
                            txtTenDangNhap.Enabled = true;
                            //txtUsername.BorderBrush = Brushes.Red;
                            txtMatKhau.Enabled = true;
                            //pbxPassword.BorderBrush = Brushes.Red;
                            btnDangNhap.Enabled = true;
                        }
                    }

                }
            }
        }
    }
}