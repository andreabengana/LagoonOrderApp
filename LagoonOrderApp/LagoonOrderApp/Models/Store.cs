using System;
using System.Collections.Generic;
using System.Text;

namespace LagoonOrderApp.Models
{
    public class Store
    {
        public int ID_Store { get; set; }
        public string StoreName { get; set; }
        public string StoreLocation { get; set; }
        public string StoreDescription { get; set; }
        public string StoreAvailability { get; set; }
    }
}