using System;
using System.Data;
using System.Windows.Forms;

namespace herra_emp1
{
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            // Lógica básica de generación de informe
            string criterio = cmbCriterio.SelectedItem?.ToString() ?? "N/A";
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;
            string formato = rdbPdf.Checked ? "PDF" : "Excel";

            MessageBox.Show($"Generando informe...\n\n" +
                            $"Criterio: {criterio}\n" +
                            $"Desde: {fechaInicio.ToShortDateString()} Hasta: {fechaFin.ToShortDateString()}\n" +
                            $"Formato: {formato}");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
