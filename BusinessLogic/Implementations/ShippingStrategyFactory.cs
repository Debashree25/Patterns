using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Implementations
{
    public class ShippingStrategyFactory : IShippingStrategyFactory
    {
        private readonly IEnumerable<IShippingStrategy> availableStrategies;

        public ShippingStrategyFactory(IEnumerable<IShippingStrategy> availableStrategies)
        {
            this.availableStrategies = availableStrategies;
        }

        public IShippingStrategy GetShippingStrategy(Order order)
        {
            var supportedStrategy = availableStrategies.Where(x => x.SupportedShippingMethod == order.ShippingMethod).FirstOrDefault();
            if(availableStrategies==null)
            {
                throw new InvalidOperationException("No Supported Strategy found");
            }
            return supportedStrategy;
        }
    }
}
