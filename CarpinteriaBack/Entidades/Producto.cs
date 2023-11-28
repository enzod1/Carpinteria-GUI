using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaBack.Entidades
{
    public class Producto
    {
        public int Productonro { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public bool Activo { get; set; }

        public Producto()
        {

        }
        public Producto(int productonro, string nombre, double precio)
        {
            Productonro = productonro;
            Nombre = nombre;
            Precio = precio;
            Activo = true;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
