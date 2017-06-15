using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public  class CUSTOMER_GROUPDTO
    {
        private string customer_Group_ID;
        private string customer_Group_Name;
        private string description;
        private bool active;

        public string Customer_Group_ID
        {
            get
            {
                return customer_Group_ID;
            }

            set
            {
                customer_Group_ID = value;
            }
        }

        public string Customer_Group_Name
        {
            get
            {
                return customer_Group_Name;
            }

            set
            {
                customer_Group_Name = value;
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
