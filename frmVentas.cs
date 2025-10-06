using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace herra_emp1
{
    public partial class frmVentas : Form
    {
        private AccesoDatos datos;

        public frmVentas()
        {
            InitializeComponent();
            datos = new AccesoDatos();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                string query = "SELECT IdCliente, Nombre FROM Clientes";
                DataTable dt = datos.EjecutarConsulta(query);

                cmbClientes.DataSource = dt;
                cmbClientes.DisplayMember = "Nombre";
                cmbClientes.ValueMember = "IdCliente";
                cmbClientes.SelectedIndex = -1; // Ninguno seleccionado al inicio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClientes.SelectedValue == null || string.IsNullOrWhiteSpace(txtTotal.Text))
                {
                    MessageBox.Show("Debe seleccionar un cliente e ingresar el total.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idCliente = Convert.ToInt32(cmbClientes.SelectedValue);
                decimal total;

                if (!decimal.TryParse(txtTotal.Text, out total) || total <= 0)
                {
                    MessageBox.Show("Ingrese un monto válido para el total.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO Ventas (IdCliente, Fecha, Total) VALUES (@idCliente, @fecha, @total)";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@idCliente", SqlDbType.Int) { Value = idCliente },
                    new SqlParameter("@fecha", SqlDbType.DateTime) { Value = DateTime.Now },
                    new SqlParameter("@total", SqlDbType.Decimal) { Value = total }
                };

                int filas = datos.EjecutarComando(query, parametros);

                if (filas > 0)
                {
                    MessageBox.Show("Venta registrada correctamente.", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTotal.Clear();
                    cmbClientes.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la venta.", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message, "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID de la venta a eliminar:", "Eliminar Venta", "");

                if (string.IsNullOrWhiteSpace(input))
                    return;

                int idVenta;
                if (!int.TryParse(input, out idVenta))
                {
                    MessageBox.Show("ID de venta inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "DELETE FROM Ventas WHERE IdVenta = @idVenta";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@idVenta", SqlDbType.Int) { Value = idVenta }
                };

                int filas = datos.EjecutarComando(query, parametros);

                if (filas > 0)
                {
                    MessageBox.Show("Venta eliminada correctamente.", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna venta con ese ID.", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la venta: " + ex.Message, "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
