
namespace AbilityScoreTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true) 
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Początkowy rzut 4d6");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Dzielone przez");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Dodawana wartość");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Obliczone punkty umiejętności: " + calculator.Score);
                Console.WriteLine("Wciśnij Q, aby zakończyć, lub inny klawisz żeby kontunować");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;

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
        private static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.Write($"{prompt} + [{lastUsedValue}]: ");
            if (double.TryParse(Console.ReadLine(), out double value) && (value != 0))
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
