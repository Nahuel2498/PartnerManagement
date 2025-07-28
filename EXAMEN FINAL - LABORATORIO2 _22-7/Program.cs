using System;
using System.Windows.Forms;

namespace EXAMEN_FINAL___LABORATORIO_2
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmInfoDesarrollador presentacion = new frmInfoDesarrollador();
            presentacion.ShowDialog();

            Application.Run(new frmSistemaGestionSocios());
        }
    }
}