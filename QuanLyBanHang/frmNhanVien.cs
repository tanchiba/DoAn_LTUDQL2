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
using QuanLyBanHang.AppData;

namespace QuanLyBanHang
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        QuanLyBanHangEntities data = new QuanLyBanHangEntities();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            List<EMPLOYEE> nv = data.EMPLOYEEs.ToList();
            grcNhanVien.DataSource = nv;
        }
    }
}