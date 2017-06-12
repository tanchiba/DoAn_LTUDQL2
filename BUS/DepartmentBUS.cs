using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DepartmentBUS
    {
        public static List<DepartmentDTO> getDepartment()
        {
            return DAO.DepartmentDAO.GetDepartment();
        }
    }
}
