using System;
using System.Windows.Forms;

namespace herra_emp1
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

            // Iniciar con el Login
            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // Si el login fue exitoso, abrir el Menú Principal
                    Application.Run(new frmMenuPrincipal());
                }
                else
                {

                    Application.Exit();
                }
            }
        }
    }
}
