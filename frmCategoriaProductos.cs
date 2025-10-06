using System;
using System.Data;
using System.Windows.Forms;

namespace herra_emp1
{
    public partial class frmCategoriaProductos : Form
    {
        // Simulación de base de datos en memoria (puedes luego conectar a SQL)
        private DataTable dtCategorias;

        public frmCategoriaProductos()
        {
            InitializeComponent();
            InicializarTabla();
            CargarCategorias();
        }

        private void InicializarTabla()
        {
            dtCategorias = new DataTable();
            dtCategorias.Columns.Add("IdCategoria", typeof(int));
            dtCategorias.Columns.Add("NombreCategoria", typeof(string));

            // Autoincrement para simular PK
            dtCategorias.Columns["IdCategoria"].AutoIncrement = true;
            dtCategorias.Columns["IdCategoria"].AutoIncrementSeed = 1;
            dtCategorias.Columns["IdCategoria"].AutoIncrementStep = 1;
        }

        private void CargarCategorias()
        {
            dgvCategorias.DataSource = dtCategorias;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de categoría.");
                return;
            }

            DataRow fila = dtCategorias.NewRow();
            fila["NombreCategoria"] = txtNombreCategoria.Text;
            dtCategorias.Rows.Add(fila);

            txtNombreCategoria.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categoría para actualizar.");
                return;
            }

            dgvCategorias.CurrentRow.Cells["NombreCategoria"].Value = txtNombreCategoria.Text;
            txtNombreCategoria.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categoría para eliminar.");
                return;
            }

            dgvCategorias.Rows.RemoveAt(dgvCategorias.CurrentRow.Index);
            txtNombreCategoria.Clear();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNombreCategoria.Text = dgvCategorias.Rows[e.RowIndex].Cells["NombreCategoria"].Value.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
