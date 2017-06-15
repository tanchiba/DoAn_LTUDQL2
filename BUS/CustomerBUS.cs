using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class CustomerBUS
    {
        public static CustomerDTO queryByID(string id)
        {
            return DAO.CustomerDAO.queryByID(id);
        }

        public static string MaKhachHang()
        {
            return DAO.CustomerDAO.MaKhachHang();
        }

        public static List<CustomerDTO> GetCustomer()
        {
            return DAO.CustomerDAO.GetCustomer();
        }
        public static void deleteByID(string id)
        {
            DAO.CustomerDAO.deleteByID(id);
        }
        public static void add(string id, string cgid, string customername, string customeraddress, string customertypeid, string email, string tel, bool active)
        {
            DAO.CustomerDAO.add(id, cgid, customername, customeraddress, customertypeid, email, tel, active);
        }
        public static void editByID(string id, string cgid, string customername, string customeraddress, string customertypeid, string email, string tel, bool active)
        {
            DAO.CustomerDAO.editByID(id, cgid, customername, customeraddress, customertypeid, email, tel, active);
        }
    }
}
