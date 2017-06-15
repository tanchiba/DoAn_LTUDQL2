using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO.AppData;
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
            TreeListMultiSelection selectedNodes = tlVaitro.Selection;
            var a = selectedNodes[0].GetValue(tlNguoiDung.Columns[0]).ToString();
            var b = db.SYS_GROUP.ToList();
            var c = db.SYS_USER.ToList();
            foreach (var item in b)
            {
                if (a == item.GroupName)
                {
                    frmSua frm = new frmSua();
                    frm.Show();
                    break;
                }
            }
            foreach (var item in c)
            {
                if (a== item.UserName)
                {
                    frmSuaNguoiDung fm = new frmSuaNguoiDung();
                    fm.Show();
                    break;
                }
            }
            

        }
        #endregion
        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            tlVaiTroLoad(tlVaitro);
        }
        private void tlVaiTroLoad(TreeList tl)
        {
            var sg = BUS.VaiTroObject1BUS.getVaiTroObject();
            var list = sg;
            var hn = BUS.SYS_GROUPBUS.getGroup();
            TreeListNode[] parentnode = new TreeListNode[hn.Count()];
            TreeListNode[] childnode = new TreeListNode[sg.Count()];
            for (int i = 0; i < hn.Count(); i++)
            {
                parentnode[i] = tl.AppendNode(null, null);
                parentnode[i].SetValue("GroupName", hn[i].Groupname);
            }
            for (int j = 0; j < hn.Count(); j++)
            {
                for (int k = 0; k < sg.Count(); k++)
                {
                    if (list[k].Group_id == hn[j].Group_id)
                    {
                        childnode[k] = tl.AppendNode(null, parentnode[j]);
                        childnode[k].SetValue("GroupName", list[k].Username);
                    }
                }
            }
            tl.ExpandAll();
        }
        private void callNguoiDung(TreeList tl, string str)
        {
            var sg = BUS.VaiTroObject1BUS.getNguoiDungByStr(str);
            var list = sg.Select(s => new { s.Groupname, s.Username, s.Group_id, s.Description, s.Active }).ToList();
            var hn = BUS.SYS_GROUPBUS.getGroup();
            TreeListNode[] parentnode = new TreeListNode[hn.Count()];
            TreeListNode[] childnode = new TreeListNode[sg.Count()];
            for (int i = 0; i < hn.Count(); i++)
            {
                if (hn[i].Groupname == str)
                {
                    parentnode[i] = tl.AppendNode(null, null);
                    parentnode[i].SetValue("Group_ID", hn[i].Group_id);
                    parentnode[i].SetValue("GroupName", hn[i].Groupname);
                    parentnode[i].SetValue("Description", hn[i].Description);
                    parentnode[i].SetValue("Active", hn[i].Active);
                }

            }

            for (int j = 0; j < hn.Count(); j++)
            {
                for (int k = 0; k < sg.Count(); k++)
                {
                    if (list[k].Group_id == hn[j].Group_id)
                    {
                        childnode[k] = tl.AppendNode(null, parentnode[j]);
                        childnode[k].SetValue("Group_ID", list[k].Username);
                        childnode[k].SetValue("GroupName", list[k].Groupname);
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
            var hn = DAO.SYS_GROUPDAO.getGroup();
            var sg = DAO.SYS_USERDAO.GetUser();
           
            for (int i = 0; i < sg.Count(); i++)
            {
                if (a == sg[i].UserName)
                {
                    callNguoiDung(tlNguoiDung, a);
                }
            }
            for (int j = 0; j < hn.Count(); j++)
            {
                if (a == hn[j].Groupname)
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
            var hn = DAO.SYS_GROUPDAO.getGroup();
            var tg = DAO.SYS_USERDAO.GetUser();
            for (int i = 0; i < tg.Count(); i++)
            {
                if (a == tg[i].UserName)
                {
                    query = DAO.SYS_USERDAO.queryByUserName(a).Group_ID;
                    break;
                }
            }
            for (int j = 0; j < hn.Count(); j++)
            {
                if (a == hn[j].Group_id)
                {
                    query = a;
                    break;
                }
            }
            #endregion
            #region query db
            var sg = DAO.myobjectDAO.getGroup(query);
            tlPhanQuyen.DataSource = sg.ToList();
            tlPhanQuyen.KeyFieldName = "Object_ID";
            tlPhanQuyen.ParentFieldName = "Parent_ID";
            #endregion
        }

        private void tlVaitro_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {

        }
    }
}
