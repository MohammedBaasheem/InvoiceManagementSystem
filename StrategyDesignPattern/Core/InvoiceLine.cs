﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Core
{
    internal class InvoiceLine
    {
        public int ItemId { get; set; } 
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
    }
}
