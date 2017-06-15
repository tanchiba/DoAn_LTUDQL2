namespace QuanLyBanHang
{
    partial class frmCapNhatTienTe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatTienTe));
            this.groupThongTin = new DevExpress.XtraEditors.GroupControl();
            this.txtTenTyGia = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTyGia = new DevExpress.XtraEditors.TextEdit();
            this.checkBConQuanLy = new System.Windows.Forms.CheckBox();
            this.lblTygiaquydoi = new System.Windows.Forms.Label();
            this.lblTenTyGia = new System.Windows.Forms.Label();
            this.lblMaTyGia = new System.Windows.Forms.Label();
            this.spbtnDong = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.calTyGiaQuyDoi = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).BeginInit();
            this.groupThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTyGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTyGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calTyGiaQuyDoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupThongTin
            // 
            this.groupThongTin.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupThongTin.Appearance.Options.UseBackColor = true;
            this.groupThongTin.Controls.Add(this.txtTenTyGia);
            this.groupThongTin.Controls.Add(this.txtMaTyGia);
            this.groupThongTin.Controls.Add(this.checkBConQuanLy);
            this.groupThongTin.Controls.Add(this.lblTygiaquydoi);
            this.groupThongTin.Controls.Add(this.lblTenTyGia);
            this.groupThongTin.Controls.Add(this.lblMaTyGia);
            this.groupThongTin.Controls.Add(this.calTyGiaQuyDoi);
            this.groupThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupThongTin.Location = new System.Drawing.Point(0, 0);
            this.groupThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(459, 176);
            this.groupThongTin.TabIndex = 3;
            this.groupThongTin.Text = "Thông tin";
            // 
            // txtTenTyGia
            // 
            this.txtTenTyGia.Location = new System.Drawing.Point(103, 76);
            this.txtTenTyGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenTyGia.Name = "txtTenTyGia";
            this.txtTenTyGia.Size = new System.Drawing.Size(330, 20);
            this.txtTenTyGia.TabIndex = 8;
            // 
            // txtMaTyGia
            // 
            this.txtMaTyGia.Location = new System.Drawing.Point(103, 43);
            this.txtMaTyGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaTyGia.Name = "txtMaTyGia";
            this.txtMaTyGia.Size = new System.Drawing.Size(330, 20);
            this.txtMaTyGia.TabIndex = 7;
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
            // lblTenTyGia
            // 
            this.lblTenTyGia.AutoSize = true;
            this.lblTenTyGia.Location = new System.Drawing.Point(17, 78);
            this.lblTenTyGia.Name = "lblTenTyGia";
            this.lblTenTyGia.Size = new System.Drawing.Size(58, 13);
            this.lblTenTyGia.TabIndex = 1;
            this.lblTenTyGia.Text = "Tên Tỷ Giá";
            // 
            // lblMaTyGia
            // 
            this.lblMaTyGia.AutoSize = true;
            this.lblMaTyGia.Location = new System.Drawing.Point(18, 45);
            this.lblMaTyGia.Name = "lblMaTyGia";
            this.lblMaTyGia.Size = new System.Drawing.Size(54, 13);
            this.lblMaTyGia.TabIndex = 0;
            this.lblMaTyGia.Text = "Mã Tỷ Giá";
            // 
            // spbtnDong
            // 
            this.spbtnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbtnDong.Appearance.Options.UseFont = true;
            this.spbtnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("spbtnDong.ImageOptions.Image")));
            this.spbtnDong.Location = new System.Drawing.Point(324, 186);
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
            this.spbtnLuu.Location = new System.Drawing.Point(209, 186);
            this.spbtnLuu.Name = "spbtnLuu";
            this.spbtnLuu.Size = new System.Drawing.Size(109, 32);
            this.spbtnLuu.TabIndex = 11;
            this.spbtnLuu.Text = "Lưu";
            this.spbtnLuu.Click += new System.EventHandler(this.spbtnLuu_Click);
            // 
            // calTyGiaQuyDoi
            // 
            this.calTyGiaQuyDoi.Location = new System.Drawing.Point(102, 109);
            this.calTyGiaQuyDoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calTyGiaQuyDoi.Name = "calTyGiaQuyDoi";
            this.calTyGiaQuyDoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calTyGiaQuyDoi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.calTyGiaQuyDoi.Size = new System.Drawing.Size(331, 20);
            this.calTyGiaQuyDoi.TabIndex = 10;
            // 
            // frmCapNhatTienTe
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 230);
            this.Controls.Add(this.spbtnDong);
            this.Controls.Add(this.spbtnLuu);
            this.Controls.Add(this.groupThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCapNhatTienTe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Tiền Tệ";
            this.Load += new System.EventHandler(this.frmCapNhatTienTe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).EndInit();
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTyGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTyGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calTyGiaQuyDoi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupThongTin;
        private DevExpress.XtraEditors.TextEdit txtTenTyGia;
        private DevExpress.XtraEditors.TextEdit txtMaTyGia;
        private System.Windows.Forms.CheckBox checkBConQuanLy;
        private System.Windows.Forms.Label lblTygiaquydoi;
        private System.Windows.Forms.Label lblTenTyGia;
        private System.Windows.Forms.Label lblMaTyGia;
        private DevExpress.XtraEditors.SimpleButton spbtnDong;
        private DevExpress.XtraEditors.SimpleButton spbtnLuu;
        private DevExpress.XtraEditors.CalcEdit calTyGiaQuyDoi;
    }
}