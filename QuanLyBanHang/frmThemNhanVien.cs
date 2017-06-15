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
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        DEPARTMENT dp;
        EMPLOYEE empl;

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            //String 
            edtMa.Text = BUS.EmployeeBUS.MaNhanVien();

            List<DepartmentDTO> bp = BUS.DepartmentBUS.getDepartment();
            glpedtBoPhan.Properties.DataSource = bp;
            glpedtBoPhan.Properties.DisplayMember = "DepartmentName";
            glpedtBoPhan.Properties.ValueMember = "Department_ID";
            glpedtBoPhan.EditValue = glpedtBoPhan.Properties.GetKeyValue(0);

            List<EmployeeDTO> ql = BUS.EmployeeBUS.getEmployee();
            glpedtQuanLy.Properties.DataSource = ql;
            glpedtQuanLy.Properties.DisplayMember = "EmployeeName";
            glpedtQuanLy.Properties.ValueMember = "Employee_ID";
            //glpedtQuanLy.EditValue = glpedtQuanLy.Properties.GetKeyValue(0);

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string emplID = edtMa.Text;
            string emplName = edtName.Text;
            string emplAddress = edtDiaChi.Text;
            string emplTel = edtDienThoai.Text;
            string emplEmail = edtEmail.Text;
            DateTime emplBirthDay = DateTime.Parse(dtpNgaySinh.Text);
            string emplPosition = edtChucVu.Text;
            string emplDepartment = glpedtBoPhan.EditValue.ToString();
            string emplManager = glpedtQuanLy.EditValue.ToString();
            Boolean emplActive;
            if (cbConQuanLy.Checked == true)
                emplActive = true;
            else emplActive = false;
            BUS.EmployeeBUS.InsertEmployee(emplID, emplName, emplAddress, emplTel, emplEmail, emplBirthDay, emplPosition,emplDepartment, emplManager, emplActive);
            this.Close();
        }

        private void glpedtBoPhan_EditValueChanged(object sender, EventArgs e)
        {
            dp = glpedtBoPhan.GetSelectedDataRow() as DEPARTMENT;

        }

        private void glpedtQuanLy_EditValueChanged(object sender, EventArgs e)
        {
            empl = glpedtQuanLy.GetSelectedDataRow() as EMPLOYEE;
        }
    }
}