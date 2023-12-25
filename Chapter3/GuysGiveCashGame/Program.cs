namespace GuysGiveCashGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = .75;
            Guy player = new Guy() { Name = "Gracz", Cash = 100 };

            Console.WriteLine($"Witaj w kasynie. Prawdopodobieństwo przegranej: {odds}.");

            while (player.Cash>0)
            {
                player.WriteMyInfo();
                Console.Write("Stawiana kwota: ");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount)*2;
                    double number = random.NextDouble();
                    if (pot > 0)
                    {
                        if (number > odds)
                        {
                            player.ReceiveCash(pot);
                            Console.WriteLine($"Wygrałeś {pot}");
                        }
                        else
                        {
                            Console.WriteLine("Niestety przegrałeś.");
                        }
                    }

                }

            }
            Console.WriteLine("Niestety przegrałeś.\nKasyno zawsze wygrywa.");



        }
    }
}
