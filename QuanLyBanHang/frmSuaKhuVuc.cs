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
using DAO.AppData;
using BUS;
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
            bool a;
            if (!checkBox1.Checked)
            {
                a = false;
            }
            else
            {
                a = true;
            }
            CUSTOMER_GROUPBUS.EditByID(tbMa.Text, tbTen.Text, tbGhiChu.Text, a);
            this.Close();
           
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}