namespace herra_emp1
{
    partial class frmRolEmpleados
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreRol;
        private System.Windows.Forms.Label lblDescripcionRol;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.TextBox txtDescripcionRol;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;

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
            this.lblNombreRol = new System.Windows.Forms.Label();
            this.lblDescripcionRol = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.txtDescripcionRol = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(100, 10);
            this.lblTitulo.Text = "ROL DE EMPLEADOS";

            // lblNombreRol
            this.lblNombreRol.Text = "Nombre Rol:";
            this.lblNombreRol.Location = new System.Drawing.Point(20, 50);

            // txtNombreRol
            this.txtNombreRol.Location = new System.Drawing.Point(150, 50);
            this.txtNombreRol.Width = 200;

            // lblDescripcionRol
            this.lblDescripcionRol.Text = "Descripción del Rol:";
            this.lblDescripcionRol.Location = new System.Drawing.Point(20, 90);

            // txtDescripcionRol
            this.txtDescripcionRol.Location = new System.Drawing.Point(150, 90);
            this.txtDescripcionRol.Multiline = true;
            this.txtDescripcionRol.Size = new System.Drawing.Size(200, 60);

            // btnActualizar
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.Location = new System.Drawing.Point(80, 180);
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // btnSalir
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Location = new System.Drawing.Point(200, 180);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // frmRolEmpleados
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombreRol);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.lblDescripcionRol);
            this.Controls.Add(this.txtDescripcionRol);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnSalir);
            this.Text = "frmRolEmpleados";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
