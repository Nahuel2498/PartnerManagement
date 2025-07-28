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
    public partial class frmBuscarSocio : Form
    {
        public frmBuscarSocio()
        {
            InitializeComponent();
        }

        private clsSocio socioActual = new clsSocio();

        private void frmBuscarSocio_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnDni_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDni.Text, out int dni))
            {
                socioActual.Buscar(dni);

                if (socioActual.Socio != 0)
                {
                    txtNombre.Text = socioActual.Nombre;
                    lblDni.Text = Convert.ToString(socioActual.Socio);
                    txtDireccion.Text = socioActual.Direccion;

                    clsBarrio barrio = new clsBarrio();
                    clsActividad actividad = new clsActividad();

                    txtBarrio.Text = barrio.ObtenerNombreBarrio(socioActual.Barrio);
                    txtActividad.Text = actividad.ObtenerNombrePorId(socioActual.Actividad);

                    txtDeuda.Text = socioActual.Deuda.ToString();
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                    txtDni.Text= "";
                }
                else
                {
                    MessageBox.Show("Dato no encontrado..!!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
            btnGuardar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(lblDni.Text); // Cambiar txtCodigo por lblDni
            clsSocio cli = new clsSocio();
            cli.Eliminar(id);
            MessageBox.Show("Dato eliminado exitosamente..!!");
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;

            txtNombre.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtBarrio.ReadOnly = false;
            txtActividad.ReadOnly = false;
            txtDeuda.ReadOnly = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            socioActual.Nombre = txtNombre.Text;
            socioActual.Direccion = txtDireccion.Text;

            clsBarrio barrio = new clsBarrio();
            clsActividad actividad = new clsActividad();

            socioActual.Barrio = barrio.ObtenerIdPorNombre(txtBarrio.Text);
            socioActual.Actividad = actividad.ObtenerIdPorNombre(txtActividad.Text);

            if (decimal.TryParse(txtDeuda.Text, out decimal deuda))
            {
                socioActual.Deuda = deuda;
                socioActual.Modificar();

                MessageBox.Show("Dato guardado exitosamente.");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido en el campo de deuda.");
            }
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtDni.Clear();
            lblDni.Text = "";
            txtActividad.Clear();
            txtBarrio.Clear();
            txtDireccion.Clear();
            txtDeuda.Clear();
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            txtNombre.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtBarrio.ReadOnly = true;
            txtActividad.ReadOnly = true;
            txtDeuda.ReadOnly = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}