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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTen = new DevExpress.XtraEditors.TextEdit();
            this.tbDuongDan = new DevExpress.XtraEditors.TextEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.btThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btDuongdan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(85, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sao lưu dự phòng dữ liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên tập tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đường dẫn";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(76, 151);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(361, 20);
            this.tbTen.TabIndex = 12;
            // 
            // tbDuongDan
            // 
            this.tbDuongDan.Location = new System.Drawing.Point(75, 205);
            this.tbDuongDan.Name = "tbDuongDan";
            this.tbDuongDan.Size = new System.Drawing.Size(351, 20);
            this.tbDuongDan.TabIndex = 13;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(76, 262);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Ghi đè tập tin cũ";
            this.checkEdit1.Size = new System.Drawing.Size(106, 19);
            this.checkEdit1.TabIndex = 15;
            // 
            // btThucHien
            // 
            this.btThucHien.Location = new System.Drawing.Point(263, 258);
            this.btThucHien.Name = "btThucHien";
            this.btThucHien.Size = new System.Drawing.Size(82, 23);
            this.btThucHien.TabIndex = 16;
            this.btThucHien.Text = "Thực Hiện";
            this.btThucHien.Click += new System.EventHandler(this.btThucHien_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(362, 258);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "Đóng";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btDuongdan
            // 
            this.btDuongdan.Image = global::QuanLyBanHang.Properties.Resources.Folder_icon;
            this.btDuongdan.Location = new System.Drawing.Point(396, 198);
            this.btDuongdan.Name = "btDuongdan";
            this.btDuongdan.Size = new System.Drawing.Size(41, 33);
            this.btDuongdan.TabIndex = 18;
            this.btDuongdan.UseVisualStyleBackColor = true;
            this.btDuongdan.Click += new System.EventHandler(this.btDuongdan_Click);
            // 
            // frmSaoLuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(472, 303);
            this.Controls.Add(this.btDuongdan);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btThucHien);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.tbDuongDan);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmSaoLuu";
            this.Text = "Sao lưu dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.TextEdit tbDuongDan;
        private DevExpress.XtraEditors.TextEdit tbTen;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btThucHien;
        private System.Windows.Forms.Button btDuongdan;
    }
}