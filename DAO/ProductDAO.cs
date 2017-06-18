using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO.AppData;
namespace DAO
{
    public class ProductDAO
    {
        public static ProductDTO queryByID(string id)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var a = db.PRODUCTs.Single(c => c.Product_ID == id);
                var b = new ProductDTO();
                b.Active = (Boolean)a.Active;
                b.Currency_ID = a.Currency_ID;
                b.image = a.Photo;
                b.MaxStock = (int)a.MaxStock;
                b.MinStock = (int)a.MinStock;
                b.Org_Price = (int)a.Org_Price;
                b.ProductName = a.ProductName;
                b.Product_Group_ID = a.Product_Group_ID;
                b.Product_ID = a.Product_ID;
                b.Product_Type_ID = a.Product_Type_ID;
                b.Provider_ID = a.Prorvider_ID;
                b.Retail_Price = (double)a.Retail_Price;
                b.Sale_Price = (double)a.Sale_Price;
                b.Stock_ID = a.Stock_ID;
                b.Unit = a.Unit;

                return b;
            }
        }
        public static void deleteByID(string id)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var a = db.PRODUCTs.Single(b => b.Product_ID == id);
                db.PRODUCTs.Remove(a);
                db.SaveChanges();
            }
        }
        public static List<ProductDTO> list()
        {
            List<ProductDTO> dsEmpl = new List<ProductDTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = from em in db.PRODUCTs
                            select em;
                foreach (var b in query)
                {
                    ProductDTO a = new ProductDTO();
                    a.Active = (Boolean)b.Active;
                    a.Currency_ID = b.Currency_ID;
                    a.image = b.Photo;
                    a.MaxStock = (int)b.MaxStock;
                    a.MinStock = (int)b.MinStock;
                    a.Org_Price = (double)b.Org_Price;
                    a.ProductName = b.ProductName;
                    a.Product_Group_ID = b.Product_Group_ID;
                    a.Product_ID = b.Product_ID;
                    a.Product_Type_ID = b.Product_Type_ID;
                    a.Provider_ID = b.Prorvider_ID;
                    a.Retail_Price =(double) b.Retail_Price;
                    a.Sale_Price = (double)b.Sale_Price;
                    a.Stock_ID = b.Stock_ID;
                    a.Unit = b.Unit;
                    dsEmpl.Add(a);
                }
                return dsEmpl;
            }
        }
        public static void add(string productname,string productid,string producttypeid,string productgroupid,string providerid,string unitid,double org,double sale,double retail,int min,int max, string stockid,byte[] image,bool active)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var a = new PRODUCT();
                a.Active = (Boolean)active;
                a.MinStock = min;
                a.Org_Price = (decimal)org;
                a.Photo = image;
                a.ProductName = productname;
                a.Product_Group_ID = productgroupid;
                a.Product_ID = productid;
                a.Product_Type_ID = producttypeid;
                a.Prorvider_ID = providerid;
                a.Retail_Price = (decimal)retail;
                a.Sale_Price = (decimal)sale;
                a.Stock_ID = stockid;
                a.Unit = unitid;
                a.MaxStock = max;
                db.PRODUCTs.Add(a);
                db.SaveChanges();
            }
        }
        public static void edit(string productname, string productid, string producttypeid, string productgroupid, string providerid, string unitid, double org, double sale, double retail, int min, int max, string stockid, byte[] image, bool active)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var a = db.PRODUCTs.Single(b => b.Product_ID == productid);
                a.Active = (Boolean)active;
                a.MinStock = min;
                a.Org_Price = (decimal)org;
                a.Photo = image;
                a.ProductName = productname;
                a.Product_Group_ID = productgroupid;
                a.Product_ID = productid;
                a.Product_Type_ID = producttypeid;
                a.Prorvider_ID = providerid;
                a.Retail_Price = (decimal)retail;
                a.Sale_Price = (decimal)sale;
                a.Stock_ID = stockid;
                a.Unit = unitid;
                a.MaxStock = max;
                db.SaveChanges();
            }
        }
    }
}
