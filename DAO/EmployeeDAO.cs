
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
                    empl.Active = (Boolean)row.Active;
                    dsEmpl.Add(empl);
                }
                return dsEmpl;
            }
        }

        public static string MaNhanVien()
        {
            string MaNhanVien;
            var db = new QuanLyBanHangEntities();
            MaNhanVien = db.EMPLOYEEs.OrderByDescending(dv => dv.Employee_ID).FirstOrDefault().Employee_ID;
            if (MaNhanVien != null)
            {
                MaNhanVien = XuLyChuoi.LayChuoi(MaNhanVien);
            }
            return MaNhanVien;
        }

        public static void InsertEmployee(string employee, string employName, string employeeAddress, string tel, string email, DateTime birthday, string position, string department, string manager, bool active)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                EMPLOYEE empl = new EMPLOYEE();
                empl.Employee_ID = employee;
                empl.EmployeeName = employName;
                empl.EmployeeAddress = employeeAddress;
                empl.Tel = tel;
                empl.Email = email;
                empl.Birthday = birthday;
                empl.Position = position;
                empl.Department_ID = department;
                empl.Manager_ID = manager;
                empl.Active = active;

                
                db.EMPLOYEEs.Add(empl);
                db.SaveChanges();
            }
        }


        public static void UpdateEmployee(string employee, string employName, string employeeAddress, string tel, string email, DateTime birthday, string position, string department, string manager, bool active)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = (from emp in db.EMPLOYEEs
                             where emp.Employee_ID == employee
                             select emp).First();
                query.Employee_ID = employee;
                query.EmployeeName = employName;
                query.EmployeeAddress = employeeAddress;
                query.Tel = tel;
                query.Email = email;
                query.Birthday = birthday;
                query.Position = position;
                query.Department_ID = department;
                query.Manager_ID = manager;
                query.Active = active;

                db.SaveChanges();
            }
        }

        public static void GetDataForm(string id_employee)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                //var query = (from emp in db.EMPLOYEEs
                //             where emp.Employee_ID == id_employee
                //             select emp).First();
                var query = db.EMPLOYEEs.Single(a => a.Employee_ID == id_employee);
                //id_employee = query.Employee_ID;
                //employName = query.EmployeeName;
                //employeeAddress = query.EmployeeAddress;
                //tel = query.Tel;
                //email = query.Email;
                ////birthday = Convert.ToDateTime(query.Birthday);
                //position = query.Position;
                //department = query.Department_ID;
                //manager = query.Manager_ID;
                //active = Convert.ToBoolean(query.Active);
            }
        }

        public static void DeleteEmployee(string employee_ID)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = db.EMPLOYEEs.Single(a => a.Employee_ID == employee_ID);
                db.EMPLOYEEs.Remove(query);
                db.SaveChanges();
            }
        }
    }
}
