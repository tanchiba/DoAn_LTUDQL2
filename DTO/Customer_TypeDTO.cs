using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer_TypeDTO
    {
        private string customer_Type_ID;
        private string customer_Type_Name;
        private string description;
        private bool active;

        public string Customer_Type_ID
        {
            get
            {
                return customer_Type_ID;
            }

            set
            {
                customer_Type_ID = value;
            }
        }

        public string Customer_Type_Name
        {
            get
            {
                return customer_Type_Name;
            }

            set
            {
                customer_Type_Name = value;
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
