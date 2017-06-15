using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CurrencyDTO
    {
        public string Currency_ID { get; set; }
        public string CurrencyName { get; set; }

        public Nullable<long> Exchange { get; set; }
        public bool? Active { get; set; }
    }
}
