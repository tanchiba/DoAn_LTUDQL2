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
    public partial class frmThemTienTe : DevExpress.XtraEditors.XtraForm
    {
        public frmThemTienTe()
        {
            InitializeComponent();
        }

        private void frmThemTienTe_Load(object sender, EventArgs e)
        {

        }

        private void spbtnLuu_Click(object sender, EventArgs e)
        {
            string Currency_ID, CurrencyName;
            long? Exchange;
            bool Active;

            Currency_ID = txtMaTyGia.Text;
            CurrencyName = txtTenTyGia.Text;
            if (string.IsNullOrWhiteSpace(calTyGiaQuyDoi.Text))
                Exchange = null;
            else
                Exchange = Convert.ToInt64(calTyGiaQuyDoi.EditValue.ToString());
            Active = (checkBConQuanLy.Checked == true) ? true : false;
            BUS.CurrencyBUS tg = new BUS.CurrencyBUS();
            tg.Them(Currency_ID, CurrencyName, Exchange, Active);
            this.Close();
        }

        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}