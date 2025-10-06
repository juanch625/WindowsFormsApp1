namespace herra_emp1
{
    partial class frmInformes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.ComboBox cmbCriterio;
        private System.Windows.Forms.RadioButton rdbPdf;
        private System.Windows.Forms.RadioButton rdbExcel;
        private System.Windows.Forms.Button btnGenerarInforme;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvInformes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.rdbPdf = new System.Windows.Forms.RadioButton();
            this.rdbExcel = new System.Windows.Forms.RadioButton();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvInformes = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(150, 10);
            this.lblTitulo.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";

            // lblFechaInicio
            this.lblFechaInicio.Text = "Fecha Inicio:";
            this.lblFechaInicio.Location = new System.Drawing.Point(20, 50);

            // lblFechaFin
            this.lblFechaFin.Text = "Fecha Final:";
            this.lblFechaFin.Location = new System.Drawing.Point(250, 50);

            // lblCriterio
            this.lblCriterio.Text = "Criterio:";
            this.lblCriterio.Location = new System.Drawing.Point(480, 50);

            // dtpFechaInicio
            this.dtpFechaInicio.Location = new System.Drawing.Point(100, 50);

            // dtpFechaFin
            this.dtpFechaFin.Location = new System.Drawing.Point(320, 50);

            // cmbCriterio
            this.cmbCriterio.Location = new System.Drawing.Point(540, 50);
            this.cmbCriterio.Size = new System.Drawing.Size(150, 23);

            // rdbPdf
            this.rdbPdf.Text = "En PDF";
            this.rdbPdf.Location = new System.Drawing.Point(100, 80);

            // rdbExcel
            this.rdbExcel.Text = "En Excel";
            this.rdbExcel.Location = new System.Drawing.Point(180, 80);

            // btnGenerarInforme
            this.btnGenerarInforme.Text = "GENERAR INFORME";
            this.btnGenerarInforme.Location = new System.Drawing.Point(350, 80);
            this.btnGenerarInforme.Click += new System.EventHandler(this.btnGenerarInforme_Click);

            // btnSalir
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Location = new System.Drawing.Point(500, 80);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // dgvInformes
            this.dgvInformes.Location = new System.Drawing.Point(20, 120);
            this.dgvInformes.Size = new System.Drawing.Size(670, 250);

            // frmInformes
            this.ClientSize = new System.Drawing.Size(720, 400);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.cmbCriterio);
            this.Controls.Add(this.rdbPdf);
            this.Controls.Add(this.rdbExcel);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvInformes);
            this.Text = "frmInformes";

            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
