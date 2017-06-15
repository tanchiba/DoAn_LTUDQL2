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
using System.IO;
using BUS;
using DAO.AppData;

namespace QuanLyBanHang
{
    public partial class frmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            frmhanghoaload();
            gridView2.ExpandAllGroups();
            gridView2.IndicatorWidth = 40;
        }

        private void frmhanghoaload()
        {

            var listhanghoa = BUS.ProductObjectBUS.list();
            gridControl2.DataSource = listhanghoa;          
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >=0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThemHangHoa f = new frmThemHangHoa();
            f.Show();
            frmhanghoaload();
            gridView2.ExpandAllGroups();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gridView2.FocusedRowHandle >= 0)
            {
               // QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                frmSuaHangHoa f = new frmSuaHangHoa();
                var pid = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Product_ID").ToString();

                //PRODUCT p = db.PRODUCTs.Single(a => a.Product_ID == pid);



                var p = ProductBUS.queryByID(pid);


                f.tbTenHang.Text = p.ProductName;
                f.tbMaHang.Text = p.Product_ID;
                if (p.Product_Type_ID == "0")
                {
                    f.cbbHangHoa.ValueMember = "0";
                }
                else f.cbbHangHoa.ValueMember = "1";
                #region gridlookupedit
                var kh = StockBUS.list();
                f.glKhoMacDinh.Properties.DataSource = kh;
                f.glKhoMacDinh.Properties.DisplayMember = "StockName";
                f.glKhoMacDinh.Properties.ValueMember = "Stock_ID";

                var pg = Product_GroupBUS.list();
                f.gllPhanLoai.Properties.DataSource = pg;
                f.gllPhanLoai.Properties.DisplayMember = "Product_Group_Name";
                f.gllPhanLoai.Properties.ValueMember = "Product_Group_ID";

                var unit = UnitBUS.list();
                f.glDonVi.Properties.DataSource = unit;
                f.glDonVi.Properties.DisplayMember = "UnitName";
                f.glDonVi.Properties.ValueMember = "Unit_ID";

                var lp = BUS.ProviderBUS.list();
                f.glNCC.Properties.DataSource = lp;
                f.glNCC.Properties.DisplayMember = "ProviderName";
                f.glNCC.Properties.ValueMember = "Provider_ID";
                #endregion
                f.gllPhanLoai.EditValue = p.Product_Group_ID;
                f.glNCC.EditValue = p.Provider_ID;
                f.glDonVi.EditValue = p.Unit;
                f.glGiaMua.Text = p.Org_Price.ToString();
                f.glGiaBanLe.Text = p.Retail_Price.ToString();
                f.glGiaSi.Text = p.Sale_Price.ToString();
                f.glToiThieu.Text = p.MinStock.ToString();
                f.glKhoMacDinh.EditValue = p.Stock_ID;

                if (p.Active == true)
                {
                    f.cbActive.Checked = true;
                }
                else f.cbActive.Checked = false;

                //byte[] img = (byte[])p.i;
                //if (img == null)
                //{
                //    f.pictureBox1.Image = null;
                //}
                //else
                //{
                //    MemoryStream m = new MemoryStream(img);
                //    f.pictureBox1.Image = Image.FromStream(m);
                //}

                f.ShowDialog();
                frmhanghoaload();
                gridView2.ExpandAllGroups();
            }
            else MessageBox.Show("Bạn chưa chọn đối tượng cần sửa", "thông báo", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var pid = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Product_ID").ToString();
            ProductBUS.deleteByID(pid);
            frmhanghoaload();
            gridView2.ExpandAllGroups();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}