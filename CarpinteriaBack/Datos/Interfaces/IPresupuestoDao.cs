using CarpinteriaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaBack.Datos.Interfaces
{
    public interface IPresupuestoDao
    {
        int ObtenerProximoNro();
        List<Producto> ObtenerProducto();
        bool Crear(Presupuesto oPresupuesto);
        bool Actualizar(Presupuesto oPresupuesto);
        List<Presupuesto> ObtenerPresupuestoPorFiltro(DateTime desde, DateTime hasta, string cliente);
        Presupuesto ObtenerPresupuestoPorNro(int numero);
    }
}
