using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace herra_emp1
{
    public partial class frmRolEmpleados : Form
    {
        private AccesoDatos datos = new AccesoDatos();

        public frmRolEmpleados()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Roles (NombreRol, DescripcionRol) VALUES (@NombreRol, @DescripcionRol)";
            SqlParameter[] parametros =
            {
                new SqlParameter("@NombreRol", txtNombreRol.Text),
                new SqlParameter("@DescripcionRol", txtDescripcionRol.Text)
            };

            try
            {
                int filas = datos.EjecutarComando(query, parametros);
                MessageBox.Show($"Rol agregado correctamente ({filas} fila(s)).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
