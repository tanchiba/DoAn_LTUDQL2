using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class EmployeeBUS
    {
        public static List<EmployeeDTO> getEmployee()
        {
            return DAO.EmployeeDAO.GetEmployee();
        }
        public static string MaNhanVien()
        {
            return DAO.EmployeeDAO.MaNhanVien();
        }


        public static void InsertEmployee(string employee, string employName, string employeeAddress, string tel, string email, DateTime birthday, string position, string department, string manager, bool active)
        {
            DAO.EmployeeDAO.InsertEmployee(employee, employName, employeeAddress, tel, email, birthday, position, department, manager, active);
        }

        public static void UpdateEmployee(string employee, string employName, string employeeAddress, string tel, string email, DateTime birthday, string position, string department, string manager, bool active)
        {
            DAO.EmployeeDAO.UpdateEmployee(employee, employName, employeeAddress, tel, email, birthday, position, department, manager, active);
        }

        public static void GetFromData(string employee)
        {
            DAO.EmployeeDAO.GetDataForm(employee);
        }

        public static void DeleteEmployee(string employeeid)
        {
            DAO.EmployeeDAO.DeleteEmployee(employeeid);
        }
    }
}
