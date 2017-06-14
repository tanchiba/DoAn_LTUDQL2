using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO.AppData;

namespace DAO
{
    public class DepartmentDAO
    {
        public static List<DepartmentDTO> GetDepartment()
        {
            List<DepartmentDTO> dsDep = new List<DepartmentDTO>();
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = from em in db.DEPARTMENTs
                            select em;
                foreach (var row in query)
                {
                    DepartmentDTO dep = new DepartmentDTO();
                    dep.Department_ID = row.Department_ID;
                    dep.DepartmentName = row.DepartmentName;
                    dep.Description = row.Description;
                    dep.Active = row.Active;

                    dsDep.Add(dep);
                }
                return dsDep;
            }
        }


        public static void InsertDepartment(string iddepartment, string namedepartment,string  description, bool active)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                DEPARTMENT dp = new DEPARTMENT();
                dp.Department_ID = iddepartment;
                dp.DepartmentName = namedepartment;
                dp.Description = description;
                dp.Active = active;

                db.DEPARTMENTs.Add(dp);
                db.SaveChanges();
            }
        }


        public static void UpdateDepartment(string iddepartment, string namedepartment, string description, bool active)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = (from dp in db.DEPARTMENTs
                             where dp.Department_ID == iddepartment
                             select dp).First();
                query.Department_ID = iddepartment;
                query.DepartmentName = namedepartment;
                query.Description = description;
                query.Active = active;

                db.SaveChanges();
            }
        }

        
        public static void DeleteDepartment(string iddepartment)
        {
            using (QuanLyBanHangEntities db = new QuanLyBanHangEntities())
            {
                var query = db.DEPARTMENTs.Single(a => a.Department_ID == iddepartment);
                db.DEPARTMENTs.Remove(query);
                db.SaveChanges();
            }
        }
    }
}
