﻿namespace QuanLyBanHang
{
    partial class frmSuaKhachHang
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
            System.Windows.Forms.Button btnLuu;
            System.Windows.Forms.Button btnDong;
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvKhuVuc = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDienThoai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Customer_Group_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            btnLuu = new System.Windows.Forms.Button();
            btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhuVuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.Location = new System.Drawing.Point(391, 229);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(75, 23);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(457, 12);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(88, 17);
            this.cbActive.TabIndex = 2;
            this.cbActive.Text = "Còn Quản Lý";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridLookUpEdit1);
            this.groupControl1.Controls.Add(this.gvKhuVuc);
            this.groupControl1.Controls.Add(this.label12);
            this.groupControl1.Controls.Add(this.tbEmail);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.tbDienThoai);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.tbDiaChi);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.tbTen);
            this.groupControl1.Controls.Add(this.lbTen);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.tbMa);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 36);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(543, 187);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông Tin Chung";
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.EditValue = "";
            this.gridLookUpEdit1.Location = new System.Drawing.Point(87, 158);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.View = this.gridView1;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(446, 20);
            this.gridLookUpEdit1.TabIndex = 26;
            this.gridLookUpEdit1.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gvKhuVuc
            // 
            this.gvKhuVuc.EditValue = "";
            this.gvKhuVuc.Location = new System.Drawing.Point(294, 24);
            this.gvKhuVuc.Name = "gvKhuVuc";
            this.gvKhuVuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvKhuVuc.Properties.View = this.gridLookUpEdit1View;
            this.gvKhuVuc.Size = new System.Drawing.Size(241, 20);
            this.gvKhuVuc.TabIndex = 25;
            this.gvKhuVuc.EditValueChanged += new System.EventHandler(this.gvKhuVuc_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Customer_Group_Name});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Loại Khách Hàng";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(87, 131);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(446, 21);
            this.tbEmail.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Email";
            // 
            // tbDienThoai
            // 
            this.tbDienThoai.Location = new System.Drawing.Point(87, 104);
            this.tbDienThoai.Name = "tbDienThoai";
            this.tbDienThoai.Size = new System.Drawing.Size(446, 21);
            this.tbDienThoai.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Điện thoại";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(46, 77);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(488, 21);
            this.tbDiaChi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đia Chỉ";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(46, 50);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(488, 21);
            this.tbTen.TabIndex = 6;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(5, 58);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(25, 13);
            this.lbTen.TabIndex = 5;
            this.lbTen.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khu Vực";
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(87, 23);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(131, 21);
            this.tbMa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // btnDong
            // 
            btnDong.Location = new System.Drawing.Point(470, 229);
            btnDong.Name = "btnDong";
            btnDong.Size = new System.Drawing.Size(75, 23);
            btnDong.TabIndex = 5;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Loại Khách Hàng";
            this.gridColumn1.FieldName = "Customer_Type_Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // Customer_Group_Name
            // 
            this.Customer_Group_Name.Caption = "Khu Vực";
            this.Customer_Group_Name.FieldName = "Customer_Group_Name";
            this.Customer_Group_Name.Name = "Customer_Group_Name";
            this.Customer_Group_Name.Visible = true;
            this.Customer_Group_Name.VisibleIndex = 0;
            // 
            // frmSuaKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 257);
            this.Controls.Add(btnDong);
            this.Controls.Add(btnLuu);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cbActive);
            this.Name = "frmSuaKhachHang";
            this.Text = "frmThamKhachHang";
            this.Load += new System.EventHandler(this.frmThamKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhuVuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Customer_Group_Name;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        public System.Windows.Forms.CheckBox cbActive;
        public System.Windows.Forms.TextBox tbEmail;
        public System.Windows.Forms.TextBox tbDienThoai;
        public System.Windows.Forms.TextBox tbDiaChi;
        public System.Windows.Forms.TextBox tbTen;
        public System.Windows.Forms.TextBox tbMa;
        public DevExpress.XtraEditors.GridLookUpEdit gvKhuVuc;
        public DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
    }
}