using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProviderDTO
    {
        public string  Provider_ID { get; set; }
        public string ProviderName { get; set; }

        public string Customer_Group_ID { get; set; }
        public string ProviderAddress { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

    }
}
