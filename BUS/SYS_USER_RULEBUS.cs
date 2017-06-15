using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BUS
{
    public class SYS_USER_RULEBUS
    {
      public static void addUserRule(string groupid, int objectid, string ruleid, bool access, bool add, bool delete, bool edit, bool import, bool export, bool print, bool active)
        {
            DAO.SYS_USER_RULEDAO.addUserRule(groupid, objectid, ruleid, access, add, delete, edit, import, export, print, active);
        }
    }
}
