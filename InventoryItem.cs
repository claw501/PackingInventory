﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    public class InventoryItem
    {
        public double Weight { get; }
        public double Volume { get; }
        public InventoryItem(double weight, double volume) 
        {
            Weight = weight;
            Volume = volume;
        }
    }
}
