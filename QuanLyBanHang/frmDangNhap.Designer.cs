namespace QuanLyBanHang
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblThongBaoLoi = new System.Windows.Forms.Label();
            this.cbNhomatKhau = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuenTaiKhoan = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(252, 187);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(87, 34);
            this.btnDangNhap.TabIndex = 15;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // lblThongBaoLoi
            // 
            this.lblThongBaoLoi.AutoSize = true;
            this.lblThongBaoLoi.BackColor = System.Drawing.Color.Transparent;
            this.lblThongBaoLoi.ForeColor = System.Drawing.Color.White;
            this.lblThongBaoLoi.Location = new System.Drawing.Point(71, 151);
            this.lblThongBaoLoi.Name = "lblThongBaoLoi";
            this.lblThongBaoLoi.Size = new System.Drawing.Size(78, 13);
            this.lblThongBaoLoi.TabIndex = 14;
            this.lblThongBaoLoi.Text = "lblThongBaoLoi";
            // 
            // cbNhomatKhau
            // 
            this.cbNhomatKhau.AutoSize = true;
            this.cbNhomatKhau.BackColor = System.Drawing.Color.Transparent;
            this.cbNhomatKhau.ForeColor = System.Drawing.Color.White;
            this.cbNhomatKhau.Location = new System.Drawing.Point(71, 172);
            this.cbNhomatKhau.Name = "cbNhomatKhau";
            this.cbNhomatKhau.Size = new System.Drawing.Size(92, 17);
            this.cbNhomatKhau.TabIndex = 13;
            this.cbNhomatKhau.Text = "Nhớ mật khẩu";
            this.cbNhomatKhau.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "ĐĂNG NHẬP";
            // 
            // lblQuenTaiKhoan
            // 
            this.lblQuenTaiKhoan.AutoSize = true;
            this.lblQuenTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblQuenTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.lblQuenTaiKhoan.Location = new System.Drawing.Point(174, 173);
            this.lblQuenTaiKhoan.Name = "lblQuenTaiKhoan";
            this.lblQuenTaiKhoan.Size = new System.Drawing.Size(85, 13);
            this.lblQuenTaiKhoan.TabIndex = 11;
            this.lblQuenTaiKhoan.Text = "Quên tài khoản?";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(71, 73);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(268, 26);
            this.txtTenDangNhap.TabIndex = 9;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(71, 110);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.Size = new System.Drawing.Size(268, 26);
            this.txtMatKhau.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(394, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(419, 237);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lblThongBaoLoi);
            this.Controls.Add(this.cbNhomatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQuenTaiKhoan);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblThongBaoLoi;
        private System.Windows.Forms.CheckBox cbNhomatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuenTaiKhoan;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnClose;
    }
}