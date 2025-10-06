using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace herra_emp1
{
    public partial class frmClientes : Form
    {
        private int? idCliente = null;
        private AccesoDatos datos;

        public frmClientes()
        {
            InitializeComponent();
            datos = new AccesoDatos();
        }

        // Constructor para editar
        public frmClientes(int idCliente) : this()
        {
            this.idCliente = idCliente;
            CargarCliente();
        }

        private void CargarCliente()
        {
            try
            {
                string query = "SELECT Nombre, Documento, Telefono, Email FROM Clientes WHERE IdCliente = @Id";
                var parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", idCliente)
                };

                DataTable dt = datos.EjecutarConsulta(query, parametros);

                if (dt.Rows.Count > 0)
                {
                    txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
                    txtDocumento.Text = dt.Rows[0]["Documento"].ToString();
                    txtTelefono.Text = dt.Rows[0]["Telefono"].ToString();
                    txtEmail.Text = dt.Rows[0]["Email"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cliente: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre del cliente.");
                    return;
                }

                if (idCliente == null) // Nuevo
                {
                    string query = "INSERT INTO Clientes (Nombre, Documento, Telefono, Email) " +
                                   "VALUES (@Nombre, @Documento, @Telefono, @Email)";
                    var parametros = new SqlParameter[]
                    {
                        new SqlParameter("@Nombre", txtNombre.Text),
                        new SqlParameter("@Documento", txtDocumento.Text),
                        new SqlParameter("@Telefono", txtTelefono.Text),
                        new SqlParameter("@Email", txtEmail.Text)
                    };

                    datos.EjecutarComando(query, parametros);
                    MessageBox.Show("Cliente agregado correctamente.");
                }
                else // Editar
                {
                    string query = "UPDATE Clientes SET Nombre=@Nombre, Documento=@Documento, " +
                                   "Telefono=@Telefono, Email=@Email WHERE IdCliente=@Id";
                    var parametros = new SqlParameter[]
                    {
                        new SqlParameter("@Nombre", txtNombre.Text),
                        new SqlParameter("@Documento", txtDocumento.Text),
                        new SqlParameter("@Telefono", txtTelefono.Text),
                        new SqlParameter("@Email", txtEmail.Text),
                        new SqlParameter("@Id", idCliente)
                    };

                    datos.EjecutarComando(query, parametros);
                    MessageBox.Show("Cliente actualizado correctamente.");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cliente: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
