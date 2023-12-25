using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuysGiveCashGame
{
    internal class Guy
    {
        public string Name;
        public int Cash;


        /// <summary>
        /// Wyświetla w konsoli imię i posiadanąkwotę.
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine($"{Name} ma {Cash} zł.");
        }



        /// <summary>
        /// Przekazuje pieniądze i usuwa je z portwela (lub wyświetla w konsoli komunikat o braku środków
        /// </summary>
        /// <param name="amount">Przekazywana kwota</param>
        /// <returns>Ilość pieniędzy wyjmowanych z portwela lub 0, jeśli dostępne środki są za małe. (lub parametr amount jest nieprawidłowy). </returns>


        public int GiveCash(int amount)
        {
            if (amount<=0)
            {
                Console.WriteLine($"{Name} mówi: {amount} nie jest poproawną kwotą.");
                return 0;
            }
            if (amount>Cash)
            {
                Console.WriteLine($"{Name} mówi: nie mam wystarczających środków aby dać Ci {amount} zł.");
                return 0;
            }
            Cash -= amount;
            return amount;
        }


        public void ReceiveCash (int amount)
        {
            if (amount<=0)
            {
                Console.WriteLine($"{Name} mówi: nie przyjmę {amount} zł.");
            }
            else
            {
                Cash += amount;
            }
        }




    }
}
