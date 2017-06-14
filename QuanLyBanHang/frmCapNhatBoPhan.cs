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
    public partial class frmCapNhatBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhatBoPhan()
        {
            InitializeComponent();
        }

        private void frmCapNhatBoPhan_Load(object sender, EventArgs e)
        {
            edtMaBoPhan.Enabled = false;
        }

        private void spbtnLuu_Click(object sender, EventArgs e)
        {
            string maBP = edtMaBoPhan.Text;
            string tenBP = edtTenBoPhan.Text;
            string desBP = edtGhiChu.Text;

            Boolean active;
            if (cbConQuanLy.Checked == true)
                active = true;
            else active = false;

            BUS.DepartmentBUS.UpdateEmployee(maBP, tenBP, desBP, active);
            this.Close();
        }

        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}