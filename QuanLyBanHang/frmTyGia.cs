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
    public partial class frmTyGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTyGia()
        {
            InitializeComponent();
        }

        public List<CurrencyDTO> listtygia;

        private static dynamic LayDanhSach()
        {
            return BUS.CurrencyBUS.LoadData();
        }

        private void frmTyGia_Load(object sender, EventArgs e)
        {
            grcTyGia.DataSource = LayDanhSach();
        }

        private void spbtnThem_Click(object sender, EventArgs e)
        {
            frmThemTienTe frm = new frmThemTienTe();
            frm.ShowDialog();
            grcTyGia.DataSource = LayDanhSach();
        }

        private void spbtnSuaChua_Click(object sender, EventArgs e)
        {
            frmCapNhatTienTe frm = new frmCapNhatTienTe();
            frm.Currency_ID = grvTyGia.GetRowCellValue(grvTyGia.FocusedRowHandle, "Currency_ID").ToString();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            grcTyGia.DataSource = LayDanhSach();
        }

        private void spbtnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int vitri = grvTyGia.GetFocusedDataSourceRowIndex();
                BUS.CurrencyBUS.Xoa(grvTyGia.GetRowCellValue(vitri, "Currency_ID").ToString());
                grcTyGia.DataSource = LayDanhSach();
                XtraMessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}