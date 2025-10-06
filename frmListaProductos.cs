using System;
using System.Data;
using System.Windows.Forms;

namespace herra_emp1
{
    public partial class frmListaProductos : Form
    {
        private AccesoDatos datos = new AccesoDatos();

        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                string query = "SELECT IdProducto, Nombre, Descripcion, Precio, Stock FROM Productos";
                DataTable dt = datos.EjecutarConsulta(query);
                dgvProductos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProductos form = new frmProductos();
            if (form.ShowDialog() == DialogResult.OK)
            {
                CargarProductos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["IdProducto"].Value);
                string nombre = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                string descripcion = dgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                decimal precio = Convert.ToDecimal(dgvProductos.CurrentRow.Cells["Precio"].Value);
                int stock = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Stock"].Value);

                frmProductos form = new frmProductos(idProducto, nombre, descripcion, precio, stock);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CargarProductos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["IdProducto"].Value);
                DialogResult result = MessageBox.Show("¿Eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM Productos WHERE IdProducto = {idProducto}";
                    datos.EjecutarComando(query);
                    CargarProductos();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}
