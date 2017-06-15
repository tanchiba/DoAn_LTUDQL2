namespace QuanLyBanHang
{
    partial class frmSaoLuu
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.tbTen = new DevExpress.XtraEditors.TextEdit();
            this.tbDuongDan = new DevExpress.XtraEditors.TextEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.spbtnThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.spbtnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btDuongdan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDuongDan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(88, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sao lưu dự phòng dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiến trình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên tập tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đường dẫn";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(79, 71);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Appearance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.progressBarControl1.Size = new System.Drawing.Size(362, 22);
            this.progressBarControl1.TabIndex = 11;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(79, 113);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(361, 20);
            this.tbTen.TabIndex = 12;
            // 
            // tbDuongDan
            // 
            this.tbDuongDan.Location = new System.Drawing.Point(78, 158);
            this.tbDuongDan.Name = "tbDuongDan";
            this.tbDuongDan.Size = new System.Drawing.Size(351, 20);
            this.tbDuongDan.TabIndex = 13;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(79, 201);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Ghi đè tập tin cũ";
            this.checkEdit1.Size = new System.Drawing.Size(106, 19);
            this.checkEdit1.TabIndex = 15;
            // 
            // spbtnThucHien
            // 
            this.spbtnThucHien.Location = new System.Drawing.Point(267, 199);
            this.spbtnThucHien.Name = "spbtnThucHien";
            this.spbtnThucHien.Size = new System.Drawing.Size(82, 23);
            this.spbtnThucHien.TabIndex = 16;
            this.spbtnThucHien.Text = "Thực Hiện";
            this.spbtnThucHien.Click += new System.EventHandler(this.spbtnThucHien_Click);
            // 
            // spbtnDong
            // 
            this.spbtnDong.Location = new System.Drawing.Point(366, 199);
            this.spbtnDong.Name = "spbtnDong";
            this.spbtnDong.Size = new System.Drawing.Size(75, 23);
            this.spbtnDong.TabIndex = 17;
            this.spbtnDong.Text = "Đóng";
            this.spbtnDong.Click += new System.EventHandler(this.spbtnDong_Click);
            // 
            // btDuongdan
            // 
            this.btDuongdan.Image = global::QuanLyBanHang.Properties.Resources.Folder_icon;
            this.btDuongdan.Location = new System.Drawing.Point(400, 151);
            this.btDuongdan.Name = "btDuongdan";
            this.btDuongdan.Size = new System.Drawing.Size(41, 33);
            this.btDuongdan.TabIndex = 19;
            this.btDuongdan.UseVisualStyleBackColor = true;
            this.btDuongdan.Click += new System.EventHandler(this.btDuongdan_Click);
            // 
            // frmSaoLuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(472, 234);
            this.Controls.Add(this.btDuongdan);
            this.Controls.Add(this.spbtnDong);
            this.Controls.Add(this.spbtnThucHien);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.tbDuongDan);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSaoLuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao lưu dữ liệu";
            this.Load += new System.EventHandler(this.frmSaoLuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDuongDan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.TextEdit tbDuongDan;
        private DevExpress.XtraEditors.TextEdit tbTen;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton spbtnDong;
        private DevExpress.XtraEditors.SimpleButton spbtnThucHien;
        private System.Windows.Forms.Button btDuongdan;
    }
}