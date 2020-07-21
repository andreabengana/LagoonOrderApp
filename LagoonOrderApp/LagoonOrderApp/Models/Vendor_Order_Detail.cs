using System;
using System.Collections.Generic;
using System.Text;

namespace LagoonOrderApp.Models
{
    public class Vendor_Order_Detail
    {
        public int ID_Order { get; set; }
        public Nullable<int> ID_StoreProduct { get; set; }
        public Nullable<int> CashAmount { get; set; }
        public Nullable<int> TotalAmount { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<System.DateTime> PickupTime { get; set; }
        public string Status { get; set; }
    }
}
