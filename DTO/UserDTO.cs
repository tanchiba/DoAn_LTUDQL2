using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        private int _User_ID;
        private string _UserName;
        private string _Password;
        private string _FullName;
        private string _Group_ID;
        private string _Description;
        private string _Active;

        public int User_ID
        {
            get
            {
                return _User_ID;
            }

            set
            {
                _User_ID = value;
            }
        }

        public string UserName
        {
            get
            {
                return _UserName;
            }

            set
            {
                _UserName = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
            }
        }

        public string FullName
        {
            get
            {
                return _FullName;
            }

            set
            {
                _FullName = value;
            }
        }

        public string Group_ID
        {
            get
            {
                return _Group_ID;
            }

            set
            {
                _Group_ID = value;
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

        public string Active
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
