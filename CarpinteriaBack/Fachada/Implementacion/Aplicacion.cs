using CarpinteriaBack.Datos.Interfaces;
using CarpinteriaBack.Entidades;
using CarpinteriaBack.Datos.Implementaciones;
using CarpinteriaBack.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaBack.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {
        private IPresupuestoDao dao;
        public Aplicacion()
        {
            dao = new PresupuestoDao();
        }
        public List<Producto> GetProductos()
        {
            return dao.ObtenerProducto();
        }

        public bool SavePresupuesto(Presupuesto oPresupuesto)
        {
            return dao.Crear(oPresupuesto);
        }
    }
}
