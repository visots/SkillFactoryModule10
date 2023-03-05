namespace FinalTask10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();

            Calculator calculator = new Calculator(logger);

            while (true)
            {
                Console.WriteLine("Введите значение Х");
                int x = calculator.ReadValue();
                Console.WriteLine("Введите значение Y");
                int y = calculator.ReadValue();

                Console.WriteLine("Результат: " + calculator.Sum(x, y) + "\n");
            }
        }
    }
}