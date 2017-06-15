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
    public partial class frmCapNhatTienTe : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhatTienTe()
        {
            InitializeComponent();
        }

        public string Currency_ID;

        private void frmCapNhatTienTe_Load(object sender, EventArgs e)
        {
            BUS.CurrencyBUS load = new BUS.CurrencyBUS();
            var tg = load.LoadDataSua(Currency_ID);

            foreach (var item in tg)
            {
                txtMaTyGia.Text = item.Currency_ID;
                txtTenTyGia.Text = item.CurrencyName;
                calTyGiaQuyDoi.EditValue = item.Exchange;
                checkBConQuanLy.Checked = (item.Active == true) ? true : false;
            }
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
            BUS.CurrencyBUS tygia = new BUS.CurrencyBUS();
            tygia.Sua(Currency_ID, CurrencyName, Exchange, Active);
            this.Close();
        }

        private void spbtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}