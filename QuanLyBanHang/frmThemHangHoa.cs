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

namespace QuanLyBanHang
{
    public partial class frmThemHangHoa : DevExpress.XtraEditors.XtraForm
    {
        string pg;
        string providerid;
        string u;
        string kho;
        public frmThemHangHoa()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
          
      
        }

        private void frmThemHangHoa_Load(object sender, EventArgs e)
        {
            var lpb = ProductBUS.list();
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("0", "Hàng Hóa");
            test.Add("1", "Dịch Vụ");
            cbbHangHoa.DataSource = new BindingSource(test, null);
            cbbHangHoa.DisplayMember = "Value";
            cbbHangHoa.ValueMember = "Key";
            var kh = StockBUS.list();
            glKhoMacDinh.Properties.DataSource = kh;
            glKhoMacDinh.Properties.DisplayMember = "StockName";
            glKhoMacDinh.Properties.ValueMember = "Stock_ID";
            glKhoMacDinh.EditValue = glKhoMacDinh.Properties.GetKeyValue(0);
            var pg = Product_GroupBUS.list();
            gllPhanLoai.Properties.DataSource = pg;
            gllPhanLoai.Properties.DisplayMember = "Product_Group_Name";
            gllPhanLoai.Properties.ValueMember = "Product_Group_ID";
            gllPhanLoai.EditValue = gllPhanLoai.Properties.GetKeyValue(0);
            var unit = UnitBUS.list();
            glDonVi.Properties.DataSource = unit;
            glDonVi.Properties.DisplayMember = "UnitName";
            glDonVi.Properties.ValueMember = "Unit_ID";
            glDonVi.EditValue = glDonVi.Properties.GetKeyValue(0);
            var lp = ProviderBUS.list();
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
            bool a;
            if (cbActive.Checked == true)
                a = true;
            else a = false;
            byte[] img = null;
            if (pictureBox1 != null && pictureBox1.Image != null)
            {
                FileStream f = new FileStream(pictureBox1.ImageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader b = new BinaryReader(f);
                img = b.ReadBytes((int)f.Length);
            }
            ProductBUS.add(tbTenHang.Text, tbMaHang.Text, cbbHangHoa.SelectedIndex.ToString(), pg, providerid, u,double.Parse(glGiaMua.Text),double.Parse( glGiaSi.Text),double.Parse(glGiaBanLe.Text), int.Parse(glToiThieu.Text),int.Parse(glToiDa.Text), kho, img, a);
            this.Close();
        }

        private void gllPhanLoai_EditValueChanged(object sender, EventArgs e)
        {
            pg = Product_GroupBUS.objectToDTO( gllPhanLoai.GetSelectedDataRow()).Product_Group_ID;
        }

        private void glNCC_EditValueChanged(object sender, EventArgs e)
        {
           providerid =ProviderBUS.objectToDTO( glNCC.GetSelectedDataRow()).Provider_ID;
        }

        private void glDonVi_EditValueChanged(object sender, EventArgs e)
        {
            u = UnitBUS.objectToDTO( glDonVi.GetSelectedDataRow()).Unit_ID;
        }

        private void glKhoMacDinh_EditValueChanged(object sender, EventArgs e)
        {
            kho = StockBUS.objectToDTO( glKhoMacDinh.GetSelectedDataRow()).Stock_ID;
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