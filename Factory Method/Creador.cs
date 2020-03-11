using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
   public class Creador
    {
        public const int Manzana = 1;
        public const int Pera = 2;

        public static Comida CreadorAlimento(int tipo)
        {
            switch (tipo)
            {
                case Manzana:
                    return new Manzana();
                case Pera:
                    return new Alimento();
                default: return null;
            }
        }
    }
}
