using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SYS_USERDTO
    {
        private int user_ID;
        private string userName;
        private string passWord;
        private string fullName;
        private string group_ID;
        private string description;
        private bool active;

        public int User_ID
        {
            get
            {
                return user_ID;
            }

            set
            {
                user_ID = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string PassWord
        {
            get
            {
                return passWord;
            }

            set
            {
                passWord = value;
            }
        }

        public string FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                fullName = value;
            }
        }

        public string Group_ID
        {
            get
            {
                return group_ID;
            }

            set
            {
                group_ID = value;
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
