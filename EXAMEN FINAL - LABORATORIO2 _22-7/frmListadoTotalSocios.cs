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
    public partial class frmListadoTotalSocios : Form
    {
        public frmListadoTotalSocios()
        {
            InitializeComponent();
        }

        private void frmListadoTotalSocios_Load(object sender, EventArgs e)
        {
            btnGenerarR.Enabled = false;
            btnImprimirR.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsSocio ObjSocio = new clsSocio();
            ObjSocio.ListarClientes(Grilla);
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
            ObjSocio.ReporteTodosSocio();
            btnGenerarR.Enabled = false;
            MessageBox.Show("Reporte generado correctamente");
        }

        private void btnImprimirR_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            prtDocumento.Print();
            MessageBox.Show("Reporte impreso correctamente");

            btnImprimirR.Enabled = false;
        }

        private void prtDocumento_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsSocio ObjCliente = new clsSocio();
            ObjCliente.CalcularEstadisticas(Grilla);
            ObjCliente.ImprimirListadoGeneral(e, Grilla, ObjCliente.TotalDeuda, ObjCliente.PromedioDeuda, ObjCliente.Mayor_Deuda, ObjCliente.Menor_Deuda);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}