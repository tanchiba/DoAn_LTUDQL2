using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class Customer_TypeBUS
    {
        public static List<Customer_TypeDTO> list()
        {
            return DAO.Customer_TypeDAO.list();
        }
        public static Customer_TypeDTO objectToDTO(object a)
        {
            return DAO.Customer_TypeDAO.objectToDTO(a);
        }
    }
}
