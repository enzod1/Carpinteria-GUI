using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaBack.Entidades
{
    public class Presupuesto
    {
        public int PresupuestoNro { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public double CostoMO { get; set; }
        public double Descuento { get; set; }
        public DateTime FechaBaja { get; set; }
        public List<DetallesPresupuesto> Detalles { get; set; }

        public Presupuesto()
        {
            Detalles = new List<DetallesPresupuesto>();
        }

        public void AgregarDetalle(DetallesPresupuesto detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int posicion)
        {
            Detalles.RemoveAt(posicion);
        }

        public double CalcularTotal()
        {
            double total = 0;

            foreach (DetallesPresupuesto detalle in Detalles)
            {
                total += detalle.CalcularSubTotal();
            }

            return total;
        }
    }
}
