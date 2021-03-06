﻿namespace QuanLyBanHang
{
    partial class frmThuTien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuTien));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dpnChucNang = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.nbcBHChucNang = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgrTTPhieuThu = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiDSPhieuThu = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgrCKBangKe = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiDSPhieuGhiCongNo = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDSPhieuTraNgay = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTheoDoiCongNo = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTongCongNo = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiCKHangHoa = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiCKKhachHang = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiCKKhoHang = new DevExpress.XtraNavBar.NavBarItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniXem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLapPhieuThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mniXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDong = new System.Windows.Forms.ToolStripMenuItem();
            this.dedtTu = new DevExpress.XtraEditors.DateEdit();
            this.dedtDen = new DevExpress.XtraEditors.DateEdit();
            this.cmbTuyChon = new System.Windows.Forms.ComboBox();
            this.grcDanhSachGhiNoCong = new DevExpress.XtraEditors.GroupControl();
            this.grcDSGhiCongNo = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DaTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ConLai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dpnChucNang.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbcBHChucNang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedtTu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedtTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedtDen.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedtDen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhSachGhiNoCong)).BeginInit();
            this.grcDanhSachGhiNoCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDSGhiCongNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpnChucNang});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // dpnChucNang
            // 
            this.dpnChucNang.Controls.Add(this.dockPanel1_Container);
            this.dpnChucNang.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dpnChucNang.ID = new System.Guid("d60d4eac-9e6e-457f-8962-91bb85ad2831");
            this.dpnChucNang.Location = new System.Drawing.Point(0, 0);
            this.dpnChucNang.Name = "dpnChucNang";
            this.dpnChucNang.OriginalSize = new System.Drawing.Size(176, 200);
            this.dpnChucNang.Size = new System.Drawing.Size(176, 561);
            this.dpnChucNang.Text = "Chức Năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.nbcBHChucNang);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(167, 534);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // nbcBHChucNang
            // 
            this.nbcBHChucNang.ActiveGroup = this.nbgrTTPhieuThu;
            this.nbcBHChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.nbcBHChucNang.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgrTTPhieuThu,
            this.nbgrCKBangKe});
            this.nbcBHChucNang.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiCKHangHoa,
            this.nbiCKKhachHang,
            this.nbiCKKhoHang,
            this.nbiDSPhieuThu,
            this.nbiDSPhieuGhiCongNo,
            this.nbiDSPhieuTraNgay,
            this.nbiTheoDoiCongNo,
            this.nbiTongCongNo});
            this.nbcBHChucNang.Location = new System.Drawing.Point(0, 0);
            this.nbcBHChucNang.Name = "nbcBHChucNang";
            this.nbcBHChucNang.OptionsNavPane.ExpandedWidth = 170;
            this.nbcBHChucNang.Size = new System.Drawing.Size(170, 534);
            this.nbcBHChucNang.TabIndex = 6;
            this.nbcBHChucNang.Text = "navBarControl1";
            // 
            // nbgrTTPhieuThu
            // 
            this.nbgrTTPhieuThu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbgrTTPhieuThu.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.nbgrTTPhieuThu.Appearance.Options.UseFont = true;
            this.nbgrTTPhieuThu.Appearance.Options.UseForeColor = true;
            this.nbgrTTPhieuThu.Caption = "Phiếu Thu";
            this.nbgrTTPhieuThu.Expanded = true;
            this.nbgrTTPhieuThu.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.nbgrTTPhieuThu.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDSPhieuThu)});
            this.nbgrTTPhieuThu.Name = "nbgrTTPhieuThu";
            // 
            // nbiDSPhieuThu
            // 
            this.nbiDSPhieuThu.Caption = "Danh Sách Phiếu Thu";
            this.nbiDSPhieuThu.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiDSPhieuThu.LargeImage")));
            this.nbiDSPhieuThu.Name = "nbiDSPhieuThu";
            // 
            // nbgrCKBangKe
            // 
            this.nbgrCKBangKe.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbgrCKBangKe.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.nbgrCKBangKe.Appearance.Options.UseFont = true;
            this.nbgrCKBangKe.Appearance.Options.UseForeColor = true;
            this.nbgrCKBangKe.Caption = "Bảng Kê";
            this.nbgrCKBangKe.Expanded = true;
            this.nbgrCKBangKe.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.nbgrCKBangKe.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDSPhieuGhiCongNo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDSPhieuTraNgay),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTheoDoiCongNo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTongCongNo)});
            this.nbgrCKBangKe.Name = "nbgrCKBangKe";
            // 
            // nbiDSPhieuGhiCongNo
            // 
            this.nbiDSPhieuGhiCongNo.Caption = "Danh Sách Phiếu Ghi Công Nợ";
            this.nbiDSPhieuGhiCongNo.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiDSPhieuGhiCongNo.LargeImage")));
            this.nbiDSPhieuGhiCongNo.Name = "nbiDSPhieuGhiCongNo";
            // 
            // nbiDSPhieuTraNgay
            // 
            this.nbiDSPhieuTraNgay.Caption = "Danh Sách Phiếu Trả Ngay";
            this.nbiDSPhieuTraNgay.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiDSPhieuTraNgay.LargeImage")));
            this.nbiDSPhieuTraNgay.Name = "nbiDSPhieuTraNgay";
            // 
            // nbiTheoDoiCongNo
            // 
            this.nbiTheoDoiCongNo.Caption = "Theo Dõi Công Nợ";
            this.nbiTheoDoiCongNo.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiTheoDoiCongNo.LargeImage")));
            this.nbiTheoDoiCongNo.Name = "nbiTheoDoiCongNo";
            // 
            // nbiTongCongNo
            // 
            this.nbiTongCongNo.Caption = "Tổng Công Nợ";
            this.nbiTongCongNo.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiTongCongNo.LargeImage")));
            this.nbiTongCongNo.Name = "nbiTongCongNo";
            // 
            // nbiCKHangHoa
            // 
            this.nbiCKHangHoa.Caption = "Hàng Hóa";
            this.nbiCKHangHoa.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiCKHangHoa.LargeImage")));
            this.nbiCKHangHoa.Name = "nbiCKHangHoa";
            this.nbiCKHangHoa.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiCKHangHoa.SmallImage")));
            // 
            // nbiCKKhachHang
            // 
            this.nbiCKKhachHang.Caption = "Khách Hàng";
            this.nbiCKKhachHang.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiCKKhachHang.LargeImage")));
            this.nbiCKKhachHang.Name = "nbiCKKhachHang";
            this.nbiCKKhachHang.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiCKKhachHang.SmallImage")));
            // 
            // nbiCKKhoHang
            // 
            this.nbiCKKhoHang.Caption = "Kho Hàng";
            this.nbiCKKhoHang.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiCKKhoHang.LargeImage")));
            this.nbiCKKhoHang.Name = "nbiCKKhoHang";
            this.nbiCKKhoHang.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiCKKhoHang.SmallImage")));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.splitContainerControl1);
            this.panel1.Location = new System.Drawing.Point(391, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 39);
            this.panel1.TabIndex = 4;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Location = new System.Drawing.Point(3, 3);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.menuStrip1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(464, 33);
            this.splitContainerControl1.SplitterPosition = 2;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniXem,
            this.mniLapPhieuThu,
            this.mniXuat,
            this.mniDong});
            this.menuStrip1.Location = new System.Drawing.Point(16, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(298, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniXem
            // 
            this.mniXem.Image = ((System.Drawing.Image)(resources.GetObject("mniXem.Image")));
            this.mniXem.Name = "mniXem";
            this.mniXem.Size = new System.Drawing.Size(59, 20);
            this.mniXem.Text = "Xem";
            // 
            // mniLapPhieuThu
            // 
            this.mniLapPhieuThu.Image = ((System.Drawing.Image)(resources.GetObject("mniLapPhieuThu.Image")));
            this.mniLapPhieuThu.Name = "mniLapPhieuThu";
            this.mniLapPhieuThu.Size = new System.Drawing.Size(108, 20);
            this.mniLapPhieuThu.Text = "Lập phiếu thu";
            // 
            // mniXuat
            // 
            this.mniXuat.Image = ((System.Drawing.Image)(resources.GetObject("mniXuat.Image")));
            this.mniXuat.Name = "mniXuat";
            this.mniXuat.Size = new System.Drawing.Size(59, 20);
            this.mniXuat.Text = "Xuất";
            // 
            // mniDong
            // 
            this.mniDong.Image = ((System.Drawing.Image)(resources.GetObject("mniDong.Image")));
            this.mniDong.Name = "mniDong";
            this.mniDong.Size = new System.Drawing.Size(64, 20);
            this.mniDong.Text = "Đóng";
            // 
            // dedtTu
            // 
            this.dedtTu.EditValue = null;
            this.dedtTu.Location = new System.Drawing.Point(142, 12);
            this.dedtTu.Name = "dedtTu";
            this.dedtTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedtTu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedtTu.Size = new System.Drawing.Size(87, 20);
            this.dedtTu.TabIndex = 2;
            // 
            // dedtDen
            // 
            this.dedtDen.EditValue = null;
            this.dedtDen.Location = new System.Drawing.Point(279, 12);
            this.dedtDen.Name = "dedtDen";
            this.dedtDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedtDen.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedtDen.Size = new System.Drawing.Size(106, 20);
            this.dedtDen.TabIndex = 2;
            // 
            // cmbTuyChon
            // 
            this.cmbTuyChon.FormattingEnabled = true;
            this.cmbTuyChon.Location = new System.Drawing.Point(3, 12);
            this.cmbTuyChon.Name = "cmbTuyChon";
            this.cmbTuyChon.Size = new System.Drawing.Size(101, 21);
            this.cmbTuyChon.TabIndex = 1;
            // 
            // grcDanhSachGhiNoCong
            // 
            this.grcDanhSachGhiNoCong.Controls.Add(this.grcDSGhiCongNo);
            this.grcDanhSachGhiNoCong.Controls.Add(this.panel2);
            this.grcDanhSachGhiNoCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDanhSachGhiNoCong.Location = new System.Drawing.Point(176, 0);
            this.grcDanhSachGhiNoCong.Name = "grcDanhSachGhiNoCong";
            this.grcDanhSachGhiNoCong.Size = new System.Drawing.Size(868, 561);
            this.grcDanhSachGhiNoCong.TabIndex = 1;
            this.grcDanhSachGhiNoCong.Text = "Danh Sách Ghi Công Nợ Chi Tiết";
            // 
            // grcDSGhiCongNo
            // 
            this.grcDSGhiCongNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDSGhiCongNo.Location = new System.Drawing.Point(2, 63);
            this.grcDSGhiCongNo.MainView = this.gridView2;
            this.grcDSGhiCongNo.Name = "grcDSGhiCongNo";
            this.grcDSGhiCongNo.Size = new System.Drawing.Size(864, 496);
            this.grcDSGhiCongNo.TabIndex = 7;
            this.grcDSGhiCongNo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ChungTu,
            this.Ngay,
            this.MaKH,
            this.KhachHang,
            this.SoTien,
            this.DaTra,
            this.ConLai,
            this.DienGiai});
            this.gridView2.GridControl = this.grcDSGhiCongNo;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // ChungTu
            // 
            this.ChungTu.Caption = "Chứng Từ";
            this.ChungTu.Name = "ChungTu";
            this.ChungTu.Visible = true;
            this.ChungTu.VisibleIndex = 0;
            this.ChungTu.Width = 89;
            // 
            // Ngay
            // 
            this.Ngay.Caption = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.Visible = true;
            this.Ngay.VisibleIndex = 1;
            this.Ngay.Width = 111;
            // 
            // MaKH
            // 
            this.MaKH.Caption = "Mã KH";
            this.MaKH.Name = "MaKH";
            this.MaKH.Visible = true;
            this.MaKH.VisibleIndex = 2;
            this.MaKH.Width = 83;
            // 
            // KhachHang
            // 
            this.KhachHang.Caption = "Khách Hàng";
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.Visible = true;
            this.KhachHang.VisibleIndex = 3;
            this.KhachHang.Width = 164;
            // 
            // SoTien
            // 
            this.SoTien.Caption = "Số Tiền";
            this.SoTien.Name = "SoTien";
            this.SoTien.Visible = true;
            this.SoTien.VisibleIndex = 4;
            this.SoTien.Width = 104;
            // 
            // DaTra
            // 
            this.DaTra.Caption = "Đã Trả";
            this.DaTra.Name = "DaTra";
            this.DaTra.Visible = true;
            this.DaTra.VisibleIndex = 5;
            this.DaTra.Width = 104;
            // 
            // ConLai
            // 
            this.ConLai.Caption = "Còn Lại";
            this.ConLai.Name = "ConLai";
            this.ConLai.Visible = true;
            this.ConLai.VisibleIndex = 6;
            this.ConLai.Width = 104;
            // 
            // DienGiai
            // 
            this.DienGiai.Caption = "Diễn Giải";
            this.DienGiai.Name = "DienGiai";
            this.DienGiai.Visible = true;
            this.DienGiai.VisibleIndex = 7;
            this.DienGiai.Width = 116;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbTuyChon);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dedtTu);
            this.panel2.Controls.Add(this.dedtDen);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 43);
            this.panel2.TabIndex = 6;
            // 
            // frmThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 561);
            this.Controls.Add(this.grcDanhSachGhiNoCong);
            this.Controls.Add(this.dpnChucNang);
            this.Name = "frmThuTien";
            this.Text = "Thu Tiền";
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dpnChucNang.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbcBHChucNang)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedtTu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedtTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedtDen.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedtDen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhSachGhiNoCong)).EndInit();
            this.grcDanhSachGhiNoCong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcDSGhiCongNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dpnChucNang;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarControl nbcBHChucNang;
        private DevExpress.XtraNavBar.NavBarGroup nbgrTTPhieuThu;
        private DevExpress.XtraNavBar.NavBarGroup nbgrCKBangKe;
        private DevExpress.XtraNavBar.NavBarItem nbiCKHangHoa;
        private DevExpress.XtraNavBar.NavBarItem nbiCKKhachHang;
        private DevExpress.XtraNavBar.NavBarItem nbiCKKhoHang;
        private DevExpress.XtraEditors.GroupControl grcDanhSachGhiNoCong;
        private DevExpress.XtraGrid.GridControl grcDSGhiCongNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn MaKH;
        private DevExpress.XtraGrid.Columns.GridColumn KhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn SoTien;
        private DevExpress.XtraGrid.Columns.GridColumn DaTra;
        private DevExpress.XtraGrid.Columns.GridColumn ConLai;
        private DevExpress.XtraGrid.Columns.GridColumn DienGiai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbTuyChon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniXem;
        private System.Windows.Forms.ToolStripMenuItem mniLapPhieuThu;
        private System.Windows.Forms.ToolStripMenuItem mniXuat;
        private System.Windows.Forms.ToolStripMenuItem mniDong;
        private DevExpress.XtraEditors.DateEdit dedtTu;
        private DevExpress.XtraEditors.DateEdit dedtDen;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraNavBar.NavBarItem nbiDSPhieuThu;
        private DevExpress.XtraNavBar.NavBarItem nbiDSPhieuGhiCongNo;
        private DevExpress.XtraNavBar.NavBarItem nbiDSPhieuTraNgay;
        private DevExpress.XtraNavBar.NavBarItem nbiTheoDoiCongNo;
        private DevExpress.XtraNavBar.NavBarItem nbiTongCongNo;
    }
}