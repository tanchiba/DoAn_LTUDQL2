namespace QuanLyBanHang
{
    partial class frmPhucHoi
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
            this.btDuongdan = new System.Windows.Forms.Button();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.btThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.tbCSDL = new DevExpress.XtraEditors.TextEdit();
            this.tbTen = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbCSDL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btDuongdan
            // 
            this.btDuongdan.Image = global::QuanLyBanHang.Properties.Resources.Folder_icon;
            this.btDuongdan.Location = new System.Drawing.Point(423, 33);
            this.btDuongdan.Name = "btDuongdan";
            this.btDuongdan.Size = new System.Drawing.Size(39, 37);
            this.btDuongdan.TabIndex = 24;
            this.btDuongdan.UseVisualStyleBackColor = true;
            this.btDuongdan.Click += new System.EventHandler(this.btDuongdan_Click);
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(387, 119);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(75, 23);
            this.btDong.TabIndex = 23;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btThucHien
            // 
            this.btThucHien.Location = new System.Drawing.Point(285, 119);
            this.btThucHien.Name = "btThucHien";
            this.btThucHien.Size = new System.Drawing.Size(75, 23);
            this.btThucHien.TabIndex = 22;
            this.btThucHien.Text = "Thực Hiện";
            this.btThucHien.Click += new System.EventHandler(this.btThucHien_Click);
            // 
            // tbCSDL
            // 
            this.tbCSDL.Location = new System.Drawing.Point(103, 86);
            this.tbCSDL.Name = "tbCSDL";
            this.tbCSDL.Size = new System.Drawing.Size(359, 20);
            this.tbCSDL.TabIndex = 21;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(103, 42);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(359, 20);
            this.tbTen.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cơ sở dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên tập tin";
            // 
            // frmPhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 157);
            this.Controls.Add(this.btDuongdan);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btThucHien);
            this.Controls.Add(this.tbCSDL);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPhucHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phục hồi dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.tbCSDL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDuongdan;
        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.SimpleButton btThucHien;
        private DevExpress.XtraEditors.TextEdit tbCSDL;
        private DevExpress.XtraEditors.TextEdit tbTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}