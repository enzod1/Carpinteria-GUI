using CarpinteriaBack.Datos.Interfaces;
using CarpinteriaBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaBack.Datos.Implementaciones
{
    public class PresupuestoDao : IPresupuestoDao
    {
        public List<Producto> ObtenerProducto()
        {
            List<Producto> lProductos = new List<Producto>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_PRODUCTOS");

            foreach (DataRow fila in tabla.Rows)
            {
                int nro = int.Parse(fila[0].ToString());
                string? nom = fila[1].ToString();
                double pre = double.Parse(fila[2].ToString());
                Producto p = new Producto(nro, nom, pre);
                lProductos.Add(p);
            }

            return lProductos;
        }

        public int ObtenerProximoNro()
        {
            return HelperDao.ObtenerInstancia().ConsultarEscalar("SP_PROXIMO_ID", "next");
        }

        public bool Crear(Presupuesto oPresupuesto)
        {
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            bool resultado = true;
            SqlTransaction? t = null;

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_MAESTRO";
                comando.Parameters.AddWithValue("@cliente", oPresupuesto.Cliente);
                comando.Parameters.AddWithValue("@dto", oPresupuesto.Descuento);
                comando.Parameters.AddWithValue("@total", oPresupuesto.CalcularTotal());
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@presupuesto_nro";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);
                comando.ExecuteNonQuery();

                int presupuestoNro = (int)parametro.Value;
                int detalleNro = 1;
                SqlCommand cmdDetalle;

                foreach (DetallesPresupuesto dp in oPresupuesto.Detalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@presupuesto_nro", presupuestoNro);
                    cmdDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("@id_producto", dp.Producto.Productonro);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", dp.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                    detalleNro++;
                }
                t.Commit();
            }
            catch
            {
                t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resultado;
        }

        public bool Actualizar(Presupuesto oPresupuesto)
        {
            throw new NotImplementedException();
        }

        public List<Presupuesto> ObtenerPresupuestoPorFiltro(DateTime desde, DateTime hasta, string cliente)
        {
            List<Presupuesto>lPresupuestos = new List<Presupuesto>();
            
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@fecha_desde", desde));
            lista.Add(new Parametro("@fecha_hasta", hasta));
            lista.Add(new Parametro("@cliente", cliente));
            
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_PRESUPUESTOS", lista);

            foreach (DataRow fila in tabla.Rows)
            {
                Presupuesto p = new Presupuesto();
                p.PresupuestoNro = int.Parse(fila[0].ToString());
                p.Fecha = DateTime.Parse(fila["fecha"].ToString());
                p.Cliente = fila["cliente"].ToString();
                p.Descuento = double.Parse(fila["descuento"].ToString());
                lPresupuestos.Add(p);
            }

            return lPresupuestos;
        }

        public Presupuesto ObtenerPresupuestoPorNro(int numero)
        {
            Presupuesto? oPresupuesto = null;

            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@presupuesto_nro", numero));

            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_DETALLES_PRESUPUESTO", lista);

            bool primero = true;
            foreach (DataRow fila in tabla.Rows)
            {
                oPresupuesto = new Presupuesto();
                if (primero)
                {
                    oPresupuesto.PresupuestoNro = int.Parse(fila[0].ToString());
                    oPresupuesto.Fecha = DateTime.Parse(fila["fecha"].ToString());
                    oPresupuesto.Cliente = fila["cliente"].ToString();
                    oPresupuesto.Descuento = double.Parse(fila["descuento"].ToString());
                    primero = false;
                }
                Producto pro = new Producto();
                pro.Productonro = int.Parse(fila["id_producto"].ToString());
                pro.Nombre = fila["n_producto"].ToString();
                pro.Precio = double.Parse(fila["precio"].ToString());

                int cantidad = int.Parse(fila["cantidad"].ToString());
                DetallesPresupuesto dp = new DetallesPresupuesto(pro, cantidad);
                oPresupuesto.AgregarDetalle(dp);
            }
            return oPresupuesto;
        }
    }
}
