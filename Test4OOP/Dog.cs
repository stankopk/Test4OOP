using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4OOP
{
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            Name = name;
        }

        public override string MakeNoise()
        {
            return "Woof!";
        }

        public override string MakeTrick()
        {
            return "Hold my paw, human!";
        }
    }
}
