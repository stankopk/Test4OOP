using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4OOP
{

    public interface IAnimal : IMakeNoise, IMakeTrick
    {
        string Type { get; }
        string Name { get; }
        void Perform();
    }
}
