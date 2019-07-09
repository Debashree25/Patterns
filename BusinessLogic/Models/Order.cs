using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class Order
    {
       public string ShippingMethod { get; set; }
        public int OrderTotal { get; set; }
        public int OrderWeight { get; set; }
        public int OrderZipCode { get; set; }
    }
}
