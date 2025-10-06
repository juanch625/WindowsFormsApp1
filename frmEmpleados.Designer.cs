namespace herra_emp1
{
    partial class frmEmpleados
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRolEmpleado;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblRetiro;
        private System.Windows.Forms.Label lblDatosAdicionales;

        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbRolEmpleado;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.DateTimePicker dtpRetiro;
        private System.Windows.Forms.TextBox txtDatosAdicionales;
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
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRolEmpleado = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblRetiro = new System.Windows.Forms.Label();
            this.lblDatosAdicionales = new System.Windows.Forms.Label();

            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbRolEmpleado = new System.Windows.Forms.ComboBox();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpRetiro = new System.Windows.Forms.DateTimePicker();
            this.txtDatosAdicionales = new System.Windows.Forms.TextBox();

            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(150, 10);
            this.lblTitulo.Text = "ADMINISTRACIÓN DE EMPLEADOS";

            // lblNombreEmpleado
            this.lblNombreEmpleado.Text = "Nombre Empleado:";
            this.lblNombreEmpleado.Location = new System.Drawing.Point(20, 50);

            // txtNombreEmpleado
            this.txtNombreEmpleado.Location = new System.Drawing.Point(150, 50);
            this.txtNombreEmpleado.Width = 200;

            // lblDocumento
            this.lblDocumento.Text = "Documento:";
            this.lblDocumento.Location = new System.Drawing.Point(20, 80);

            // txtDocumento
            this.txtDocumento.Location = new System.Drawing.Point(150, 80);
            this.txtDocumento.Width = 200;

            // lblDireccion
            this.lblDireccion.Text = "Dirección:";
            this.lblDireccion.Location = new System.Drawing.Point(20, 110);

            // txtDireccion
            this.txtDireccion.Location = new System.Drawing.Point(150, 110);
            this.txtDireccion.Width = 200;

            // lblTelefono
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.Location = new System.Drawing.Point(20, 140);

            // txtTelefono
            this.txtTelefono.Location = new System.Drawing.Point(150, 140);
            this.txtTelefono.Width = 200;

            // lblEmail
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(20, 170);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(150, 170);
            this.txtEmail.Width = 200;

            // lblRolEmpleado
            this.lblRolEmpleado.Text = "Rol Empleado:";
            this.lblRolEmpleado.Location = new System.Drawing.Point(20, 200);

            // cmbRolEmpleado
            this.cmbRolEmpleado.Location = new System.Drawing.Point(150, 200);
            this.cmbRolEmpleado.Width = 200;

            // lblIngreso
            this.lblIngreso.Text = "F. Ingreso:";
            this.lblIngreso.Location = new System.Drawing.Point(20, 230);

            // dtpIngreso
            this.dtpIngreso.Location = new System.Drawing.Point(150, 230);

            // lblRetiro
            this.lblRetiro.Text = "F. Retiro:";
            this.lblRetiro.Location = new System.Drawing.Point(20, 260);

            // dtpRetiro
            this.dtpRetiro.Location = new System.Drawing.Point(150, 260);

            // lblDatosAdicionales
            this.lblDatosAdicionales.Text = "Datos Adicionales:";
            this.lblDatosAdicionales.Location = new System.Drawing.Point(20, 290);

            // txtDatosAdicionales
            this.txtDatosAdicionales.Location = new System.Drawing.Point(150, 290);
            this.txtDatosAdicionales.Size = new System.Drawing.Size(200, 60);
            this.txtDatosAdicionales.Multiline = true;

            // btnActualizar
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.Location = new System.Drawing.Point(100, 370);
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // btnSalir
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Location = new System.Drawing.Point(250, 370);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // frmEmpleados
            this.ClientSize = new System.Drawing.Size(400, 430);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblRolEmpleado);
            this.Controls.Add(this.cmbRolEmpleado);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.dtpIngreso);
            this.Controls.Add(this.lblRetiro);
            this.Controls.Add(this.dtpRetiro);
            this.Controls.Add(this.lblDatosAdicionales);
            this.Controls.Add(this.txtDatosAdicionales);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnSalir);
            this.Text = "frmEmpleados";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
