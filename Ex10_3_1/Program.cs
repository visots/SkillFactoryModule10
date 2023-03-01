namespace Ex10_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IWriter writer = new FileManager();
            IReader reader = new FileManager();
            IMailer mailer = new FileManager();

            writer.Write();
            reader.Read();
            mailer.Mail();
        }
    }

    public class FileManager : IWriter, IReader, IMailer
    {
        void IMailer.Mail()
        {
            Console.WriteLine("Mail");
        }

        void IReader.Read()
        {
            Console.WriteLine("Read");
        }

        void IWriter.Write()
        {
            Console.WriteLine("Write");
        }
    }

    public interface IWriter
    {
        void Write();
    }

    public interface IReader
    {
        void Read();
    }

    public interface IMailer
    {
        void Mail();
    }
}