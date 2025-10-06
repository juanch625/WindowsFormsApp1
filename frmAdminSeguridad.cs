using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace herra_emp1
{
    public partial class frmAdminSeguridad : Form
    {
        private AccesoDatos datos = new AccesoDatos();

        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string empleado = cmbEmpleado.SelectedItem?.ToString() ?? "N/A";
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Debe ingresar usuario y clave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "UPDATE Usuarios SET Usuario = @Usuario, Clave = @Clave WHERE Empleado = @Empleado";

            SqlParameter[] parametros = {
                new SqlParameter("@Usuario", usuario),
                new SqlParameter("@Clave", clave),
                new SqlParameter("@Empleado", empleado)
            };

            try
            {
                int filas = datos.EjecutarComando(query, parametros);
                MessageBox.Show($"Usuario actualizado correctamente ({filas} fila(s)).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
