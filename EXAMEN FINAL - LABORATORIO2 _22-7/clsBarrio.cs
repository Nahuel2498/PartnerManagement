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
    internal class clsBarrio
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=BD_Clientes.mdb";
        private String Tabla = "Barrio";

        public void Listar(ComboBox Combo)
        {
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = Tabla;
            adaptador = new OleDbDataAdapter(comando);
            DataSet DS = new DataSet();
            adaptador.Fill(DS, Tabla);
            Combo.DataSource = DS.Tables[Tabla];
            Combo.DisplayMember = "Nombre";
            Combo.ValueMember = "idBarrio";
            conexion.Close();
        }

        public string ObtenerNombreBarrio(int idBarrio)
        {
            string nombreBarrio = "";
            using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
            {
                string sql = "SELECT Nombre FROM Barrio WHERE IdBarrio = @idBarrio";
                OleDbCommand comando = new OleDbCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idBarrio", idBarrio);

                conexion.Open();
                var resultado = comando.ExecuteScalar();
                if (resultado != null)
                {
                    nombreBarrio = resultado.ToString();
                }
            }
            return nombreBarrio;
        }

        public int ObtenerIdPorNombre(string nombreBarrio)
        {
            int idBarrio = 0;
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
                        if (DR.GetString(1).Equals(nombreBarrio, StringComparison.OrdinalIgnoreCase))
                        {
                            idBarrio = DR.GetInt32(0);
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
            return idBarrio;
        }
    }
}