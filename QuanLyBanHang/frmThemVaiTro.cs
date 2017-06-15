using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using System.Collections;
using DevExpress.XtraGrid.Views.Base;
using BUS;
namespace QuanLyBanHang
{
    public partial class frmThemVaiTro : Form
    {

       
        List<DTO.myobjectDTO> sg;
        public frmThemVaiTro()
        {
            InitializeComponent();
            sg = DAO.myobjectDAO.getGroup("admin");
            tlVaiTro.DataSource = sg.ToList();
            tlVaiTro.KeyFieldName = "Object_ID";
            tlVaiTro.ParentFieldName = "Parent_ID";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tlVaiTro.PostEditor();
            tlVaiTro.EndCurrentEdit();
            DAO.SYS_GROUPDAO.Add(tbMa.Text, tbten.Text, tbDescription.Text, true);
            
            foreach (var item in sg.ToList())
            {
                //SYS_USER_RULE sur = new SYS_USER_RULE();
                //sur.Group_ID = tbMa.Text;
                //sur.Object_ID = item.Object_ID;
                //sur.Rule_ID = "RL000010";
                //sur.AllowAccess = item.AllowAccess;
                //sur.AllowAdd = item.AllowAdd;
                //sur.AllowDelete = item.AllowDelete;
                //sur.AllowEdit = item.AllowEdit;
                //sur.AllowExport = item.AllowExport;
                //sur.AllowImport = item.AllowImport;
                //sur.AllowPrint = item.AllowPrint;
                //sur.Active = true;
                //lsur.Add(sur);
                SYS_USER_RULEBUS.addUserRule(tbMa.Text, item.Object_ID, "RL000010", (Boolean)item.AllowAccess, (Boolean)item.AllowAdd, (Boolean)item.AllowDelete, (Boolean)item.AllowEdit, (Boolean)item.AllowImport, (Boolean)item.AllowExport, (Boolean)item.AllowPrint, true);
            }
            //for (int i = 0; i < lsur.Count(); i++)
            //{
            //        db.SYS_USER_RULE.Add(lsur[i]);
            //        db.SaveChanges();
            //}
            
            
            this.Close();
        }

        private void tlVaiTro_CellValueChanging(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {

        }

        private void tlVaiTro_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            TreeListMultiSelection selectedNodes = tlVaiTro.Selection;
            var a = selectedNodes[0].GetValue(e.Column.FieldName).ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

