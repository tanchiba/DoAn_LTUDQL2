namespace QuanLyBanHang
{
    partial class frmHangHoa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colOrg_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSale_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetail_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Group_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            //this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl2);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 434);
            this.panel1.TabIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gridControl2.Location = new System.Drawing.Point(9, 111);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl2.Size = new System.Drawing.Size(1135, 271);
            this.gridControl2.TabIndex = 7;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa,
            this.colProductName,
            this.colUnit,
            this.colActive,
            this.colOrg_Price,
            this.colSale_Price,
            this.colRetail_price,
            this.gridColumn1,
            this.colMaxStock,
            this.colProduct_Group_ID});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupCount = 1;
            this.gridView2.Name = "gridView2";
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProduct_Group_ID, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMa
            // 
            this.colMa.FieldName = "Product_ID";
            this.colMa.Name = "colMa";
            this.colMa.Visible = true;
            this.colMa.VisibleIndex = 0;
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 2;
            // 
            // colActive
            // 
            this.colActive.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 8;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colOrg_Price
            // 
            this.colOrg_Price.FieldName = "Org_Price";
            this.colOrg_Price.Name = "colOrg_Price";
            this.colOrg_Price.Visible = true;
            this.colOrg_Price.VisibleIndex = 3;
            // 
            // colSale_Price
            // 
            this.colSale_Price.FieldName = "Sale_Price";
            this.colSale_Price.Name = "colSale_Price";
            this.colSale_Price.Visible = true;
            this.colSale_Price.VisibleIndex = 4;
            // 
            // colRetail_price
            // 
            this.colRetail_price.FieldName = "Retail_Price";
            this.colRetail_price.Name = "colRetail_price";
            this.colRetail_price.Visible = true;
            this.colRetail_price.VisibleIndex = 5;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "MinStock";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            // 
            // colMaxStock
            // 
            this.colMaxStock.FieldName = "MaxStock";
            this.colMaxStock.Name = "colMaxStock";
            this.colMaxStock.Visible = true;
            this.colMaxStock.VisibleIndex = 7;
            // 
            // colProduct_Group_ID
            // 
            this.colProduct_Group_ID.FieldName = "Product_Group_ID";
            this.colProduct_Group_ID.Name = "colProduct_Group_ID";
            this.colProduct_Group_ID.Visible = true;
            this.colProduct_Group_ID.VisibleIndex = 9;
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
            this.panelControl1.Location = new System.Drawing.Point(3, 4);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(843, 72);
            this.panelControl1.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Image = global::QuanLyBanHang.Properties.Resources.MS_Office_2003_Excel_icon;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(359, 6);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 60);
            this.button7.TabIndex = 7;
            this.button7.Text = "Nhập";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = global::QuanLyBanHang.Properties.Resources.Folders_OS_Exit_Full_Screen_Metro_icon;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(429, 6);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 60);
            this.button6.TabIndex = 6;
            this.button6.Text = "Đóng";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::QuanLyBanHang.Properties.Resources.Export_To_File_icon;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(289, 6);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 60);
            this.button5.TabIndex = 5;
            this.button5.Text = "Xuất";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::QuanLyBanHang.Properties.Resources.Button_Refresh_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(219, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "Nạp lại";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::QuanLyBanHang.Properties.Resources.Actions_edit_delete_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(149, 6);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "Xóa";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::QuanLyBanHang.Properties.Resources.hp_customization_control_panel_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(77, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sửa";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Image = global::QuanLyBanHang.Properties.Resources.add_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 596);
            this.Controls.Add(this.panel1);
            this.Name = "frmHangHoa";
            this.Text = "Hàng Hóa & Dịch Vụ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrg_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colSale_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colRetail_price;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxStock;
        //private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Group_ID;
    }
}