﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO.AppData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyBanHangEntities : DbContext
    {
        public QuanLyBanHangEntities()
            : base("name=QuanLyBanHangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CASH_METHOD> CASH_METHOD { get; set; }
        public virtual DbSet<CASH_TERM> CASH_TERM { get; set; }
        public virtual DbSet<CURRENCY> CURRENCies { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMERs { get; set; }
        public virtual DbSet<CUSTOMER_GROUP> CUSTOMER_GROUP { get; set; }
        public virtual DbSet<CUSTOMER_TYPE> CUSTOMER_TYPE { get; set; }
        public virtual DbSet<DEPARTMENT> DEPARTMENTs { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEEs { get; set; }
        public virtual DbSet<INVENTORY_ACTION> INVENTORY_ACTION { get; set; }
        public virtual DbSet<MESSAGE> MESSAGEs { get; set; }
        public virtual DbSet<PRODUCT> PRODUCTs { get; set; }
        public virtual DbSet<PRODUCT_GROUP> PRODUCT_GROUP { get; set; }
        public virtual DbSet<PROVIDER> PROVIDERs { get; set; }
        public virtual DbSet<REPORT> REPORTs { get; set; }
        public virtual DbSet<STOCK> STOCKs { get; set; }
        public virtual DbSet<SYS_COMPANY> SYS_COMPANY { get; set; }
        public virtual DbSet<SYS_GROUP> SYS_GROUP { get; set; }
        public virtual DbSet<SYS_LOG> SYS_LOG { get; set; }
        public virtual DbSet<SYS_OBJECT> SYS_OBJECT { get; set; }
        public virtual DbSet<SYS_RULE> SYS_RULE { get; set; }
        public virtual DbSet<SYS_USER> SYS_USER { get; set; }
        public virtual DbSet<SYS_USER_RULE> SYS_USER_RULE { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UNIT> UNITs { get; set; }
    }
}
