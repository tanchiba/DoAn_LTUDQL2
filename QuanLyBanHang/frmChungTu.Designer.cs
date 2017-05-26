namespace QuanLyBanHang
{
    partial class frmChungTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChungTu));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.edtChungTuDen = new DevExpress.XtraEditors.TextEdit();
            this.edtChungTuTu = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnChungTuThoiGian = new System.Windows.Forms.RadioButton();
            this.rbtnChungTuTatCa = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnChungTuXem = new System.Windows.Forms.Button();
            this.grcChungTu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.stt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtChungTuDen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtChungTuTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.button5);
            this.panelControl1.Controls.Add(this.button4);
            this.panelControl1.Controls.Add(this.button3);
            this.panelControl1.Controls.Add(this.button2);
            this.panelControl1.Controls.Add(this.btnChungTuXem);
            this.panelControl1.Controls.Add(this.edtChungTuDen);
            this.panelControl1.Controls.Add(this.edtChungTuTu);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.rbtnChungTuThoiGian);
            this.panelControl1.Controls.Add(this.rbtnChungTuTatCa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(978, 43);
            this.panelControl1.TabIndex = 3;
            // 
            // edtChungTuDen
            // 
            this.edtChungTuDen.Location = new System.Drawing.Point(356, 10);
            this.edtChungTuDen.Name = "edtChungTuDen";
            this.edtChungTuDen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtChungTuDen.Properties.Appearance.Options.UseFont = true;
            this.edtChungTuDen.Size = new System.Drawing.Size(100, 22);
            this.edtChungTuDen.TabIndex = 2;
            // 
            // edtChungTuTu
            // 
            this.edtChungTuTu.Location = new System.Drawing.Point(202, 10);
            this.edtChungTuTu.Name = "edtChungTuTu";
            this.edtChungTuTu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtChungTuTu.Properties.Appearance.Options.UseFont = true;
            this.edtChungTuTu.Size = new System.Drawing.Size(100, 22);
            this.edtChungTuTu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ";
            // 
            // rbtnChungTuThoiGian
            // 
            this.rbtnChungTuThoiGian.AutoSize = true;
            this.rbtnChungTuThoiGian.Location = new System.Drawing.Point(81, 12);
            this.rbtnChungTuThoiGian.Name = "rbtnChungTuThoiGian";
            this.rbtnChungTuThoiGian.Size = new System.Drawing.Size(68, 17);
            this.rbtnChungTuThoiGian.TabIndex = 0;
            this.rbtnChungTuThoiGian.TabStop = true;
            this.rbtnChungTuThoiGian.Text = "Thời gian";
            this.rbtnChungTuThoiGian.UseVisualStyleBackColor = true;
            // 
            // rbtnChungTuTatCa
            // 
            this.rbtnChungTuTatCa.AutoSize = true;
            this.rbtnChungTuTatCa.Location = new System.Drawing.Point(6, 12);
            this.rbtnChungTuTatCa.Name = "rbtnChungTuTatCa";
            this.rbtnChungTuTatCa.Size = new System.Drawing.Size(55, 17);
            this.rbtnChungTuTatCa.TabIndex = 0;
            this.rbtnChungTuTatCa.TabStop = true;
            this.rbtnChungTuTatCa.Text = "Tất cả";
            this.rbtnChungTuTatCa.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(884, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 32);
            this.button5.TabIndex = 3;
            this.button5.Text = "Thoát";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(784, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 32);
            this.button4.TabIndex = 3;
            this.button4.Text = "Lưu";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(683, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Xuống dưới";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(583, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Lên trên";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnChungTuXem
            // 
            this.btnChungTuXem.Image = ((System.Drawing.Image)(resources.GetObject("btnChungTuXem.Image")));
            this.btnChungTuXem.Location = new System.Drawing.Point(484, 5);
            this.btnChungTuXem.Name = "btnChungTuXem";
            this.btnChungTuXem.Size = new System.Drawing.Size(89, 32);
            this.btnChungTuXem.TabIndex = 3;
            this.btnChungTuXem.Text = "Xem";
            this.btnChungTuXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChungTuXem.UseVisualStyleBackColor = true;
            // 
            // grcChungTu
            // 
            this.grcChungTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcChungTu.Location = new System.Drawing.Point(0, 43);
            this.grcChungTu.MainView = this.gridView1;
            this.grcChungTu.Name = "grcChungTu";
            this.grcChungTu.Size = new System.Drawing.Size(978, 443);
            this.grcChungTu.TabIndex = 7;
            this.grcChungTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.stt,
            this.ChungTu,
            this.Ngay,
            this.LoaiChungTu,
            this.ThanhTien,
            this.DienGiai});
            this.gridView1.GridControl = this.grcChungTu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // stt
            // 
            this.stt.Caption = "STT";
            this.stt.Name = "stt";
            this.stt.Visible = true;
            this.stt.VisibleIndex = 0;
            this.stt.Width = 37;
            // 
            // ChungTu
            // 
            this.ChungTu.Caption = "Chứng từ";
            this.ChungTu.Name = "ChungTu";
            this.ChungTu.Visible = true;
            this.ChungTu.VisibleIndex = 1;
            this.ChungTu.Width = 157;
            // 
            // Ngay
            // 
            this.Ngay.Caption = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.Visible = true;
            this.Ngay.VisibleIndex = 2;
            this.Ngay.Width = 100;
            // 
            // LoaiChungTu
            // 
            this.LoaiChungTu.Caption = "Loại chứng từ";
            this.LoaiChungTu.Name = "LoaiChungTu";
            this.LoaiChungTu.Visible = true;
            this.LoaiChungTu.VisibleIndex = 3;
            this.LoaiChungTu.Width = 133;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 4;
            this.ThanhTien.Width = 133;
            // 
            // DienGiai
            // 
            this.DienGiai.Caption = "Diễn giải";
            this.DienGiai.Name = "DienGiai";
            this.DienGiai.Visible = true;
            this.DienGiai.VisibleIndex = 5;
            this.DienGiai.Width = 202;
            // 
            // frmChungTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 486);
            this.Controls.Add(this.grcChungTu);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmChungTu";
            this.Text = "Chứng Từ";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtChungTuDen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtChungTuTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnChungTuXem;
        private DevExpress.XtraEditors.TextEdit edtChungTuDen;
        private DevExpress.XtraEditors.TextEdit edtChungTuTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnChungTuThoiGian;
        private System.Windows.Forms.RadioButton rbtnChungTuTatCa;
        private DevExpress.XtraGrid.GridControl grcChungTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn stt;
        private DevExpress.XtraGrid.Columns.GridColumn ChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn DienGiai;
    }
}