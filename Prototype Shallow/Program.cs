using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Shallow
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Animal1 = new Animal() { Nombre = "Caballo sara", Patas = 4 };
            Animal animal2 = Animal1.Clone() as Animal;
            animal2.Patas = 5;
            Console.WriteLine(Animal1.Patas);
            Console.ReadLine();
        }
    }
}
