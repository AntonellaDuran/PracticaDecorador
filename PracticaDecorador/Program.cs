using System;

namespace PracticaDecorador
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var OrdenRegular = new ORDENREGULAR();
            Console.WriteLine(OrdenRegular.CalculoTotalPrecio());
            Console.WriteLine();

            var preOrden = new PREORDEN();
            Console.WriteLine(preOrden.CalculoTotalPrecio());
            Console.WriteLine();

            var OrdenPremium = new ORDENPREMIUM(preOrden);
            Console.WriteLine(OrdenPremium.CalculoTotalPrecio());
            Console.WriteLine();
        }
    }
}