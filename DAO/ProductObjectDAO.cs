using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO.AppData;
namespace DAO
{
    public class ProductObjectDAO
    {
        public static List<ProductObjectDTO> list()
        {
            var dsEmpl = new List<ProductObjectDTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = from a in db.PRODUCTs
                            from b in db.PRODUCT_GROUP
                            from c in db.UNITs
                            where a.Product_Group_ID == b.Product_Group_ID && a.Unit == c.Unit_ID
                            select new ProductObjectDTO
                            {
                                Product_ID = a.Product_ID,
                                ProductName = a.ProductName,
                                Product_Group_ID = b.Product_Group_Name,
                                Unit = c.UnitName,
                                Org_Price = a.Org_Price,
                                Sale_Price = a.Sale_Price,
                                Retail_Price = a.Retail_Price,
                                Quantity = a.Quantity,
                                MinStock = a.MinStock,
                                MaxStock = a.MaxStock,
                            };
                foreach (var row in query)
                {

                    dsEmpl.Add(row);
                }
                return dsEmpl;
            }
        }
    }
}
