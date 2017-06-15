using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class ProductBUS
    {
        public static ProductDTO queryByID(string id)
        {
            return DAO.ProductDAO.queryByID(id);
        }
        public static void deleteByID(string id)
        {
            DAO.ProductDAO.deleteByID(id);
        }
        public static List<ProductDTO> list()
        {
            return DAO.ProductDAO.list();
        }
        public static void add(string productname, string productid, string producttypeid, string productgroupid, string providerid, string unitid, double org, double sale, double retail, int min,int max, string stockid, byte[] image, bool active)
        {
            DAO.ProductDAO.add(productname, productid, producttypeid, productgroupid, providerid, unitid, org, sale, retail, min,max, stockid, image, active);
        }
        public static void edit(string productname, string productid, string producttypeid, string productgroupid, string providerid, string unitid, double org, double sale, double retail, int min, int max, string stockid, byte[] image, bool active)
        {
            DAO.ProductDAO.edit(productname, productid, producttypeid, productgroupid, providerid, unitid, org, sale, retail, min, max, stockid, image, active);
        }
    }
}
