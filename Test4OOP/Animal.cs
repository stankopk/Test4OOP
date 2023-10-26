using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4OOP
{
    abstract class Animal : IAnimal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can't be null or empty!");
                }

                name = value;
            }
        }

        protected Animal(string name)
        {
            Name = name;
        }

        public string Type { get; }

        public void Perform()
        {
            Console.WriteLine($">>> {this.MakeNoise()}");
            Console.WriteLine($">>> {this.MakeTrick()}");
        }

        public abstract string MakeTrick();
        public abstract string MakeNoise();

        public override string ToString()
        {
            return Type + " " + Name;
        }
    }
}
