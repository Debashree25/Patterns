using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class StrategyPattern
    {
        IShippingStrategyFactory shippingStrategyFactory;

        public StrategyPattern(IShippingStrategyFactory shippingStrategyFactory)
        {
            this.shippingStrategyFactory = shippingStrategyFactory;
        }

        public int CalculatePrice()
        {
            var order = new Order()
            {
                OrderTotal = 3,
                ShippingMethod = "DHL",
                OrderWeight = 10,
                OrderZipCode = 123456
            };
            var strategy = shippingStrategyFactory.GetShippingStrategy(order);
            return strategy.CalculateShippingCost(order);
        }
    }
}
