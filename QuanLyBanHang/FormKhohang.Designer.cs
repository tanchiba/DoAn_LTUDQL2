namespace QuanLyBanHang
{
    partial class FormKhoHang
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet = new QuanLyBanHang.QuanLyBanHangDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cUSTOMERTableAdapter = new QuanLyBanHang.QuanLyBanHangDataSetTableAdapters.CUSTOMERTableAdapter();
            //this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.sTOCKTableAdapter = new QuanLyBanHang.QuanLyBanHangDataSetTableAdapters.STOCKTableAdapter();
            this.colStock_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Controls.Add(this.gridSplitContainer1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(690, 134, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(750, 383);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.button7);
            this.panelControl1.Controls.Add(this.button6);
            this.panelControl1.Controls.Add(this.button5);
            this.panelControl1.Controls.Add(this.button3);
            this.panelControl1.Controls.Add(this.button4);
            this.panelControl1.Controls.Add(this.button2);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(726, 51);
            this.panelControl1.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.Image = global::QuanLyBanHang.Properties.Resources.MS_Office_2003_Excel_icon;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(308, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 49);
            this.button7.TabIndex = 7;
            this.button7.Text = "Nhập";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = global::QuanLyBanHang.Properties.Resources.Folders_OS_Exit_Full_Screen_Metro_icon;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(368, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 49);
            this.button6.TabIndex = 6;
            this.button6.Text = "Đóng";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::QuanLyBanHang.Properties.Resources.Export_To_File_icon;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(248, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "Xuất";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::QuanLyBanHang.Properties.Resources.Button_Refresh_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(188, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "Nạp lại";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::QuanLyBanHang.Properties.Resources.Actions_edit_delete_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(128, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "Xóa";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::QuanLyBanHang.Properties.Resources.hp_customization_control_panel_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(66, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sửa";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Image = global::QuanLyBanHang.Properties.Resources.add_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = this.gridControl1;
            this.gridSplitContainer1.Location = new System.Drawing.Point(12, 67);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Size = new System.Drawing.Size(726, 1);
            this.gridSplitContainer1.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sTOCKBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 72);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(726, 299);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // sTOCKBindingSource
            // 
            this.sTOCKBindingSource.DataMember = "STOCK";
            this.sTOCKBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // quanLyBanHangDataSet
            // 
            this.quanLyBanHangDataSet.DataSetName = "QuanLyBanHangDataSet";
            this.quanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStock_ID,
            this.colStockName,
            this.colStockAddress,
            this.colEmail,
            this.colTel,
            this.colDescription,
            this.colActive});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(750, 383);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridSplitContainer1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 55);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(730, 5);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panelControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(730, 55);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(730, 303);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // sTOCKTableAdapter
            // 
            this.sTOCKTableAdapter.ClearBeforeFill = true;
            // 
            // colStock_ID
            // 
            this.colStock_ID.FieldName = "Stock_ID";
            this.colStock_ID.Name = "colStock_ID";
            this.colStock_ID.Visible = true;
            this.colStock_ID.VisibleIndex = 0;
            // 
            // colStockName
            // 
            this.colStockName.FieldName = "StockName";
            this.colStockName.Name = "colStockName";
            this.colStockName.Visible = true;
            this.colStockName.VisibleIndex = 1;
            // 
            // colStockAddress
            // 
            this.colStockAddress.FieldName = "StockAddress";
            this.colStockAddress.Name = "colStockAddress";
            this.colStockAddress.Visible = true;
            this.colStockAddress.VisibleIndex = 2;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            // 
            // colTel
            // 
            this.colTel.FieldName = "Tel";
            this.colTel.Name = "colTel";
            this.colTel.Visible = true;
            this.colTel.VisibleIndex = 4;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 6;
            // 
            // FormKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 383);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormKhoHang";
            this.Text = "FormKhoHang";
            this.Load += new System.EventHandler(this.FormKhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private QuanLyBanHangDataSet quanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private QuanLyBanHangDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        //private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private QuanLyBanHangDataSetTableAdapters.STOCKTableAdapter sTOCKTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colStockName;
        private DevExpress.XtraGrid.Columns.GridColumn colStockAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
    }
}