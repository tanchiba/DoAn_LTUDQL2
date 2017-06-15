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
    public partial class frmThemDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public frmThemDonViTinh()
        {
            InitializeComponent();
        }

        private void spbtnLuu_Click(object sender, EventArgs e)
        {
            string Unit_ID = txtMaDonViTinh.Text;
            string UnitName = txtTenDonViTinh.Text;
            string Description = txtGhiChu.Text;
            bool Active;
            if (checkBConQuanLy.Checked == true)
                Active = true;
            else
                Active = false;
            BUS.UnitBUS.ThemDonVi(Unit_ID, UnitName, Description, Active);
            this.Close();

        }

        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemDonViTinh_Load(object sender, EventArgs e)
        {
            txtMaDonViTinh.Text = BUS.UnitBUS.MaDonVi();
        }
    }
}