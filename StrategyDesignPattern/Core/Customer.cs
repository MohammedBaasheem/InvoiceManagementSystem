﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Core
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CustomerCategory category { get; set; }  
    }
}
