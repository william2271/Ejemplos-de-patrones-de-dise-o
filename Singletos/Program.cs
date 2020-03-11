using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletos
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Singleton.Instance.mensaje = "Ejemplo";
            Console.WriteLine(Singleton.Instance.mensaje);
            Console.ReadLine();
        }
    }
}
