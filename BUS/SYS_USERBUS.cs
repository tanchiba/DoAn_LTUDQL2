using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    class SYS_USERBUS
    {
        public static List<SYS_USERDTO> getUser()
        {
            return DAO.SYS_USERDAO.GetUser();
        }
        public static SYS_USERDTO queryByUserName(String username)
        {
           return DAO.SYS_USERDAO.queryByUserName(username);
        }
    }
}
