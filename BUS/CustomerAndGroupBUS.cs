using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class CustomerAndGroupBUS
    {
        public static List<CustomerAndGroupDTO> list()
        {
            return DAO.CustomerAndGroupDAO.list();
        }
    }
}
