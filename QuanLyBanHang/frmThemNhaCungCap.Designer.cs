namespace QuanLyBanHang
{
    partial class frmThemNhaCungCap
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
            this.glkKhuVuc = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.tbTenNhaCungCap = new DevExpress.XtraEditors.TextEdit();
            this.tbEmail = new DevExpress.XtraEditors.TextEdit();
            this.tbDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.tbDes = new DevExpress.XtraEditors.TextEdit();
            this.tbMaNhaCungCap = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btKhuvuc = new DevExpress.XtraEditors.SimpleButton();
            this.Customer_Group_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Customer_Group_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbConQuanLy = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glkKhuVuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenNhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaNhaCungCap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.glkKhuVuc);
            this.groupControl1.Controls.Add(this.btKhuvuc);
            this.groupControl1.Controls.Add(this.tbDiaChi);
            this.groupControl1.Controls.Add(this.tbTenNhaCungCap);
            this.groupControl1.Controls.Add(this.tbEmail);
            this.groupControl1.Controls.Add(this.tbDienThoai);
            this.groupControl1.Controls.Add(this.tbDes);
            this.groupControl1.Controls.Add(this.tbMaNhaCungCap);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(514, 239);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông Tin Chung";
            // 
            // glkKhuVuc
            // 
            this.glkKhuVuc.EditValue = "Null";
            this.glkKhuVuc.Location = new System.Drawing.Point(78, 204);
            this.glkKhuVuc.Name = "glkKhuVuc";
            this.glkKhuVuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glkKhuVuc.Properties.DisplayMember = "Customer_Group_ID";
            this.glkKhuVuc.Properties.ValueMember = "Customer_Group_ID";
            this.glkKhuVuc.Properties.View = this.gridLookUpEdit1View;
            this.glkKhuVuc.Size = new System.Drawing.Size(384, 20);
            this.glkKhuVuc.TabIndex = 6;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Customer_Group_ID,
            this.Customer_Group_Name});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(78, 81);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(423, 20);
            this.tbDiaChi.TabIndex = 2;
            // 
            // tbTenNhaCungCap
            // 
            this.tbTenNhaCungCap.Location = new System.Drawing.Point(78, 53);
            this.tbTenNhaCungCap.Name = "tbTenNhaCungCap";
            this.tbTenNhaCungCap.Size = new System.Drawing.Size(423, 20);
            this.tbTenNhaCungCap.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(78, 110);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(423, 20);
            this.tbEmail.TabIndex = 2;
            // 
            // tbDienThoai
            // 
            this.tbDienThoai.Location = new System.Drawing.Point(78, 172);
            this.tbDienThoai.Name = "tbDienThoai";
            this.tbDienThoai.Size = new System.Drawing.Size(423, 20);
            this.tbDienThoai.TabIndex = 2;
            // 
            // tbDes
            // 
            this.tbDes.Location = new System.Drawing.Point(78, 140);
            this.tbDes.Name = "tbDes";
            this.tbDes.Size = new System.Drawing.Size(423, 20);
            this.tbDes.TabIndex = 2;
            // 
            // tbMaNhaCungCap
            // 
            this.tbMaNhaCungCap.Location = new System.Drawing.Point(78, 27);
            this.tbMaNhaCungCap.Name = "tbMaNhaCungCap";
            this.tbMaNhaCungCap.Size = new System.Drawing.Size(423, 20);
            this.tbMaNhaCungCap.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Khu vực";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thông Tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã (*)";
            // 
            // btDong
            // 
            this.btDong.ImageOptions.Image = global::QuanLyBanHang.Properties.Resources.Sign_Delete_icon__1_;
            this.btDong.Location = new System.Drawing.Point(426, 245);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(75, 23);
            this.btDong.TabIndex = 10;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btLuu
            // 
            this.btLuu.ImageOptions.Image = global::QuanLyBanHang.Properties.Resources.Actions_document_save_icon;
            this.btLuu.Location = new System.Drawing.Point(345, 245);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 9;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btKhuvuc
            // 
            this.btKhuvuc.ImageOptions.Image = global::QuanLyBanHang.Properties.Resources.Button_Add_icon__1_;
            this.btKhuvuc.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btKhuvuc.Location = new System.Drawing.Point(468, 205);
            this.btKhuvuc.Name = "btKhuvuc";
            this.btKhuvuc.Size = new System.Drawing.Size(33, 18);
            this.btKhuvuc.TabIndex = 5;
            this.btKhuvuc.Click += new System.EventHandler(this.btKhuvuc_Click);
            // 
            // Customer_Group_ID
            // 
            this.Customer_Group_ID.Caption = "Mã";
            this.Customer_Group_ID.FieldName = "Customer_Group_ID";
            this.Customer_Group_ID.Name = "Customer_Group_ID";
            this.Customer_Group_ID.Visible = true;
            this.Customer_Group_ID.VisibleIndex = 0;
            // 
            // Customer_Group_Name
            // 
            this.Customer_Group_Name.Caption = "Tên Khu Vực";
            this.Customer_Group_Name.FieldName = "Customer_Group_Name";
            this.Customer_Group_Name.Name = "Customer_Group_Name";
            this.Customer_Group_Name.Visible = true;
            this.Customer_Group_Name.VisibleIndex = 1;
            // 
            // cbConQuanLy
            // 
            this.cbConQuanLy.AutoSize = true;
            this.cbConQuanLy.Location = new System.Drawing.Point(78, 254);
            this.cbConQuanLy.Name = "cbConQuanLy";
            this.cbConQuanLy.Size = new System.Drawing.Size(88, 17);
            this.cbConQuanLy.TabIndex = 11;
            this.cbConQuanLy.Text = "Còn Quản Lý";
            this.cbConQuanLy.UseVisualStyleBackColor = true;
            // 
            // frmThemNhaCungCap
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 283);
            this.Controls.Add(this.cbConQuanLy);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmThemNhaCungCap";
            this.Text = "Thêm Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.frmThemNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glkKhuVuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenNhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaNhaCungCap.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GridLookUpEdit glkKhuVuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btKhuvuc;
        private DevExpress.XtraEditors.TextEdit tbDiaChi;
        private DevExpress.XtraEditors.TextEdit tbTenNhaCungCap;
        private DevExpress.XtraEditors.TextEdit tbEmail;
        private DevExpress.XtraEditors.TextEdit tbDienThoai;
        private DevExpress.XtraEditors.TextEdit tbDes;
        private DevExpress.XtraEditors.TextEdit tbMaNhaCungCap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraGrid.Columns.GridColumn Customer_Group_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Customer_Group_Name;
        private System.Windows.Forms.CheckBox cbConQuanLy;
    }
}