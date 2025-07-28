using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EXAMEN_FINAL___LABORATORIO_2
{
    public partial class frmListadoSocioActividad : Form
    {
        public frmListadoSocioActividad()
        {
            InitializeComponent();
        }

        private void frmListadoSocioActividad_Load(object sender, EventArgs e)
        {
            clsActividad actividad = new clsActividad();
            actividad.Listar(cmbActividad);
            btnGenerarR.Enabled = false;
            btnImprimirR.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            int idAct = Convert.ToInt32(cmbActividad.SelectedValue);
            clsSocio soc = new clsSocio();

            soc.ListarSociosActividad(Grilla, idAct);

            lblMayorD.Text = soc.Mayor_Deuda.ToString("C");
            lblMenorD.Text = soc.Menor_Deuda.ToString("C");
            lblPromedioDeuda.Text = soc.PromedioDeuda.ToString("C");
            lblTotalDeuda.Text = soc.TotalDeuda.ToString("C");
            btnGenerarR.Enabled = true;
            btnImprimirR.Enabled = true;
        }

        private void btnGenerarR_Click(object sender, EventArgs e)
        {
            clsSocio ObjSocio = new clsSocio();
            ObjSocio.ReporteSocioActividad(Grilla, cmbActividad.Text);
            MessageBox.Show("Reporte generado correctamente");
            btnGenerarR.Enabled = false;
        }

        private void btnImprimirR_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            prtDocumento.Print();
            MessageBox.Show("Reporte impreso correctamente");
            btnImprimirR.Enabled = false;
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsSocio ObjSocio = new clsSocio();

            string actividadSeleccionada = cmbActividad.Text;

            decimal total = decimal.Parse(lblTotalDeuda.Text, NumberStyles.Any);
            decimal promedio = decimal.Parse(lblPromedioDeuda.Text, NumberStyles.Any);
            decimal mayor = decimal.Parse(lblMayorD.Text, NumberStyles.Any);
            decimal menor = decimal.Parse(lblMenorD.Text, NumberStyles.Any);

            ObjSocio.ImprimirListadoPorActividad(e, Grilla, actividadSeleccionada, total, promedio, mayor, menor);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}