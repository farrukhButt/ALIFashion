//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace stockQuantity
{
    using System;
    using System.Collections.Generic;
    
    public partial class newItemStockTrack
    {
        public int id { get; set; }
        public string ItemCode { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<double> SaleQty { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<double> SalePrice { get; set; }
        public Nullable<int> ShopOut { get; set; }
        public Nullable<int> ShopIn { get; set; }
        public Nullable<double> SaleExchange { get; set; }
        public Nullable<double> ReturnToShop { get; set; }
        public Nullable<double> ReturnFromShop { get; set; }
        public Nullable<double> TotalReceived { get; set; }
        public Nullable<int> ShopCode { get; set; }
        public Nullable<double> StockQty { get; set; }
    }
}
