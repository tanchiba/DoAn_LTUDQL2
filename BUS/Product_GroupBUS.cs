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

        public void Them(string Product_Group_ID, string Product_Group_Name, string Description, bool Active)
        {
            DAO.Product_GroupDAO.Them(Product_Group_ID, Product_Group_Name, Description, Active);
        }

        public static void Xoa(string Product_Group_ID)
        {
            DAO.Product_GroupDAO.Xoa(Product_Group_ID);
        }

        public static void Sua(string Product_Group_ID, string Product_Group_Name, string Description, bool Active)
        {
            DAO.Product_GroupDAO.Sua(Product_Group_ID, Product_Group_Name, Description, Active);
        }
    }
}
