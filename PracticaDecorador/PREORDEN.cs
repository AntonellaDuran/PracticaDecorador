using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaDecorador
{
    public class PREORDEN : ORDENBASE
    {
        public override double CalculoTotalPrecio()
        {
            Console.WriteLine("Calculo del precio total en una PreOrden");
            return productos.Sum(x => x.Precio) * 0.9;
        }
    }
}