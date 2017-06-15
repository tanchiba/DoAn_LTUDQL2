using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.AppData;
using DTO;

namespace DAO
{
    public class SYS_USER_RULEDAO
    {
        public static void addUserRule(string groupid, int objectid, string ruleid, bool access, bool add, bool delete, bool edit, bool import, bool export, bool print, bool active)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var sg = new SYS_USER_RULE();
                sg.Active = active;
                sg.AllowAccess = access;
                sg.AllowAdd = add;
                sg.AllowDelete = delete;
                sg.AllowEdit = edit;
                sg.AllowExport = export;
                sg.AllowImport = import;
                sg.AllowPrint = print;
                sg.Group_ID = groupid;
                sg.Object_ID = objectid;
                sg.Rule_ID = ruleid;
                db.SYS_USER_RULE.Add(sg);
                db.SaveChanges();
            }
        }
    }
}
