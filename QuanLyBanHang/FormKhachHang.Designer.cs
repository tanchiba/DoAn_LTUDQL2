namespace QuanLyBanHang
{
    partial class FormKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Group_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.spbtnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnNapLai = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnDong = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet = new QuanLyBanHang.QuanLyBanHangDataSet();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cUSTOMERTableAdapter = new QuanLyBanHang.QuanLyBanHangDataSetTableAdapters.CUSTOMERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridSplitContainer1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(690, 134, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(750, 383);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = this.gridControl1;
            this.gridSplitContainer1.Location = new System.Drawing.Point(12, 12);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.panelControl1);
            this.gridSplitContainer1.Size = new System.Drawing.Size(726, 57);
            this.gridSplitContainer1.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 73);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(726, 298);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.colCustomerName,
            this.colCustomer_Group_ID,
            this.colCustomerAddress,
            this.colTel,
            this.colEmail,
            this.colActive});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustomer_Group_ID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator_1);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "Customer_ID";
            this.ID.Name = "ID";
            this.ID.OptionsFilter.AllowFilter = false;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 88;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Tên Khách Hàng";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            this.colCustomerName.Width = 88;
            // 
            // colCustomer_Group_ID
            // 
            this.colCustomer_Group_ID.Caption = "Khu Vực";
            this.colCustomer_Group_ID.FieldName = "Customer_Group_ID";
            this.colCustomer_Group_ID.Name = "colCustomer_Group_ID";
            this.colCustomer_Group_ID.Visible = true;
            this.colCustomer_Group_ID.VisibleIndex = 1;
            this.colCustomer_Group_ID.Width = 97;
            // 
            // colCustomerAddress
            // 
            this.colCustomerAddress.Caption = "Địa Chỉ khách Hàng";
            this.colCustomerAddress.FieldName = "CustomerAddress";
            this.colCustomerAddress.Name = "colCustomerAddress";
            this.colCustomerAddress.Visible = true;
            this.colCustomerAddress.VisibleIndex = 2;
            this.colCustomerAddress.Width = 85;
            // 
            // colTel
            // 
            this.colTel.Caption = "SĐt liên hệ";
            this.colTel.FieldName = "Tel";
            this.colTel.Name = "colTel";
            this.colTel.Visible = true;
            this.colTel.VisibleIndex = 3;
            this.colTel.Width = 85;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            this.colEmail.Width = 85;
            // 
            // colActive
            // 
            this.colActive.Caption = "Hoạt Động?";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 5;
            this.colActive.Width = 92;
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
            this.panelControl1.Size = new System.Drawing.Size(726, 50);
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
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(750, 383);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridSplitContainer1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(730, 61);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 61);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(730, 302);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // quanLyBanHangDataSet
            // 
            this.quanLyBanHangDataSet.DataSetName = "QuanLyBanHangDataSet";
            this.quanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 383);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormKhachHang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private QuanLyBanHangDataSet quanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private QuanLyBanHangDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        //private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        public DevExpress.XtraGrid.Columns.GridColumn colCustomer_Group_ID;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton spbtnSuaChua;
        private DevExpress.XtraEditors.SimpleButton spbtnNapLai;
        private DevExpress.XtraEditors.SimpleButton spbtnDong;
        private DevExpress.XtraEditors.SimpleButton spbtnXuat;
        private DevExpress.XtraEditors.SimpleButton spbtnXoa;
        private DevExpress.XtraEditors.SimpleButton spbtnThem;
    }
}