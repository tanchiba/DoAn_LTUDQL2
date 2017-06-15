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
using DTO;

namespace QuanLyBanHang
{
    public partial class frmCapNhatNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhatNhaCungCap()
        {
            InitializeComponent();
        }

        public ProviderDTO ProviderInfo { get; set; }

        public frmCapNhatNhaCungCap(ProviderDTO pvd)
        {
            InitializeComponent();
            ProviderInfo = pvd;
        }

        

        private void frmCapNhatNhaCungCap_Load(object sender, EventArgs e)
        {
            tbMaNhaCungCap.Enabled = false;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string providerID = tbMaNhaCungCap.Text;
            string providerName = tbTenNhaCungCap.Text;
            string Customer_Group_ID = glkKhuVuc.EditValue.ToString();
            string ProviderAddress = tbDiaChi.Text;
            string Email = tbEmail.Text;
            string Descripsion = tbDes.Text;
            string Tel = tbDienThoai.Text;
            Boolean Active;
            if (cEConQuanLy.Checked == true)
                Active = true;
            else Active = false;

            BUS.ProviderBUS.UpdateProvider(providerID, providerName, Customer_Group_ID, ProviderAddress, Tel, Email, Descripsion, Active);
            this.Close();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}