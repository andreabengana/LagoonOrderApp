using System;
using System.Collections.Generic;
using System.Text;

namespace LagoonOrderApp.Models
{
    public class Product_Feedback
    {
        public int ID_ProductFeedback { get; set; }
        public Nullable<int> ID_StoreProduct { get; set; }
        public string UserName { get; set; }
        public string ProductFeedback { get; set; }
    }
}
