namespace QuanLyBanHang
{
    partial class frmThemTienTe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemTienTe));
            this.grcThongTin = new DevExpress.XtraEditors.GroupControl();
            this.checkBConQuanLy = new System.Windows.Forms.CheckBox();
            this.lblTyGiaQuyDoi = new System.Windows.Forms.Label();
            this.lblTenTienTe = new System.Windows.Forms.Label();
            this.lblMaTienTe = new System.Windows.Forms.Label();
            this.btnLuuTienTe = new System.Windows.Forms.Button();
            this.btnDongTienTe = new System.Windows.Forms.Button();
            this.txtMaTienTe = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTienTe = new DevExpress.XtraEditors.TextEdit();
            this.cmbTyGiaQuyDoi = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grcThongTin)).BeginInit();
            this.grcThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTienTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTienTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTyGiaQuyDoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcThongTin
            // 
            this.grcThongTin.Controls.Add(this.cmbTyGiaQuyDoi);
            this.grcThongTin.Controls.Add(this.txtTenTienTe);
            this.grcThongTin.Controls.Add(this.txtMaTienTe);
            this.grcThongTin.Controls.Add(this.checkBConQuanLy);
            this.grcThongTin.Controls.Add(this.lblTyGiaQuyDoi);
            this.grcThongTin.Controls.Add(this.lblTenTienTe);
            this.grcThongTin.Controls.Add(this.lblMaTienTe);
            this.grcThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grcThongTin.Location = new System.Drawing.Point(0, 0);
            this.grcThongTin.Name = "grcThongTin";
            this.grcThongTin.Size = new System.Drawing.Size(446, 217);
            this.grcThongTin.TabIndex = 1;
            this.grcThongTin.Text = "Thông tin";
            // 
            // checkBConQuanLy
            // 
            this.checkBConQuanLy.AutoSize = true;
            this.checkBConQuanLy.Location = new System.Drawing.Point(137, 181);
            this.checkBConQuanLy.Name = "checkBConQuanLy";
            this.checkBConQuanLy.Size = new System.Drawing.Size(104, 21);
            this.checkBConQuanLy.TabIndex = 6;
            this.checkBConQuanLy.Text = "Còn quản lý";
            this.checkBConQuanLy.UseVisualStyleBackColor = true;
            // 
            // lblTyGiaQuyDoi
            // 
            this.lblTyGiaQuyDoi.AutoSize = true;
            this.lblTyGiaQuyDoi.Location = new System.Drawing.Point(13, 133);
            this.lblTyGiaQuyDoi.Name = "lblTyGiaQuyDoi";
            this.lblTyGiaQuyDoi.Size = new System.Drawing.Size(95, 17);
            this.lblTyGiaQuyDoi.TabIndex = 2;
            this.lblTyGiaQuyDoi.Text = "Tỷ giá quy đổi";
            // 
            // lblTenTienTe
            // 
            this.lblTenTienTe.AutoSize = true;
            this.lblTenTienTe.Location = new System.Drawing.Point(16, 84);
            this.lblTenTienTe.Name = "lblTenTienTe";
            this.lblTenTienTe.Size = new System.Drawing.Size(31, 17);
            this.lblTenTienTe.TabIndex = 1;
            this.lblTenTienTe.Text = "Tên";
            // 
            // lblMaTienTe
            // 
            this.lblMaTienTe.AutoSize = true;
            this.lblMaTienTe.Location = new System.Drawing.Point(13, 40);
            this.lblMaTienTe.Name = "lblMaTienTe";
            this.lblMaTienTe.Size = new System.Drawing.Size(25, 17);
            this.lblMaTienTe.TabIndex = 0;
            this.lblMaTienTe.Text = "Mã";
            // 
            // btnLuuTienTe
            // 
            this.btnLuuTienTe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuuTienTe.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuTienTe.Image")));
            this.btnLuuTienTe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuuTienTe.Location = new System.Drawing.Point(19, 247);
            this.btnLuuTienTe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuuTienTe.Name = "btnLuuTienTe";
            this.btnLuuTienTe.Size = new System.Drawing.Size(136, 56);
            this.btnLuuTienTe.TabIndex = 4;
            this.btnLuuTienTe.Text = "Lưu";
            this.btnLuuTienTe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuuTienTe.UseVisualStyleBackColor = true;
            // 
            // btnDongTienTe
            // 
            this.btnDongTienTe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDongTienTe.Image = ((System.Drawing.Image)(resources.GetObject("btnDongTienTe.Image")));
            this.btnDongTienTe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDongTienTe.Location = new System.Drawing.Point(188, 243);
            this.btnDongTienTe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDongTienTe.Name = "btnDongTienTe";
            this.btnDongTienTe.Size = new System.Drawing.Size(143, 60);
            this.btnDongTienTe.TabIndex = 5;
            this.btnDongTienTe.Text = "Đóng";
            this.btnDongTienTe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDongTienTe.UseVisualStyleBackColor = true;
            // 
            // txtMaTienTe
            // 
            this.txtMaTienTe.Location = new System.Drawing.Point(137, 37);
            this.txtMaTienTe.Name = "txtMaTienTe";
            this.txtMaTienTe.Size = new System.Drawing.Size(256, 22);
            this.txtMaTienTe.TabIndex = 7;
            // 
            // txtTenTienTe
            // 
            this.txtTenTienTe.Location = new System.Drawing.Point(137, 81);
            this.txtTenTienTe.Name = "txtTenTienTe";
            this.txtTenTienTe.Size = new System.Drawing.Size(256, 22);
            this.txtTenTienTe.TabIndex = 8;
            // 
            // cmbTyGiaQuyDoi
            // 
            this.cmbTyGiaQuyDoi.Location = new System.Drawing.Point(137, 128);
            this.cmbTyGiaQuyDoi.Name = "cmbTyGiaQuyDoi";
            this.cmbTyGiaQuyDoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTyGiaQuyDoi.Size = new System.Drawing.Size(256, 22);
            this.cmbTyGiaQuyDoi.TabIndex = 9;
            // 
            // frmThemTienTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 354);
            this.Controls.Add(this.btnDongTienTe);
            this.Controls.Add(this.btnLuuTienTe);
            this.Controls.Add(this.grcThongTin);
            this.Name = "frmThemTienTe";
            this.Text = "Thêm Tiền Tệ";
            ((System.ComponentModel.ISupportInitialize)(this.grcThongTin)).EndInit();
            this.grcThongTin.ResumeLayout(false);
            this.grcThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTienTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTienTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTyGiaQuyDoi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grcThongTin;
        private System.Windows.Forms.CheckBox checkBConQuanLy;
        private System.Windows.Forms.Label lblTyGiaQuyDoi;
        private System.Windows.Forms.Label lblTenTienTe;
        private System.Windows.Forms.Label lblMaTienTe;
        private System.Windows.Forms.Button btnLuuTienTe;
        private System.Windows.Forms.Button btnDongTienTe;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTyGiaQuyDoi;
        private DevExpress.XtraEditors.TextEdit txtTenTienTe;
        private DevExpress.XtraEditors.TextEdit txtMaTienTe;
    }
}