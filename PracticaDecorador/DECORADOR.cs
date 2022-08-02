using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaDecorador
{
    class DECORADOR : ORDENBASE
    {
        protected ORDENBASE orden;
        public DECORADOR(ORDENBASE orden)
        {
            this.orden = orden;
        }
        public override double CalculoTotalPrecio()
        {
            Console.WriteLine("CALCULO DEL PRECIO TOTAL DESDE LA CLASER DECORADOR");
            return orden.CalculoTotalPrecio();
        }
    }
}