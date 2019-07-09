using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface IShippingStrategy
    {
        string SupportedShippingMethod { get; }
        int CalculateShippingCost(Order order);
    }
}
