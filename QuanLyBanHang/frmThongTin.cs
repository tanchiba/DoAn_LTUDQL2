using DevExpress.DataAccess.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO.AppData;

namespace QuanLyBanHang
{
    public partial class frmThongTin : Form
    {
        public frmThongTin()
        {
            InitializeComponent();
        }
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            
            var query = from n in db.SYS_COMPANY
                        select n;

            foreach ( var item in query)
            {
                tbTenDonVi.Text = item.CompanyName;
                tbDiaChi.Text = item.CompanyAddress;
                tbDienThoai.Text = item.Tel;
                tbFax.Text = item.Fax;
                tbEmail.Text = item.Email;
                tbWebsite.Text = item.Website;
         
            }
            
        }

        private void btDongY_Click(object sender, EventArgs e)
        {
            string name = tbTenDonVi.Text;

            var select = db.SYS_COMPANY.Single(tt => tt.CompanyName == name);

            select.CompanyName = tbTenDonVi.Text;
            select.CompanyAddress = tbDiaChi.Text;
            select.Tel = tbDienThoai.Text;
            select.Fax = tbFax.Text;
            select.Website = tbWebsite.Text;
            select.Email = tbEmail.Text;

            db.SaveChanges();
            MessageBox.Show("Lưu thành công");
        }
    }
}
