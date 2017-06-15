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
    public partial class frmCapNhatNhomHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhatNhomHangHoa()
        {
            InitializeComponent();
        }

        public void getData(string Product_Group_ID, string Product_Group_Name, string Description, bool Active)
        {
            txtMaNhomHang.Text = Product_Group_ID;
            txtTenNhomHang.Text = Product_Group_Name;
            txtGhiChu.Text = Description;
            if (Active == true)
            {
                checkBConQuanLy.Checked = true;
            }
            else
            {
                checkBConQuanLy.Checked = false;
            }
        }

        private void spbtnLuu_Click(object sender, EventArgs e)
        {
            bool Active;
            if (checkBConQuanLy.Checked)
            {
                Active = true;
            }
            else
            {
                Active = false;
            }

            BUS.Product_GroupBUS.Sua(txtMaNhomHang.Text, txtTenNhomHang.Text, txtGhiChu.Text, Active);
            this.Close();
        }

        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}