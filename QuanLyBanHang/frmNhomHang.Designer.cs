namespace QuanLyBanHang
{
    partial class frmNhomHang
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            //this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableAdapterManager1 = new QuanLyBanHang.QuanLyBanHangDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
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
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1247, 76);
            this.panelControl1.TabIndex = 5;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
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
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gridControl1.Location = new System.Drawing.Point(12, 84);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1134, 365);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa,
            this.colTen,
            this.colGhichu,
            this.colConQuanLy,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMa
            // 
            this.colMa.FieldName = "Mã";
            this.colMa.Name = "colMa";
            this.colMa.Visible = true;
            this.colMa.VisibleIndex = 0;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Tên";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            // 
            // colGhichu
            // 
            this.colGhichu.FieldName = "Ghi chú";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 2;
            // 
            // colConQuanLy
            // 
            this.colConQuanLy.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colConQuanLy.FieldName = "Còn Quản Lý";
            this.colConQuanLy.Name = "colConQuanLy";
            this.colConQuanLy.Visible = true;
            this.colConQuanLy.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CASH_METHODTableAdapter = null;
            this.tableAdapterManager1.CASH_TERMTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.CURRENCYTableAdapter = null;
            this.tableAdapterManager1.CUSTOMER_GROUPTableAdapter = null;
            this.tableAdapterManager1.CUSTOMER_TYPETableAdapter = null;
            this.tableAdapterManager1.CUSTOMERTableAdapter = null;
            this.tableAdapterManager1.DEPARTMENTTableAdapter = null;
            this.tableAdapterManager1.EMPLOYEETableAdapter = null;
            this.tableAdapterManager1.INVENTORY_ACTIONTableAdapter = null;
            this.tableAdapterManager1.MESSAGETableAdapter = null;
            this.tableAdapterManager1.PRODUCT_GROUPTableAdapter = null;
            this.tableAdapterManager1.PRODUCTTableAdapter = null;
            this.tableAdapterManager1.PROVIDERTableAdapter = null;
            this.tableAdapterManager1.REPORTTableAdapter = null;
            this.tableAdapterManager1.STOCKTableAdapter = null;
            this.tableAdapterManager1.SYS_COMPANYTableAdapter = null;
            this.tableAdapterManager1.SYS_GROUPTableAdapter = null;
            this.tableAdapterManager1.SYS_LOGTableAdapter = null;
            this.tableAdapterManager1.SYS_OBJECTTableAdapter = null;
            this.tableAdapterManager1.SYS_RULETableAdapter = null;
            this.tableAdapterManager1.SYS_USER_RULETableAdapter = null;
            this.tableAdapterManager1.SYS_USERTableAdapter = null;
            this.tableAdapterManager1.UNITTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QuanLyBanHang.QuanLyBanHangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmNhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 452);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmNhomHang";
            this.Text = "Nhóm Hàng";
            this.Load += new System.EventHandler(this.frmNhomHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        //private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn colConQuanLy;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private QuanLyBanHangDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}