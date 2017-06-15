using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class ProductObjectBUS
    {
        public static List<ProductObjectDTO> list()
        {
            return DAO.ProductObjectDAO.list();
        }
    }
}
