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
    public partial class frmThemKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public frmThemKhoHang()
        {
            InitializeComponent();
        }

        QuanLyBanHangEntities db = new QuanLyBanHangEntities();

        private void frmThemKhoHang_Load(object sender, EventArgs e)
        {
            List<EMPLOYEE> listKH = new List<EMPLOYEE>();
            listKH = db.EMPLOYEEs.ToList();
            grlpedtQuanLy.Properties.DataSource = listKH;
            grlpedtQuanLy.Properties.ValueMember = "Employee_ID";
            grlpedtQuanLy.Properties.DisplayMember = "EmployeeName";
            txtMaKho.Text = BUS.StockBUS.Stock_ID();
        }

        private void spbtnLuu_Click(object sender, EventArgs e)
        {
            string Stock_ID, StockName, StockAddress, Email, Tel, Description, Manager_ID;
            bool Active;

            Stock_ID = txtMaKho.Text;
            StockName = txtTen.Text;
            StockAddress = txtDiaChi.Text;
            Email = txtEmail.Text;
            Tel = txtDT.Text;
            Description = txtDG.Text;
            Manager_ID = grlpedtQuanLy.EditValue.ToString();
            Active = (checkBConQuanLy.Checked == true) ? true : false;
            BUS.StockBUS kh = new BUS.StockBUS();
            kh.Them(Stock_ID, StockName, StockAddress, Email, Tel, Description, Active, Manager_ID);
            this.Close();
        }

        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}