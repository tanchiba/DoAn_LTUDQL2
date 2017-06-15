using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class ProviderBUS
    {
        public static List<ProviderDTO> list()
        { return DAO.ProviderDao.list(); }
        public static ProviderDTO objectToDTO(object a)
        {
            return a as ProviderDTO;
        }


        public static string MaNhaCungCap()
        {
            return DAO.ProviderDao.MaNhaCungCap();
        }

        public static void InsertProvider(string providerID, string providerName, string customer_Group_ID, string providerAddress, string tel, string email, string description, bool active)
        {
            DAO.ProviderDao.InsertProvider(providerID, providerName, customer_Group_ID, providerAddress, tel, email, description, active);
        }

        public static void DeleteProvider(string Provider_ID)
        {
            DAO.ProviderDao.DeleteProvider(Provider_ID);
        }

        public static void UpdateProvider(string providerID, string providerName, string Customer_Group_ID, string ProviderAddress,
           string Tel, string Email, string Descripsion, bool Active)
        {
            DAO.ProviderDao.UpdateProvider(providerID, providerName, Customer_Group_ID, ProviderAddress, Tel, Email, Descripsion, Active);
        }
    }
}
