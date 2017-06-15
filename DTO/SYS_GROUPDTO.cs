using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SYS_GROUPDTO
    {
        private string group_id;
        private string groupname;
        private string description;
        private Boolean active;

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
