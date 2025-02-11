using StrategyDesignPattern.Core;
using StrategyDesignPattern.Core.DiscountStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    internal class CustomerDiscountStrategyFactory
    {
        public ICustomerDiscountStrategy CreatCustomerDiscountStrategy(CustomerCategory category)
        {
            if (category == CustomerCategory.Gold)
            {
                return  new GoldCustomerDiscountStrategy();
            }
            else if (category == CustomerCategory.Silver)
            {
                return new SilverCustomerDiscountStrategy();
            }
            return new NullDiscountStrategy();
        }
    }
}
