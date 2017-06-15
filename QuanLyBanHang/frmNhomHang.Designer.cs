namespace QuanLyBanHang
{
    partial class frmNhomHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhomHang));
            this.tableAdapterManager1 = new QuanLyBanHang.QuanLyBanHangDataSetTableAdapters.TableAdapterManager();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.spbtnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnNapLai = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnDong = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.grcNhomHang = new DevExpress.XtraGrid.GridControl();
            this.grvNhomHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_Group_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Group_Names = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhomHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhomHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CASH_METHODTableAdapter = null;
            this.tableAdapterManager1.CASH_TERMTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.CURRENCYTableAdapter = null;
            this.tableAdapterManager1.CUSTOMER_GROUPTableAdapter = null;
            this.tableAdapterManager1.CUSTOMER_TYPETableAdapter = null;
            this.tableAdapterManager1.CUSTOMERTableAdapter = null;
            this.tableAdapterManager1.DEPARTMENTTableAdapter = null;
            this.tableAdapterManager1.EMPLOYEETableAdapter = null;
            this.tableAdapterManager1.INVENTORY_ACTIONTableAdapter = null;
            this.tableAdapterManager1.MESSAGETableAdapter = null;
            this.tableAdapterManager1.PRODUCT_GROUPTableAdapter = null;
            this.tableAdapterManager1.PRODUCTTableAdapter = null;
            this.tableAdapterManager1.PROVIDERTableAdapter = null;
            this.tableAdapterManager1.REPORTTableAdapter = null;
            this.tableAdapterManager1.STOCKTableAdapter = null;
            this.tableAdapterManager1.SYS_COMPANYTableAdapter = null;
            this.tableAdapterManager1.SYS_GROUPTableAdapter = null;
            this.tableAdapterManager1.SYS_LOGTableAdapter = null;
            this.tableAdapterManager1.SYS_OBJECTTableAdapter = null;
            this.tableAdapterManager1.SYS_RULETableAdapter = null;
            this.tableAdapterManager1.SYS_USER_RULETableAdapter = null;
            this.tableAdapterManager1.SYS_USERTableAdapter = null;
            this.tableAdapterManager1.UNITTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QuanLyBanHang.QuanLyBanHangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.panelControl1.Size = new System.Drawing.Size(818, 50);
            this.panelControl1.TabIndex = 7;
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
            // grcNhomHang
            // 
            this.grcNhomHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNhomHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grcNhomHang.Location = new System.Drawing.Point(0, 50);
            this.grcNhomHang.MainView = this.grvNhomHang;
            this.grcNhomHang.Name = "grcNhomHang";
            this.grcNhomHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.grcNhomHang.Size = new System.Drawing.Size(818, 317);
            this.grcNhomHang.TabIndex = 8;
            this.grcNhomHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNhomHang});
            // 
            // grvNhomHang
            // 
            this.grvNhomHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct_Group_ID,
            this.colProduct_Group_Names,
            this.colDescription,
            this.colActive});
            this.grvNhomHang.GridControl = this.grcNhomHang;
            this.grvNhomHang.Name = "grvNhomHang";
            // 
            // colProduct_Group_ID
            // 
            this.colProduct_Group_ID.Caption = "Mã Nhóm Hàng";
            this.colProduct_Group_ID.FieldName = "Product_Group_ID";
            this.colProduct_Group_ID.Name = "colProduct_Group_ID";
            this.colProduct_Group_ID.Visible = true;
            this.colProduct_Group_ID.VisibleIndex = 0;
            this.colProduct_Group_ID.Width = 159;
            // 
            // colProduct_Group_Names
            // 
            this.colProduct_Group_Names.Caption = "Tên Nhóm Hàng";
            this.colProduct_Group_Names.FieldName = "Product_Group_Name";
            this.colProduct_Group_Names.Name = "colProduct_Group_Names";
            this.colProduct_Group_Names.Visible = true;
            this.colProduct_Group_Names.VisibleIndex = 1;
            this.colProduct_Group_Names.Width = 136;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Ghi Chú";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 159;
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
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // frmNhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 367);
            this.Controls.Add(this.grcNhomHang);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNhomHang";
            this.Text = "Nhóm Hàng";
            this.Load += new System.EventHandler(this.frmNhomHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcNhomHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhomHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QuanLyBanHangDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton spbtnSuaChua;
        private DevExpress.XtraEditors.SimpleButton spbtnNapLai;
        private DevExpress.XtraEditors.SimpleButton spbtnDong;
        private DevExpress.XtraEditors.SimpleButton spbtnXuat;
        private DevExpress.XtraEditors.SimpleButton spbtnXoa;
        private DevExpress.XtraEditors.SimpleButton spbtnThem;
        private DevExpress.XtraGrid.GridControl grcNhomHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grvNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Group_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Group_Names;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}