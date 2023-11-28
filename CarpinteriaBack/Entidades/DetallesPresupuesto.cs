using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaBack.Entidades
{
    public class DetallesPresupuesto
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        public DetallesPresupuesto(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        public double CalcularSubTotal()
        {
            return Producto.Precio * Cantidad;
        }
    }
}
