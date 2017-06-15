namespace QuanLyBanHang
{
    partial class frmThemNhomHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNhomHangHoa));
            this.groupThongTin = new DevExpress.XtraEditors.GroupControl();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenNhomHang = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNhomHang = new DevExpress.XtraEditors.TextEdit();
            this.checkBConQuanLy = new System.Windows.Forms.CheckBox();
            this.lblTygiaquydoi = new System.Windows.Forms.Label();
            this.lblTenTienTe = new System.Windows.Forms.Label();
            this.lblMaTienTe = new System.Windows.Forms.Label();
            this.spbtnDong = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).BeginInit();
            this.groupThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhomHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhomHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupThongTin
            // 
            this.groupThongTin.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupThongTin.Appearance.Options.UseBackColor = true;
            this.groupThongTin.Controls.Add(this.txtGhiChu);
            this.groupThongTin.Controls.Add(this.txtTenNhomHang);
            this.groupThongTin.Controls.Add(this.txtMaNhomHang);
            this.groupThongTin.Controls.Add(this.checkBConQuanLy);
            this.groupThongTin.Controls.Add(this.lblTygiaquydoi);
            this.groupThongTin.Controls.Add(this.lblTenTienTe);
            this.groupThongTin.Controls.Add(this.lblMaTienTe);
            this.groupThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupThongTin.Location = new System.Drawing.Point(0, 0);
            this.groupThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(453, 176);
            this.groupThongTin.TabIndex = 5;
            this.groupThongTin.Text = "Thông tin";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(103, 109);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(330, 21);
            this.txtGhiChu.TabIndex = 9;
            // 
            // txtTenNhomHang
            // 
            this.txtTenNhomHang.Location = new System.Drawing.Point(103, 76);
            this.txtTenNhomHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNhomHang.Name = "txtTenNhomHang";
            this.txtTenNhomHang.Size = new System.Drawing.Size(330, 20);
            this.txtTenNhomHang.TabIndex = 8;
            // 
            // txtMaNhomHang
            // 
            this.txtMaNhomHang.Location = new System.Drawing.Point(103, 43);
            this.txtMaNhomHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhomHang.Name = "txtMaNhomHang";
            this.txtMaNhomHang.Size = new System.Drawing.Size(330, 20);
            this.txtMaNhomHang.TabIndex = 7;
            // 
            // checkBConQuanLy
            // 
            this.checkBConQuanLy.AutoSize = true;
            this.checkBConQuanLy.Location = new System.Drawing.Point(103, 144);
            this.checkBConQuanLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBConQuanLy.Name = "checkBConQuanLy";
            this.checkBConQuanLy.Size = new System.Drawing.Size(83, 17);
            this.checkBConQuanLy.TabIndex = 6;
            this.checkBConQuanLy.Text = "Còn quản lý";
            this.checkBConQuanLy.UseVisualStyleBackColor = true;
            // 
            // lblTygiaquydoi
            // 
            this.lblTygiaquydoi.AutoSize = true;
            this.lblTygiaquydoi.Location = new System.Drawing.Point(18, 112);
            this.lblTygiaquydoi.Name = "lblTygiaquydoi";
            this.lblTygiaquydoi.Size = new System.Drawing.Size(44, 13);
            this.lblTygiaquydoi.TabIndex = 2;
            this.lblTygiaquydoi.Text = "Ghi Chú";
            // 
            // lblTenTienTe
            // 
            this.lblTenTienTe.AutoSize = true;
            this.lblTenTienTe.Location = new System.Drawing.Point(17, 78);
            this.lblTenTienTe.Name = "lblTenTienTe";
            this.lblTenTienTe.Size = new System.Drawing.Size(83, 13);
            this.lblTenTienTe.TabIndex = 1;
            this.lblTenTienTe.Text = "Tên Nhóm Hàng";
            // 
            // lblMaTienTe
            // 
            this.lblMaTienTe.AutoSize = true;
            this.lblMaTienTe.Location = new System.Drawing.Point(18, 45);
            this.lblMaTienTe.Name = "lblMaTienTe";
            this.lblMaTienTe.Size = new System.Drawing.Size(79, 13);
            this.lblMaTienTe.TabIndex = 0;
            this.lblMaTienTe.Text = "Mã Nhóm Hàng";
            // 
            // spbtnDong
            // 
            this.spbtnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbtnDong.Appearance.Options.UseFont = true;
            this.spbtnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnDong.ImageOptions.Image")));
            this.spbtnDong.Location = new System.Drawing.Point(324, 190);
            this.spbtnDong.Name = "spbtnDong";
            this.spbtnDong.Size = new System.Drawing.Size(109, 32);
            this.spbtnDong.TabIndex = 10;
            this.spbtnDong.Text = "Đóng";
            this.spbtnDong.Click += new System.EventHandler(this.spbtnDong_Click);
            // 
            // spbtnLuu
            // 
            this.spbtnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbtnLuu.Appearance.Options.UseFont = true;
            this.spbtnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnLuu.ImageOptions.Image")));
            this.spbtnLuu.Location = new System.Drawing.Point(209, 190);
            this.spbtnLuu.Name = "spbtnLuu";
            this.spbtnLuu.Size = new System.Drawing.Size(109, 32);
            this.spbtnLuu.TabIndex = 11;
            this.spbtnLuu.Text = "Lưu";
            this.spbtnLuu.Click += new System.EventHandler(this.spbtnLuu_Click);
            // 
            // frmThemNhomHangHoa
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 225);
            this.Controls.Add(this.spbtnDong);
            this.Controls.Add(this.spbtnLuu);
            this.Controls.Add(this.groupThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThemNhomHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Nhóm Hàng Hóa";
            this.Load += new System.EventHandler(this.frmThemNhomHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).EndInit();
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhomHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhomHang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupThongTin;
        private System.Windows.Forms.TextBox txtGhiChu;
        private DevExpress.XtraEditors.TextEdit txtTenNhomHang;
        private DevExpress.XtraEditors.TextEdit txtMaNhomHang;
        private System.Windows.Forms.CheckBox checkBConQuanLy;
        private System.Windows.Forms.Label lblTygiaquydoi;
        private System.Windows.Forms.Label lblTenTienTe;
        private System.Windows.Forms.Label lblMaTienTe;
        private DevExpress.XtraEditors.SimpleButton spbtnDong;
        private DevExpress.XtraEditors.SimpleButton spbtnLuu;
    }
}