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
            this.grbThongTin = new DevExpress.XtraEditors.GroupControl();
            this.cbConQuanLy = new System.Windows.Forms.CheckBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblProduct_Group_Name = new System.Windows.Forms.Label();
            this.lblMaNhomHangHoa = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtNhomHangHoa = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grbThongTin)).BeginInit();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhomHangHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txtGhiChu);
            this.grbThongTin.Controls.Add(this.txtTen);
            this.grbThongTin.Controls.Add(this.txtNhomHangHoa);
            this.grbThongTin.Controls.Add(this.cbConQuanLy);
            this.grbThongTin.Controls.Add(this.lblGhiChu);
            this.grbThongTin.Controls.Add(this.lblProduct_Group_Name);
            this.grbThongTin.Controls.Add(this.lblMaNhomHangHoa);
            this.grbThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThongTin.Location = new System.Drawing.Point(0, 0);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(529, 269);
            this.grbThongTin.TabIndex = 1;
            this.grbThongTin.Text = "Thông tin";
            // 
            // cbConQuanLy
            // 
            this.cbConQuanLy.AutoSize = true;
            this.cbConQuanLy.Location = new System.Drawing.Point(179, 219);
            this.cbConQuanLy.Name = "cbConQuanLy";
            this.cbConQuanLy.Size = new System.Drawing.Size(104, 21);
            this.cbConQuanLy.TabIndex = 6;
            this.cbConQuanLy.Text = "Còn quản lý";
            this.cbConQuanLy.UseVisualStyleBackColor = true;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(16, 163);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(54, 17);
            this.lblGhiChu.TabIndex = 3;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // lblProduct_Group_Name
            // 
            this.lblProduct_Group_Name.AutoSize = true;
            this.lblProduct_Group_Name.Location = new System.Drawing.Point(16, 101);
            this.lblProduct_Group_Name.Name = "lblProduct_Group_Name";
            this.lblProduct_Group_Name.Size = new System.Drawing.Size(31, 17);
            this.lblProduct_Group_Name.TabIndex = 2;
            this.lblProduct_Group_Name.Text = "Tên";
            // 
            // lblMaNhomHangHoa
            // 
            this.lblMaNhomHangHoa.AutoSize = true;
            this.lblMaNhomHangHoa.Location = new System.Drawing.Point(13, 43);
            this.lblMaNhomHangHoa.Name = "lblMaNhomHangHoa";
            this.lblMaNhomHangHoa.Size = new System.Drawing.Size(25, 17);
            this.lblMaNhomHangHoa.TabIndex = 1;
            this.lblMaNhomHangHoa.Text = "Mã";
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(50, 294);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(155, 60);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDong.Location = new System.Drawing.Point(266, 294);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(166, 60);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // txtNhomHangHoa
            // 
            this.txtNhomHangHoa.Location = new System.Drawing.Point(179, 28);
            this.txtNhomHangHoa.Name = "txtNhomHangHoa";
            this.txtNhomHangHoa.Size = new System.Drawing.Size(269, 22);
            this.txtNhomHangHoa.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(179, 98);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(269, 22);
            this.txtTen.TabIndex = 8;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(179, 160);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(269, 22);
            this.txtGhiChu.TabIndex = 9;
            // 
            // frmThemNhomHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 378);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grbThongTin);
            this.Name = "frmThemNhomHangHoa";
            this.Text = "Thêm Nhóm Hàng Hóa";
            ((System.ComponentModel.ISupportInitialize)(this.grbThongTin)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhomHangHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grbThongTin;
        private System.Windows.Forms.CheckBox cbConQuanLy;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblProduct_Group_Name;
        private System.Windows.Forms.Label lblMaNhomHangHoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtNhomHangHoa;
    }
}