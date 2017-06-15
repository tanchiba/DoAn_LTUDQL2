using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class StockDTO
    {
        public string Stock_ID { get; set; }
        public string StockName { get; set; }
        public string StockAddress { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public string Manager_ID { get; set; }

    }
}
