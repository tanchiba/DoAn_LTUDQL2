using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SYS_CompanyDTO
    {
        private int _Company_ID;
        private string _CompanyName;
        private string _CompanyAddress;
        private string _Tel;
        private string _Fax;
        private string _Website;
        private string _Email;
        private string _Photo;

        public int Company_ID
        {
            get
            {
                return _Company_ID;
            }

            set
            {
                _Company_ID = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return _CompanyName;
            }

            set
            {
                _CompanyName = value;
            }
        }

        public string CompanyAddress
        {
            get
            {
                return _CompanyAddress;
            }

            set
            {
                _CompanyAddress = value;
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

        public string Fax
        {
            get
            {
                return _Fax;
            }

            set
            {
                _Fax = value;
            }
        }

        public string Website
        {
            get
            {
                return _Website;
            }

            set
            {
                _Website = value;
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

        public string Photo
        {
            get
            {
                return _Photo;
            }

            set
            {
                _Photo = value;
            }
        }
    }
}
