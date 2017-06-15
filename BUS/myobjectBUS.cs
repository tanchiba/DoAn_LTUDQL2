using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class myobjectBUS
    {

        public static List<myobjectDTO> getGroup(String GroupID)
        {
            return DAO.myobjectDAO.getGroup(GroupID);
        }
    }
}
