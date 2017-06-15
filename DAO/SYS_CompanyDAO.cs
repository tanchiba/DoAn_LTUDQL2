using DAO.AppData;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SYS_CompanyDAO
    {
        public static List<SYS_CompanyDTO> GetDanhSach()
        {
            List<SYS_CompanyDTO> thlh = new List<SYS_CompanyDTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var q = from f in db.SYS_COMPANY
                        select f;
                foreach (var row in q)
                {
                    SYS_CompanyDTO tt = new SYS_CompanyDTO();
                    tt.CompanyName = row.CompanyName;
                    tt.CompanyAddress = row.CompanyAddress;
                    tt.Tel = row.Tel;
                    tt.Fax = row.Fax;
                    tt.Website = row.Website;
                    tt.Email = row.Email;

                    thlh.Add(tt);

                }
                return thlh;
            }
        }
    }
}
