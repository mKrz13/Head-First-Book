using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HiLo
{
    internal static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();
        private static int currentNumber = random.Next(1, MAXIMUM + 1);
        private static int pot = 10;





        internal static int GetPot()
        {
            return pot;
        }

        internal static void Guess(bool higher)
        {
            int nextNumber = random.Next(1, MAXIMUM + 1);
            if ((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber)) { Console.WriteLine("Zgadłeś!"); pot++; }
            else { Console.WriteLine("Niestety, błędna odpowiedź"); pot--; }
            currentNumber = nextNumber;
            Console.WriteLine($"Aktualna wartość to: {currentNumber}.");
        }

        internal static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber>=half) Console.WriteLine($"Liczba wynosi co najmniej: {half}.");
            else Console.WriteLine($"Liczba jest mniejsza niż: {half}.");
            pot--;

        }
    }
}
