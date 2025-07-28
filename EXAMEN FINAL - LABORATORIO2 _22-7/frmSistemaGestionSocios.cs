using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_FINAL___LABORATORIO_2
{
    public partial class frmSistemaGestionSocios : Form
    {
        public frmSistemaGestionSocios()
        {
            InitializeComponent();
        }

        private void frmSistemaGestionSocios_Load(object sender, EventArgs e)
        {
            btnRestaurar.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarNuevoSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarNuevoSocio ventana = new frmAgregarNuevoSocio();
            ventana.ShowDialog();
        }

        private void buscarSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarSocio ventana = new frmBuscarSocio();
            ventana.ShowDialog();
        }

        private void consultaDeSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaSocio ventana = new frmConsultaSocio();
            ventana.ShowDialog();
        }

        private void listadoTotalSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoTotalSocios ventana = new frmListadoTotalSocios();
            ventana.ShowDialog();
        }

        private void listadoSociosDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSociosDeudores ventana = new frmListadoSociosDeudores();
            ventana.ShowDialog();
        }

        private void listadoSociosPorActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSocioActividad ventana = new frmListadoSocioActividad();
            ventana.ShowDialog();
        }

        private void listadoSociosPorBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSocioBarrio ventana = new frmListadoSocioBarrio();
            ventana.ShowDialog();
        }

        private void informacionDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfoDesarrollador ventana = new frmInfoDesarrollador();
            ventana.ShowDialog();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMiniminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}