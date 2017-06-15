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
    public partial class frmNhomHang : DevExpress.XtraEditors.XtraForm
    {
        public frmNhomHang()
        {
            InitializeComponent();
        }

        public delegate void SenData(string Product_Group_ID, string Product_Group_Name, string Description, bool Active);

        private List<Product_GroupDTO> LayDanhSach()
        {
            return BUS.Product_GroupBUS.list();
        }


        private void frmNhomHang_Load(object sender, EventArgs e)
        {
            grcNhomHang.DataSource = LayDanhSach();
        }

        private void spbtnThem_Click(object sender, EventArgs e)
        {
            frmThemNhomHangHoa frm = new frmThemNhomHangHoa();
            frm.ShowDialog();
            grcNhomHang.DataSource = LayDanhSach();
        }

        private void spbtnSuaChua_Click(object sender, EventArgs e)
        {
            string Product_Group_ID = "";
            string Product_Group_Name = "";
            string Description = "";
            bool Active = false;
            int vitri = grvNhomHang.GetFocusedDataSourceRowIndex();
            Product_Group_ID = grvNhomHang.GetRowCellValue(vitri, "Product_Group_ID").ToString();
            Product_Group_Name = grvNhomHang.GetRowCellValue(vitri, "Product_Group_Name").ToString();
            Active = (bool)grvNhomHang.GetRowCellValue(vitri, "Active");
            if (grvNhomHang.GetRowCellValue(vitri, "Description") != null)
            {
                Description = grvNhomHang.GetRowCellValue(vitri, "Description").ToString();
            }

            frmCapNhatNhomHangHoa frm = new frmCapNhatNhomHangHoa();
            SenData s = new SenData(frm.getData);
            s(Product_Group_ID, Product_Group_Name, Description, Active);
            frm.ShowDialog();
            grcNhomHang.DataSource = LayDanhSach();
        }

        private void spbtnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int vitri = grvNhomHang.GetFocusedDataSourceRowIndex();
                BUS.Product_GroupBUS.Xoa(grvNhomHang.GetRowCellValue(vitri, "Product_Group_ID").ToString());
                grcNhomHang.DataSource = LayDanhSach();
                XtraMessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}