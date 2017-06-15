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

namespace QuanLyBanHang
{
    public partial class frmCapNhatKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhatKhoHang()
        {
            InitializeComponent();
        }

        private void frmCapNhatKhoHang_Load(object sender, EventArgs e)
        {
            txtMaKho.Enabled = false;
        }

        public void getData(string Stock_ID, string StockName, string StockAddress, string Email, string Tel, string Description, bool Active, string Manager_ID)
        {
            txtMaKho.Text = Stock_ID;
            txtTen.Text = StockName;
            txtDiaChi.Text = StockAddress;
            txtEmail.Text = Email;
            txtDT.Text = Tel;
            txtDG.Text = Description;
            Manager_ID = grlpedtQuanLy.EditValue.ToString();
            Active = (checkBConQuanLy.Checked == true) ? true : false;


        }

        private void spbtnLuu_Click(object sender, EventArgs e)
        {

            bool Active;
            if (checkBConQuanLy.Checked)
            {
                Active = true;
            }
            else
            {
                Active = false;
            }
            BUS.StockBUS.Sua(txtMaKho.Text, txtTen.Text, txtDiaChi.Text, txtEmail.Text, txtDT.Text, txtDG.Text, Active, grlpedtQuanLy.EditValue.ToString());
            this.Close();
        }

        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}