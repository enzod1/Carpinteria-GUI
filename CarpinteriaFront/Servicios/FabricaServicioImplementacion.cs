using CarpinteriaFront.Servicios.Implementaciones;
using CarpinteriaFront.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaFront.Servicios
{
    public class FabricaServicioImplementacion : FabricaServicios
    {
        public override IServicio CrearServicio()
        {
            return new Servicio();
        }
    }
}
