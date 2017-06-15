using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class SYS_GROUPBUS
    {
        public static List<SYS_GROUPDTO> getGroup()
        {
            return DAO.SYS_GROUPDAO.getGroup();
        }
        public static void add(String groupid, String groupname, String description, Boolean Active)
        {
            DAO.SYS_GROUPDAO.Add(groupid,groupname,description,Active);
        }
    }
}
