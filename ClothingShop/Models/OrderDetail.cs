//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClothingShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int ID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> IDOrder { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
    
        public virtual DonHang DonHang { get; set; }
        public virtual Product Product { get; set; }
    }
}
