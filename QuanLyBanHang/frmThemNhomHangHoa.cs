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

namespace QuanLyBanHang
{
    public partial class frmThemNhomHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNhomHangHoa()
        {
            InitializeComponent();
        }

        private void frmThemNhomHangHoa_Load(object sender, EventArgs e)
        {

        }

        private void spbtnLuu_Click(object sender, EventArgs e)
        {
            string Product_Group_ID, Product_Group_Name, Description;
            bool Active;

            Product_Group_ID = txtMaNhomHang.Text;
            Product_Group_Name = txtTenNhomHang.Text;
            Description = txtGhiChu.Text;
            Active = (checkBConQuanLy.Checked == true) ? true : false;
            BUS.Product_GroupBUS nhomhang = new BUS.Product_GroupBUS();
            nhomhang.Them(Product_Group_ID, Product_Group_Name, Description, Active);
            this.Close();
        }

        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}