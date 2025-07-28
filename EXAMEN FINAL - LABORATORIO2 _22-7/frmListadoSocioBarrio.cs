using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_FINAL___LABORATORIO_2
{
    public partial class frmListadoSocioBarrio : Form
    {
        public frmListadoSocioBarrio()
        {
            InitializeComponent();
        }

        private void frmListadoSocioBarrio_Load(object sender, EventArgs e)
        {
            clsBarrio barrio = new clsBarrio();
            barrio.Listar(cmbBarrio);
            btnGenerarR.Enabled = false;
            btnImprimirR.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            int idBarrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            string nombreBarrio = cmbBarrio.Text;
            clsSocio soc = new clsSocio();
            soc.ListarSociosPorBarrio(Grilla, idBarrio);

            lblTotalDeuda.Text = soc.TotalDeuda.ToString("N2");
            lblPromedioDeuda.Text = soc.PromedioDeuda.ToString("N2");
            lblMayorD.Text = soc.Mayor_Deuda.ToString("N2");
            lblMenorD.Text = soc.Menor_Deuda.ToString("N2");

            btnGenerarR.Enabled = true;
            btnImprimirR.Enabled = true;
        }

        private void btnGenerarR_Click(object sender, EventArgs e)
        {
            string nombreBarrio = cmbBarrio.Text;
            clsSocio soc = new clsSocio();
            soc.ReporteSociosPorBarrio(Grilla, nombreBarrio);
            MessageBox.Show("Reporte generado");
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

            string barrioSeleccionado = cmbBarrio.Text;

            decimal total = decimal.Parse(lblTotalDeuda.Text, NumberStyles.Any);
            decimal promedio = decimal.Parse(lblPromedioDeuda.Text, NumberStyles.Any);
            decimal mayor = decimal.Parse(lblMayorD.Text, NumberStyles.Any);
            decimal menor = decimal.Parse(lblMenorD.Text, NumberStyles.Any);

            ObjSocio.ImprimirSociosPorBarrio(e, Grilla, barrioSeleccionado, total, promedio, mayor, menor);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}