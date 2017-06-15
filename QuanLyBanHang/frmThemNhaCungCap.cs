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
    public partial class frmThemNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmThemNhaCungCap_Load(object sender, EventArgs e)
        {
            tbMaNhaCungCap.Text = BUS.ProviderBUS.MaNhaCungCap();

            List<CUSTOMER_GROUPDTO> ql = BUS.CUSTOMER_GROUPBUS.list();
            glkKhuVuc.Properties.DataSource = ql;
            glkKhuVuc.Properties.DisplayMember = "Customer_Group_Name";
            glkKhuVuc.Properties.ValueMember = "Customer_Group_ID";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            InsertProvider();
        }

        private void btKhuvuc_Click(object sender, EventArgs e)
        {
            frmThemKhuVuc frm = new frmThemKhuVuc();
            frm.ShowDialog();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertProvider()
        {

            if (glkKhuVuc.Text == "" || tbMaNhaCungCap.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn Mã Nhà Cung Cấp hoặc Khu Vưc", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            string providerID = tbMaNhaCungCap.Text;
            string providerName = tbTenNhaCungCap.Text;
            string Customer_Group_ID = glkKhuVuc.EditValue.ToString();
            string ProviderAddress = tbDiaChi.Text;
            string Email = tbEmail.Text;
            string Descripsion = tbDes.Text;
            string Tel = tbDienThoai.Text;
            Boolean Active;
            if (cbConQuanLy.Checked == true)
                Active = true;
            else Active = false;

            BUS.ProviderBUS.InsertProvider(providerID, providerName, Customer_Group_ID, ProviderAddress, Tel, Email, Descripsion, Active);
            this.Close();
        }

       
    }
}