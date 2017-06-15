using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.AppData;
using DTO;
namespace DAO
{
    public class SYS_GROUPDAO
    {
        public static List<SYS_GROUPDTO> getGroup()
        {
            List<SYS_GROUPDTO> dsGroup = new List<SYS_GROUPDTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var sg = from a in db.SYS_GROUP
                         select a;
                foreach (var row in sg)
                {
                    SYS_GROUPDTO gr = new SYS_GROUPDTO();
                    gr.Active = (Boolean)row.Active;
                    gr.Description = row.Description;
                    gr.Groupname = row.GroupName;
                    gr.Group_id = row.Group_ID;
                    dsGroup.Add(gr);
                }
                return dsGroup;
            }
        }
        public static void Add(String groupid,String groupname,String description,Boolean Active)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                SYS_GROUP sg = new SYS_GROUP();
                sg.Active = Active;
                sg.Description = description;
                sg.GroupName = groupname;
                sg.Group_ID = groupid;
                
                db.SYS_GROUP.Add(sg);
                db.SaveChanges();
            }
        }
    }
}
