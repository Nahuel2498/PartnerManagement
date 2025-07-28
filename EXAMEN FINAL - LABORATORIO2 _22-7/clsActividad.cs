using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_FINAL___LABORATORIO_2
{
    internal class clsActividad
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=BD_Clientes.mdb";
        private String Tabla = "Actividad";

        public void Listar(ComboBox cmbActividad)
        {
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = Tabla;
            adaptador = new OleDbDataAdapter(comando);
            DataSet DS = new DataSet();
            adaptador.Fill(DS, Tabla);
            cmbActividad.DataSource = DS.Tables[Tabla];
            cmbActividad.DisplayMember = "Nombre";
            cmbActividad.ValueMember = "idActividad";
            conexion.Close();
        }

        public string ObtenerNombrePorId(int idActividad)
        {
            string nombreActividad = string.Empty;
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == idActividad)
                        {
                            nombreActividad = DR.GetString(1);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return nombreActividad;
        }

        public int ObtenerIdPorNombre(string nombreActividad)
        {
            int idActividad = 0;

            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetString(1).Equals(nombreActividad, StringComparison.OrdinalIgnoreCase))
                        {
                            idActividad = DR.GetInt32(0);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return idActividad;
        }

        public string ObtenerNombreActividad(int idActividad)
        {
            string nombreActividad = "";
            using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
            {
                string sql = "SELECT Nombre FROM Actividad WHERE IdActividad = @idActividad";
                OleDbCommand comando = new OleDbCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idActividad", idActividad);

                conexion.Open();
                var resultado = comando.ExecuteScalar();
                if (resultado != null)
                {
                    nombreActividad = resultado.ToString();
                }
            }
            return nombreActividad;
        }
    }
}