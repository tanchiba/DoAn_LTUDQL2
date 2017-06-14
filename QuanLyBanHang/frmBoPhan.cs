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
using DAO.AppData;

namespace QuanLyBanHang
{
    public partial class frmBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmBoPhan()
        {
            InitializeComponent();
        }

     

        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            List<DepartmentDTO> bp = BUS.DepartmentBUS.getDepartment();
            grcBoPhan.DataSource = bp;
        }

        private void spbtnThem_Click(object sender, EventArgs e)
        {
            frmThemBoPhan frmThemBP = new frmThemBoPhan();
            frmThemBP.Show();
            LoadData();
        }

        private void spbtnSuaChua_Click(object sender, EventArgs e)
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            frmCapNhatBoPhan frm = new frmCapNhatBoPhan();
            var idBP = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Department_ID").ToString();
            DEPARTMENT bp = db.DEPARTMENTs.Single(a => a.Department_ID == idBP);

            frm.edtMaBoPhan.Text = bp.Department_ID;
            frm.edtTenBoPhan.Text = bp.DepartmentName;
            frm.edtGhiChu.Text = bp.Description;
            if (bp.Active == true)
                frm.cbConQuanLy.Checked = true;
            else frm.cbConQuanLy.Checked = false;
            

            frm.ShowDialog();
            LoadData();
        }

        private void DeleteDepartment()
        {
            var idBP = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Department_ID").ToString();
            BUS.DepartmentBUS.DeleteEmployee(idBP);
            LoadData();
        }

        private void spbtnXoa_Click(object sender, EventArgs e)
        {
            DeleteDepartment();
        }

        private void spbtnNapLai_Click(object sender, EventArgs e)
        {

        }

        private void spbtnXuat_Click(object sender, EventArgs e)
        {

        }

        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}