using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO.AppData;
namespace DAO
{
    public class Product_GroupDAO
    {
        public static List<Product_GroupDTO> list()
        {
            List<Product_GroupDTO> dsEmpl = new List<Product_GroupDTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = from em in db.PRODUCT_GROUP
                            select em;
                foreach (var row in query)
                {
                    Product_GroupDTO a = new Product_GroupDTO();
                    a.Active =(Boolean) row.Active;
                    a.Description = row.Description;
                    a.Product_Group_ID = row.Product_Group_ID;
                    a.Product_Group_Name = row.Product_Group_Name;   
                    dsEmpl.Add(a);
                }
                return dsEmpl;
            }
        }

        public static Product_GroupDTO objectToDTO(object a)
        {
            return a as Product_GroupDTO;
        }

        public static void Them(string Product_Group_ID, string Product_Group_Name, string Description, bool Active)
        {
            PRODUCT_GROUP nhomhang = new PRODUCT_GROUP();
            nhomhang.Product_Group_ID = Product_Group_ID;
            nhomhang.Product_Group_Name = Product_Group_Name;
            nhomhang.Description = Description;
            nhomhang.Active = Active;
            var db = new QuanLyBanHangEntities();
            db.PRODUCT_GROUP.Add(nhomhang);
            db.SaveChanges();
        }

        public static void Xoa(string Product_Group_ID)
        {
            var db = new QuanLyBanHangEntities();
            var nh = db.PRODUCT_GROUP.Where(k => k.Product_Group_ID == Product_Group_ID).First();
            db.PRODUCT_GROUP.Remove(nh);
            db.SaveChanges();
        }

        public static void Sua(string Product_Group_ID, string Product_Group_Name, string Description, bool Active)
        {
            var db = new QuanLyBanHangEntities();
            var nh = db.PRODUCT_GROUP.Where(k => k.Product_Group_ID == Product_Group_ID).First();
            nh.Product_Group_Name = Product_Group_Name;
            nh.Description = Description;
            nh.Active = Active;
            db.SaveChanges();
        }
    }
}
