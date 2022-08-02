using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaDecorador
{
    public abstract class ORDENBASE
    {
        protected List<PRODUCTO> productos = new List<PRODUCTO>
{
   new PRODUCTO {Nombre= "Telefono", Precio= 800},
   new PRODUCTO {Nombre= "Tablet", Precio= 1000},
   new PRODUCTO {Nombre= "PC Gamer5", Precio= 1800},
};
        public abstract double CalculoTotalPrecio();
    }
}