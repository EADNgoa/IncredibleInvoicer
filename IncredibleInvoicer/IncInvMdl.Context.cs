﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IncredibleInvoicer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IncredibleInvoicerEntities : DbContext
    {
        public IncredibleInvoicerEntities()
            : base("name=IncredibleInvoicerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Tax> Taxes { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<InvYr> InvYrs { get; set; }
    }
}
