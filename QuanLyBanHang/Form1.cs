using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace QuanLyBanHang
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
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

        private bool ExistFrom1(Form form)
        {
            foreach (var child  in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }

            }
            return false;
        }

        private void bbtnNhapDanhMucExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new FormNhapExcel();
            if (ExistForm(f)) return;
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
            var frm = new FormKhachHang();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbtnNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmNhaCungCap();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbtnKhoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmKhoHang();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbtnDonViTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDonViTinh();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

       
        private void bbtnNhomHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmNhomHang();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbtnHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmHangHoa();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbtnInMaVach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmInMaVach();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbtnTyGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmTyGia();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bbtnBoPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmBoPhan();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();

        }

        private void bbtnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmNhanVien();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();


        }

        private void bbtnTonKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmTonKho = new frmTonKho();
            if (ExistForm(frmTonKho)) return;
            frmTonKho.MdiParent = this;
            frmTonKho.Show();
        }

        private void bbtnChungTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmChungTu = new frmChungTu();
            if (ExistForm(frmChungTu)) return;
            frmChungTu.MdiParent = this;
            frmChungTu.Show();
        }

        private void bbtnMuaHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmNhapHang = new frmNhapHang();
            if (ExistForm(frmNhapHang)) return;
            frmNhapHang.MdiParent = this;
            frmNhapHang.Show();
        }

        private void bbtnBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmBanHang = new frmBanHang();
            if (ExistForm(frmBanHang)) return;
            frmBanHang.MdiParent = this;
            frmBanHang.Show();
        }

     
        private void bbtnChuyenKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmChuyenKho = new frmChuyenKho();
            if (ExistForm(frmChuyenKho)) return;
            frmChuyenKho.MdiParent = this;
            frmChuyenKho.Show();
        }

        private void bbtnSoDuDauKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmSoDu = new frmNhapSoDuDauKy();
            if (ExistForm(frmSoDu)) return;
            frmSoDu.MdiParent = this;
            frmSoDu.Show();
        }

        private void bbtnThuTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmThuTien = new frmThuTien();
            if (ExistForm(frmThuTien)) return;
            frmThuTien.MdiParent = this;
            frmThuTien.Show();
        }

        private void bbtnTraTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmPhieuChi = new frmPhieuChi();
            if (ExistForm(frmPhieuChi)) return;
            frmPhieuChi.MdiParent = this;
            frmPhieuChi.Show();
        }

        private void bbtnBaoCaoKhoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmBCKhoHang = new frmBaoCaoKhoHang();
            if (ExistForm(frmBCKhoHang)) return;
            frmBCKhoHang.MdiParent = this;
            frmBCKhoHang.Show();
        }

        private void bbtnBaoCaoBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmBCBanHang = new frmBaoCaoBanHang();
            if (ExistForm(frmBCBanHang)) return;
            frmBCBanHang.MdiParent = this;
            frmBCBanHang.Show();
        }

        private void bbtnDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmTGDangKy = new frmTroGiupDangKy();
            frmTGDangKy.ShowDialog();
        }

        private void bbtnTGThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmTGTT = new frmThongTinTroGiup();
            frmTGTT.ShowDialog();
        }

        private void bbtnKetThuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbtnThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTin frmtt = new frmThongTin();
            frmtt.ShowDialog();
        }

        private void bbtnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmPQ = new frmPhanQuyen();
            if (ExistFrom1(frmPQ)) return;
            frmPQ.MdiParent = this;
            frmPQ.Show(); 

            
        }

        private void bbtnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau frmdmk = new frmDoiMatKhau();
            frmdmk.ShowDialog();
        }

        private void bbtnNhatKyHeThong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmNKHT = new formNhatKyHeThong();
            if (ExistFrom1(frmNKHT)) return;
            frmNKHT.MdiParent = this;
            frmNKHT.Show();

        }

        private void bbtnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSaoLuu frmsl = new frmSaoLuu();
            frmsl.ShowDialog();
        }

        private void bbtnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhucHoi frmph = new frmPhucHoi();
            frmph.ShowDialog();
        }

        private void bbtnSuaChua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSuaChua frmsc = new frmSuaChua();
            frmsc.ShowDialog();
        }

        private void bbtnKetChuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKetChuyen frmkc = new frmKetChuyen();
            frmkc.ShowDialog();
        }

        private void bbtnLienHe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTin frmthongtin = new frmThongTin();
            frmthongtin.ShowDialog();
        }

        private void bbtnHuongDanSuDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("http://www.perfect.com.vn/video-huong-dan-su-dung-phan-mem-quan-ly-ban-hang.html");
        }

        private void bbtnHoTroTrucTuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("http://www.perfect.com.vn/huong-dan-su-dung-phan-mem-quan-ly-ban-hang.html");
        }

        private void bbtnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
