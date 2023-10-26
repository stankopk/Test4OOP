using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test4OOP
{
    public class Trainer
    {
        private IAnimal entity;
        private string name;

        public Trainer(string name, IAnimal entity)
        {
            this.Name = name;
            this.Entity = entity;
        }
        public string Name
        {
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can't be null or empty!");
                }

                name = value;
            }
            get { return name; }
        }

        public IAnimal Entity
        {
            get { return entity; }
            private set
            {
                entity = value;
            }
        }

        public void Work(IAnimal entity)
        {
            this.Entity = entity;
            Console.WriteLine($"Trainer {this.Name} works with {Entity}!");
        }

        public void Make()
        {
            this.Entity.Perform();
        }
    }
}
