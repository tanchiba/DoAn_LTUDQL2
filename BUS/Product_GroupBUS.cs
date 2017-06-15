using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class Product_GroupBUS
    {
        public static List<Product_GroupDTO> list()
        {
            return DAO.Product_GroupDAO.list();
        }
        public static Product_GroupDTO objectToDTO(object a)
        {
            return DAO.Product_GroupDAO.objectToDTO(a);
        }
    }
}
