namespace QuanLyBanHang
{
    partial class frmNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.quanLyBanHangDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet = new QuanLyBanHang.QuanLyBanHangDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnNapLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSuaChua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter = new QuanLyBanHang.QuanLyBanHangDataSetTableAdapters.EMPLOYEETableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grcNhanVien);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 466);
            this.panel1.TabIndex = 0;
            // 
            // grcNhanVien
            // 
            this.grcNhanVien.DataSource = this.quanLyBanHangDataSetBindingSource;
            this.grcNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grcNhanVien.Location = new System.Drawing.Point(0, 58);
            this.grcNhanVien.MainView = this.gridView1;
            this.grcNhanVien.Name = "grcNhanVien";
            this.grcNhanVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.grcNhanVien.Size = new System.Drawing.Size(909, 408);
            this.grcNhanVien.TabIndex = 6;
            this.grcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // quanLyBanHangDataSetBindingSource
            // 
            this.quanLyBanHangDataSetBindingSource.DataSource = this.quanLyBanHangDataSet;
            this.quanLyBanHangDataSetBindingSource.Position = 0;
            // 
            // quanLyBanHangDataSet
            // 
            this.quanLyBanHangDataSet.DataSetName = "QuanLyBanHangDataSet";
            this.quanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployee,
            this.colEmployeeName,
            this.colEmployeeAddress,
            this.colTel,
            this.colEmail,
            this.colActive});
            this.gridView1.GridControl = this.grcNhanVien;
            this.gridView1.Name = "gridView1";
            // 
            // colEmployee
            // 
            this.colEmployee.Caption = "Mã Nhân Viên";
            this.colEmployee.FieldName = "Employee_ID";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.Visible = true;
            this.colEmployee.VisibleIndex = 0;
            this.colEmployee.Width = 159;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.Caption = "Tên Nhân Viên";
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 1;
            this.colEmployeeName.Width = 136;
            // 
            // colEmployeeAddress
            // 
            this.colEmployeeAddress.Caption = "Địa chỉ";
            this.colEmployeeAddress.FieldName = "EmployeeAddress";
            this.colEmployeeAddress.Name = "colEmployeeAddress";
            this.colEmployeeAddress.Visible = true;
            this.colEmployeeAddress.VisibleIndex = 2;
            this.colEmployeeAddress.Width = 159;
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
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            this.colEmail.Width = 147;
            // 
            // colActive
            // 
            this.colActive.Caption = "Còn Quản Lý";
            this.colActive.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 5;
            this.colActive.Width = 324;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDong);
            this.panelControl1.Controls.Add(this.btnXuat);
            this.panelControl1.Controls.Add(this.btnNapLai);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnSuaChua);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(909, 58);
            this.panelControl1.TabIndex = 5;
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QuanLyBanHang.Properties.Resources.Folders_OS_Exit_Full_Screen_Metro_icon;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDong.Location = new System.Drawing.Point(331, 5);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(54, 49);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            this.btnXuat.Image = global::QuanLyBanHang.Properties.Resources.Export_To_File_icon;
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXuat.Location = new System.Drawing.Point(271, 5);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(54, 49);
            this.btnXuat.TabIndex = 5;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNapLai
            // 
            this.btnNapLai.Image = global::QuanLyBanHang.Properties.Resources.Button_Refresh_icon;
            this.btnNapLai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNapLai.Location = new System.Drawing.Point(211, 5);
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.Size = new System.Drawing.Size(54, 49);
            this.btnNapLai.TabIndex = 4;
            this.btnNapLai.Text = "Nạp lại";
            this.btnNapLai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNapLai.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyBanHang.Properties.Resources.Actions_edit_delete_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(151, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 49);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Image = global::QuanLyBanHang.Properties.Resources.hp_customization_control_panel_icon;
            this.btnSuaChua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaChua.Location = new System.Drawing.Point(66, 5);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(79, 49);
            this.btnSuaChua.TabIndex = 1;
            this.btnSuaChua.Text = "Sửa Chữa";
            this.btnSuaChua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaChua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSuaChua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Image = global::QuanLyBanHang.Properties.Resources.add_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(5, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(55, 49);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 466);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnNapLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSuaChua;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraGrid.GridControl grcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private QuanLyBanHangDataSet quanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private QuanLyBanHangDataSetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.BindingSource quanLyBanHangDataSetBindingSource;
    }
}