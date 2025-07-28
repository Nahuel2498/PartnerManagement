using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_FINAL___LABORATORIO_2
{
    public partial class frmConsultaSocio : Form
    {
        public frmConsultaSocio()
        {
            InitializeComponent();
        }

        private void frmConsultaSocio_Load(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=BD_Clientes.mdb");
            OleDbCommand comando = new OleDbCommand("SELECT Nombre FROM Socio", conexion);

            try
            {
                conexion.Open();
                OleDbDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    cmbSocio.Items.Add(reader["Nombre"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar socios: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cmbSocio.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un socio.");
                return;
            }

            string nombreSocio = cmbSocio.SelectedItem.ToString();
            using (OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=BD_Clientes.mdb"))
            {
                OleDbCommand comando = new OleDbCommand("SELECT IdSocio, Nombre, Direccion, Deuda, idBarrio, idActividad FROM Socio WHERE Nombre = @Nombre", conexion);
                comando.Parameters.AddWithValue("@Nombre", nombreSocio);

                try
                {
                    conexion.Open();
                    OleDbDataReader reader = comando.ExecuteReader();
                    if (reader.Read())
                    {
                        lblDni.Text = reader["IdSocio"].ToString();
                        lblDomicilio.Text = reader["Direccion"].ToString();
                        lblDeuda.Text = reader["Deuda"].ToString();

                        // Convertir idBarrio e idActividad a sus nombres correspondientes
                        int idBarrio = Convert.ToInt32(reader["idBarrio"]);
                        int idActividad = Convert.ToInt32(reader["idActividad"]);

                        clsBarrio barrio = new clsBarrio();
                        clsActividad actividad = new clsActividad();

                        lblBarrio.Text = barrio.ObtenerNombreBarrio(idBarrio);
                        lblActividad.Text = actividad.ObtenerNombreActividad(idActividad);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar datos del socio: " + ex.Message);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}