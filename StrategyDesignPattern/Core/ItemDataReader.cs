﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Core
{
    internal class ItemDataReader
    {
        public IEnumerable<Item> GetItems()
        {
            return new[]
            {
                new Item { Id = 1, Name = "Laptop", UnitPrice = 10000 },
                new Item { Id = 2, Name = "LCD", UnitPrice = 2000 },
                new Item { Id = 3, Name = "Keyboard", UnitPrice = 150 },
                new Item { Id = 3, Name = "Mouse", UnitPrice = 100 },
            };
        }
    }
}
