using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Alimento : Comida
    {

        public override int CuantoComiPorHora()
        {
            return 20;

        }
    }
}
