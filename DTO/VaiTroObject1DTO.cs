using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VaiTroObject1DTO
    {
        private string groupname;
        private string username;
        private string group_id;
        private string description;
        private Boolean active;

        public string Groupname
        {
            get
            {
                return groupname;
            }

            set
            {
                groupname = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Group_id
        {
            get
            {
                return group_id;
            }

            set
            {
                group_id = value;
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
