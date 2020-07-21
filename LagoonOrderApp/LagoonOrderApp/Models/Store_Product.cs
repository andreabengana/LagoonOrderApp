using System;
using System.Collections.Generic;
using System.Text;

namespace LagoonOrderApp.Models
{
    public class Store_Product
    {
        public int ID_StoreProduct { get; set; }
        public Nullable<int> ID_Store { get; set; }
        public Nullable<int> ID_Product { get; set; }
    }
}
