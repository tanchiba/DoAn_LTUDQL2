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
    public partial class frmThemBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmThemBoPhan()
        {
            InitializeComponent();
        }

        private void frmThemBoPhan_Load(object sender, EventArgs e)
        {

        }

        private void spbtnLuu_Click(object sender, EventArgs e)
        {
            string maBP = edtMaBoPhan.Text;
            string tenBP = edtTenBoPhan.Text;
            string desBP = edtGhiChu.Text;
            Boolean acBP;
            if (cbConQuanLy.Checked == true)
                acBP = true;
            else acBP = false;
            BUS.DepartmentBUS.InsertEmployee(maBP, tenBP, desBP, acBP);
            LoadData();
            this.Close();
            
        }

        public void LoadData()
        {
            frmBoPhan frmbp = new frmBoPhan();
            List<DepartmentDTO> bp = BUS.DepartmentBUS.getDepartment();
            frmbp.grcBoPhan.DataSource = bp;
        }


        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}