using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnsSloppySandwitches
{
    class MenuItem
    {

        public static Random Randomizer = new Random();
        public string[] Proteins = { "Wołowina", "Salami", "Indyk", "Szynka", "Pastrami", "Tofu" };
        public string[] Condiments = { "musztarda żółta", "musztarda brązowa", "musztarda midowa", "majonez", "sos francuski", "przyprawy" };
        public string[] Breads = { "ryżowe", "białe", "bułka", "pumpernikiel", "przenne" };
        public string Description = "";
        public string Price;


        public void GenerateMenu()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];

            Description = $"{randomProtein} i {randomCondiment}. Pieczywo: {randomBread}.";

            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = bucks + (cents * 0.01m);
            Price = $"{price.ToString()} zł.";

            
        }

    }
}
