namespace FinalTask10_5
{
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Событие: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}