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
using QuanLyBanHang.AppData;
namespace QuanLyBanHang
{
    public partial class FormKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public FormKhachHang()
        {
            InitializeComponent();
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                frmSuaKhachHang form = new frmSuaKhachHang();
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                var cmid = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Customer_ID").ToString();
                var kh = db.CUSTOMERs.Single(a => a.Customer_ID == cmid);
                form.tbMa.Text = kh.Customer_ID;
                form.tbTen.Text = kh.CustomerName;
                form.tbDiaChi.Text = kh.CustomerAddress;
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

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            //this.cUSTOMERTableAdapter.Fill(this.quanLyBanHangDataSet.CUSTOMER);
            frmkhachhangload();
            this.gridView1.ExpandAllGroups();
        }
    private void frmkhachhangload()
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            List<CUSTOMER> listkhachhang = db.CUSTOMERs.ToList<CUSTOMER>();
            var listkh = from a in db.CUSTOMERs
                         from b in db.CUSTOMER_GROUP
                         where a.Customer_Group_ID == b.Customer_Group_ID
                         select new
                         {
                             Customer_ID = a.Customer_ID, CustomerName = a.CustomerName, Customer_Group_ID = b.Customer_Group_Name,CustomerAddress = a.CustomerAddress,Email = a.Email,Tel = a.Tel,Active = a.Active,
                                
                          };
            gridView1.IndicatorWidth = 40;
            gridControl1.DataSource = listkh.ToList() ;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomDrawRowIndicator_1(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = e.RowHandle.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThamKhachHang f = new frmThamKhachHang();
            f.ShowDialog();
            frmkhachhangload();
            this.gridView1.ExpandAllGroups();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có chắc muốn xóa không", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                var cmid = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Customer_ID").ToString();
                CUSTOMER cm = db.CUSTOMERs.Single(a => a.Customer_ID == cmid);
                db.CUSTOMERs.Remove(cm);
                db.SaveChanges();
                frmkhachhangload();
                gridView1.ExpandAllGroups();
            }
        }
    }
}