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

        public static void InsertEmployee(string iddepartment, string namedepartment, string description, bool active)
        {
            DAO.DepartmentDAO.InsertDepartment(iddepartment, namedepartment, description, active);
        }

        public static void UpdateEmployee(string iddepartment, string namedepartment, string description, bool active)
        {
            DAO.DepartmentDAO.UpdateDepartment(iddepartment, namedepartment, description, active);
        }

        

        public static void DeleteEmployee(string iddepartment)
        {
            DAO.DepartmentDAO.DeleteDepartment(iddepartment);
        }
    }
}
