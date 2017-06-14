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
    public partial class frmCapNhatNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhatNhanVien()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ma = edtMa.Text;
           
            string name = edtTen.Text;
            string address = edtDiaChi.Text;
            string tel = edtDienThoai.Text;
            string email = edtEmail.Text;
            DateTime ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
            string chucvu = edtChucVu.Text;
            string bophan = glpedtBoPhan.EditValue.ToString();
            string quanly = glpedtQuanLy.EditValue.ToString();
            Boolean active;
            if (cbConQuanLy.Checked == true)
                active = true;
            else active = false;

            BUS.EmployeeBUS.UpdateEmployee(ma, name, address, tel, email, ngaysinh, chucvu, bophan, quanly, active);
            this.Close();
        }

        private void frmCapNhatNhanVien_Load(object sender, EventArgs e)
        {
            edtMa.Enabled = false;
        }
    }
}