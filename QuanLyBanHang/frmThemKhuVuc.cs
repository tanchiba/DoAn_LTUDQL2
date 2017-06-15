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
using BUS;
namespace QuanLyBanHang
{
    public partial class frmThemKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public frmThemKhuVuc()
        {
            InitializeComponent();
        }

        

        
        private void btnThem_Click(object sender, EventArgs e)
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
            CUSTOMER_GROUPBUS.add(tbMa.Text, tbTen.Text, tbGhiChu.Text, a);
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemKhuVuc_Load(object sender, EventArgs e)
        {
            tbMa.Text = BUS.CUSTOMER_GROUPBUS.MaKhuVuc();
        }
    }
}