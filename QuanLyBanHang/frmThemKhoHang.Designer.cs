namespace QuanLyBanHang
{
    partial class frmThemKhoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemKhoHang));
            this.grcThongTinBatBuoc = new DevExpress.XtraEditors.GroupControl();
            this.grlpedtQuanLy = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Employee_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.lblNguoiQuanLy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBConQuanLy = new System.Windows.Forms.CheckBox();
            this.spbtnDong = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.grcThongTinKhac = new DevExpress.XtraEditors.GroupControl();
            this.txtDG = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtDT = new DevExpress.XtraEditors.TextEdit();
            this.txtNguoiLienHe = new DevExpress.XtraEditors.TextEdit();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDienGia = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNguoiLienHe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grcThongTinBatBuoc)).BeginInit();
            this.grcThongTinBatBuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grlpedtQuanLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcThongTinKhac)).BeginInit();
            this.grcThongTinKhac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiLienHe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcThongTinBatBuoc
            // 
            this.grcThongTinBatBuoc.Controls.Add(this.grlpedtQuanLy);
            this.grcThongTinBatBuoc.Controls.Add(this.txtTen);
            this.grcThongTinBatBuoc.Controls.Add(this.txtMaKho);
            this.grcThongTinBatBuoc.Controls.Add(this.lblNguoiQuanLy);
            this.grcThongTinBatBuoc.Controls.Add(this.label4);
            this.grcThongTinBatBuoc.Controls.Add(this.label1);
            this.grcThongTinBatBuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.grcThongTinBatBuoc.Location = new System.Drawing.Point(0, 0);
            this.grcThongTinBatBuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grcThongTinBatBuoc.Name = "grcThongTinBatBuoc";
            this.grcThongTinBatBuoc.Size = new System.Drawing.Size(474, 142);
            this.grcThongTinBatBuoc.TabIndex = 0;
            this.grcThongTinBatBuoc.Text = "Thông tin bắt buộc";
            // 
            // grlpedtQuanLy
            // 
            this.grlpedtQuanLy.Location = new System.Drawing.Point(79, 102);
            this.grlpedtQuanLy.Name = "grlpedtQuanLy";
            this.grlpedtQuanLy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grlpedtQuanLy.Properties.View = this.gridLookUpEdit1View;
            this.grlpedtQuanLy.Size = new System.Drawing.Size(380, 20);
            this.grlpedtQuanLy.TabIndex = 8;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Employee_ID,
            this.EmployeeName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Employee_ID
            // 
            this.Employee_ID.Caption = "Mã";
            this.Employee_ID.FieldName = "Employee_ID";
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.Visible = true;
            this.Employee_ID.VisibleIndex = 0;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Caption = "Tên ";
            this.EmployeeName.FieldName = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Visible = true;
            this.EmployeeName.VisibleIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(79, 67);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(380, 20);
            this.txtTen.TabIndex = 7;
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(79, 33);
            this.txtMaKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(380, 20);
            this.txtMaKho.TabIndex = 5;
            // 
            // lblNguoiQuanLy
            // 
            this.lblNguoiQuanLy.AutoSize = true;
            this.lblNguoiQuanLy.Location = new System.Drawing.Point(8, 103);
            this.lblNguoiQuanLy.Name = "lblNguoiQuanLy";
            this.lblNguoiQuanLy.Size = new System.Drawing.Size(73, 13);
            this.lblNguoiQuanLy.TabIndex = 4;
            this.lblNguoiQuanLy.Text = "Người quản lý";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã (*)";
            // 
            // checkBConQuanLy
            // 
            this.checkBConQuanLy.AutoSize = true;
            this.checkBConQuanLy.Location = new System.Drawing.Point(79, 372);
            this.checkBConQuanLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBConQuanLy.Name = "checkBConQuanLy";
            this.checkBConQuanLy.Size = new System.Drawing.Size(83, 17);
            this.checkBConQuanLy.TabIndex = 7;
            this.checkBConQuanLy.Text = "Còn quản lý";
            this.checkBConQuanLy.UseVisualStyleBackColor = true;
            // 
            // spbtnDong
            // 
            this.spbtnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbtnDong.Appearance.Options.UseFont = true;
            this.spbtnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnDong.ImageOptions.Image")));
            this.spbtnDong.Location = new System.Drawing.Point(350, 363);
            this.spbtnDong.Name = "spbtnDong";
            this.spbtnDong.Size = new System.Drawing.Size(109, 32);
            this.spbtnDong.TabIndex = 12;
            this.spbtnDong.Text = "Đóng";
            this.spbtnDong.Click += new System.EventHandler(this.spbtnDong_Click);
            // 
            // spbtnLuu
            // 
            this.spbtnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbtnLuu.Appearance.Options.UseFont = true;
            this.spbtnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnLuu.ImageOptions.Image")));
            this.spbtnLuu.Location = new System.Drawing.Point(235, 363);
            this.spbtnLuu.Name = "spbtnLuu";
            this.spbtnLuu.Size = new System.Drawing.Size(109, 32);
            this.spbtnLuu.TabIndex = 13;
            this.spbtnLuu.Text = "Lưu";
            this.spbtnLuu.Click += new System.EventHandler(this.spbtnLuu_Click);
            // 
            // grcThongTinKhac
            // 
            this.grcThongTinKhac.Controls.Add(this.txtDG);
            this.grcThongTinKhac.Controls.Add(this.txtEmail);
            this.grcThongTinKhac.Controls.Add(this.txtDiaChi);
            this.grcThongTinKhac.Controls.Add(this.txtDT);
            this.grcThongTinKhac.Controls.Add(this.txtNguoiLienHe);
            this.grcThongTinKhac.Controls.Add(this.lblDienThoai);
            this.grcThongTinKhac.Controls.Add(this.lblDiaChi);
            this.grcThongTinKhac.Controls.Add(this.lblDienGia);
            this.grcThongTinKhac.Controls.Add(this.lblEmail);
            this.grcThongTinKhac.Controls.Add(this.lblNguoiLienHe);
            this.grcThongTinKhac.Location = new System.Drawing.Point(1, 143);
            this.grcThongTinKhac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grcThongTinKhac.Name = "grcThongTinKhac";
            this.grcThongTinKhac.Size = new System.Drawing.Size(473, 212);
            this.grcThongTinKhac.TabIndex = 14;
            this.grcThongTinKhac.Text = "Thông tin khác";
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(79, 176);
            this.txtDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(380, 20);
            this.txtDG.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(79, 139);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(79, 70);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(380, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(79, 103);
            this.txtDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(380, 20);
            this.txtDT.TabIndex = 6;
            // 
            // txtNguoiLienHe
            // 
            this.txtNguoiLienHe.Location = new System.Drawing.Point(79, 37);
            this.txtNguoiLienHe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNguoiLienHe.Name = "txtNguoiLienHe";
            this.txtNguoiLienHe.Size = new System.Drawing.Size(380, 20);
            this.txtNguoiLienHe.TabIndex = 5;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(10, 107);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(56, 13);
            this.lblDienThoai.TabIndex = 4;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(10, 73);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(39, 13);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblDienGia
            // 
            this.lblDienGia.AutoSize = true;
            this.lblDienGia.Location = new System.Drawing.Point(10, 178);
            this.lblDienGia.Name = "lblDienGia";
            this.lblDienGia.Size = new System.Drawing.Size(45, 13);
            this.lblDienGia.TabIndex = 2;
            this.lblDienGia.Text = "Diễn giả";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(31, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblNguoiLienHe
            // 
            this.lblNguoiLienHe.AutoSize = true;
            this.lblNguoiLienHe.Location = new System.Drawing.Point(10, 40);
            this.lblNguoiLienHe.Name = "lblNguoiLienHe";
            this.lblNguoiLienHe.Size = new System.Drawing.Size(69, 13);
            this.lblNguoiLienHe.TabIndex = 0;
            this.lblNguoiLienHe.Text = "Người liên hệ";
            // 
            // frmThemKhoHang
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 401);
            this.Controls.Add(this.grcThongTinKhac);
            this.Controls.Add(this.spbtnDong);
            this.Controls.Add(this.spbtnLuu);
            this.Controls.Add(this.checkBConQuanLy);
            this.Controls.Add(this.grcThongTinBatBuoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThemKhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Kho";
            this.Load += new System.EventHandler(this.frmThemKhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcThongTinBatBuoc)).EndInit();
            this.grcThongTinBatBuoc.ResumeLayout(false);
            this.grcThongTinBatBuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grlpedtQuanLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcThongTinKhac)).EndInit();
            this.grcThongTinKhac.ResumeLayout(false);
            this.grcThongTinKhac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiLienHe.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grcThongTinBatBuoc;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private System.Windows.Forms.Label lblNguoiQuanLy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBConQuanLy;
        private DevExpress.XtraEditors.SimpleButton spbtnDong;
        private DevExpress.XtraEditors.SimpleButton spbtnLuu;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.GridLookUpEdit grlpedtQuanLy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GroupControl grcThongTinKhac;
        private DevExpress.XtraEditors.TextEdit txtDG;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtDT;
        private DevExpress.XtraEditors.TextEdit txtNguoiLienHe;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienGia;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNguoiLienHe;
        private DevExpress.XtraGrid.Columns.GridColumn Employee_ID;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeName;
    }
}