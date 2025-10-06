using System;
using System.Data;
using System.Windows.Forms;

namespace herra_emp1
{
    public partial class frmListaClientes : Form
    {
        private AccesoDatos datos;

        public frmListaClientes()
        {
            InitializeComponent();
            datos = new AccesoDatos();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                string query = "SELECT IdCliente, Nombre, Documento, Telefono, Email FROM Clientes";
                DataTable dt = datos.EjecutarConsulta(query);
                dgvClientes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmClientes form = new frmClientes();
            form.ShowDialog();
            CargarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null &&
                dgvClientes.CurrentRow.Cells["IdCliente"].Value != null)
            {
                int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["IdCliente"].Value);
                frmClientes form = new frmClientes(idCliente);
                form.ShowDialog();
                CargarClientes();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.CurrentRow != null &&
                    dgvClientes.CurrentRow.Cells["IdCliente"].Value != null &&
                    int.TryParse(dgvClientes.CurrentRow.Cells["IdCliente"].Value.ToString(), out int idCliente))
                {
                    DialogResult result = MessageBox.Show(
                        "¿Está seguro de eliminar este cliente?",
                        "Confirmar Eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        string query = "DELETE FROM Clientes WHERE IdCliente = @Id";
                        var parametros = new System.Data.SqlClient.SqlParameter[]
                        {
                            new System.Data.SqlClient.SqlParameter("@Id", idCliente)
                        };

                        int filas = datos.EjecutarComando(query, parametros);

                        if (filas > 0)
                        {
                            MessageBox.Show("Cliente eliminado correctamente.");
                            CargarClientes();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el cliente.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un cliente válido para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente: " + ex.Message);
            }
        }
    }
}
