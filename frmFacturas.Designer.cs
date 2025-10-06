namespace herra_emp1
{
    partial class frmFacturas
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNoFactura;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblTotalIVA;
        private System.Windows.Forms.TextBox txtTotalIVA;
        private System.Windows.Forms.Label lblTotalFactura;
        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDetalleFactura;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNoFactura = new System.Windows.Forms.Label();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblTotalIVA = new System.Windows.Forms.Label();
            this.txtTotalIVA = new System.Windows.Forms.TextBox();
            this.lblTotalFactura = new System.Windows.Forms.Label();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.lblDetalleFactura = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(180, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(240, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ADMINISTRACIÓN FACTURAS";
            // 
            // lblNoFactura
            // 
            this.lblNoFactura.AutoSize = true;
            this.lblNoFactura.Location = new System.Drawing.Point(30, 50);
            this.lblNoFactura.Name = "lblNoFactura";
            this.lblNoFactura.Size = new System.Drawing.Size(65, 15);
            this.lblNoFactura.TabIndex = 1;
            this.lblNoFactura.Text = "No Factura";
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Location = new System.Drawing.Point(120, 47);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(100, 23);
            this.txtNoFactura.TabIndex = 2;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(30, 80);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.Location = new System.Drawing.Point(120, 77);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(180, 23);
            this.cbCliente.TabIndex = 4;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(30, 110);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(61, 15);
            this.lblEmpleado.TabIndex = 5;
            this.lblEmpleado.Text = "Empleado";
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleado.Location = new System.Drawing.Point(120, 107);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(180, 23);
            this.cbEmpleado.TabIndex = 6;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(30, 140);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(63, 15);
            this.lblDescuento.TabIndex = 7;
            this.lblDescuento.Text = "Descuento";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(120, 137);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 23);
            this.txtDescuento.TabIndex = 8;
            // 
            // lblTotalIVA
            // 
            this.lblTotalIVA.AutoSize = true;
            this.lblTotalIVA.Location = new System.Drawing.Point(30, 170);
            this.lblTotalIVA.Name = "lblTotalIVA";
            this.lblTotalIVA.Size = new System.Drawing.Size(52, 15);
            this.lblTotalIVA.TabIndex = 9;
            this.lblTotalIVA.Text = "Total IVA";
            // 
            // txtTotalIVA
            // 
            this.txtTotalIVA.Location = new System.Drawing.Point(120, 167);
            this.txtTotalIVA.Name = "txtTotalIVA";
            this.txtTotalIVA.Size = new System.Drawing.Size(100, 23);
            this.txtTotalIVA.TabIndex = 10;
            // 
            // lblTotalFactura
            // 
            this.lblTotalFactura.AutoSize = true;
            this.lblTotalFactura.Location = new System.Drawing.Point(30, 200);
            this.lblTotalFactura.Name = "lblTotalFactura";
            this.lblTotalFactura.Size = new System.Drawing.Size(74, 15);
            this.lblTotalFactura.TabIndex = 11;
            this.lblTotalFactura.Text = "Total Factura";
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Location = new System.Drawing.Point(120, 197);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(100, 23);
            this.txtTotalFactura.TabIndex = 12;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(330, 50);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(91, 15);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha Realizado";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(430, 47);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(120, 23);
            this.dtpFecha.TabIndex = 14;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(330, 80);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(83, 15);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Estado Factura";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Location = new System.Drawing.Point(430, 77);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(120, 23);
            this.cbEstado.TabIndex = 16;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(580, 47);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 30);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(580, 80);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblDetalleFactura
            // 
            this.lblDetalleFactura.AutoSize = true;
            this.lblDetalleFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetalleFactura.Location = new System.Drawing.Point(30, 240);
            this.lblDetalleFactura.Name = "lblDetalleFactura";
            this.lblDetalleFactura.Size = new System.Drawing.Size(128, 19);
            this.lblDetalleFactura.TabIndex = 19;
            this.lblDetalleFactura.Text = "DETALLE FACTURA";
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Location = new System.Drawing.Point(30, 265);
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.Size = new System.Drawing.Size(650, 200);
            this.dgvDetalleFactura.TabIndex = 20;
            // 
            // frmFacturas
            // 
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.Controls.Add(this.dgvDetalleFactura);
            this.Controls.Add(this.lblDetalleFactura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtTotalFactura);
            this.Controls.Add(this.lblTotalFactura);
            this.Controls.Add(this.txtTotalIVA);
            this.Controls.Add(this.lblTotalIVA);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtNoFactura);
            this.Controls.Add(this.lblNoFactura);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
