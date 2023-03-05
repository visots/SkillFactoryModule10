namespace FinalTask10_5
{
    public class Calculator : ISum
    {
        ILogger Logger { get; set; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        public int Sum(int x, int y)
        {
            Logger.Event($"Введены значения X={x}, Y={y}");
            return x + y;
        }

        public int ReadValue()
        {
            int value = 0;

            try
            {
                value = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Logger.Error("Ошибка, введите числовое значение");
            }

            return value;
        }
    }
}