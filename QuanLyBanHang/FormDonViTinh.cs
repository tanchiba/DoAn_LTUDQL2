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

namespace QuanLyBanHang
{
    public partial class frmDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SenData(string Unit_ID, string UnitName, string Description, bool Active);
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            List<UnitDTO> dv = BUS.UnitBUS.list();
            grcDonViTinh.DataSource = dv;
        }

        public List<UnitDTO> LayDanhSach()
        {
            return BUS.UnitBUS.list();
        }

        private void spbtnThem_Click(object sender, EventArgs e)
        {
            frmThemDonViTinh frmThem = new frmThemDonViTinh();
            frmThem.ShowDialog();
            grcDonViTinh.DataSource = LayDanhSach();
        }

        private void spbtnSuaChua_Click(object sender, EventArgs e)
        {
            string ma = "";
            string ten = "";
            string ghichu = "";
            bool ConQuanLy = false;


            int index = grvDonViTinh.GetFocusedDataSourceRowIndex();
            ma = grvDonViTinh.GetRowCellValue(index, "Unit_ID").ToString();
            ten = grvDonViTinh.GetRowCellValue(index, "UnitName").ToString();
            ConQuanLy = (bool)grvDonViTinh.GetRowCellValue(index, "Active");
            if (grvDonViTinh.GetRowCellValue(index, "Description") != null)
            {
                ghichu = grvDonViTinh.GetRowCellValue(index, "Description").ToString();

            }

            frmCapNhatDonVi frm = new frmCapNhatDonVi();
            SenData s = new SenData(frm.getData);
            s(ma, ten, ghichu, ConQuanLy);
            frm.ShowDialog();
            grcDonViTinh.DataSource = LayDanhSach();
        }

        private void spbtnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int xoa = grvDonViTinh.GetFocusedDataSourceRowIndex();
                BUS.UnitBUS.XoaDonVi(grvDonViTinh.GetRowCellValue(xoa, "Unit_ID").ToString());
                grcDonViTinh.DataSource = LayDanhSach();

                XtraMessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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