using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    public class Pack
    {
        public InventoryItem[] Items { get; }
        public double MaxWeight { get; }
        public double MaxVolume { get; }
        public Pack(int itemCount, double maxWeight, double maxVolume) 
        {
            Items = new InventoryItem[itemCount];
            this.MaxWeight = maxWeight;
            this.MaxVolume = maxVolume;
        }

        public bool add(InventoryItem item) {
            //if too heavy
            return false;
            //if too large
            return false;
            //if too many items
            return false;
            //else add item
            return true;
        }
    }
}
