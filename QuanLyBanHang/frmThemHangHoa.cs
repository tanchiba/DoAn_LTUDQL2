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
using System.IO;

namespace QuanLyBanHang
{
    public partial class frmThemHangHoa : DevExpress.XtraEditors.XtraForm
    {
        PRODUCT_GROUP pg;
        PROVIDER providerid;
        UNIT u;
        STOCK kho;
        public frmThemHangHoa()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
          
      
        }

        private void frmThemHangHoa_Load(object sender, EventArgs e)
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            List<PRODUCT> lpb = db.PRODUCTs.ToList();
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("0", "Hàng Hóa");
            test.Add("1", "Dịch Vụ");
            cbbHangHoa.DataSource = new BindingSource(test, null);
            cbbHangHoa.DisplayMember = "Value";
            cbbHangHoa.ValueMember = "Key";
            List<STOCK> kh = db.STOCKs.ToList();
            glKhoMacDinh.Properties.DataSource = kh;
            glKhoMacDinh.Properties.DisplayMember = "StockName";
            glKhoMacDinh.Properties.ValueMember = "Stock_ID";
            glKhoMacDinh.EditValue = glKhoMacDinh.Properties.GetKeyValue(0);
            List<PRODUCT_GROUP> pg = db.PRODUCT_GROUP.ToList();
            gllPhanLoai.Properties.DataSource = pg;
            gllPhanLoai.Properties.DisplayMember = "Product_Group_Name";
            gllPhanLoai.Properties.ValueMember = "Product_Group_ID";
            gllPhanLoai.EditValue = gllPhanLoai.Properties.GetKeyValue(0);
            List<UNIT> unit = db.UNITs.ToList();
            glDonVi.Properties.DataSource = unit;
            glDonVi.Properties.DisplayMember = "UnitName";
            glDonVi.Properties.ValueMember = "Unit_ID";
            glDonVi.EditValue = glDonVi.Properties.GetKeyValue(0);
            List<PROVIDER> lp = db.PROVIDERs.ToList();
            glNCC.Properties.DataSource = lp;
            glNCC.Properties.DisplayMember = "ProviderName";
            glNCC.Properties.ValueMember = "Provider_ID";
            glNCC.EditValue = glNCC.Properties.GetKeyValue(0);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            PRODUCT p = new PRODUCT();
            p.ProductName = tbTenHang.Text;
            p.Product_ID = tbMaHang.Text;
            p.Product_Type_ID = cbbHangHoa.SelectedIndex.ToString();
            p.Product_Group_ID = pg.Product_Group_ID;
            p.Prorvider_ID = providerid.Provider_ID;
            p.Unit = u.Unit_ID;
            p.Org_Price = decimal.Parse(glGiaMua.Text);
            p.Sale_Price = decimal.Parse(glGiaSi.Text);
            p.Retail_Price = decimal.Parse(glGiaBanLe.Text);
            p.MinStock = int.Parse(glToiThieu.Text);
            p.Stock_ID = kho.Stock_ID;
            if (cbActive.Checked == true)
                p.Active = true;
            else p.Active = false;
            if (pictureBox1 != null && pictureBox1.Image != null)
            {

                byte[] img = null;
                FileStream f = new FileStream(pictureBox1.ImageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader b = new BinaryReader(f);
                img = b.ReadBytes((int)f.Length);
                p.Photo = img;
            }
            db.PRODUCTs.Add(p);
            db.SaveChanges();
            this.Close();

             
        }

        private void gllPhanLoai_EditValueChanged(object sender, EventArgs e)
        {
            pg = gllPhanLoai.GetSelectedDataRow() as PRODUCT_GROUP;
        }

        private void glNCC_EditValueChanged(object sender, EventArgs e)
        {
            providerid = glNCC.GetSelectedDataRow() as PROVIDER;
        }

        private void glDonVi_EditValueChanged(object sender, EventArgs e)
        {
            u = glDonVi.GetSelectedDataRow() as UNIT;
        }

        private void glKhoMacDinh_EditValueChanged(object sender, EventArgs e)
        {
            kho = glKhoMacDinh.GetSelectedDataRow() as STOCK;
        }
        OpenFileDialog odf = new OpenFileDialog();
        
        private void loadHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            odf.Filter = "JPG|*.jpg|PNG|*.png|All file|*.*";
            odf.Title = "Chọn hình của sản phẩm";
            if (odf.ShowDialog() ==DialogResult.OK)
            {
                pictureBox1.ImageLocation = odf.FileName;
            }
        }

        private void xóaHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}