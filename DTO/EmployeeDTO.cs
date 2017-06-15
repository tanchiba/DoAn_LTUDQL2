using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmployeeDTO
    {
        private string _Employee_ID;
        private string _EmployeeName;
        private string _EmployeeAddress;
        private string _Tel;
        private string _Email;
        private DateTime _BirthDay;
        private string _Position;
        private string _Department_ID;
        private string _Manager_ID;
        private string _Description;
        private bool _Active;

        public string Employee_ID
        {
            get
            {
                return _Employee_ID;
            }

            set
            {
                _Employee_ID = value;
            }
        }

        public string EmployeeName
        {
            get
            {
                return _EmployeeName;
            }

            set
            {
                _EmployeeName = value;
            }
        }

        public string EmployeeAddress
        {
            get
            {
                return _EmployeeAddress;
            }

            set
            {
                _EmployeeAddress = value;
            }
        }

        public string Tel
        {
            get
            {
                return _Tel;
            }

            set
            {
                _Tel = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public DateTime BirthDay
        {
            get
            {
                return _BirthDay;
            }

            set
            {
                _BirthDay = value;
            }
        }

        public string Position
        {
            get
            {
                return _Position;
            }

            set
            {
                _Position = value;
            }
        }

        public string Department_ID
        {
            get
            {
                return _Department_ID;
            }

            set
            {
                _Department_ID = value;
            }
        }

        public string Manager_ID
        {
            get
            {
                return _Manager_ID;
            }

            set
            {
                _Manager_ID = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }

            set
            {
                _Description = value;
            }
        }

        public bool  Active
        {
            get
            {
                return _Active;
            }

            set
            {
                _Active = value;
            }
        }
    }
}

