﻿using System;
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

       
    }
}
