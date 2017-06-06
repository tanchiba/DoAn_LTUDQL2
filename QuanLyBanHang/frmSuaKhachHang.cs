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
using QuanLyBanHang.AppData;
namespace QuanLyBanHang
{
    public partial class frmSuaKhachHang : DevExpress.XtraEditors.XtraForm
    {
        CUSTOMER_GROUP item;
        CUSTOMER_TYPE item1;
        public frmSuaKhachHang()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmThamKhachHang_Load(object sender, EventArgs e)
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            List<CUSTOMER_GROUP> cg = new List<CUSTOMER_GROUP>();
            cg = db.CUSTOMER_GROUP.ToList();
            List<CUSTOMER_TYPE> tp = new List<CUSTOMER_TYPE>();
            tp = db.CUSTOMER_TYPE.ToList();
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.CUSTOMER_GROUP' table. You can move, or remove it, as needed.
            gvKhuVuc.Properties.DataSource = cg;
            gvKhuVuc.Properties.DisplayMember = "Customer_Group_Name";
            gvKhuVuc.Properties.ValueMember = "Customer_Group_ID";
            gridLookUpEdit1.Properties.DataSource = tp;
            gridLookUpEdit1.Properties.DisplayMember = "Customer_Type_Name";
            gridLookUpEdit1.Properties.ValueMember = "Customer_Type_ID";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            var khuvuc = db.CUSTOMERs.Single(a => a.Customer_ID == tbMa.Text.ToString());
            khuvuc.Customer_ID = tbMa.Text;
            khuvuc.CustomerName = tbTen.Text;
            khuvuc.Customer_Type_ID = item1.Customer_Type_ID;
            khuvuc.Customer_Group_ID = item.Customer_Group_ID;
            khuvuc.CustomerAddress = tbDiaChi.Text;
            khuvuc.Tel = tbDienThoai.Text;
            khuvuc.Email = tbEmail.Text;
            if (!cbActive.Checked)
            {
                khuvuc.Active = false;
            }
            else
            {
                khuvuc.Active = true;
            }
            db.SaveChanges();

            this.Close();

        }
        
        public void gvKhuVuc_EditValueChanged(object sender, EventArgs e)
        {
            item = gvKhuVuc.GetSelectedDataRow() as CUSTOMER_GROUP;
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            item1 = gridLookUpEdit1.GetSelectedDataRow() as CUSTOMER_TYPE;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}