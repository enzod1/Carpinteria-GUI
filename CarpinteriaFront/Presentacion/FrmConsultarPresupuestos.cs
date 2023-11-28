using CarpinteriaBack.Entidades;
using CarpinteriaFront.Servicios;
using CarpinteriaFront.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpinteriaFront.Presentacion
{
    public partial class FrmConsultarPresupuestos : Form
    {
        IServicio servicio = null;
        public FrmConsultarPresupuestos(FabricaServicios fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_presupuestos.CurrentCell.ColumnIndex == 4)
            {
                //int nro = int.Parse(dgv_presupuestos.CurrentRow.Cells["col_numero"].Value.ToString());
                int nro = Convert.ToInt32(dgv_presupuestos.CurrentRow.Cells["col_numero"].Value.ToString());
                FrmDetallePresupuesto detalle = new FrmDetallePresupuesto(nro);
                detalle.ShowDialog();
            }
        }

        private void FrmConsultarPresupuestos_Load(object sender, EventArgs e)
        {
            dtp_desde.Value = DateTime.Now.AddDays(-7);
            dtp_hasta.Value = DateTime.Now;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            //validar datos de entrada

            //List<Parametro> lista = new List<Parametro>();
            //lista.Add(new Parametro("@fecha_desde", dtp_desde.Value.ToString("yyyy/MM/dd")));
            //lista.Add(new Parametro("@fecha_hasta", dtp_hasta.Value.ToString("yyyy/MM/dd")));
            //lista.Add(new Parametro("@cliente", txt_cliente.Text));

            List<Presupuesto> lPresupuestos = servicio.TraerPresupuestosFiltrados(dtp_desde.Value, dtp_hasta.Value, txt_cliente.Text);
            dgv_presupuestos.Rows.Clear();
            foreach (Presupuesto p in lPresupuestos)
            {
                dgv_presupuestos.Rows.Add(new object[] { p.PresupuestoNro,
                                                         p.Fecha,
                                                         p.Cliente,
                                                         p.CalcularTotal(), });
            }

            //DataTable tabla = new DBhelper().Consultar("SP_CONSULTAR_PRESUPUESTOS", lista);
            //dgv_presupuestos.Rows.Clear();
            //foreach (DataRow fila in tabla.Rows)
            //{
            //    dgv_presupuestos.Rows.Add(new object[] {fila["presupuesto_nro"].ToString(),
            //                                            ((DateTime)fila["fecha"]).ToShortDateString(),
            //                                            fila["cliente"].ToString(),
            //                                            fila["total"].ToString()
            //    });
            //}
        }

        private void dtp_desde_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
