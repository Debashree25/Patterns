using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Implementations
{
    public class DHLShippingStrategy : IShippingStrategy
    {
        public string SupportedShippingMethod = "DHL";

        string IShippingStrategy.SupportedShippingMethod
        {
            get
            { return this.SupportedShippingMethod; }
        }

        public int CalculateShippingCost(Order order)
        {
            if (order.OrderWeight > 5)
                return 10;
            else
                return 5;
        }
    }
}
