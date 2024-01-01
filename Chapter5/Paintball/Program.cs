namespace Paintball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls = ReadInt(20, "Liczba kulek");
            int magazineSize = ReadInt(16, "Pojemność magazynka");
            Console.WriteLine($"Załadowany [false]: ");
            bool.TryParse(Console.ReadLine(), out bool isLoaded);



            PaintballGun gun = new PaintballGun(numberOfBalls, magazineSize, isLoaded);
            while (true)
            {
                Console.WriteLine($"Kulki : {gun.Balls}, załadowano: {gun.BallsLoaded}");
                if (gun.IsEmpty()) Console.WriteLine("Brak amunicji");
                Console.WriteLine("Spacja - strzał, p - przeładowanie, + - dodaj amunicję, k - koniec");
                char key = Console.ReadKey(true).KeyChar;
                if (key == ' ') Console.WriteLine($"Próba strzału: {gun.Shoot()}");
                else if (key == 'p') gun.Reload();
                else if (key == '+') gun.Balls += gun.MagazineSize;
                else if (key == 'k') return;

            }
        }

        private static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write($"{prompt} + [{lastUsedValue}]: ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                Console.WriteLine($"\t użycie wartości {value}");
                return value;
            }
            else
            {
                Console.WriteLine($"\t użycie wartości domyślnej {lastUsedValue}");
                return lastUsedValue;
            }
        }
    }
}
