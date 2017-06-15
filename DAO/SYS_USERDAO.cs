using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.AppData;
using DTO;
namespace DAO
{
    public class SYS_USERDAO
    {
        public static List<SYS_USERDTO> GetUser()
        {
            List<SYS_USERDTO> dsUser = new List<SYS_USERDTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = from em in db.SYS_USER
                            select em;
                foreach (var row in query)
                {
                    SYS_USERDTO u = new SYS_USERDTO();
                    u.Active = (Boolean)row.Active;
                    u.Description = row.Description;
                    u.FullName = row.FullName;
                    u.Group_ID = row.Group_ID;
                    u.PassWord = row.Password;
                    u.UserName = row.UserName;
                    u.User_ID = row.User_ID;
                    dsUser.Add(u);
                }
                return dsUser;
            }
        }
        public static SYS_USERDTO queryByUserName(String username)
        {
            SYS_USERDTO user = new SYS_USERDTO();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                
                var b = db.SYS_USER.Single(a => a.UserName == username);
                user.Active =(Boolean) b.Active;
                user.Description = b.Description;
                user.FullName = b.FullName;
                user.Group_ID = b.Group_ID;
                user.PassWord = b.Password;
                user.UserName = b.UserName;
                user.User_ID = b.User_ID;
            }
                return user;
        }
    }
}
