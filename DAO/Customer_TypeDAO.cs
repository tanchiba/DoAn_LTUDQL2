using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.AppData;
using DTO;
namespace DAO
{
   public class Customer_TypeDAO
    {
        public static List<Customer_TypeDTO> list()
        {
            List<Customer_TypeDTO> dsEmpl = new List<Customer_TypeDTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = from em in db.CUSTOMER_TYPE
                            select em;
                foreach (var row in query)
                {
                    Customer_TypeDTO cg = new Customer_TypeDTO();
                    cg.Active = (Boolean)row.Active;
                    cg.Customer_Type_ID = row.Customer_Type_ID;
                    cg.Customer_Type_Name = row.Customer_Type_Name;
                    cg.Description = row.Description;
                    //empl.Active = (row.Active);
                    dsEmpl.Add(cg);
                }
                return dsEmpl;
            }
        }

        public static Customer_TypeDTO objectToDTO(object a)
        {
            return a as Customer_TypeDTO;
        }
    }
}
