namespace QuanLyBanHang
{
    partial class frmThemKhuVuc
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.checkBox1);
            this.groupControl1.Controls.Add(this.tbGhiChu);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.tbTen);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.tbMa);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(358, 153);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(80, 111);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Còn Quản Lý";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(80, 84);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(252, 21);
            this.tbGhiChu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ghi Chú";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(80, 58);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(252, 21);
            this.tbTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(40, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(80, 34);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(252, 21);
            this.tbMa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(210, 178);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(291, 178);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmThemKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 213);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupControl1);
            this.HtmlText = "Thêm Khu Vực";
            this.Name = "frmThemKhuVuc";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMa;
    }
}