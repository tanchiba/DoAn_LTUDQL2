namespace QuanLyBanHang
{
    partial class frmThemVaiTro
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescription = new DevExpress.XtraEditors.TextEdit();
            this.tbten = new DevExpress.XtraEditors.TextEdit();
            this.tbMa = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tlVaiTro = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.AllowImport = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemTreeListLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit();
            this.repositoryItemTreeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlVaiTro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnDong);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.tbDescription);
            this.groupControl1.Controls.Add(this.tbten);
            this.groupControl1.Controls.Add(this.tbMa);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(803, 101);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin vai trò";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(640, 62);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(559, 61);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Luu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Diễn giải";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Vai Trò";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(435, 23);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(363, 20);
            this.tbDescription.TabIndex = 2;
            // 
            // tbten
            // 
            this.tbten.Location = new System.Drawing.Point(67, 68);
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(299, 20);
            this.tbten.TabIndex = 1;
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(67, 23);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(299, 20);
            this.tbMa.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.tlVaiTro);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 101);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(803, 311);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Quyền Hạn";
            // 
            // tlVaiTro
            // 
            this.tlVaiTro.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.AllowImport,
            this.treeListColumn7,
            this.treeListColumn6});
            this.tlVaiTro.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.tlVaiTro.Location = new System.Drawing.Point(5, 23);
            this.tlVaiTro.Name = "tlVaiTro";
            this.tlVaiTro.OptionsView.AutoWidth = false;
            this.tlVaiTro.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFocus;
            this.tlVaiTro.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTreeListLookUpEdit1});
            this.tlVaiTro.Size = new System.Drawing.Size(798, 288);
            this.tlVaiTro.TabIndex = 0;
            this.tlVaiTro.CellValueChanging += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.tlVaiTro_CellValueChanging);
            this.tlVaiTro.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.tlVaiTro_CellValueChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Chức Năng";
            this.treeListColumn1.FieldName = "ObjectName";
            this.treeListColumn1.MinWidth = 88;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 88;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Truy Cập";
            this.treeListColumn2.FieldName = "AllowAccess";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Thêm";
            this.treeListColumn3.FieldName = "AllowAdd";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Xóa";
            this.treeListColumn4.FieldName = "AllowDelete";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 3;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Sửa";
            this.treeListColumn5.FieldName = "AllowEdit";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 4;
            // 
            // AllowImport
            // 
            this.AllowImport.Caption = "Nhập";
            this.AllowImport.FieldName = "AllowImport";
            this.AllowImport.Name = "AllowImport";
            this.AllowImport.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.AllowImport.Visible = true;
            this.AllowImport.VisibleIndex = 5;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "Xuất";
            this.treeListColumn7.FieldName = "AllowExport";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 6;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "In";
            this.treeListColumn6.FieldName = "AllowPrint";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 7;
            // 
            // repositoryItemTreeListLookUpEdit1
            // 
            this.repositoryItemTreeListLookUpEdit1.AutoHeight = false;
            this.repositoryItemTreeListLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTreeListLookUpEdit1.Name = "repositoryItemTreeListLookUpEdit1";
            this.repositoryItemTreeListLookUpEdit1.TreeList = this.repositoryItemTreeListLookUpEdit1TreeList;
            // 
            // repositoryItemTreeListLookUpEdit1TreeList
            // 
            this.repositoryItemTreeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.repositoryItemTreeListLookUpEdit1TreeList.Name = "repositoryItemTreeListLookUpEdit1TreeList";
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.repositoryItemTreeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // frmThemVaiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 412);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmThemVaiTro";
            this.Text = "frmThemVaiTro";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlVaiTro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit tbDescription;
        private DevExpress.XtraEditors.TextEdit tbten;
        private DevExpress.XtraEditors.TextEdit tbMa;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraTreeList.TreeList tlVaiTro;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn AllowImport;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit repositoryItemTreeListLookUpEdit1;
        private DevExpress.XtraTreeList.TreeList repositoryItemTreeListLookUpEdit1TreeList;
    }
}