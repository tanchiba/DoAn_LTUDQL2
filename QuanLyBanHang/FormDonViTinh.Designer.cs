namespace QuanLyBanHang
{
    partial class frmDonViTinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonViTinh));
            this.uNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet = new QuanLyBanHang.QuanLyBanHangDataSet();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cUSTOMERTableAdapter = new QuanLyBanHang.QuanLyBanHangDataSetTableAdapters.CUSTOMERTableAdapter();
            this.uNITTableAdapter = new QuanLyBanHang.QuanLyBanHangDataSetTableAdapters.UNITTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.spbtnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnNapLai = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnDong = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.grcDonViTinh = new DevExpress.XtraGrid.GridControl();
            this.grvDonViTinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnit_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // uNITBindingSource
            // 
            this.uNITBindingSource.DataMember = "UNIT";
            this.uNITBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // quanLyBanHangDataSet
            // 
            this.quanLyBanHangDataSet.DataSetName = "QuanLyBanHangDataSet";
            this.quanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // uNITTableAdapter
            // 
            this.uNITTableAdapter.ClearBeforeFill = true;
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
            this.panelControl1.Size = new System.Drawing.Size(750, 50);
            this.panelControl1.TabIndex = 6;
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
            this.spbtnNapLai.Click += new System.EventHandler(this.spbtnNapLai_Click);
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
            this.spbtnXuat.Click += new System.EventHandler(this.spbtnXuat_Click);
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
            // grcDonViTinh
            // 
            this.grcDonViTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDonViTinh.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grcDonViTinh.Location = new System.Drawing.Point(0, 50);
            this.grcDonViTinh.MainView = this.grvDonViTinh;
            this.grcDonViTinh.Name = "grcDonViTinh";
            this.grcDonViTinh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.grcDonViTinh.Size = new System.Drawing.Size(750, 333);
            this.grcDonViTinh.TabIndex = 7;
            this.grcDonViTinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDonViTinh});
            // 
            // grvDonViTinh
            // 
            this.grvDonViTinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUnit_ID,
            this.colUnitName,
            this.colDescription,
            this.colActive});
            this.grvDonViTinh.GridControl = this.grcDonViTinh;
            this.grvDonViTinh.Name = "grvDonViTinh";
            // 
            // colUnit_ID
            // 
            this.colUnit_ID.Caption = "Mã ";
            this.colUnit_ID.FieldName = "Unit_ID";
            this.colUnit_ID.Name = "colUnit_ID";
            this.colUnit_ID.Visible = true;
            this.colUnit_ID.VisibleIndex = 0;
            this.colUnit_ID.Width = 159;
            // 
            // colUnitName
            // 
            this.colUnitName.Caption = "Tên Đơn Vị";
            this.colUnitName.FieldName = "UnitName";
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.Visible = true;
            this.colUnitName.VisibleIndex = 1;
            this.colUnitName.Width = 136;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Mô Tả";
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
            // frmDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 383);
            this.Controls.Add(this.grcDonViTinh);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDonViTinh";
            this.Text = "Đơn Vị Tính";
            this.Load += new System.EventHandler(this.frmDonViTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private QuanLyBanHangDataSet quanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private QuanLyBanHangDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.BindingSource uNITBindingSource;
        private QuanLyBanHangDataSetTableAdapters.UNITTableAdapter uNITTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton spbtnSuaChua;
        private DevExpress.XtraEditors.SimpleButton spbtnNapLai;
        private DevExpress.XtraEditors.SimpleButton spbtnDong;
        private DevExpress.XtraEditors.SimpleButton spbtnXuat;
        private DevExpress.XtraEditors.SimpleButton spbtnXoa;
        private DevExpress.XtraEditors.SimpleButton spbtnThem;
        private DevExpress.XtraGrid.GridControl grcDonViTinh;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}