using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO.AppData;
namespace DAO
{
    public class CUSTOMER_GROUPDAO
    {
        public static List<CUSTOMER_GROUPDTO> list()
        {
            List<CUSTOMER_GROUPDTO> dsEmpl = new List<CUSTOMER_GROUPDTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = from em in db.CUSTOMER_GROUP
                            select em;
                foreach (var row in query)
                {
                    CUSTOMER_GROUPDTO cg = new CUSTOMER_GROUPDTO();
                    cg.Active = (Boolean)row.Active;
                    cg.Description = row.Description;
                    cg.Customer_Group_ID = row.Customer_Group_ID;
                    cg.Customer_Group_Name = row.Customer_Group_Name;
                    //empl.Active = (row.Active);
                    dsEmpl.Add(cg);
                }
                return dsEmpl;
            }
        }
        public static void deleteID(string id)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var cg = db.CUSTOMER_GROUP.Single(a => a.Customer_Group_ID == id);
                db.CUSTOMER_GROUP.Remove(cg);
                db.SaveChanges();
            }
        }
        public static void add(string groupid, string groupname, string description, bool active)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                CUSTOMER_GROUP cg = new CUSTOMER_GROUP();
                cg.Active = active;
                cg.Customer_Group_ID = groupid;
                cg.Customer_Group_Name = groupname;
                cg.Description = description;
                db.CUSTOMER_GROUP.Add(cg);
                db.SaveChanges();
            }
        }
        public static void EditByID(string ID,string groupname,string desciption,bool active)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {

                var a = db.CUSTOMER_GROUP.Single(b => b.Customer_Group_ID == ID);
                a.Active = active;
                a.Customer_Group_ID = ID;
                a.Customer_Group_Name = groupname;
                a.Description = desciption;
                db.SaveChanges();
            }
        }
        public static CUSTOMER_GROUPDTO objectToDTO(object a)
        {
            return a as CUSTOMER_GROUPDTO;
        }
    }
}
