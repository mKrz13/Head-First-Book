namespace OscarDamageCalculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage();
            Random random = new Random();

            while (true)
            {
                Console.Write($"0 - ani magiczny, ani płonący; 1 - magiczny; 2 - płonący; 3 - magiczny i płonący; inne wartości - koniec: ");
                char key = Console.ReadKey().KeyChar;
                if (key != '0' && key != '1' && key != '2' && key != '3') return;
                int roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                swordDamage.Roll = roll;
                swordDamage.SetMagic(key == '1' || key == '3');
                swordDamage.SetFlaming(key == '2' || key == '3');

                Console.WriteLine($"\nRzut: {roll}, punkty obrażeń: {swordDamage.Damage}\n");


                /*
                if (pressedKey == '0')
                {
                    swordDamage.SetMagic(false);
                }
                else if (pressedKey == '1')
                {
                    swordDamage.SetMagic(true);
                }
                else if (pressedKey == '2')
                {
                    swordDamage.SetMagic(false);
                }
                else if (pressedKey == '3')
                {
                    swordDamage.SetMagic(true);
                }
                else
                {
                    return;
                }*/
            }

        }
    }
}
