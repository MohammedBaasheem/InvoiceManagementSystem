using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Core
{
    internal class Invoice
    {
        public Customer Customer { get; set; }
        public IEnumerable<InvoiceLine> Lines { get; set; }
        public double Taxes { get; set; }
        public double TotalPrice => Lines.Sum(l => l.Quantity * l.UnitPrice);
        public double DiscounPrecentage { get; set; }
        public double NetPrice => TotalPrice + Taxes - TotalPrice * DiscounPrecentage;
    }
}
