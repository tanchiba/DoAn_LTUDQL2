using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class CustomerDTO
    {
        private string customer_ID;
        private string customerName;
        private string customer_Type_ID;
        private string customer_Group_ID;
        private string customerAdress;
        private string tel;
        private string email;
        bool active;

        public string Customer_ID
        {
            get
            {
                return customer_ID;
            }

            set
            {
                customer_ID = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

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

        public string CustomerAdress
        {
            get
            {
                return customerAdress;
            }

            set
            {
                customerAdress = value;
            }
        }

        public string Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
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
