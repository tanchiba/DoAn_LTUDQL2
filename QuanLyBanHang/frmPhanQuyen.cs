using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.AppData;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using System.Data.Entity;
using DevExpress.XtraTreeList.Nodes.Operations;
using DevExpress.XtraEditors.Repository;

namespace QuanLyBanHang
{
    public partial class frmPhanQuyen : Form
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        public frmPhanQuyen()
        {

            InitializeComponent();

        }
        #region button
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemVaiTro frm = new frmThemVaiTro();
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemNguoiDung frm = new frmThemNguoiDung();
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSua frm = new frmSua();
            frm.Show();

        }
        #endregion
        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            tlVaiTroLoad(tlVaitro);
        }
        private void tlVaiTroLoad(TreeList tl)
        {
            var sg = from a in db.SYS_GROUP
                     join b in db.SYS_USER
                     on a.Group_ID equals b.Group_ID
                     select new
                     {
                         GroupName = a.GroupName,
                         UserName = b.UserName,
                         GroupID = a.Group_ID,
                         Description = b.Description,
                         Active = b.Active,
                     };
            var list = sg.Select(s => new { s.GroupName, s.UserName, s.GroupID }).ToList();
            var hn = db.SYS_GROUP.ToList();
            TreeListNode[] parentnode = new TreeListNode[hn.Count()];
            TreeListNode[] childnode = new TreeListNode[sg.Count()];
            for (int i = 0; i < hn.Count(); i++)
            {
                parentnode[i] = tl.AppendNode(null, null);
                parentnode[i].SetValue("GroupName", hn[i].GroupName);
            }
            for (int j = 0; j < hn.Count(); j++)
            {
                for (int k = 0; k < sg.Count(); k++)
                {
                    if (list[k].GroupID == hn[j].Group_ID)
                    {
                        childnode[k] = tl.AppendNode(null, parentnode[j]);
                        childnode[k].SetValue("GroupName", list[k].UserName);
                    }
                }
            }
            tl.ExpandAll();
        }
        private void callNguoiDung(TreeList tl, string str)
        {
            var sg = from a in db.SYS_GROUP
                     join b in db.SYS_USER
                     on a.Group_ID equals b.Group_ID
                     where a.GroupName == str || b.UserName == str
                     select new
                     {
                         GroupName = a.GroupName,
                         UserName = b.UserName,
                         GroupID = a.Group_ID,
                         Description = b.Description,
                         Active = b.Active,
                     };
            //}

            var list = sg.Select(s => new { s.GroupName, s.UserName, s.GroupID, s.Description, s.Active }).ToList();
            var hn = db.SYS_GROUP.ToList();
            TreeListNode[] parentnode = new TreeListNode[hn.Count()];
            TreeListNode[] childnode = new TreeListNode[sg.Count()];
            for (int i = 0; i < hn.Count(); i++)
            {
                if (hn[i].GroupName == str)
                {
                    parentnode[i] = tl.AppendNode(null, null);
                    parentnode[i].SetValue("Group_ID", hn[i].Group_ID);
                    parentnode[i].SetValue("GroupName", hn[i].GroupName);
                    parentnode[i].SetValue("Description", hn[i].Description);
                    parentnode[i].SetValue("Active", hn[i].Active);
                }

            }
            for (int j = 0; j < hn.Count(); j++)
            {
                for (int k = 0; k < sg.Count(); k++)
                {
                    if (list[k].GroupID == hn[j].Group_ID)
                    {
                        childnode[k] = tl.AppendNode(null, parentnode[j]);
                        childnode[k].SetValue("Group_ID", list[k].UserName);
                        childnode[k].SetValue("GroupName", list[k].GroupName);
                        childnode[k].SetValue("Description", list[k].Description);
                        childnode[k].SetValue("Active", list[k].Active);
                    }
                }
            }
            tl.ExpandAll();
        }

        private void tlVaitro_AfterFocusNode(object sender, NodeEventArgs e)
        {
            tlNguoiDung.RefreshDataSource();
            TreeListMultiSelection selectedNodes = tlVaitro.Selection;
            var a = selectedNodes[0].GetValue(tlVaitro.Columns[0]).ToString();
            #region kiemtraGroupNAme
            var hn = db.SYS_GROUP.ToList();
            var sg = db.SYS_USER.ToList();
           
            for (int i = 0; i < sg.Count(); i++)
            {
                if (a == sg[i].UserName)
                {
                    callNguoiDung(tlNguoiDung, a);
                }
            }
            for (int j = 0; j < hn.Count(); j++)
            {
                if (a == hn[j].GroupName)
                {
                    callNguoiDung(tlNguoiDung, a);
                }
            }
            #endregion

        }
        #region PhanBo


        private void tlPhanQuyen_AfterFocusNode(object sender, NodeEventArgs e)
        {
            
        }

     

        private void tlPhanQuyen_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
           
        }

        private void tlPhanQuyen_AfterCheckNode(object sender, NodeEventArgs e)
        {
      
        }
        private void tlPhanQuyenLoad()
        {
           
        }
        #endregion
        private void tlNguoiDung_AfterFocusNode(object sender, NodeEventArgs e)
        {
            tlPhanQuyen.RefreshDataSource();
            TreeListMultiSelection selectedNodes = tlNguoiDung.Selection;
            var a = selectedNodes[0].GetValue(tlNguoiDung.Columns[0]).ToString();
            String query = null;
            #region kiemtra
            var hn = db.SYS_GROUP.ToList();
            var tg = db.SYS_USER.ToList();
            for (int i = 0; i < tg.Count(); i++)
            {
                if (a == tg[i].UserName)
                {
                    query = db.SYS_USER.Single(b => b.UserName == a).Group_ID;
                    break;
                }
            }
            for (int j = 0; j < hn.Count(); j++)
            {
                if (a == hn[j].Group_ID)
                {
                    query = a;
                    break;
                }
            }
            #endregion
            #region query db
            var sg = from obj in db.SYS_OBJECT
                     from sur in db.SYS_USER_RULE
                     where sur.Object_ID == obj.Object_ID && sur.Group_ID ==query
                     select new myobject
                     {
                         ObjectName = obj.ObjectName,
                         Parent_ID = obj.Parent_ID,
                         Object_ID = obj.Object_ID,
                         AllowAccess = sur.AllowAccess,
                         AllowAdd = sur.AllowAdd,
                         AllowDelete = sur.AllowDelete,
                         AllowEdit = sur.AllowEdit,
                         AllowExport = sur.AllowExport,
                         AllowImport = sur.AllowImport,
                         AllowPrint = sur.AllowPrint,
                     };


            tlPhanQuyen.DataSource = sg.ToList();
            tlPhanQuyen.KeyFieldName = "Object_ID";
            tlPhanQuyen.ParentFieldName = "Parent_ID";
            #endregion
        }
    }
}
