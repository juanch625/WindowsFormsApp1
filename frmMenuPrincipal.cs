using System;
using System.Windows.Forms;

namespace herra_emp1
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmListaClientes form = new frmListaClientes();
            form.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmListaProductos form = new frmListaProductos();
            form.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmListaUsuarios form = new frmListaUsuarios();
            form.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas form = new frmVentas();
            form.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategoriaProductos form = new frmCategoriaProductos();
            form.ShowDialog();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmFacturas form = new frmFacturas();
            form.ShowDialog();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmInformes form = new frmInformes();
            form.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados form = new frmEmpleados();
            form.ShowDialog();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmRolEmpleados form = new frmRolEmpleados();
            form.ShowDialog();
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            frmAdminSeguridad form = new frmAdminSeguridad();
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
