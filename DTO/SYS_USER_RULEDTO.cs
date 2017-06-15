using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SYS_USER_RULEDTO
    {
        private string groupid;
        private int objectid;
        private string ruleid;
        private bool add;
        private bool delete;
        private bool edit;
        private bool access;
        private bool print;
        private bool export;
        private bool import;
        private bool active;

        public string Groupid
        {
            get
            {
                return groupid;
            }

            set
            {
                groupid = value;
            }
        }

        public int Objectid
        {
            get
            {
                return objectid;
            }

            set
            {
                objectid = value;
            }
        }

        public string Ruleid
        {
            get
            {
                return ruleid;
            }

            set
            {
                ruleid = value;
            }
        }

        public bool Delete
        {
            get
            {
                return delete;
            }

            set
            {
                delete = value;
            }
        }

        public bool Add
        {
            get
            {
                return add;
            }

            set
            {
                add = value;
            }
        }

        public bool Edit
        {
            get
            {
                return edit;
            }

            set
            {
                edit = value;
            }
        }

        public bool Access
        {
            get
            {
                return access;
            }

            set
            {
                access = value;
            }
        }

        public bool Print
        {
            get
            {
                return print;
            }

            set
            {
                print = value;
            }
        }

        public bool Export
        {
            get
            {
                return export;
            }

            set
            {
                export = value;
            }
        }

        public bool Import
        {
            get
            {
                return import;
            }

            set
            {
                import = value;
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
