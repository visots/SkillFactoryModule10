﻿namespace Ex10._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Writer writer = new Writer();
            ((IWriter)writer).Write();
        }

        public class Writer : IWriter
        {
            void IWriter.Write()
            {
                Console.WriteLine("Write");
            }
        }

        public interface IWriter
        {
            void Write();
        }
    }
}