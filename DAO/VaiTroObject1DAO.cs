using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO.AppData;
namespace DAO
{
   public  class VaiTroObject1DAO
    {
        public static List<VaiTroObject1DTO> getVaiTroObject()
        {
            List<VaiTroObject1DTO> dsObject = new List<VaiTroObject1DTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var sg = from a in db.SYS_GROUP
                         join b in db.SYS_USER
                         on a.Group_ID equals b.Group_ID
                         select new 
                         {
                             Groupname = a.GroupName,
                             Username = b.UserName,
                             Group_id = a.Group_ID,
                             Description = b.Description,
                             Active = (Boolean)b.Active,
                         };
                foreach (var row in sg)
                {
                    VaiTroObject1DTO ob = new VaiTroObject1DTO();
                    ob.Active = row.Active;
                    ob.Description = row.Description;
                    ob.Groupname = row.Description;
                    ob.Group_id = row.Group_id;
                    ob.Username = row.Username;
                    //empl.Active = (row.Active);
                    dsObject.Add(ob);
                }
                return dsObject;
            }
    }
        public static List<VaiTroObject1DTO> getNguoiDungByStr(String str)
        {
            List<VaiTroObject1DTO> dsObject = new List<VaiTroObject1DTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var sg = from a in db.SYS_GROUP
                         join b in db.SYS_USER
                         on a.Group_ID equals b.Group_ID
                         where a.GroupName == str || b.UserName == str
                         select new
                         {
                             Groupname = a.GroupName,
                             Username = b.UserName,
                             Group_id = a.Group_ID,
                             Description = b.Description,
                             Active = (Boolean)b.Active,
                         };
                foreach (var row in sg)
                {
                    VaiTroObject1DTO ob = new VaiTroObject1DTO();
                    ob.Active = row.Active;
                    ob.Description = row.Description;
                    ob.Groupname = row.Description;
                    ob.Group_id = row.Group_id;
                    ob.Username = row.Username;
                    //empl.Active = (row.Active);
                    dsObject.Add(ob);
                }
                return dsObject;
            }
        }
    }
}
