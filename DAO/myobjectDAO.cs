using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO.AppData;
namespace DAO
{
    public class myobjectDAO
    {
        public static List<myobjectDTO> getGroup(String GroupID)
        {
            List<myobjectDTO> dsO = new List<myobjectDTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var sg = from obj in db.SYS_OBJECT
                         from sur in db.SYS_USER_RULE
                         where sur.Object_ID == obj.Object_ID && sur.Group_ID == GroupID
                         select new myobjectDTO
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
                foreach (var row in sg)
                {
                    dsO.Add(row);
                }
                return dsO;
            }
        }
    }
}
