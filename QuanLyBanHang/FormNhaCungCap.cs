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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

      
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
            grvNhaCungCap.ExpandAllGroups();
            grvNhaCungCap.IndicatorWidth = 40;
        }

        public void LoadData()
        {
            List<ProviderDTO> nhacungcap = BUS.ProviderBUS.list();
            grcNhaCungCap.DataSource = nhacungcap;
        }

        public List<ProviderDTO> LayDanhSach()
        {
            return BUS.ProviderBUS.list();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNhaCungCap frm = new frmThemNhaCungCap();
            frm.ShowDialog();
            grcNhaCungCap.DataSource = LayDanhSach();
        }

        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            if (grvNhaCungCap.FocusedRowHandle >= 0)
            {
                frmCapNhatNhaCungCap frm = new frmCapNhatNhaCungCap();
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                var cmid = grvNhaCungCap.GetRowCellValue(grvNhaCungCap.FocusedRowHandle, "Provider_ID").ToString();
                var pvd = db.PROVIDERs.Single(a => a.Provider_ID == cmid);
                frm.tbMaNhaCungCap.Text = pvd.Provider_ID;
                frm.tbTenNhaCungCap.Text = pvd.ProviderName;

                #region gridlookupedit
                List<CUSTOMER_GROUPDTO> ql = BUS.CUSTOMER_GROUPBUS.list();
                frm.glkKhuVuc.Properties.DataSource = ql;
                frm.glkKhuVuc.Properties.DisplayMember = "Customer_Group_Name";
                frm.glkKhuVuc.Properties.ValueMember = "Customer_Group_ID";
                #endregion

                frm.glkKhuVuc.EditValue = pvd.Customer_Group_ID;
                frm.tbDiaChi.Text = pvd.ProviderAddress;
                frm.tbDienThoai.Text = pvd.Tel;
                frm.tbEmail.Text = pvd.Email;
                frm.tbDes.Text = pvd.Description;
           

                frm.ShowDialog();

                grvNhaCungCap.ExpandAllGroups();
                LoadData();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đối tượng cần sửa", "thông báo", MessageBoxButtons.OK);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = grvNhaCungCap.FocusedRowHandle;
                string name = "Provider_ID";
                object value = grvNhaCungCap.GetRowCellValue(row_index, name);

                BUS.ProviderBUS.DeleteProvider((string)value);
                LoadData();
                XtraMessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}