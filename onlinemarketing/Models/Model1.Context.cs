﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace onlinemarketing.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class onlinemarketingEntities2 : DbContext
    {
        public onlinemarketingEntities2()
            : base("name=onlinemarketingEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<adminn> adminns { get; set; }
        public virtual DbSet<cateogory> cateogories { get; set; }
        public virtual DbSet<order_table> order_table { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<tbl_invoice> tbl_invoice { get; set; }
        public virtual DbSet<tbl_user> tbl_user { get; set; }
    }
}
