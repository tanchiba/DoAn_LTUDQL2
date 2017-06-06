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
namespace QuanLyBanHang
{
    public partial class frmThemKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public frmThemKhuVuc()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            CUSTOMER_GROUP khuvuc = new CUSTOMER_GROUP();
            khuvuc.Customer_Group_ID = tbMa.Text;
            khuvuc.Customer_Group_Name = tbTen.Text;
            khuvuc.Description = tbGhiChu.Text;
            if (!checkBox1.Checked)
            {
                khuvuc.Active = false;
            }
            else
            {
                khuvuc.Active = true;
            }
            db.CUSTOMER_GROUP.Add(khuvuc);
            db.SaveChanges();
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}