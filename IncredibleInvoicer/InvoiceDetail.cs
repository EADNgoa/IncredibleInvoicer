//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class InvoiceDetail
    {
        public int InvoiceDetailID { get; set; }
        public Nullable<int> InvoiceID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<int> UnitID { get; set; }
        public Nullable<decimal> Rate { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Item Item { get; set; }
    }
}
