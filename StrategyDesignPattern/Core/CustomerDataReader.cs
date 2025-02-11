using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Core
{
    internal class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new[]
            {
                new Customer { Id = 1, Name = "Mohammed Baasheem" ,category=CustomerCategory.Gold},
                new Customer { Id = 2, Name = "Ali Bamatrf" ,category=CustomerCategory.Silver},
                new Customer { Id = 3, Name = "Omer saleh" ,category=CustomerCategory.None}
            };
        }

    }
}
