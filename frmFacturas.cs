using System;
using System.Data;
using System.Windows.Forms;

namespace herra_emp1
{
    public partial class frmFacturas : Form
    {
        private DataTable dtFacturaDetalle;

        public frmFacturas()
        {
            InitializeComponent();
            InicializarTablaDetalle();
            CargarDetalleFactura();
            InicializarCombos();
        }

        private void InicializarTablaDetalle()
        {
            dtFacturaDetalle = new DataTable();
            dtFacturaDetalle.Columns.Add("Producto", typeof(string));
            dtFacturaDetalle.Columns.Add("Cantidad", typeof(int));
            dtFacturaDetalle.Columns.Add("PrecioUnitario", typeof(decimal));
            dtFacturaDetalle.Columns.Add("Subtotal", typeof(decimal), "Cantidad * PrecioUnitario");
        }

        private void CargarDetalleFactura()
        {
            dgvDetalleFactura.DataSource = dtFacturaDetalle;
        }

        private void InicializarCombos()
        {
            // Clientes de ejemplo
            cbCliente.Items.AddRange(new object[] { "Juan Pérez", "María Gómez", "Carlos Ruiz" });

            // Empleados de ejemplo
            cbEmpleado.Items.AddRange(new object[] { "Empleado 1", "Empleado 2", "Empleado 3" });

            // Estado Factura
            cbEstado.Items.AddRange(new object[] { "Pendiente", "Pagada", "Anulada" });

            if (cbCliente.Items.Count > 0) cbCliente.SelectedIndex = 0;
            if (cbEmpleado.Items.Count > 0) cbEmpleado.SelectedIndex = 0;
            if (cbEstado.Items.Count > 0) cbEstado.SelectedIndex = 0;
        }

        private void CalcularTotales()
        {
            decimal total = 0;
            foreach (DataRow fila in dtFacturaDetalle.Rows)
            {
                total += Convert.ToDecimal(fila["Subtotal"]);
            }

            decimal descuento = 0;
            if (!string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                decimal.TryParse(txtDescuento.Text, out descuento);
            }

            decimal totalConDescuento = total - descuento;
            decimal iva = totalConDescuento * 0.19m; // 19% IVA ejemplo
            decimal totalFactura = totalConDescuento + iva;

            txtTotalIVA.Text = iva.ToString("N2");
            txtTotalFactura.Text = totalFactura.ToString("N2");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoFactura.Text))
            {
                MessageBox.Show("Debe ingresar el número de factura.");
                return;
            }

            if (dtFacturaDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un producto en el detalle.");
                return;
            }

            CalcularTotales();
            MessageBox.Show("Factura actualizada con éxito.");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
