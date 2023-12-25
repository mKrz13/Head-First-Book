
namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperatorExamples();
        }

        private static void OperatorExamples()
        {
            int width = 3;
            width++;

            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            string result = "Powierzchnia";
            result = result + " wynosi " + area;
            Console.WriteLine(result);

            bool truthValue = true;
            Console.WriteLine(truthValue);


            int someValue = 10;
            string message = "";

            if (someValue==24)
            {
                message = "Wartość wynosi 24!";
            }
            else
            {
                message = "Wartość nie wynosi 24";
            }

        }
    }
}
