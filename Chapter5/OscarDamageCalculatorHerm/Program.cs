using System;
using System.Globalization;

namespace OscarDamageCalculatorHerm
{
    internal class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage(RollDice());

            while (true)
            {
                Console.Write($"0 - ani magiczny, ani płonący; 1 - magiczny; 2 - płonący; 3 - magiczny i płonący; inne wartości - koniec: ");
                char key = Console.ReadKey().KeyChar;
                if (key != '0' && key != '1' && key != '2' && key != '3') return;
                int roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                swordDamage.Roll = RollDice();
                swordDamage.Magic = (key == '1' || key == '3');
                swordDamage.Flaming = (key == '2' || key == '3');
                Console.WriteLine($"\nRzut: {swordDamage.Roll}, punkty obrażeń: {swordDamage.Damage}\n");
            }
        }

        private static int RollDice()
        {
            return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);

        }
    }
}
