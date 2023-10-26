using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                Animal animal = CreateAnimal(line);
                animals.Add(animal);
            }

            string trainerName = Console.ReadLine();
            Trainer trainer = null;
            string name = Console.ReadLine();

            while (name != "End")
            {
                Animal current = animals.Where(a => a.Name.Equals(name)).FirstOrDefault();

                if (current == null)
                {
                    Console.WriteLine("No such name in the Database!");
                }
                else
                {
                    if (trainer == null)
                    {
                        trainer = new Trainer(trainerName, current);
                    }

                    trainer.Work(current);
                    trainer.Make();
                }

                name = Console.ReadLine();
            }
        }

        private static Animal CreateAnimal(string[] line)
        {
            Animal animal = null;
            switch (line[0])
            {
                case "Cat":
                    animal = new Cat(line[1]);
                    break;

                case "Dog":
                    animal = new Dog(line[1]);
                    break;
            }

            return animal;
        }
    }
}