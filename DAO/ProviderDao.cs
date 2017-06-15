using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO.AppData;
namespace DAO
{
    public class ProviderDao
    {
        public static List<ProviderDTO> list()
        {
            List<ProviderDTO> dsEmpl = new List<ProviderDTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = from em in db.PROVIDERs
                            select em;
                foreach (var row in query)
                {
                    ProviderDTO a = new ProviderDTO();
                    a.Active = (Boolean)row.Active;
                    a.Customer_Group_ID = row.Customer_Group_ID;
                    a.Description = row.Description;
                    a.Email = row.Email;
                    a.ProviderAddress = row.ProviderAddress;
                    a.ProviderName = row.ProviderName;
                    a.Provider_ID = row.Provider_ID;
                    a.Tel = row.Tel;
                    dsEmpl.Add(a);
                }
                return dsEmpl;
            }
        }
        public static ProviderDTO objectToDTO(object a)
        { return a as ProviderDTO; }


        public static string MaNhaCungCap()
        {
            string MaNhaCungCap;
            var db = new QuanLyBanHangEntities();
            MaNhaCungCap = db.PROVIDERs.OrderByDescending(dv => dv.Provider_ID).FirstOrDefault().Provider_ID;
            if (MaNhaCungCap != null)
            {
                MaNhaCungCap = XuLyChuoi.LayChuoi(MaNhaCungCap);
            }
            return MaNhaCungCap;
        }

        public static void InsertProvider(string providerID, string providerName, string customer_Group_ID, string providerAddress, string tel, string email, string description, bool active)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {


                PROVIDER pvd = new PROVIDER();
                pvd.Provider_ID = providerID;
                pvd.ProviderName = providerName;
                pvd.Customer_Group_ID = customer_Group_ID;
                pvd.ProviderAddress = providerAddress;
                pvd.Tel = tel;
                pvd.Email = email;
                pvd.Description = description;
                pvd.Active = active;
            
                db.PROVIDERs.Add(pvd);
                db.SaveChanges();
                
            }
        }

        public static void DeleteProvider(string Provider_ID)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = (from a in db.PROVIDERs
                             where a.Provider_ID == Provider_ID
                             select a).FirstOrDefault();
                db.PROVIDERs.Remove(query);
                db.SaveChanges();
            }
        }

        public static void UpdateProvider(string providerID, string providerName, string Customer_Group_ID, string ProviderAddress,
            string Tel, string Email, string Description, bool Active)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                try
                {



                    var query = (from u in db.PROVIDERs
                                 where u.Provider_ID == providerID
                                 select u).First();

                    query.Provider_ID = providerID;
                    query.ProviderName = providerName;
                    query.ProviderAddress = ProviderAddress;
                    query.Email = Email;
                    query.Tel = Tel;
                    query.Customer_Group_ID = Customer_Group_ID;
                    query.Description = Description;
                    query.Active = Active;


                    db.SaveChanges();
                }
                catch
                {

                }
            }
        }
    }
}
