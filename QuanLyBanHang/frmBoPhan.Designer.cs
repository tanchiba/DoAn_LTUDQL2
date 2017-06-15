namespace QuanLyBanHang
{
    partial class frmBoPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoPhan));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.spbtnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnNapLai = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnDong = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.grcBoPhan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Department = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcBoPhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(910, 55);
            this.panelControl1.TabIndex = 8;
            // 
            // spbtnSuaChua
            // 
            this.spbtnSuaChua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnSuaChua.ImageOptions.Image")));
            this.spbtnSuaChua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.spbtnSuaChua.Location = new System.Drawing.Point(65, 3);
            this.spbtnSuaChua.Name = "spbtnSuaChua";
            this.spbtnSuaChua.Size = new System.Drawing.Size(72, 47);
            this.spbtnSuaChua.TabIndex = 0;
            this.spbtnSuaChua.Text = "Sửa Chữa";
            this.spbtnSuaChua.Click += new System.EventHandler(this.spbtnSuaChua_Click);
            // 
            // spbtnNapLai
            // 
            this.spbtnNapLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnNapLai.ImageOptions.Image")));
            this.spbtnNapLai.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.spbtnNapLai.Location = new System.Drawing.Point(201, 4);
            this.spbtnNapLai.Name = "spbtnNapLai";
            this.spbtnNapLai.Size = new System.Drawing.Size(52, 47);
            this.spbtnNapLai.TabIndex = 0;
            this.spbtnNapLai.Text = "Nạp Lại";
            this.spbtnNapLai.Click += new System.EventHandler(this.spbtnNapLai_Click);
            // 
            // spbtnDong
            // 
            this.spbtnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnDong.ImageOptions.Image")));
            this.spbtnDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.spbtnDong.Location = new System.Drawing.Point(317, 4);
            this.spbtnDong.Name = "spbtnDong";
            this.spbtnDong.Size = new System.Drawing.Size(52, 47);
            this.spbtnDong.TabIndex = 0;
            this.spbtnDong.Text = "Đóng";
            this.spbtnDong.Click += new System.EventHandler(this.spbtnDong_Click);
            // 
            // spbtnXuat
            // 
            this.spbtnXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnXuat.ImageOptions.Image")));
            this.spbtnXuat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.spbtnXuat.Location = new System.Drawing.Point(259, 4);
            this.spbtnXuat.Name = "spbtnXuat";
            this.spbtnXuat.Size = new System.Drawing.Size(52, 47);
            this.spbtnXuat.TabIndex = 0;
            this.spbtnXuat.Text = "Xuất";
            this.spbtnXuat.Click += new System.EventHandler(this.spbtnXuat_Click);
            // 
            // spbtnXoa
            // 
            this.spbtnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnXoa.ImageOptions.Image")));
            this.spbtnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.spbtnXoa.Location = new System.Drawing.Point(143, 4);
            this.spbtnXoa.Name = "spbtnXoa";
            this.spbtnXoa.Size = new System.Drawing.Size(52, 47);
            this.spbtnXoa.TabIndex = 0;
            this.spbtnXoa.Text = "Xóa";
            this.spbtnXoa.Click += new System.EventHandler(this.spbtnXoa_Click);
            // 
            // spbtnThem
            // 
            this.spbtnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnThem.ImageOptions.Image")));
            this.spbtnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.spbtnThem.Location = new System.Drawing.Point(8, 3);
            this.spbtnThem.Name = "spbtnThem";
            this.spbtnThem.Size = new System.Drawing.Size(52, 47);
            this.spbtnThem.TabIndex = 0;
            this.spbtnThem.Text = "Thêm";
            this.spbtnThem.Click += new System.EventHandler(this.spbtnThem_Click);
            // 
            // grcBoPhan
            // 
            this.grcBoPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcBoPhan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grcBoPhan.Location = new System.Drawing.Point(0, 55);
            this.grcBoPhan.MainView = this.gridView1;
            this.grcBoPhan.Name = "grcBoPhan";
            this.grcBoPhan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.grcBoPhan.Size = new System.Drawing.Size(910, 335);
            this.grcBoPhan.TabIndex = 9;
            this.grcBoPhan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Department,
            this.colDepartmentName,
            this.colDescription,
            this.colActive});
            this.gridView1.GridControl = this.grcBoPhan;
            this.gridView1.Name = "gridView1";
            // 
            // Department
            // 
            this.Department.Caption = "Mã";
            this.Department.FieldName = "Department_ID";
            this.Department.Name = "Department";
            this.Department.Visible = true;
            this.Department.VisibleIndex = 0;
            this.Department.Width = 159;
            // 
            // colDepartmentName
            // 
            this.colDepartmentName.Caption = "Tên ";
            this.colDepartmentName.FieldName = "DepartmentName";
            this.colDepartmentName.Name = "colDepartmentName";
            this.colDepartmentName.Visible = true;
            this.colDepartmentName.VisibleIndex = 1;
            this.colDepartmentName.Width = 136;
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
            // frmBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 390);
            this.Controls.Add(this.grcBoPhan);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBoPhan";
            this.Text = "Bộ Phận";
            this.Load += new System.EventHandler(this.frmBoPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBoPhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Department;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        public DevExpress.XtraGrid.GridControl grcBoPhan;
    }
}