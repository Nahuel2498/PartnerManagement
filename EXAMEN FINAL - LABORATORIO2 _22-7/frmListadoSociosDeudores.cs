using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EXAMEN_FINAL___LABORATORIO_2
{
    public partial class frmListadoSociosDeudores : Form
    {
        public frmListadoSociosDeudores()
        {
            InitializeComponent();
        }

        private void frmListadoSociosDeudores_Load(object sender, EventArgs e)
        {
            btnGenerarR.Enabled = false;
            btnImprimirR.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsSocio ObjSocio = new clsSocio();
            ObjSocio.ListarDeudores(Grilla);
            lblTotalDeuda.Text = ObjSocio.TotalDeuda.ToString("N2");
            lblPromedioDeuda.Text = ObjSocio.PromedioDeuda.ToString("N2");
            lblMayorD.Text = ObjSocio.Mayor_Deuda.ToString("N2");
            lblMenorD.Text = ObjSocio.Menor_Deuda.ToString("N2");

            btnListar.Enabled = false;
            btnGenerarR.Enabled = true;
            btnImprimirR.Enabled = true;
        }

        private void btnGenerarR_Click(object sender, EventArgs e)
        {
            clsSocio ObjSocio = new clsSocio();
            ObjSocio.ReporteSocioDeudores();
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
            decimal total = Convert.ToDecimal(lblTotalDeuda.Text);
            decimal promedio = Convert.ToDecimal(lblPromedioDeuda.Text);
            decimal mayor = Convert.ToDecimal(lblMayorD.Text);
            decimal menor = Convert.ToDecimal(lblMenorD.Text);

            clsSocio obj = new clsSocio();
            obj.ImprimirListadoDeudores(e, Grilla, total, promedio, mayor, menor);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}