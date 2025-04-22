using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    public class Arrow : InventoryItem
    {
        public Arrow() : base(0.01, 0.05)
        { 
        }
    }
    public class Bow : InventoryItem
    {
        public Bow() : base(1, 4)
        {
        }
    }
    public class Rope : InventoryItem
    {
        public Rope() : base(1, 1.5)
        {
        }
    }
    public class Water : InventoryItem
    {
        public Water() : base(2, 3)
        {
        }
    }
    public class Food : InventoryItem
    {
        public Food() : base(1, 0.5)
        {
        }
    }
    public class Sword : InventoryItem
    {
        public Sword() : base(5, 3)
        {
        }
    }
}
