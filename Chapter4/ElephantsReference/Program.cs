namespace ElephantsReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lucek = new Elephant() { Name = "Lucek", EarSize = 100};
            Elephant laura = new Elephant() { Name = "Laura", EarSize = 80};


            Console.WriteLine("Wciśnij 1 (Lucek), 2 (Laura) lub 3 (przestawienie):");

            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine($"Wcisnąłeś {input}.");
                if (input=='1')
                {
                    Console.WriteLine("Wywołanie lucek.WhoAmI().");
                    lucek.WhoAmI();
                }else if (input == '2')
                {
                    Console.WriteLine("Wywołanie laura.WhoAmI().");
                    laura.WhoAmI();
                }else if(input == '3')
                {
                    Elephant elephantHolder = lucek;
                    lucek = laura;
                    laura = elephantHolder;
                    Console.WriteLine("Referencje zostały przestawione");
                }
                else if (input=='4')
                {
                    lucek = laura;
                    lucek.EarSize = 4321;
                    lucek.WhoAmI();
                }
                else if (input=='5')
                {
                    laura.SpeakTo(lucek, "Cześć, lucku");
                }
                else
                {
                    Console.WriteLine("Zamknięcie programu");
                    break;
                }
            }

        }
    }
}
