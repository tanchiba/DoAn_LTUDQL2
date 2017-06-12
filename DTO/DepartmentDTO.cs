using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DepartmentDTO
    {
        private string department_ID;
        private string departmentName;
        private string description;
        private Boolean active;

        public string Department_ID
        {
            get
            {
                return department_ID;
            }

            set
            {
                department_ID = value;
            }
        }

        public string DepartmentName
        {
            get
            {
                return departmentName;
            }

            set
            {
                departmentName = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public bool Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
            }
        }
    }
}
