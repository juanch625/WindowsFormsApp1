using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace herra_emp1
{
    public partial class frmLogin : Form
    {
        AccesoDatos datos = new AccesoDatos();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = "SELECT IdUsuario, Usuario FROM Usuarios WHERE Usuario = @usuario AND Password = @password";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@usuario", SqlDbType.VarChar) { Value = usuario },
                    new SqlParameter("@password", SqlDbType.VarChar) { Value = password }
                };

                DataTable dt = datos.EjecutarConsulta(query, parametros);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Bienvenido " + usuario, "Acceso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
