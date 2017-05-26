namespace QuanLyBanHang
{
    partial class frmTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTonKho));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.grcTonKho = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhomHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ConQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bmnTonKho = new DevExpress.XtraBars.Bar();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.bbtTKXem = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnTKXuat = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnTKIn = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnTKDong = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.grcTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // grcTonKho
            // 
            this.grcTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcTonKho.Location = new System.Drawing.Point(0, 24);
            this.grcTonKho.MainView = this.gridView1;
            this.grcTonKho.Name = "grcTonKho";
            this.grcTonKho.Size = new System.Drawing.Size(904, 403);
            this.grcTonKho.TabIndex = 6;
            this.grcTonKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHang,
            this.TenHang,
            this.DonVi,
            this.SoLuong,
            this.NhomHang,
            this.ConQuanLy});
            this.gridView1.GridControl = this.grcTonKho;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // MaHang
            // 
            this.MaHang.Caption = "Mã hàng";
            this.MaHang.Name = "MaHang";
            this.MaHang.Visible = true;
            this.MaHang.VisibleIndex = 0;
            this.MaHang.Width = 93;
            // 
            // TenHang
            // 
            this.TenHang.Caption = "Tên hàng";
            this.TenHang.Name = "TenHang";
            this.TenHang.Visible = true;
            this.TenHang.VisibleIndex = 1;
            this.TenHang.Width = 144;
            // 
            // DonVi
            // 
            this.DonVi.Caption = "Đơn vị";
            this.DonVi.Name = "DonVi";
            this.DonVi.Visible = true;
            this.DonVi.VisibleIndex = 2;
            this.DonVi.Width = 91;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            this.SoLuong.Width = 122;
            // 
            // NhomHang
            // 
            this.NhomHang.Caption = "Nhóm hàng";
            this.NhomHang.Name = "NhomHang";
            this.NhomHang.Visible = true;
            this.NhomHang.VisibleIndex = 4;
            this.NhomHang.Width = 122;
            // 
            // ConQuanLy
            // 
            this.ConQuanLy.Caption = "Còn quản lý";
            this.ConQuanLy.Name = "ConQuanLy";
            this.ConQuanLy.Visible = true;
            this.ConQuanLy.VisibleIndex = 5;
            this.ConQuanLy.Width = 115;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bmnTonKho,
            this.bar6});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbtTKXem,
            this.bbtnTKXuat,
            this.bbtnTKIn,
            this.bbtnTKDong});
            this.barManager1.MainMenu = this.bmnTonKho;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar6;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(904, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 427);
            this.barDockControlBottom.Size = new System.Drawing.Size(904, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 403);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(904, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 403);
            // 
            // bmnTonKho
            // 
            this.bmnTonKho.BarName = "Main menu";
            this.bmnTonKho.DockCol = 0;
            this.bmnTonKho.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bmnTonKho.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtTKXem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnTKXuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnTKIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnTKDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bmnTonKho.OptionsBar.MultiLine = true;
            this.bmnTonKho.OptionsBar.UseWholeRow = true;
            this.bmnTonKho.Text = "Main menu";
            // 
            // bar6
            // 
            this.bar6.BarName = "Status bar";
            this.bar6.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar6.DockCol = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar6.OptionsBar.AllowQuickCustomization = false;
            this.bar6.OptionsBar.DrawDragBorder = false;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Status bar";
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // bar7
            // 
            this.bar7.BarName = "Main menu";
            this.bar7.DockCol = 0;
            this.bar7.DockRow = 0;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar7.OptionsBar.MultiLine = true;
            this.bar7.OptionsBar.UseWholeRow = true;
            this.bar7.Text = "Main menu";
            // 
            // bbtTKXem
            // 
            this.bbtTKXem.Caption = "Xem";
            this.bbtTKXem.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtTKXem.Glyph")));
            this.bbtTKXem.Id = 0;
            this.bbtTKXem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtTKXem.LargeGlyph")));
            this.bbtTKXem.Name = "bbtTKXem";
            // 
            // bbtnTKXuat
            // 
            this.bbtnTKXuat.Caption = "Xuất";
            this.bbtnTKXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnTKXuat.Glyph")));
            this.bbtnTKXuat.Id = 1;
            this.bbtnTKXuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnTKXuat.LargeGlyph")));
            this.bbtnTKXuat.Name = "bbtnTKXuat";
            // 
            // bbtnTKIn
            // 
            this.bbtnTKIn.Caption = "In";
            this.bbtnTKIn.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnTKIn.Glyph")));
            this.bbtnTKIn.Id = 2;
            this.bbtnTKIn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnTKIn.LargeGlyph")));
            this.bbtnTKIn.Name = "bbtnTKIn";
            // 
            // bbtnTKDong
            // 
            this.bbtnTKDong.Caption = "Đóng";
            this.bbtnTKDong.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnTKDong.Glyph")));
            this.bbtnTKDong.Id = 3;
            this.bbtnTKDong.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnTKDong.LargeGlyph")));
            this.bbtnTKDong.Name = "bbtnTKDong";
            // 
            // frmTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.grcTonKho);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTonKho";
            this.Text = "Tồn Kho";
            ((System.ComponentModel.ISupportInitialize)(this.grcTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraGrid.GridControl grcTonKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaHang;
        private DevExpress.XtraGrid.Columns.GridColumn TenHang;
        private DevExpress.XtraGrid.Columns.GridColumn DonVi;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn NhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn ConQuanLy;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bmnTonKho;
        private DevExpress.XtraBars.BarButtonItem bbtTKXem;
        private DevExpress.XtraBars.BarButtonItem bbtnTKXuat;
        private DevExpress.XtraBars.BarButtonItem bbtnTKIn;
        private DevExpress.XtraBars.BarButtonItem bbtnTKDong;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar7;
    }
}