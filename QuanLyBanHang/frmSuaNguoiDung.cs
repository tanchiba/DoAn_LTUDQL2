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
    public partial class frmSuaNguoiDung : Form
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        public frmSuaNguoiDung()
        {
            InitializeComponent();
            frmThemNguoiDungLoad();
        }

        private void frmThemNguoiDungLoad()
        {
            var groupid = db.SYS_GROUP.ToList();
            var employee = db.EMPLOYEEs.ToList();
            glNhanVien.Properties.DataSource = employee;
            glNhanVien.Properties.DisplayMember = "Employee_ID";
            glNhanVien.Properties.DisplayMember = "EmployeeName";
            glNhanVien.Properties.ValueMember = "EmployeeName";
            glVaiTro.Properties.DataSource = groupid;
            glVaiTro.Properties.DisplayMember = "Group_ID";
            glVaiTro.Properties.DisplayMember = "GroupName";
            glVaiTro.Properties.ValueMember = "Group_ID";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SYS_USER nd = new SYS_USER();
            var a = glNhanVien.GetSelectedDataRow() as EMPLOYEE;
            var b = glVaiTro.GetSelectedDataRow() as SYS_GROUP;
            nd.UserName = tbTaiKhoan.Text;
            nd.Password = tbMatKhau.Text;
            nd.FullName = a.EmployeeName;
            nd.Description = tbDescription.Text;
            nd.Group_ID = b.Group_ID;
            nd.Active = true;
            db.SYS_USER.Add(nd);
            db.SaveChanges();
            this.Close();
        }

        private void glVaiTro_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
