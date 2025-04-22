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
        public Pack() 
        {
            int[] pack = new int[3];

            GetItemAmount(pack);
            GetItemWeight(pack);
            GetItemVolume(pack);

        }

        private void GetItemAmount(int[] pack)
        {
            while (true)
            {
                Console.WriteLine("How many items will the pack be able to store? ");
                string trypack = Console.ReadLine();
                int.TryParse(trypack, out pack[0]);
                continue;

            }
        }

        private void GetItemWeight(int[] pack)
        {
            while (true)
            {
                Console.WriteLine("How much weight will the bag be able to carry? ");
                string trypack = Console.ReadLine();
                int.TryParse(trypack, out pack[1]);
                continue;

            }
        }
        private void GetItemVolume(int[] pack)
        {
            while (true)
            {
                Console.WriteLine("How much volume will the bag be able to carry? ");
                string trypack = Console.ReadLine();
                int.TryParse(trypack, out pack[2]);
                continue;

            }
        }

    }
}
