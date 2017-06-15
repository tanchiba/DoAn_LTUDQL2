using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDTO
    {
        public string Product_ID { get; set; }
        public string ProductName { get; set; }
        public string Product_Type_ID { get; set; }
        public string Product_Group_ID { get; set; }
        public string Provider_ID { get; set; }
        public string Unit { get; set; }
        public double Org_Price { get; set; }
        public double Sale_Price { get; set; }
        public double Retail_Price { get; set; }
        public int Quantity { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public byte[] image { get; set; }
        public string Currency_ID { get; set; }
        public int User_ID { get; set; }
        public string Stock_ID { get; set; }
        public bool Active { get; set; }
    }
}
