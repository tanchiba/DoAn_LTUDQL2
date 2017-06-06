namespace QuanLyBanHang
{
    partial class frmSuaHangHoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.glKhoMacDinh = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.calcEdit1 = new DevExpress.XtraEditors.CalcEdit();
            this.gllPhanLoai = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.glDonVi = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTenHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMaHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.glToiThieu = new DevExpress.XtraEditors.CalcEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.glGiaBanLe = new DevExpress.XtraEditors.CalcEdit();
            this.glGiaSi = new DevExpress.XtraEditors.CalcEdit();
            this.glGiaMua = new DevExpress.XtraEditors.CalcEdit();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.glGiaBanSi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.glNCC = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.cbbHangHoa = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.glKhoMacDinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gllPhanLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glToiThieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glGiaBanLe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glGiaSi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glGiaMua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Hàng Hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kho Mặc Định";
            // 
            // glKhoMacDinh
            // 
            this.glKhoMacDinh.EditValue = "";
            this.glKhoMacDinh.Location = new System.Drawing.Point(380, 23);
            this.glKhoMacDinh.Name = "glKhoMacDinh";
            this.glKhoMacDinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glKhoMacDinh.Properties.NullText = "";
            this.glKhoMacDinh.Properties.View = this.gridLookUpEdit1View;
            this.glKhoMacDinh.Size = new System.Drawing.Size(266, 20);
            this.glKhoMacDinh.TabIndex = 3;
            this.glKhoMacDinh.EditValueChanged += new System.EventHandler(this.glKhoMacDinh_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên Kho";
            this.gridColumn1.FieldName = "StockName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã Kho";
            this.gridColumn2.FieldName = "Stock_ID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.calcEdit1);
            this.groupControl1.Controls.Add(this.gllPhanLoai);
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.glDonVi);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.tbTenHang);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.tbMaHang);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.glToiThieu);
            this.groupControl1.Location = new System.Drawing.Point(3, 49);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(654, 282);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông Tin Chung";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // calcEdit1
            // 
            this.calcEdit1.Enabled = false;
            this.calcEdit1.Location = new System.Drawing.Point(107, 195);
            this.calcEdit1.Name = "calcEdit1";
            this.calcEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.calcEdit1.Properties.NullText = "0";
            this.calcEdit1.Size = new System.Drawing.Size(186, 20);
            this.calcEdit1.TabIndex = 21;
            // 
            // gllPhanLoai
            // 
            this.gllPhanLoai.Location = new System.Drawing.Point(91, 29);
            this.gllPhanLoai.Name = "gllPhanLoai";
            this.gllPhanLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gllPhanLoai.Properties.NullText = "";
            this.gllPhanLoai.Properties.View = this.gridView1;
            this.gllPhanLoai.Size = new System.Drawing.Size(547, 20);
            this.gllPhanLoai.TabIndex = 20;
            this.gllPhanLoai.EditValueChanged += new System.EventHandler(this.gllPhanLoai_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Loại Hàng";
            this.gridColumn3.FieldName = "Product_Group_Name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID";
            this.gridColumn4.FieldName = "Product_Group_ID";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(299, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadHìnhToolStripMenuItem,
            this.xóaHìnhToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // loadHìnhToolStripMenuItem
            // 
            this.loadHìnhToolStripMenuItem.Name = "loadHìnhToolStripMenuItem";
            this.loadHìnhToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.loadHìnhToolStripMenuItem.Text = "Load Hình";
            this.loadHìnhToolStripMenuItem.Click += new System.EventHandler(this.loadHìnhToolStripMenuItem_Click);
            // 
            // xóaHìnhToolStripMenuItem
            // 
            this.xóaHìnhToolStripMenuItem.Name = "xóaHìnhToolStripMenuItem";
            this.xóaHìnhToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xóaHìnhToolStripMenuItem.Text = "Xóa Hình";
            this.xóaHìnhToolStripMenuItem.Click += new System.EventHandler(this.xóaHìnhToolStripMenuItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tồn Kho Hiện Tại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tồn Kho Tối Thiểu";
            // 
            // glDonVi
            // 
            this.glDonVi.Location = new System.Drawing.Point(91, 130);
            this.glDonVi.Name = "glDonVi";
            this.glDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glDonVi.Properties.NullText = "";
            this.glDonVi.Properties.View = this.gridView2;
            this.glDonVi.Size = new System.Drawing.Size(202, 20);
            this.glDonVi.TabIndex = 12;
            this.glDonVi.EditValueChanged += new System.EventHandler(this.glDonVi_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Đơn Vị";
            this.gridColumn5.FieldName = "UnitName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mã Đơn Vị";
            this.gridColumn6.FieldName = "Unit_ID";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Đơn vị";
            // 
            // tbTenHang
            // 
            this.tbTenHang.Location = new System.Drawing.Point(91, 91);
            this.tbTenHang.Name = "tbTenHang";
            this.tbTenHang.Size = new System.Drawing.Size(547, 21);
            this.tbTenHang.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên Hàng";
            // 
            // tbMaHang
            // 
            this.tbMaHang.Location = new System.Drawing.Point(91, 64);
            this.tbMaHang.Name = "tbMaHang";
            this.tbMaHang.Size = new System.Drawing.Size(547, 21);
            this.tbMaHang.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phân Loại";
            // 
            // glToiThieu
            // 
            this.glToiThieu.Location = new System.Drawing.Point(107, 156);
            this.glToiThieu.Name = "glToiThieu";
            this.glToiThieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glToiThieu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.glToiThieu.Properties.NullText = "0";
            this.glToiThieu.Size = new System.Drawing.Size(186, 20);
            this.glToiThieu.TabIndex = 16;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.glGiaBanLe);
            this.groupControl2.Controls.Add(this.glGiaSi);
            this.groupControl2.Controls.Add(this.glGiaMua);
            this.groupControl2.Controls.Add(this.cbActive);
            this.groupControl2.Controls.Add(this.glGiaBanSi);
            this.groupControl2.Controls.Add(this.label13);
            this.groupControl2.Controls.Add(this.label12);
            this.groupControl2.Controls.Add(this.glNCC);
            this.groupControl2.Controls.Add(this.label11);
            this.groupControl2.Location = new System.Drawing.Point(3, 338);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(643, 113);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Thông Tin Giao Dịch";
            // 
            // glGiaBanLe
            // 
            this.glGiaBanLe.Location = new System.Drawing.Point(377, 51);
            this.glGiaBanLe.Name = "glGiaBanLe";
            this.glGiaBanLe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glGiaBanLe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.glGiaBanLe.Properties.NullText = "0";
            this.glGiaBanLe.Size = new System.Drawing.Size(186, 20);
            this.glGiaBanLe.TabIndex = 22;
            // 
            // glGiaSi
            // 
            this.glGiaSi.Location = new System.Drawing.Point(91, 77);
            this.glGiaSi.Name = "glGiaSi";
            this.glGiaSi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glGiaSi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.glGiaSi.Properties.NullText = "0";
            this.glGiaSi.Size = new System.Drawing.Size(186, 20);
            this.glGiaSi.TabIndex = 21;
            // 
            // glGiaMua
            // 
            this.glGiaMua.Location = new System.Drawing.Point(91, 51);
            this.glGiaMua.Name = "glGiaMua";
            this.glGiaMua.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glGiaMua.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.glGiaMua.Properties.NullText = "0";
            this.glGiaMua.Size = new System.Drawing.Size(186, 20);
            this.glGiaMua.TabIndex = 20;
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(318, 80);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(88, 17);
            this.cbActive.TabIndex = 19;
            this.cbActive.Text = "Còn Quản Lý";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // glGiaBanSi
            // 
            this.glGiaBanSi.AutoSize = true;
            this.glGiaBanSi.Location = new System.Drawing.Point(9, 80);
            this.glGiaBanSi.Name = "glGiaBanSi";
            this.glGiaBanSi.Size = new System.Drawing.Size(54, 13);
            this.glGiaBanSi.TabIndex = 17;
            this.glGiaBanSi.Text = "Giá Bán Sỉ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(315, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Giá Bán Lẻ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Giá Mua";
            // 
            // glNCC
            // 
            this.glNCC.Location = new System.Drawing.Point(91, 23);
            this.glNCC.Name = "glNCC";
            this.glNCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glNCC.Properties.NullText = "";
            this.glNCC.Properties.View = this.gridView5;
            this.glNCC.Size = new System.Drawing.Size(547, 20);
            this.glNCC.TabIndex = 6;
            this.glNCC.EditValueChanged += new System.EventHandler(this.glNCC_EditValueChanged);
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Nhà Cung Cấp";
            this.gridColumn7.FieldName = "ProviderName";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Mã NCC";
            this.gridColumn8.FieldName = "Provider_ID";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Nhà Cung Cấp";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(466, 457);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(547, 457);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cbbHangHoa
            // 
            this.cbbHangHoa.FormattingEnabled = true;
            this.cbbHangHoa.Location = new System.Drawing.Point(94, 21);
            this.cbbHangHoa.Name = "cbbHangHoa";
            this.cbbHangHoa.Size = new System.Drawing.Size(202, 21);
            this.cbbHangHoa.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmSuaHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 484);
            this.Controls.Add(this.cbbHangHoa);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.glKhoMacDinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HtmlText = "Thêm Hàng Hóa, Dịch Vụ";
            this.Name = "frmSuaHangHoa";
            this.Load += new System.EventHandler(this.frmThemHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glKhoMacDinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gllPhanLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.glDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glToiThieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glGiaBanLe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glGiaSi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glGiaMua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.GridLookUpEdit glKhoMacDinh;
        public DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        public DevExpress.XtraEditors.GroupControl groupControl1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public DevExpress.XtraEditors.GridLookUpEdit glDonVi;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbTenHang;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbMaHang;
        public System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.GroupControl groupControl2;
        public System.Windows.Forms.CheckBox cbActive;
        public System.Windows.Forms.Label glGiaBanSi;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public DevExpress.XtraEditors.GridLookUpEdit glNCC;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button btnLuu;
        public System.Windows.Forms.Button btnDong;
        public System.Windows.Forms.ComboBox cbbHangHoa;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        public DevExpress.XtraEditors.GridLookUpEdit gllPhanLoai;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        public DevExpress.XtraEditors.CalcEdit glToiThieu;
        public DevExpress.XtraEditors.CalcEdit calcEdit1;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        public DevExpress.XtraEditors.CalcEdit glGiaBanLe;
        public DevExpress.XtraEditors.CalcEdit glGiaSi;
        public DevExpress.XtraEditors.CalcEdit glGiaMua;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem loadHìnhToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem xóaHìnhToolStripMenuItem;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}