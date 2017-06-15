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
using BUS;
using DAO.AppData;

namespace QuanLyBanHang
{
    public partial class FormKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public FormKhachHang()
        {
            InitializeComponent();
       
        }

       

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
           
            frmkhachhangload();
            this.gridView1.ExpandAllGroups();
        }

        private void frmkhachhangload()
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            var listkh = CustomerAndGroupBUS.list();
            gridView1.IndicatorWidth = 40;
            gridControl1.DataSource = listkh;
        }

        private void gridView1_CustomDrawRowIndicator_1(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = e.RowHandle.ToString();
        }

        private void spbtnThem_Click(object sender, EventArgs e)
        {
            frmThamKhachHang f = new frmThamKhachHang();
            f.ShowDialog();
            frmkhachhangload();
            this.gridView1.ExpandAllGroups();
        }

        private void spbtnSuaChua_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                frmSuaKhachHang form = new frmSuaKhachHang();
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                var cmid = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Customer_ID").ToString();
                var kh = BUS.CustomerBUS.queryByID(cmid);
                form.tbMa.Text = kh.Customer_ID;
                form.tbTen.Text = kh.CustomerName;
                form.tbDiaChi.Text = kh.CustomerAdress;
                form.tbDienThoai.Text = kh.Tel;
                form.tbEmail.Text = kh.Email;
                form.cbActive.Checked = (bool)kh.Active;
                form.gridLookUpEdit1.Properties.ValueMember = kh.Customer_Type_ID;
                form.gvKhuVuc.Properties.ValueMember = kh.Customer_Group_ID;
                form.ShowDialog();
                frmkhachhangload();
                gridView1.ExpandAllGroups();
            }
            else MessageBox.Show("Bạn chưa chọn đối tượng cần sửa", "thông báo", MessageBoxButtons.OK);
        }

        private void spbtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có chắc muốn xóa không", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var cmid = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Customer_ID").ToString();
                CustomerBUS.deleteByID(cmid);
                frmkhachhangload();
                gridView1.ExpandAllGroups();
            }
        }

        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}