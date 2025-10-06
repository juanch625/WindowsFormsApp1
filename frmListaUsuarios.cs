using System;
using System.Data;
using System.Windows.Forms;

namespace herra_emp1
{
    public partial class frmListaUsuarios : Form
    {
        private AccesoDatos datos;

        public frmListaUsuarios()
        {
            InitializeComponent();
            datos = new AccesoDatos();
        }

        private void frmListaUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                string query = "SELECT IdUsuario, Usuario, Password FROM Usuarios";
                DataTable dt = datos.EjecutarConsulta(query);
                dgvUsuarios.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAdminSeguridad form = new frmAdminSeguridad();
            if (form.ShowDialog() == DialogResult.OK)
            {
                CargarUsuarios();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
                string usuario = dgvUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                string clave = dgvUsuarios.CurrentRow.Cells["Password"].Value.ToString();

                frmAdminSeguridad form = new frmAdminSeguridad(id, usuario, clave);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CargarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este usuario?",
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM Usuarios WHERE IdUsuario = {id}";
                    int filas = datos.EjecutarComando(query);

                    if (filas > 0)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.");
                        CargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
            }
        }
    }
}
