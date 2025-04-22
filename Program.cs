namespace PackingInventory
{
    class Program {
        static void Main(string[] args) {
            int maxItems = GetMaxItems();
            double maxWeight = GetMaxWeight();
            double maxVolume = GetMaxVolume();

            Pack pack = new(maxItems, maxWeight, maxVolume);
        }

        private static int GetMaxItems()
        {
            int maxItems = -1;
            bool success = false;
            while (!success)
            {
                Console.WriteLine("How many items will the pack be able to store? ");
                string maxItemsAsString = Console.ReadLine();
                success = int.TryParse(maxItemsAsString, out maxItems);
            }
            return maxItems;
        }

        private static double GetMaxWeight()
        {
            double maxWeight = -1;
            bool success = false;
            while (!success)
            {
                Console.WriteLine("How much weight will the bag be able to carry? ");
                string maxWeightAsString = Console.ReadLine();
                success = double.TryParse(maxWeightAsString, out maxWeight);
            }
            return maxWeight;
        }
        
        private static double GetMaxVolume()
        {
            double maxVolume = -1;
            bool success = false;
            while (!success)
            {
                Console.WriteLine("How much volume will the bag be able to carry? ");
                string maxVolumeAsString = Console.ReadLine();
                success = double.TryParse(maxVolumeAsString, out maxVolume);
            }
            return maxVolume;
        }
    }
}
