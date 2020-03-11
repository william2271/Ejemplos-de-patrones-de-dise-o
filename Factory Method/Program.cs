using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Comida comida1 = Creador.CreadorAlimento(Creador.Manzana);
            Console.WriteLine(comida1.CuantoComiPorHora());

            Console.ReadLine();
        }
    }
}
