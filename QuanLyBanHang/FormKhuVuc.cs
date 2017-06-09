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
using DAO.AppData;
namespace QuanLyBanHang
{
    public partial class FormKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public FormKhuVuc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            frmSuaKhuVuc form = new frmSuaKhuVuc();
            form.tbMa.Text = dgvKhuVuc.GetRowCellValue(dgvKhuVuc.FocusedRowHandle, "Customer_Group_ID").ToString();
            form.tbTen.Text = dgvKhuVuc.GetRowCellValue(dgvKhuVuc.FocusedRowHandle, "Customer_Group_Name").ToString();
            form.tbGhiChu.Text = dgvKhuVuc.GetRowCellValue(dgvKhuVuc.FocusedRowHandle, "Description").ToString();
            form.checkBox1.Checked = true;
            form.ShowDialog();
            frmkhuvucload();
        }


        private void FormKhuVuc_Load(object sender, EventArgs e)
        {
            frmkhuvucload();
        }
        public void frmkhuvucload()
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            List<CUSTOMER_GROUP> listkhuvuc = new List<CUSTOMER_GROUP>();
            listkhuvuc = db.CUSTOMER_GROUP.ToList<CUSTOMER_GROUP>();
            dgvKhuVuc.IndicatorWidth = 40;
            gridControl1.DataSource = listkhuvuc;
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        
        private void dgvKhuVuc_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            
            if (e.RowHandle >= 0)
                e.Info.DisplayText = e.RowHandle.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThemKhuVuc f = new frmThemKhuVuc();
            f.ShowDialog();
            frmkhuvucload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có chắc muốn xóa không", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
               var id = dgvKhuVuc.GetRowCellValue(dgvKhuVuc.FocusedRowHandle, "Customer_Group_ID").ToString();
               var CG= db.CUSTOMER_GROUP.Single(hs => hs.Customer_Group_ID == id);
                db.CUSTOMER_GROUP.Remove(CG);
                db.SaveChanges();
                frmkhuvucload();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void dgvKhuVuc_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           // dgvKhuVuc.GetRowCellValue(dgvKhuVuc.FocusedRowHandle, "Customer_Group_ID").ToString();
        }

        //public string SendText()
        //{
        //    var id = dgvKhuVuc.GetRowCellValue(dgvKhuVuc.FocusedRowHandle, "Customer_Group_ID").ToString();
        //    return id;
        //}
    }
}