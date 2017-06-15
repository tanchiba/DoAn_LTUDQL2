
using DAO.AppData;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EmployeeDAO
    {
        public static List<EmployeeDTO> GetEmployee()
        {
            List<EmployeeDTO> dsEmpl = new List<EmployeeDTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = from em in db.EMPLOYEEs
                            select em;
                foreach (var row in query)
                {
                    EmployeeDTO empl = new EmployeeDTO();
                    empl.Employee_ID = row.Employee_ID;
                    empl.EmployeeName = row.EmployeeName;
                    empl.EmployeeAddress = row.EmployeeAddress;
                    empl.Tel = row.Tel;
                    empl.Email = row.Email;
                    //empl.Active = (row.Active);
                    dsEmpl.Add(empl);
                }
                return dsEmpl;
            }
        }
    }
}
