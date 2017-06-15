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
using System.Data.Entity;
using DTO;
using DAO.AppData;

namespace QuanLyBanHang
{
    public partial class frmKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoHang()
        {
            InitializeComponent();
        }

        public delegate void SenData(string Stock_ID, string StockName, string StockAddress, string Email, string Tel, string Description, bool Active, string Manager_ID);

        private List<StockDTO> LayDanhSach()
        {
            return BUS.StockBUS.list();
        }

        private void FormKhoHang_Load(object sender, EventArgs e)
        {
            this.grvKhoHang.ExpandAllGroups();
            frmkhohangload();
        }


        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            frmkhohangload();
        }

        private void frmkhohangload()
        {
            grcKhoHang.DataSource = LayDanhSach();
        }

        private void spbtnThem_Click(object sender, EventArgs e)
        {
            frmThemKhoHang frm = new frmThemKhoHang();
            frm.ShowDialog();
            grcKhoHang.DataSource = LayDanhSach();
        }

        private void spbtnSuaChua_Click(object sender, EventArgs e)
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            frmCapNhatKhoHang f = new frmCapNhatKhoHang();
            var id = grvKhoHang.GetRowCellValue(grvKhoHang.FocusedRowHandle, "Stock_ID").ToString();

            STOCK st = db.STOCKs.Single(a => a.Stock_ID == id);
            f.txtMaKho.Text = st.Stock_ID;
            f.txtTen.Text = st.StockName;
            f.txtDiaChi.Text = st.StockAddress;
            f.txtEmail.Text = st.Email;
            f.txtDT.Text = st.Tel;
            f.txtNguoiLienHe.Text = st.Description;

            #region gridlookupedit
            List<EmployeeDTO> ql = BUS.EmployeeBUS.getEmployee();
            f.grlpedtQuanLy.Properties.DataSource = ql;
            f.grlpedtQuanLy.Properties.DisplayMember = "EmployeeName";
            f.grlpedtQuanLy.Properties.ValueMember = "Employee_ID";
            #endregion 

            f.grlpedtQuanLy.EditValue = st.Manager_ID;
            if (st.Active == true)
                f.checkBConQuanLy.Checked = true;
            else f.checkBConQuanLy.Checked = false;

            f.ShowDialog();
            grcKhoHang.DataSource = LayDanhSach();
        }

        private void spbtnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int xoa = grvKhoHang.GetFocusedDataSourceRowIndex();
                BUS.StockBUS.Xoa(grvKhoHang.GetRowCellValue(xoa, "Stock_ID").ToString());
                grcKhoHang.DataSource = LayDanhSach();
                XtraMessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}