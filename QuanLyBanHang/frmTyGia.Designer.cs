namespace QuanLyBanHang
{
    partial class frmTyGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTyGia));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.spbtnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnNapLai = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnDong = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.grvTyGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCurrency_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExchange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcTyGia = new DevExpress.XtraGrid.GridControl();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTyGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcTyGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.spbtnSuaChua);
            this.panelControl1.Controls.Add(this.spbtnNapLai);
            this.panelControl1.Controls.Add(this.spbtnDong);
            this.panelControl1.Controls.Add(this.spbtnXuat);
            this.panelControl1.Controls.Add(this.spbtnXoa);
            this.panelControl1.Controls.Add(this.spbtnThem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(921, 50);
            this.panelControl1.TabIndex = 8;
            // 
            // spbtnSuaChua
            // 
            this.spbtnSuaChua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnSuaChua.ImageOptions.Image")));
            this.spbtnSuaChua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.spbtnSuaChua.Location = new System.Drawing.Point(67, 3);
            this.spbtnSuaChua.Name = "spbtnSuaChua";
            this.spbtnSuaChua.Size = new System.Drawing.Size(72, 42);
            this.spbtnSuaChua.TabIndex = 0;
            this.spbtnSuaChua.Text = "Sửa Chữa";
            this.spbtnSuaChua.Click += new System.EventHandler(this.spbtnSuaChua_Click);
            // 
            // spbtnNapLai
            // 
            this.spbtnNapLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnNapLai.ImageOptions.Image")));
            this.spbtnNapLai.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.spbtnNapLai.Location = new System.Drawing.Point(203, 4);
            this.spbtnNapLai.Name = "spbtnNapLai";
            this.spbtnNapLai.Size = new System.Drawing.Size(52, 42);
            this.spbtnNapLai.TabIndex = 0;
            this.spbtnNapLai.Text = "Nạp Lại";
            // 
            // spbtnDong
            // 
            this.spbtnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnDong.ImageOptions.Image")));
            this.spbtnDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.spbtnDong.Location = new System.Drawing.Point(319, 4);
            this.spbtnDong.Name = "spbtnDong";
            this.spbtnDong.Size = new System.Drawing.Size(52, 42);
            this.spbtnDong.TabIndex = 0;
            this.spbtnDong.Text = "Đóng";
            this.spbtnDong.Click += new System.EventHandler(this.spbtnDong_Click);
            // 
            // spbtnXuat
            // 
            this.spbtnXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnXuat.ImageOptions.Image")));
            this.spbtnXuat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.spbtnXuat.Location = new System.Drawing.Point(261, 4);
            this.spbtnXuat.Name = "spbtnXuat";
            this.spbtnXuat.Size = new System.Drawing.Size(52, 42);
            this.spbtnXuat.TabIndex = 0;
            this.spbtnXuat.Text = "Xuất";
            // 
            // spbtnXoa
            // 
            this.spbtnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnXoa.ImageOptions.Image")));
            this.spbtnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.spbtnXoa.Location = new System.Drawing.Point(145, 4);
            this.spbtnXoa.Name = "spbtnXoa";
            this.spbtnXoa.Size = new System.Drawing.Size(52, 42);
            this.spbtnXoa.TabIndex = 0;
            this.spbtnXoa.Text = "Xóa";
            this.spbtnXoa.Click += new System.EventHandler(this.spbtnXoa_Click);
            // 
            // spbtnThem
            // 
            this.spbtnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnThem.ImageOptions.Image")));
            this.spbtnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.spbtnThem.Location = new System.Drawing.Point(10, 3);
            this.spbtnThem.Name = "spbtnThem";
            this.spbtnThem.Size = new System.Drawing.Size(52, 42);
            this.spbtnThem.TabIndex = 0;
            this.spbtnThem.Text = "Thêm";
            this.spbtnThem.Click += new System.EventHandler(this.spbtnThem_Click);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // grvTyGia
            // 
            this.grvTyGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCurrency_ID,
            this.colCurrencyName,
            this.colExchange,
            this.colActive});
            this.grvTyGia.GridControl = this.grcTyGia;
            this.grvTyGia.Name = "grvTyGia";
            // 
            // colCurrency_ID
            // 
            this.colCurrency_ID.Caption = "Mã Tiền Tệ";
            this.colCurrency_ID.FieldName = "Currency_ID";
            this.colCurrency_ID.Name = "colCurrency_ID";
            this.colCurrency_ID.Visible = true;
            this.colCurrency_ID.VisibleIndex = 0;
            this.colCurrency_ID.Width = 159;
            // 
            // colCurrencyName
            // 
            this.colCurrencyName.Caption = "Tên Tiền Tệ";
            this.colCurrencyName.FieldName = "CurrencyName";
            this.colCurrencyName.Name = "colCurrencyName";
            this.colCurrencyName.Visible = true;
            this.colCurrencyName.VisibleIndex = 1;
            this.colCurrencyName.Width = 136;
            // 
            // colExchange
            // 
            this.colExchange.Caption = "Tỷ Giá";
            this.colExchange.FieldName = "Exchange";
            this.colExchange.Name = "colExchange";
            this.colExchange.Visible = true;
            this.colExchange.VisibleIndex = 2;
            this.colExchange.Width = 159;
            // 
            // colActive
            // 
            this.colActive.Caption = "Còn Quản Lý";
            this.colActive.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 3;
            this.colActive.Width = 324;
            // 
            // grcTyGia
            // 
            this.grcTyGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcTyGia.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grcTyGia.Location = new System.Drawing.Point(0, 50);
            this.grcTyGia.MainView = this.grvTyGia;
            this.grcTyGia.Name = "grcTyGia";
            this.grcTyGia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.grcTyGia.Size = new System.Drawing.Size(921, 407);
            this.grcTyGia.TabIndex = 9;
            this.grcTyGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTyGia});
            // 
            // colTel
            // 
            this.colTel.Caption = "Điện thoại";
            this.colTel.FieldName = "Tel";
            this.colTel.Name = "colTel";
            this.colTel.Visible = true;
            this.colTel.VisibleIndex = 3;
            this.colTel.Width = 129;
            // 
            // frmTyGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 457);
            this.Controls.Add(this.grcTyGia);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTyGia";
            this.Text = "Tỷ Giá";
            this.Load += new System.EventHandler(this.frmTyGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTyGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcTyGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton spbtnSuaChua;
        private DevExpress.XtraEditors.SimpleButton spbtnNapLai;
        private DevExpress.XtraEditors.SimpleButton spbtnDong;
        private DevExpress.XtraEditors.SimpleButton spbtnXuat;
        private DevExpress.XtraEditors.SimpleButton spbtnXoa;
        private DevExpress.XtraEditors.SimpleButton spbtnThem;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTyGia;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyName;
        private DevExpress.XtraGrid.Columns.GridColumn colExchange;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.GridControl grcTyGia;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
    }
}