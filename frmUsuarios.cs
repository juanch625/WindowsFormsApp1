using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace herra_emp1
{
    public partial class frmUsuarios : Form
    {
        private int? idUsuario; // null = nuevo, con valor = editar
        private AccesoDatos datos;

        public frmUsuarios(int? idUsuario = null, string nombre = "", string usuario = "", string password = "")
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            datos = new AccesoDatos();

            if (idUsuario.HasValue)
            {
                txtNombre.Text = nombre;
                txtUsuario.Text = usuario;
                txtPassword.Text = password;
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            if (idUsuario == null)
                this.Text = "Nuevo Usuario";
            else
                this.Text = "Editar Usuario";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GuardarUsuario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idUsuario.HasValue)
                GuardarUsuario();
            else
                MessageBox.Show("Debe seleccionar un usuario para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void GuardarUsuario()
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string usuario = txtUsuario.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query;
                SqlParameter[] parametros;

                if (idUsuario == null)
                {
                    // Nuevo usuario
                    query = "INSERT INTO Usuarios (Nombre, Usuario, Password) VALUES (@nombre, @usuario, @password)";
                    parametros = new SqlParameter[]
                    {
                        new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre },
                        new SqlParameter("@usuario", SqlDbType.VarChar) { Value = usuario },
                        new SqlParameter("@password", SqlDbType.VarChar) { Value = password }
                    };
                }
                else
                {
                    // Editar usuario
                    query = "UPDATE Usuarios SET Nombre = @nombre, Usuario = @usuario, Password = @password WHERE IdUsuario = @idUsuario";
                    parametros = new SqlParameter[]
                    {
                        new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre },
                        new SqlParameter("@usuario", SqlDbType.VarChar) { Value = usuario },
                        new SqlParameter("@password", SqlDbType.VarChar) { Value = password },
                        new SqlParameter("@idUsuario", SqlDbType.Int) { Value = idUsuario.Value }
                    };
                }

                int filas = datos.EjecutarComando(query, parametros);

                if (filas > 0)
                {
                    MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!idUsuario.HasValue)
            {
                MessageBox.Show("Debe seleccionar un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Usuarios WHERE IdUsuario = @idUsuario";
                    SqlParameter[] parametros = new SqlParameter[]
                    {
                        new SqlParameter("@idUsuario", SqlDbType.Int) { Value = idUsuario.Value }
                    };

                    int filas = datos.EjecutarComando(query, parametros);

                    if (filas > 0)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
