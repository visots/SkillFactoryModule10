﻿namespace Ex10_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entity entity = new Entity();

            entity.Create();
            entity.Update();
        }

        public class Entity : ICreatable, IDeletable, IUpdatable
        {
            public void Create()
            {
                throw new NotImplementedException();
            }

            public void Delete()
            {
                throw new NotImplementedException();
            }

            public void Update()
            {
                throw new NotImplementedException();
            }
        }

        public interface ICreatable
        {
            void Create();
        }

        public interface IDeletable
        {
            void Delete();
        }

        public interface IUpdatable
        {
            void Update();
        }
    }
}