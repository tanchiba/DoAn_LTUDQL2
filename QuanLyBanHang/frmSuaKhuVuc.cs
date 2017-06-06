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
    public partial class frmSuaKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public frmSuaKhuVuc()
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

        private void frmSuaKhuVuc_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            var khuvuc = db.CUSTOMER_GROUP.Single(a => a.Customer_Group_ID == tbMa.Text.ToString());
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
            db.SaveChanges();
            
            this.Close();
           
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}