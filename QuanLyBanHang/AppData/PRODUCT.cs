//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanHang.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCT
    {
        public string Product_ID { get; set; }
        public string ProductName { get; set; }
        public string Product_Type_ID { get; set; }
        public string Product_Group_ID { get; set; }
        public string Prorvider_ID { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> Org_Price { get; set; }
        public Nullable<decimal> Sale_Price { get; set; }
        public Nullable<decimal> Retail_Price { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> MinStock { get; set; }
        public Nullable<int> MaxStock { get; set; }
        public byte[] Photo { get; set; }
        public string Currency_ID { get; set; }
        public Nullable<int> User_ID { get; set; }
        public string Stock_ID { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual CURRENCY CURRENCY { get; set; }
        public virtual PRODUCT_GROUP PRODUCT_GROUP { get; set; }
        public virtual PROVIDER PROVIDER { get; set; }
        public virtual SYS_USER SYS_USER { get; set; }
        public virtual UNIT UNIT1 { get; set; }
    }
}
