using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO.AppData;
namespace DAO
{
    public class CustomerAndGroupDAO
    {
        public static List<CustomerAndGroupDTO> list()
        {
            List<CustomerAndGroupDTO> dsEmpl = new List<CustomerAndGroupDTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var listkh = from a in db.CUSTOMERs
                             from b in db.CUSTOMER_GROUP
                             where a.Customer_Group_ID == b.Customer_Group_ID
                             select new CustomerAndGroupDTO
                             {
                                 Customer_ID = a.Customer_ID,
                                 CustomerName = a.CustomerName,
                                 Customer_Group_ID = b.Customer_Group_Name,
                                 CustomerAddress = a.CustomerAddress,
                                 Email = a.Email,
                                 Tel = a.Tel,
                                 Active = a.Active,
                             };
                foreach (var row in listkh)
                {
                    CustomerAndGroupDTO a = new CustomerAndGroupDTO();
                    a.Active = (Boolean)row.Active;
                    a.CustomerAddress = row.CustomerAddress;
                    a.CustomerName = row.CustomerName;
                    a.Customer_Group_ID = row.Customer_Group_ID;
                    a.Customer_ID = row.Customer_ID;
                    a.Email = row.Email;
                    a.Tel = row.Tel;
                    dsEmpl.Add(a);
                }
                return dsEmpl;
            }
        }
    }
}
