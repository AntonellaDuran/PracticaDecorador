using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaDecorador
{
    class ORDENPREMIUM : DECORADOR
    {
        public ORDENPREMIUM(ORDENBASE orden) : base(orden)
        {

        }
        public override double CalculoTotalPrecio()
        {

            Console.WriteLine("Calculo total del precio OrdenPremium");
            var preOrdenPrecio = base.CalculoTotalPrecio();
            return preOrdenPrecio * 0.9;
        }
    }
}