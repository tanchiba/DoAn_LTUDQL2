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
    public partial class frmCapNhatDonVi : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhatDonVi()
        {
            InitializeComponent();
        }

        private void frmCapNhatDonVi_Load(object sender, EventArgs e)
        {

        }

        public void getData(string UnitID, string UnitName, string Description, bool Active)
        {
            txtMaDonViTinh.Text = UnitID;
            txtTenDonViTinh.Text = UnitName;
            txtGhiChu.Text = Description;
            if (Active == true)
            {
                checkBConQuanLy.Checked = true;
            }
            else
            {
                checkBConQuanLy.Checked = false;
            }
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
            BUS.UnitBUS.Sua(txtMaDonViTinh.Text, txtTenDonViTinh.Text, txtGhiChu.Text, Active);
            this.Close();
        }


        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}