using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace QuanLyBanHang
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void bbtnNhapDanhMucExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new FormNhapExcel();
            if (ExistForm1(f)) return;
            f.Show();
        }

        private void bbtnKhuVuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FormKhuVuc();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbtnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FormDonViTinh();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbtnNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FormNhaCungCap();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbtnKhoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FormKhoHang();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbtnDonViTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FormDonViTinh();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private bool ExistForm(XtraForm f)
        {
            foreach (var item in MdiChildren)
            {
                if (item.GetType() == f.GetType())
                {
                    item.Activate();
                    return true;
                }
               
            }
            return false;
        }
        private bool ExistForm1(Form f)
        {
            foreach (var item in MdiChildren)
            {
                if (item.GetType() == f.GetType())
                {
                    item.Activate();
                    return true;
                }

            }
            return false;
        }
    }
}
