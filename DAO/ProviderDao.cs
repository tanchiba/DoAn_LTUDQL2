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
    }
}
