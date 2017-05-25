﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
namespace QuanLyBanHang
{
    public partial class FormKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public FormKhachHang()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            QuanLyBanHang.AppData.QuanLyBanHangEntities dbContext = new QuanLyBanHang.AppData.QuanLyBanHangEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.CUSTOMERs.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.CUSTOMERs.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            //this.cUSTOMERTableAdapter.Fill(this.quanLyBanHangDataSet.CUSTOMER);
            this.gridView1.ExpandAllGroups();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}