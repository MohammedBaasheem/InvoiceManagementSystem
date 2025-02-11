using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Core.DiscountStrategies
{
    internal interface ICustomerDiscountStrategy
    {
        double CalculateDiscount(double totalPrice);
    }
}   
