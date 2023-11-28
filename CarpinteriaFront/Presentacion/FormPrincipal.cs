using CarpinteriaFront.Presentacion;
using CarpinteriaFront.Servicios;
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
    public partial class FormPrincipal : Form
    {
        FabricaServicios fabrica = null;
        public FormPrincipal(FabricaServicios fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPresupuesto nuevo = new FormPresupuesto(fabrica);
            nuevo.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarPresupuestos consulta = new FrmConsultarPresupuestos(fabrica);
            consulta.ShowDialog();
        }
    }
}
