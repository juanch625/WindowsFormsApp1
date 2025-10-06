using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace herra_emp1
{
    public partial class frmProductos : Form
    {
        private int? idProducto; // null = nuevo, con valor = editar
        private AccesoDatos datos;

        public frmProductos(int? idProducto = null, string nombre = "", string descripcion = "", decimal precio = 0, int stock = 0)
        {
            InitializeComponent();
            this.idProducto = idProducto;
            datos = new AccesoDatos();

            if (idProducto.HasValue)
            {
                txtNombre.Text = nombre;
                txtDescripcion.Text = descripcion;
                txtPrecio.Text = precio.ToString("N2");
                txtStock.Text = stock.ToString();
            }
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            if (idProducto == null)
                this.Text = "Nuevo Producto";
            else
                this.Text = "Editar Producto";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();
                decimal precio;
                int stock;

                if (string.IsNullOrWhiteSpace(nombre) ||
                    !decimal.TryParse(txtPrecio.Text, out precio) ||
                    !int.TryParse(txtStock.Text, out stock))
                {
                    MessageBox.Show("Complete correctamente los datos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query;
                SqlParameter[] parametros;

                if (idProducto == null)
                {
                    // Nuevo producto
                    query = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock) VALUES (@nombre, @descripcion, @precio, @stock)";

                    parametros = new SqlParameter[]
                    {
                        new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre },
                        new SqlParameter("@descripcion", SqlDbType.VarChar) { Value = descripcion },
                        new SqlParameter("@precio", SqlDbType.Decimal) { Value = precio },
                        new SqlParameter("@stock", SqlDbType.Int) { Value = stock }
                    };
                }
                else
                {
                    // Editar producto
                    query = "UPDATE Productos SET Nombre = @nombre, Descripcion = @descripcion, Precio = @precio, Stock = @stock WHERE IdProducto = @idProducto";

                    parametros = new SqlParameter[]
                    {
                        new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre },
                        new SqlParameter("@descripcion", SqlDbType.VarChar) { Value = descripcion },
                        new SqlParameter("@precio", SqlDbType.Decimal) { Value = precio },
                        new SqlParameter("@stock", SqlDbType.Int) { Value = stock },
                        new SqlParameter("@idProducto", SqlDbType.Int) { Value = idProducto.Value }
                    };
                }

                int filas = datos.EjecutarComando(query, parametros);

                if (filas > 0)
                {
                    MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar? Se perderán los cambios no guardados.", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProductos form = new frmProductos();
            if (form.ShowDialog() == DialogResult.OK)
            {
                CargarProductos(); // Recarga la lista después de agregar
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
                    CargarProductos(); // Recarga la lista después de editar
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para editar.");
            }
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
    }
}
