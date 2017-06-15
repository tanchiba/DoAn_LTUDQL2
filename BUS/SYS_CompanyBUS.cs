using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SYS_CompanyBUS
    {
        public static List<SYS_CompanyDTO> getDS()
        {
            return DAO.SYS_CompanyDAO.GetDanhSach();
        }
    }
}
