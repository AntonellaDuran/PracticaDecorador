using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaDecorador
{
    public class ORDENREGULAR : ORDENBASE
    {
        public override double CalculoTotalPrecio()
        {
            Console.WriteLine(" Calculo del Precio total de un pedido normal");
            return productos.Sum(x => x.Precio);
        }
    }
}