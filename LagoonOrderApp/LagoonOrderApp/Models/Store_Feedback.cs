using System;
using System.Collections.Generic;
using System.Text;

namespace LagoonOrderApp.Models
{
    public class Store_Feedback
    {
        public int ID_StoreFeedback { get; set; }
        public Nullable<int> ID_Store { get; set; }
        public string UserName { get; set; }
        public string StoreFeedback { get; set; }
    }
}
