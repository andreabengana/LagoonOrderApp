using System;
using System.Collections.Generic;
using System.Text;

namespace LagoonOrderApp.Models
{
    public class Product
    {
        public int ID_Product { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<System.DateTime> PreparationTime { get; set; }
        public string ProductType { get; set; }
        public string ProductDescription { get; set; }
    }
}
