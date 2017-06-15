using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.AppData;
using DTO;
namespace DAO
{
    public class CustomerDAO
    {
        public static CustomerDTO queryByID(string id)
        {
            CustomerDTO cm = new CustomerDTO();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var b = db.CUSTOMERs.Single(a => a.Customer_ID == id);
                    cm.Active = (Boolean)b.Active;
                cm.CustomerAdress = b.CustomerAddress;
                cm.CustomerName = b.CustomerName;
                cm.Customer_Group_ID = b.Customer_Group_ID;
                cm.Customer_ID = b.Customer_ID;
                cm.Customer_Type_ID = b.Customer_Type_ID;
                cm.Email = b.Email;
                cm.Tel = b.Tel;
            }
            return cm;
        }

        public static string MaKhachHang()
        {
            string MaKhachHang;
            var db = new QuanLyBanHangEntities();
            MaKhachHang = db.CUSTOMERs.OrderByDescending(dv => dv.Customer_ID).FirstOrDefault().Customer_ID;
            if (MaKhachHang != null)
            {
                MaKhachHang = XuLyChuoi.LayChuoi(MaKhachHang);
            }
            return MaKhachHang;
        }

        public static List<CustomerDTO> GetCustomer()
        {
            List<CustomerDTO> dsEmpl = new List<CustomerDTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = from em in db.CUSTOMERs
                            select em;
                foreach (var row in query)
                {
                    CustomerDTO a = new CustomerDTO();
                    a.Tel = row.Tel;
                    a.Email = row.Email;
                    a.Customer_Type_ID = row.Customer_Type_ID;
                    a.Customer_ID = row.Customer_ID;
                    a.Customer_Group_ID = row.Customer_Group_ID;
                    a.CustomerName = row.CustomerName;
                    a.CustomerAdress = row.CustomerAddress ;
                    a.Active = (Boolean)row.Active;
                    
                    //empl.Active = (row.Active);
                    dsEmpl.Add(a);
                }
                return dsEmpl;
            }
        }
        public static void deleteByID(string id)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var a = db.CUSTOMERs.Single(b => b.Customer_ID == id);
                db.CUSTOMERs.Remove(a);
                db.SaveChanges();
            }
        }
        public static void add(string id,string cgid,string customername,string customeraddress,string customertypeid,string email,string tel,bool active)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var a = new CUSTOMER();
                a.Active = (Boolean)active;
                a.CustomerAddress = customeraddress;
                a.CustomerName = customername;
                a.Customer_Group_ID = cgid;
                a.Customer_ID = id;
                a.Customer_Type_ID = customertypeid;
                a.Email = email;
                a.Tel = tel;
                db.CUSTOMERs.Add(a);
                db.SaveChanges();
            }
        }
        public static void editByID(string id, string cgid, string customername, string customeraddress, string customertypeid, string email, string tel, bool active)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var a = db.CUSTOMERs.Single(b => b.Customer_ID == id);
                a.Active = (Boolean)active;
                a.CustomerAddress = customeraddress;
                a.CustomerName = customername;
                a.Customer_Group_ID = cgid;
                a.Customer_ID = id;
                a.Customer_Type_ID = customertypeid;
                a.Email = email;
                a.Tel = tel;
                db.SaveChanges();
            }
        }
    }
}
