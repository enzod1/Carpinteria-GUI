using CarpinteriaFront.Servicios.Interfaces;
using CarpinteriaBack.Datos;
using CarpinteriaBack.Datos.Implementaciones;
using CarpinteriaBack.Entidades;
using CarpinteriaBack.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaFront.Servicios.Implementaciones
{
    public class Servicio : IServicio
    {
        private IPresupuestoDao dao;
        public Servicio()
        {
            dao = new PresupuestoDao();
        }
        public bool GrabarPresupuesto(Presupuesto oPresupuesto)
        {
            return dao.Crear(oPresupuesto);
        }

        public bool ModificarPresupuesto(Presupuesto oPresupuesto)
        {
            return dao.Actualizar(oPresupuesto);
        }

        public List<Presupuesto> TraerPresupuestosFiltrados(DateTime desde, DateTime hasta, string cliente)
        {
            return dao.ObtenerPresupuestoPorFiltro(desde, hasta, cliente);
        }

        public List<Producto> TraerProductos()
        {
            return dao.ObtenerProducto();
        }

        public int TraerProximoNro()
        {
            return dao.ObtenerProximoNro();
        }
    }
}
