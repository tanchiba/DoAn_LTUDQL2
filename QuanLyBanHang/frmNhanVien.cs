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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
     
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            List<EmployeeDTO> nv = BUS.EmployeeBUS.getEmployee();
            grcNhanVien.DataSource = nv;
        }

        public List<EmployeeDTO> LayDanhSach()
        {
            return BUS.EmployeeBUS.getEmployee();
        }

        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void spbtnThem_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frmThem = new frmThemNhanVien();
            frmThem.ShowDialog();
            grcNhanVien.DataSource = LayDanhSach();
        }

        private void spbtnSuaChua_Click(object sender, EventArgs e)
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            frmCapNhatNhanVien frm = new frmCapNhatNhanVien();
            var empl_id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Employee_ID").ToString();
            EMPLOYEE em = db.EMPLOYEEs.Single(a => a.Employee_ID == empl_id);
            frm.edtMa.Text = em.Employee_ID;
            frm.edtTen.Text = em.EmployeeName;
            frm.edtDiaChi.Text = em.EmployeeAddress;
            frm.edtDienThoai.Text = em.Tel;
            frm.edtEmail.Text = em.Email;
            frm.dtpNgaySinh.Text = Convert.ToString(em.Birthday);
            frm.edtChucVu.Text = em.Position;

           
            #region gridlookupedit
            List<DepartmentDTO> bp = BUS.DepartmentBUS.getDepartment();
            frm.glpedtBoPhan.Properties.DataSource = bp;
            frm.glpedtBoPhan.Properties.DisplayMember = "DepartmentName";
            frm.glpedtBoPhan.Properties.ValueMember = "Department_ID";
            

            List<EmployeeDTO> ql = BUS.EmployeeBUS.getEmployee();
            frm.glpedtQuanLy.Properties.DataSource = ql;
            frm.glpedtQuanLy.Properties.DisplayMember = "EmployeeName";
            frm.glpedtQuanLy.Properties.ValueMember = "Employee_ID";
            #endregion

            frm.glpedtBoPhan.EditValue = em.Department_ID;
            frm.glpedtQuanLy.EditValue = em.Manager_ID;
            if (em.Active == true)
                frm.cbConQuanLy.Checked = true;
            else frm.cbConQuanLy.Checked = false;
          
            frm.ShowDialog();
            LoadData();
        }

        private void spbtnXoa_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
        }

        private void spbtnNapLai_Click(object sender, EventArgs e)
        {

        }

        private void spbtnXuat_Click(object sender, EventArgs e)
        {

        }

        private void DeleteEmployee()
        {

            //Lấy ra index dòng được chọn -> Từ đó lấy ra id nhân viên muốn xóa
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var idEmpl = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Employee_ID").ToString();
                BUS.EmployeeBUS.DeleteEmployee(idEmpl);
                LoadData();
                XtraMessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}