namespace FinalTask10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Calculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("Введите значение Х");
                int x = ReadValue();
                Console.WriteLine("Введите значение Y");
                int y = ReadValue();

                Console.WriteLine("Результат: " + calculator.Sum(x, y));
                Console.ReadKey();
            }
        }

        static int ReadValue()
        {
            int value = 0;

            try
            {
                value = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка, введите числовое значение");
            }

            return value;
        }

    }

    public interface ISum
    {
        public int Sum(int x, int y);
    }

    public class Calculator : ISum
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}