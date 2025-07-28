using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Net.Configuration;
using System.Drawing.Printing;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace EXAMEN_FINAL___LABORATORIO_2
{
    internal class clsSocio
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private string CadenaConexion = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=BD_Clientes.mdb";
        private string Tabla = "Socio";

        private Int32 Soc;
        private string Nom;
        private string Direc;
        private Int32 Bar;
        private Int32 Act;
        private decimal deu;
        private Int32 cantidad;
        private Decimal Promedio;
        private decimal MayorDeuda;
        private decimal MenorDeuda;

        public Int32 Socio
        {
            get { return Soc; }
            set { Soc = value; }
        }
        public string Nombre
        {
            get { return Nom; }
            set { Nom = value; }
        }
        public string Direccion
        {
            get { return Direc; }
            set { Direc = value; }
        }
        public Int32 Barrio
        {
            get { return Bar; }
            set { Bar = value; }
        }
        public Int32 Actividad
        {
            get { return Act; }
            set { Act = value; }
        }
        public decimal Deuda
        {
            get { return deu; }
            set { deu = value; }
        }
        public decimal Mayor_Deuda
        {
            get { return MayorDeuda; }
            set { MayorDeuda = value; }
        }
        public decimal Menor_Deuda
        {
            get { return MenorDeuda; }
            set { MenorDeuda = value; }
        }
        public Decimal PromedioDeuda
        {
            get { return Promedio; }
            set { Promedio = value; }
        }
        public Decimal TotalDeuda
        {
            get { return deu; }
            set { deu = value; }
        }

        clsBarrio objBarrio = new clsBarrio();
        clsActividad objActividad = new clsActividad();

        public void AgregarNuevoRegistro()
        {
            conexion.ConnectionString = CadenaConexion;

            try
            {
                conexion.Open();
                string verificarDniSQL = "SELECT COUNT(*) FROM Socio WHERE IdSocio = @Dni";
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = verificarDniSQL;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Dni", Soc);

                int existe = Convert.ToInt32(comando.ExecuteScalar());

                if (existe > 0)
                {
                    MessageBox.Show("El socio con el Dni ingresado ya existe.");
                    return;
                }
                string sql = "INSERT INTO Socio (IdSocio, Nombre, Direccion, idBarrio, idActividad, Deuda) VALUES (@Dni, @Nombre, @Direccion, @Barrio, @Actividad, @Deuda)";
                comando.CommandText = sql;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Dni", Soc);
                comando.Parameters.AddWithValue("@Nombre", Nom);
                comando.Parameters.AddWithValue("@Direccion", Direc);
                comando.Parameters.AddWithValue("@Barrio", Bar);
                comando.Parameters.AddWithValue("@Actividad", Act);
                comando.Parameters.AddWithValue("@Deuda", deu);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Modificar()
        {
            String sql = "UPDATE Socio SET Nombre = '" + Nom + "', Direccion = '" + Direc + "', idBarrio = " + Bar.ToString() + ", idActividad = " + Act.ToString() + ", Deuda = " + deu.ToString() + " WHERE IdSocio = " + Soc.ToString();
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;

            comando.Parameters.AddWithValue("@Nombre", Nom);
            comando.Parameters.AddWithValue("@Direccion", Direc);
            comando.Parameters.AddWithValue("@Barrio", Bar);
            comando.Parameters.AddWithValue("@Actividad", Act);
            comando.Parameters.AddWithValue("@Deuda", deu);

            comando.Parameters.AddWithValue("@IdSocio", Socio);

            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void Eliminar(Int32 IdSocio)
        {
            try
            {
                String sql = "DELETE * FROM Socio WHERE IdSocio = " + IdSocio.ToString();
                conexion.ConnectionString = CadenaConexion; // 
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Buscar(Int32 IdSocio)
        {

            conexion.ConnectionString = CadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = Tabla;
            OleDbDataReader DR = comando.ExecuteReader();
            Soc = 0;
            if (DR.HasRows)
            {
                while (DR.Read())
                {
                    if (DR.GetInt32(0) == IdSocio)
                    {
                        Soc = DR.GetInt32(0);
                        Nom = DR.GetString(1);
                        Direc = DR.GetString(2);
                        Bar = DR.GetInt32(3);
                        Act = DR.GetInt32(4);
                        deu = DR.GetDecimal(5);
                    }
                }
            }
            conexion.Close();
        }

        public void ListarClientes(DataGridView grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                grilla.Rows.Clear();
                cantidad = 0;
                deu = 0;
                MayorDeuda = decimal.MinValue;
                MenorDeuda = decimal.MaxValue;

                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow x in DS.Tables[Tabla].Rows)
                    {
                        decimal deuda = Convert.ToDecimal(x["Deuda"]);
                        grilla.Rows.Add(Convert.ToInt32(x["IdSocio"]), x["Nombre"].ToString(), deuda);

                        cantidad++;
                        deu += deuda;

                        if (deuda > MayorDeuda) MayorDeuda = deuda;
                        if (deuda < MenorDeuda) MenorDeuda = deuda;
                    }

                    if (cantidad > 0)
                        Promedio = deu / cantidad;
                    else
                        Promedio = 0;
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los clientes: " + ex.Message);
            }
        }

        public void ReporteTodosSocio()
        {
            try
            {
                clsBarrio objBarrio = new clsBarrio();
                clsActividad objActividad = new clsActividad();

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Socio";
                OleDbDataReader DR = comando.ExecuteReader();

                StreamWriter AD = new StreamWriter("ReporteTotalSocios.csv", false);
                AD.WriteLine("Listado de Socios");
                AD.WriteLine("");
                AD.WriteLine("Codigo;Nombre;Dirección;Barrio;Actividad;Deuda");

                cantidad = 0;
                deu = 0;
                MayorDeuda = decimal.MinValue;
                MenorDeuda = decimal.MaxValue;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        int idBarrio = DR.GetInt32(3);
                        int idActividad = DR.GetInt32(4);

                        string nombreBarrio = objBarrio.ObtenerNombreBarrio(idBarrio);
                        string nombreActividad = objActividad.ObtenerNombrePorId(idActividad);

                        AD.Write(DR.GetInt32(0)); 
                        AD.Write(";");
                        AD.Write(DR.GetString(1));
                        AD.Write(";");
                        AD.Write(DR.GetString(2)); 
                        AD.Write(";");
                        AD.Write(nombreBarrio);
                        AD.Write(";");
                        AD.Write(nombreActividad);
                        AD.Write(";");

                        decimal deuda = DR.GetDecimal(5);
                        AD.WriteLine(deuda);

                        cantidad++;
                        deu += deuda;
                        if (deuda > MayorDeuda) MayorDeuda = deuda;
                        if (deuda < MenorDeuda) MenorDeuda = deuda;
                    }
                    Promedio = cantidad > 0 ? deu / cantidad : 0;
                }

                AD.WriteLine("");
                AD.WriteLine("Cantidad de socios:;;;;;" + cantidad);
                AD.WriteLine("Mayor deuda:;;;;;" + MayorDeuda);
                AD.WriteLine("Menor deuda:;;;;;" + MenorDeuda);
                AD.WriteLine("Promedio de deuda:;;;;;" + Promedio.ToString("N2"));
                AD.WriteLine("Total de deuda:;;;;;" + deu);

                conexion.Close();
                AD.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ImprimirListadoGeneral(PrintPageEventArgs e, DataGridView dgvTodos, decimal total, decimal promedio, decimal mayor, decimal menor)
        {
            Font letraTitulo = new Font("Arial", 14, FontStyle.Bold);
            Font letraCabecera = new Font("Arial", 10, FontStyle.Bold);
            Font letraTexto = new Font("Arial", 9);
            int f = 100;

            e.Graphics.DrawString("Listado de todos los clientes", letraTitulo, Brushes.DarkBlue, 100, f);
            f += 40;

            e.Graphics.DrawString("DNI", letraCabecera, Brushes.Black, 100, f);
            e.Graphics.DrawString("Nombre", letraCabecera, Brushes.Black, 200, f);
            e.Graphics.DrawString("Deuda", letraCabecera, Brushes.Black, 400, f);
            f += 25;

            int cantidadSocios = 0;

            foreach (DataGridViewRow fila in dgvTodos.Rows)
            {
                if (fila.IsNewRow) continue;

                string dni = fila.Cells[0].Value?.ToString();
                string nombre = fila.Cells[1].Value?.ToString();
                string deuda = Convert.ToDecimal(fila.Cells[2].Value).ToString("N2");

                e.Graphics.DrawString(dni, letraTexto, Brushes.Black, 100, f);
                e.Graphics.DrawString(nombre, letraTexto, Brushes.Black, 200, f);
                e.Graphics.DrawString(deuda, letraTexto, Brushes.Black, 400, f);
                f += 18;

                cantidadSocios++;
            }

            f += 30;
            e.Graphics.DrawString("Cantidad total de socios:", letraTexto, Brushes.Black, 100, f);
            e.Graphics.DrawString(cantidadSocios.ToString(), letraTexto, Brushes.Black, 400, f);
            f += 15;

            e.Graphics.DrawString("Mayor deuda:", letraTexto, Brushes.Black, 100, f);
            e.Graphics.DrawString(mayor.ToString("N2"), letraTexto, Brushes.Black, 400, f);
            f += 15;

            e.Graphics.DrawString("Menor deuda:", letraTexto, Brushes.Black, 100, f);
            e.Graphics.DrawString(menor.ToString("N2"), letraTexto, Brushes.Black, 400, f);
            f += 15;

            e.Graphics.DrawString("Promedio de deuda:", letraTexto, Brushes.Black, 100, f);
            e.Graphics.DrawString(promedio.ToString("N2"), letraTexto, Brushes.Black, 400, f);
            f += 15;

            e.Graphics.DrawString("Total de deuda:", letraTexto, Brushes.Black, 100, f);
            e.Graphics.DrawString(total.ToString("N2"), letraTexto, Brushes.Black, 400, f);
        }

        public void CalcularEstadisticas(DataGridView dgv)
        {
            TotalDeuda = 0;
            PromedioDeuda = 0;
            Mayor_Deuda = decimal.MinValue;
            Menor_Deuda = decimal.MaxValue;
            int cantidad = 0;

            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if (fila.IsNewRow) continue;

                decimal deuda = Convert.ToDecimal(fila.Cells[2].Value);
                TotalDeuda += deuda;
                if (deuda > Mayor_Deuda) Mayor_Deuda = deuda;
                if (deuda < Menor_Deuda) Menor_Deuda = deuda;
                cantidad++;
            }

            if (cantidad > 0)
                PromedioDeuda = TotalDeuda / cantidad;
        }




        public void ListarDeudores(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Socio";
                OleDbDataReader DR = comando.ExecuteReader();

                Grilla.Rows.Clear();
                int cantidad = 0;
                TotalDeuda = 0;
                Mayor_Deuda = 0;
                Menor_Deuda = decimal.MaxValue;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        decimal deuda = DR.GetDecimal(5);
                        if (deuda > 0)
                        {
                            Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), deuda);
                            cantidad++;
                            TotalDeuda += deuda;

                            if (deuda > Mayor_Deuda)
                            {
                                Mayor_Deuda = deuda;
                            }
                            if (deuda < Menor_Deuda)
                            {
                                Menor_Deuda = deuda;
                            }
                        }
                    }
                }
                PromedioDeuda = Convert.ToInt32(TotalDeuda / cantidad);
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ReporteSocioDeudores()
        {
            try
            {
                clsBarrio objBarrio = new clsBarrio();
                clsActividad objActividad = new clsActividad();

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Socio";

                OleDbDataReader DR = comando.ExecuteReader();
                StreamWriter AD = new StreamWriter("ReporteSocioDeudores.csv", false);

                AD.WriteLine("Listado de Socios con Deuda");
                AD.WriteLine();
                AD.WriteLine("Código;Nombre;Dirección;Barrio;Actividad;Deuda");

                cantidad = 0;
                deu = 0;
                MayorDeuda = decimal.MinValue;
                MenorDeuda = decimal.MaxValue;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        int idBarrio = DR.GetInt32(3);
                        int idActividad = DR.GetInt32(4);
                        decimal deuda = DR.GetDecimal(5);

                        if (deuda > 0)
                        {
                            string nombreBarrio = objBarrio.ObtenerNombreBarrio(idBarrio);
                            string nombreActividad = objActividad.ObtenerNombrePorId(idActividad);

                            AD.WriteLine(
                                DR.GetInt32(0) + ";" +
                                DR.GetString(1) + ";" +
                                DR.GetString(2) + ";" +
                                nombreBarrio + ";" +
                                nombreActividad + ";" +
                                deuda.ToString("N2")
                            );

                            cantidad++;
                            deu += deuda;

                            if (deuda > MayorDeuda)
                                MayorDeuda = deuda;

                            if (deuda < MenorDeuda)
                                MenorDeuda = deuda;
                        }
                    }
                }

                AD.WriteLine();
                AD.WriteLine("Cantidad de socios:;;;;;" + cantidad);
                AD.WriteLine("Mayor deuda:;;;;;" + MayorDeuda.ToString("N2"));
                AD.WriteLine("Menor deuda:;;;;;" + MenorDeuda.ToString("N2"));
                AD.WriteLine("Promedio de deuda:;;;;;" + (cantidad > 0 ? (deu / cantidad).ToString("N2") : "0"));
                AD.WriteLine("Total de deuda:;;;;;" + deu.ToString("N2"));

                DR.Close();
                conexion.Close();
                AD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message);
            }
        }

        public void ImprimirListadoDeudores(PrintPageEventArgs e, DataGridView Grilla, decimal total, decimal promedio, decimal mayor, decimal menor)
        {
            Font fuente = new Font("Arial", 10);
            int y = 100;
            int x = 100;

            e.Graphics.DrawString("LISTADO DE DEUDORES", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, x, y);
            y += 40;

            e.Graphics.DrawString("DNI", fuente, Brushes.Black, x, y);
            e.Graphics.DrawString("Nombre", fuente, Brushes.Black, x + 100, y);
            e.Graphics.DrawString("Deuda", fuente, Brushes.Black, x + 300, y);
            y += 30;

            int cantidadSocios = 0;
            foreach (DataGridViewRow fila in Grilla.Rows)
            {
                if (fila.IsNewRow) continue;

                string dni = fila.Cells[0].Value?.ToString();
                string nombre = fila.Cells[1].Value?.ToString();
                string deuda = fila.Cells[2].Value?.ToString();

                e.Graphics.DrawString(dni, fuente, Brushes.Black, x, y);
                e.Graphics.DrawString(nombre, fuente, Brushes.Black, x + 100, y);
                e.Graphics.DrawString(deuda, fuente, Brushes.Black, x + 300, y);
                y += 25;
                cantidadSocios++;
            }

            y += 30;
            e.Graphics.DrawString("Cantidad deudores:", fuente, Brushes.Black, x, y);
            e.Graphics.DrawString(cantidadSocios.ToString(), fuente, Brushes.Black, x + 300, y);
            y += 15;

            e.Graphics.DrawString("Mayor deuda:", fuente, Brushes.Black, x, y);
            e.Graphics.DrawString("$" + mayor.ToString("N2"), fuente, Brushes.Black, x + 300, y);
            y += 15;

            e.Graphics.DrawString("Menor deuda:", fuente, Brushes.Black, x, y);
            e.Graphics.DrawString("$" + menor.ToString("N2"), fuente, Brushes.Black, x + 300, y);
            y += 15;

            e.Graphics.DrawString("Promedio de deuda:", fuente, Brushes.Black, x, y);
            e.Graphics.DrawString("$" + promedio.ToString("N2"), fuente, Brushes.Black, x + 300, y);
            y += 15;

            e.Graphics.DrawString("Total de deuda:", fuente, Brushes.Black, x, y);
            e.Graphics.DrawString("$" + total.ToString("N2"), fuente, Brushes.Black, x + 300, y);
        }




        public void ListarSociosActividad(DataGridView Grilla, int IdActividad)
        {
            TotalDeuda = 0;
            PromedioDeuda = 0;
            Mayor_Deuda = decimal.MinValue;
            Menor_Deuda = decimal.MaxValue;

            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                Grilla.Rows.Clear();

                int cantidad = 0;

                foreach (DataRow fila in DS.Tables[Tabla].Rows)
                {
                    if (Convert.ToInt32(fila["IdActividad"]) == IdActividad)
                    {
                        int idSocio = Convert.ToInt32(fila["IdSocio"]);
                        string nombre = fila["Nombre"].ToString();
                        decimal deuda = Convert.ToDecimal(fila["Deuda"]);

                        Grilla.Rows.Add(idSocio, nombre, deuda);

                        TotalDeuda += deuda;
                        cantidad++;

                        if (deuda > Mayor_Deuda)
                            Mayor_Deuda = deuda;

                        if (deuda < Menor_Deuda)
                            Menor_Deuda = deuda;
                    }
                }

                if (cantidad > 0)
                    PromedioDeuda = TotalDeuda / cantidad;
                else
                {
                    Mayor_Deuda = 0;
                    Menor_Deuda = 0;
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void ReporteSocioActividad(DataGridView grilla, string nombreActividad)
        {
            try
            {
                StreamWriter AD = new StreamWriter("ReporteSociosPorActividad.csv", false);

                AD.WriteLine("Listado de Socios por Actividad");
                AD.WriteLine("Actividad: " + nombreActividad);
                AD.WriteLine("");
                AD.WriteLine("DNI;Nombre;Deuda");

                int cantidad = 0;
                decimal totalDeuda = 0;
                decimal mayorDeuda = decimal.MinValue;
                decimal menorDeuda = decimal.MaxValue;

                foreach (DataGridViewRow fila in grilla.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        int dni = Convert.ToInt32(fila.Cells[0].Value);
                        string nombre = fila.Cells[1].Value.ToString();
                        decimal deuda = Convert.ToDecimal(fila.Cells[2].Value);

                        AD.WriteLine($"{dni};{nombre};{deuda}");

                        cantidad++;
                        totalDeuda += deuda;
                        if (deuda > mayorDeuda) mayorDeuda = deuda;
                        if (deuda < menorDeuda) menorDeuda = deuda;
                    }
                }

                decimal promedio = (cantidad > 0) ? totalDeuda / cantidad : 0;

                AD.WriteLine("");
                AD.WriteLine("Cantidad de socios:;;" + cantidad);
                AD.WriteLine("Mayor deuda:;;" + mayorDeuda.ToString("N2"));
                AD.WriteLine("Menor deuda:;;" + menorDeuda.ToString("N2"));
                AD.WriteLine("Promedio de deuda:;;" + promedio.ToString("N2"));
                AD.WriteLine("Total de deuda:;;" + totalDeuda.ToString("N2"));

                AD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar reporte: " + ex.Message);
            }
        }

        public void ImprimirListadoPorActividad(PrintPageEventArgs e, DataGridView dgvActividad, string nombreActividad, decimal total, decimal promedio, decimal mayor, decimal menor)
        {
            Font letraTitulo = new Font("Arial", 14, FontStyle.Bold);
            Font letraCabecera = new Font("Arial", 10, FontStyle.Bold);
            Font letraTexto = new Font("Arial", 9);
            int f = 100;

            e.Graphics.DrawString("Clientes de la actividad: " + nombreActividad, letraTitulo, Brushes.DarkGreen, 100, f);
            f += 40;

            e.Graphics.DrawString("DNI", letraCabecera, Brushes.Black, 100, f);
            e.Graphics.DrawString("Nombre", letraCabecera, Brushes.Black, 200, f);
            e.Graphics.DrawString("Deuda", letraCabecera, Brushes.Black, 400, f);
            f += 25;

            int cantidadSocios = 0;
            foreach (DataGridViewRow fila in dgvActividad.Rows)
            {
                if (fila.IsNewRow) continue;

                string dni = fila.Cells[0].Value?.ToString();
                string nombre = fila.Cells[1].Value?.ToString();
                string deuda = Convert.ToDecimal(fila.Cells[2].Value).ToString("N2");

                e.Graphics.DrawString(dni, letraTexto, Brushes.Black, 100, f);
                e.Graphics.DrawString(nombre, letraTexto, Brushes.Black, 200, f);
                e.Graphics.DrawString(deuda, letraTexto, Brushes.Black, 400, f);
                f += 18;
                cantidadSocios++;
            }

            f += 30;
            e.Graphics.DrawString("Cantidad de socios:", letraTexto, Brushes.Black, 100, f);
            e.Graphics.DrawString(cantidadSocios.ToString(), letraTexto, Brushes.Black, 400, f);
            f += 15;

            e.Graphics.DrawString("Mayor deuda:", letraTexto, Brushes.Black, 100, f);
            e.Graphics.DrawString(mayor.ToString("N2"), letraTexto, Brushes.Black, 400, f);
            f += 15;

            e.Graphics.DrawString("Menor deuda:", letraTexto, Brushes.Black, 100, f);
            e.Graphics.DrawString(menor.ToString("N2"), letraTexto, Brushes.Black, 400, f);
            f += 15;

            e.Graphics.DrawString("Promedio de deuda:", letraTexto, Brushes.Black, 100, f);
            e.Graphics.DrawString(promedio.ToString("N2"), letraTexto, Brushes.Black, 400, f);
            f += 15;

            e.Graphics.DrawString("Total de deuda:", letraTexto, Brushes.Black, 100, f);
            e.Graphics.DrawString(total.ToString("N2"), letraTexto, Brushes.Black, 400, f);
        }




        public void ListarSociosPorBarrio(DataGridView grilla, int idBarrio)
        {
            TotalDeuda = 0;
            PromedioDeuda = 0;
            Mayor_Deuda = decimal.MinValue;
            Menor_Deuda = decimal.MaxValue;

            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                grilla.Rows.Clear();

                int cantidad = 0;

                foreach (DataRow fila in DS.Tables[Tabla].Rows)
                {
                    if (Convert.ToInt32(fila["IdBarrio"]) == idBarrio)
                    {
                        int idSocio = Convert.ToInt32(fila["IdSocio"]);
                        string nombre = fila["Nombre"].ToString();
                        decimal deuda = Convert.ToDecimal(fila["Deuda"]);

                        grilla.Rows.Add(idSocio, nombre, deuda);

                        TotalDeuda += deuda;
                        cantidad++;

                        if (deuda > Mayor_Deuda)
                            Mayor_Deuda = deuda;

                        if (deuda < Menor_Deuda)
                            Menor_Deuda = deuda;
                    }
                }

                if (cantidad > 0)
                    PromedioDeuda = TotalDeuda / cantidad;
                else
                {
                    Mayor_Deuda = 0;
                    Menor_Deuda = 0;
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void ReporteSociosPorBarrio(DataGridView grilla, string nombreBarrio)
        {
            try
            {
                StreamWriter AD = new StreamWriter("ReporteSociosPorBarrio.csv", false);

                AD.WriteLine("Listado de Socios por Barrio");
                AD.WriteLine("Barrio: " + nombreBarrio);
                AD.WriteLine("");
                AD.WriteLine("DNI;Nombre;Deuda");

                int cantidad = 0;
                decimal totalDeuda = 0;
                decimal mayorDeuda = decimal.MinValue;
                decimal menorDeuda = decimal.MaxValue;

                foreach (DataGridViewRow fila in grilla.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        int dni = Convert.ToInt32(fila.Cells[0].Value);
                        string nombre = fila.Cells[1].Value.ToString();
                        decimal deuda = Convert.ToDecimal(fila.Cells[2].Value);

                        AD.WriteLine($"{dni};{nombre};{deuda}");

                        cantidad++;
                        totalDeuda += deuda;
                        if (deuda > mayorDeuda) mayorDeuda = deuda;
                        if (deuda < menorDeuda) menorDeuda = deuda;
                    }
                }

                decimal promedio = (cantidad > 0) ? totalDeuda / cantidad : 0;

                AD.WriteLine("");
                AD.WriteLine("Cantidad de socios:;;" + cantidad);
                AD.WriteLine("Mayor deuda:;;" + mayorDeuda.ToString("N2"));
                AD.WriteLine("Menor deuda:;;" + menorDeuda.ToString("N2"));
                AD.WriteLine("Promedio de deuda:;;" + promedio.ToString("N2"));
                AD.WriteLine("Total de deuda:;;" + totalDeuda.ToString("N2"));

                AD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar reporte: " + ex.Message);
            }
        }

        public void ImprimirSociosPorBarrio(PrintPageEventArgs e, DataGridView dgvBarrio, string nombreBarrio, decimal total, decimal promedio, decimal mayor, decimal menor)
        {
            Font letraTitulo = new Font("Arial", 14, FontStyle.Bold);
            Font letraCabecera = new Font("Arial", 10, FontStyle.Bold);
            Font letraTexto = new Font("Arial", 9);
            int f = 100;

            e.Graphics.DrawString("Clientes del barrio: " + nombreBarrio, letraTitulo, Brushes.DarkGreen, 100, f);
            f += 40;

            e.Graphics.DrawString("DNI", letraCabecera, Brushes.Black, 100, f);
            e.Graphics.DrawString("Nombre", letraCabecera, Brushes.Black, 200, f);
            e.Graphics.DrawString("Deuda", letraCabecera, Brushes.Black, 400, f);
            f += 25;

            int cantidadSocios = 0;
            foreach (DataGridViewRow fila in dgvBarrio.Rows)
            {
                if (fila.IsNewRow) continue;

                string dni = fila.Cells[0].Value?.ToString();
                string nombre = fila.Cells[1].Value?.ToString();
                string deuda = Convert.ToDecimal(fila.Cells[2].Value).ToString("N2");

                e.Graphics.DrawString(dni, letraTexto, Brushes.Black, 100, f);
                e.Graphics.DrawString(nombre, letraTexto, Brushes.Black, 200, f);
                e.Graphics.DrawString(deuda, letraTexto, Brushes.Black, 400, f);
                f += 18;
                cantidadSocios++;
            }

            f += 30;
            e.Graphics.DrawString("Cantidad de socios:", letraTexto, Brushes.Black, 100, f);
            e.Graphics.DrawString(cantidadSocios.ToString(), letraTexto, Brushes.Black, 400, f);
            f += 15;

            e.Graphics.DrawString("Mayor deuda:", letraTexto, Brushes.Black, 100, f);
            e.Graphics.DrawString(mayor.ToString("N2"), letraTexto, Brushes.Black, 400, f);
            f += 15;

            e.Graphics.DrawString("Menor deuda:", letraTexto, Brushes.Black, 100, f);
            e.Graphics.DrawString(menor.ToString("N2"), letraTexto, Brushes.Black, 400, f);
            f += 15;

            e.Graphics.DrawString("Promedio de deuda:", letraTexto, Brushes.Black, 100, f);
            e.Graphics.DrawString(promedio.ToString("N2"), letraTexto, Brushes.Black, 400, f);
            f += 15;

            e.Graphics.DrawString("Total de deuda:", letraTexto, Brushes.Black, 100, f);
            e.Graphics.DrawString(total.ToString("N2"), letraTexto, Brushes.Black, 400, f);
        }
    }
}