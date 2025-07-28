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
    public partial class frmAgregarNuevoSocio : Form
    {
        public frmAgregarNuevoSocio()
        {
            InitializeComponent();
        }

        clsSocio x = new clsSocio();
        private void frmAgregarNuevoSocio_Load_1(object sender, EventArgs e)
        {
            clsBarrio ciu = new clsBarrio();
            clsActividad act = new clsActividad();
            ciu.Listar(cmbBarrio);
            act.Listar(cmbActividad);
            btnAgregar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VerificacionCampos();
            clsSocio cli = new clsSocio();
            cli.Socio = Convert.ToInt32(txtDni.Text);
            cli.Nombre = txtNombre.Text;
            cli.Direccion = txtDireccion.Text;
            cli.Barrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            cli.Actividad = Convert.ToInt32(cmbActividad.SelectedValue); 
            cli.Deuda = Convert.ToDecimal(txtDeuda.Text);
            cli.AgregarNuevoRegistro();
            MessageBox.Show("Socio agregado correctamente..!!");
            cmbBarrio.SelectedIndex = 0;
            txtNombre.Text = "";
            txtDeuda.Text = "";
            txtDireccion.Text = "";
            txtDni.Text = "";
        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
            ControlCajas();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            ControlCajas();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            ControlCajas();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            ControlCajas();
        }

        private void ControlCajas()
        {
            btnAgregar.Enabled = !string.IsNullOrWhiteSpace(txtDni.Text) &&
                                 !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                                 !string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                                 !string.IsNullOrWhiteSpace(txtDeuda.Text);
        }

        private void VerificacionCampos()
        {
            if ((txtDni.Text == "") || (txtNombre.Text == "") || (txtDireccion.Text == "") || (txtDeuda.Text == ""))
            {
                btnAgregar.Enabled = false;
                MessageBox.Show("Debe completar todos los campos..!!");
                return;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }
        
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}