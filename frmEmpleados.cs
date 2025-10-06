using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace herra_emp1
{
    public partial class frmEmpleados : Form
    {
        private AccesoDatos datos = new AccesoDatos();

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Empleados (Nombre, Documento, Direccion, Telefono, Email, Rol, FechaIngreso, FechaRetiro, DatosAdicionales) " +
                           "VALUES (@Nombre, @Documento, @Direccion, @Telefono, @Email, @Rol, @FechaIngreso, @FechaRetiro, @DatosAdicionales)";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Nombre", txtNombreEmpleado.Text),
                new SqlParameter("@Documento", txtDocumento.Text),
                new SqlParameter("@Direccion", txtDireccion.Text),
                new SqlParameter("@Telefono", txtTelefono.Text),
                new SqlParameter("@Email", txtEmail.Text),
                new SqlParameter("@Rol", cmbRolEmpleado.SelectedItem?.ToString() ?? "N/A"),
                new SqlParameter("@FechaIngreso", dtpIngreso.Value),
                new SqlParameter("@FechaRetiro", dtpRetiro.Value),
                new SqlParameter("@DatosAdicionales", txtDatosAdicionales.Text)
            };

            try
            {
                int filas = datos.EjecutarComando(query, parametros);
                MessageBox.Show($"Empleado agregado correctamente ({filas} fila(s)).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
