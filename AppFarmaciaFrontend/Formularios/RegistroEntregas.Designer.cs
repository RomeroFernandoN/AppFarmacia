namespace AppFarmaciaFrontend.Formularios
{
    partial class RegistroEntregas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroEntregas));
            this.GbInsumos = new System.Windows.Forms.GroupBox();
            this.dtpFechaFabricacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFabricacion = new System.Windows.Forms.Label();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nudCantidadInsumos = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAgregarInsumo = new System.Windows.Forms.Button();
            this.cboInsumo = new System.Windows.Forms.ComboBox();
            this.lblInsumo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.GbSucursal = new System.Windows.Forms.GroupBox();
            this.txtEmpleadoLogistica = new System.Windows.Forms.TextBox();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.lblEmpleadoLogistica = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtNroEntrega = new System.Windows.Forms.TextBox();
            this.lblNroEntrega = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GbInsumos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadInsumos)).BeginInit();
            this.GbSucursal.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbInsumos
            // 
            this.GbInsumos.BackColor = System.Drawing.Color.Transparent;
            this.GbInsumos.Controls.Add(this.dtpFechaFabricacion);
            this.GbInsumos.Controls.Add(this.lblFechaFabricacion);
            this.GbInsumos.Controls.Add(this.dgvInsumos);
            this.GbInsumos.Controls.Add(this.nudCantidadInsumos);
            this.GbInsumos.Controls.Add(this.lblCantidad);
            this.GbInsumos.Controls.Add(this.btnAgregarInsumo);
            this.GbInsumos.Controls.Add(this.cboInsumo);
            this.GbInsumos.Controls.Add(this.lblInsumo);
            this.GbInsumos.ForeColor = System.Drawing.Color.Black;
            this.GbInsumos.Location = new System.Drawing.Point(33, 275);
            this.GbInsumos.Name = "GbInsumos";
            this.GbInsumos.Size = new System.Drawing.Size(518, 264);
            this.GbInsumos.TabIndex = 40;
            this.GbInsumos.TabStop = false;
            this.GbInsumos.Text = "Insumos.";
            // 
            // dtpFechaFabricacion
            // 
            this.dtpFechaFabricacion.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.dtpFechaFabricacion.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.dtpFechaFabricacion.Location = new System.Drawing.Point(174, 65);
            this.dtpFechaFabricacion.Name = "dtpFechaFabricacion";
            this.dtpFechaFabricacion.Size = new System.Drawing.Size(205, 26);
            this.dtpFechaFabricacion.TabIndex = 44;
            // 
            // lblFechaFabricacion
            // 
            this.lblFechaFabricacion.AutoSize = true;
            this.lblFechaFabricacion.Location = new System.Drawing.Point(20, 69);
            this.lblFechaFabricacion.Name = "lblFechaFabricacion";
            this.lblFechaFabricacion.Size = new System.Drawing.Size(148, 18);
            this.lblFechaFabricacion.TabIndex = 43;
            this.lblFechaFabricacion.Text = "Fecha fabricación:";
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInsumos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colInsumo,
            this.colCantidad,
            this.colAcciones});
            this.dgvInsumos.Location = new System.Drawing.Point(26, 107);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInsumos.RowHeadersWidth = 51;
            this.dgvInsumos.RowTemplate.Height = 24;
            this.dgvInsumos.Size = new System.Drawing.Size(472, 137);
            this.dgvInsumos.TabIndex = 29;
            this.dgvInsumos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsumos_CellContentClick);
            // 
            // colItem
            // 
            this.colItem.HeaderText = "Item";
            this.colItem.MinimumWidth = 6;
            this.colItem.Name = "colItem";
            // 
            // colInsumo
            // 
            this.colInsumo.HeaderText = "Insumo";
            this.colInsumo.MinimumWidth = 6;
            this.colInsumo.Name = "colInsumo";
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            // 
            // colAcciones
            // 
            this.colAcciones.HeaderText = "Eliminar";
            this.colAcciones.MinimumWidth = 6;
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAcciones.Text = "Elminar.";
            this.colAcciones.UseColumnTextForButtonValue = true;
            // 
            // nudCantidadInsumos
            // 
            this.nudCantidadInsumos.ForeColor = System.Drawing.Color.Black;
            this.nudCantidadInsumos.Location = new System.Drawing.Point(403, 27);
            this.nudCantidadInsumos.Name = "nudCantidadInsumos";
            this.nudCantidadInsumos.Size = new System.Drawing.Size(96, 26);
            this.nudCantidadInsumos.TabIndex = 28;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(318, 29);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(81, 18);
            this.lblCantidad.TabIndex = 27;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnAgregarInsumo
            // 
            this.btnAgregarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnAgregarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarInsumo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarInsumo.Location = new System.Drawing.Point(403, 64);
            this.btnAgregarInsumo.Name = "btnAgregarInsumo";
            this.btnAgregarInsumo.Size = new System.Drawing.Size(96, 27);
            this.btnAgregarInsumo.TabIndex = 12;
            this.btnAgregarInsumo.Text = "Agregar.";
            this.btnAgregarInsumo.UseVisualStyleBackColor = false;
            this.btnAgregarInsumo.Click += new System.EventHandler(this.btnAgregarInsumo_Click);
            // 
            // cboInsumo
            // 
            this.cboInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInsumo.ForeColor = System.Drawing.Color.Black;
            this.cboInsumo.FormattingEnabled = true;
            this.cboInsumo.Location = new System.Drawing.Point(98, 25);
            this.cboInsumo.Name = "cboInsumo";
            this.cboInsumo.Size = new System.Drawing.Size(194, 26);
            this.cboInsumo.TabIndex = 11;
            // 
            // lblInsumo
            // 
            this.lblInsumo.AutoSize = true;
            this.lblInsumo.Location = new System.Drawing.Point(20, 29);
            this.lblInsumo.Name = "lblInsumo";
            this.lblInsumo.Size = new System.Drawing.Size(64, 18);
            this.lblInsumo.TabIndex = 10;
            this.lblInsumo.Text = "Insumo:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(323, 547);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(110, 33);
            this.btnConfirmar.TabIndex = 39;
            this.btnConfirmar.Text = "Confirmar.";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(444, 547);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 33);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.Text = "Salir.";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(35, 547);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 33);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar.";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // GbSucursal
            // 
            this.GbSucursal.BackColor = System.Drawing.Color.Transparent;
            this.GbSucursal.Controls.Add(this.txtEmpleadoLogistica);
            this.GbSucursal.Controls.Add(this.cboSucursal);
            this.GbSucursal.Controls.Add(this.lblEmpleadoLogistica);
            this.GbSucursal.Controls.Add(this.cboEmpleado);
            this.GbSucursal.Controls.Add(this.lblSucursal);
            this.GbSucursal.Controls.Add(this.dtpFechaEntrega);
            this.GbSucursal.Controls.Add(this.lblFecha);
            this.GbSucursal.Controls.Add(this.lblEmpleado);
            this.GbSucursal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GbSucursal.ForeColor = System.Drawing.Color.Black;
            this.GbSucursal.Location = new System.Drawing.Point(33, 86);
            this.GbSucursal.Name = "GbSucursal";
            this.GbSucursal.Size = new System.Drawing.Size(518, 183);
            this.GbSucursal.TabIndex = 36;
            this.GbSucursal.TabStop = false;
            this.GbSucursal.Text = "Sucursal";
            // 
            // txtEmpleadoLogistica
            // 
            this.txtEmpleadoLogistica.ForeColor = System.Drawing.Color.Black;
            this.txtEmpleadoLogistica.Location = new System.Drawing.Point(208, 134);
            this.txtEmpleadoLogistica.Name = "txtEmpleadoLogistica";
            this.txtEmpleadoLogistica.Size = new System.Drawing.Size(290, 26);
            this.txtEmpleadoLogistica.TabIndex = 42;
            // 
            // cboSucursal
            // 
            this.cboSucursal.BackColor = System.Drawing.Color.White;
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.ForeColor = System.Drawing.Color.Black;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(128, 57);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(370, 26);
            this.cboSucursal.TabIndex = 24;
            // 
            // lblEmpleadoLogistica
            // 
            this.lblEmpleadoLogistica.AutoSize = true;
            this.lblEmpleadoLogistica.Location = new System.Drawing.Point(32, 137);
            this.lblEmpleadoLogistica.Name = "lblEmpleadoLogistica";
            this.lblEmpleadoLogistica.Size = new System.Drawing.Size(154, 18);
            this.lblEmpleadoLogistica.TabIndex = 41;
            this.lblEmpleadoLogistica.Text = "Empleado logistica:";
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.BackColor = System.Drawing.Color.White;
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.ForeColor = System.Drawing.Color.Black;
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(128, 20);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(370, 26);
            this.cboEmpleado.TabIndex = 23;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(30, 62);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(73, 18);
            this.lblSucursal.TabIndex = 21;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.dtpFechaEntrega.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.dtpFechaEntrega.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.dtpFechaEntrega.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.dtpFechaEntrega.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaEntrega.Location = new System.Drawing.Point(98, 96);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(400, 26);
            this.dtpFechaEntrega.TabIndex = 20;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(32, 99);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 18);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(30, 26);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(88, 18);
            this.lblEmpleado.TabIndex = 16;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // txtNroEntrega
            // 
            this.txtNroEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(236)))));
            this.txtNroEntrega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNroEntrega.Enabled = false;
            this.txtNroEntrega.Location = new System.Drawing.Point(183, 58);
            this.txtNroEntrega.Name = "txtNroEntrega";
            this.txtNroEntrega.Size = new System.Drawing.Size(47, 19);
            this.txtNroEntrega.TabIndex = 35;
            // 
            // lblNroEntrega
            // 
            this.lblNroEntrega.AutoSize = true;
            this.lblNroEntrega.BackColor = System.Drawing.Color.Transparent;
            this.lblNroEntrega.ForeColor = System.Drawing.Color.Black;
            this.lblNroEntrega.Location = new System.Drawing.Point(29, 59);
            this.lblNroEntrega.Name = "lblNroEntrega";
            this.lblNroEntrega.Size = new System.Drawing.Size(155, 18);
            this.lblNroEntrega.TabIndex = 34;
            this.lblNroEntrega.Text = "Número de Entrega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "Registre una entrega.";
            // 
            // RegistroEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(577, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GbInsumos);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.GbSucursal);
            this.Controls.Add(this.txtNroEntrega);
            this.Controls.Add(this.lblNroEntrega);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(900, 235);
            this.Name = "RegistroEntregas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Registro Entrega.";
            this.Load += new System.EventHandler(this.RegistroEntregas_Load);
            this.GbInsumos.ResumeLayout(false);
            this.GbInsumos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadInsumos)).EndInit();
            this.GbSucursal.ResumeLayout(false);
            this.GbSucursal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbInsumos;
        private System.Windows.Forms.DateTimePicker dtpFechaFabricacion;
        private System.Windows.Forms.Label lblFechaFabricacion;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.NumericUpDown nudCantidadInsumos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAgregarInsumo;
        private System.Windows.Forms.ComboBox cboInsumo;
        private System.Windows.Forms.Label lblInsumo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox GbSucursal;
        private System.Windows.Forms.TextBox txtEmpleadoLogistica;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.Label lblEmpleadoLogistica;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtNroEntrega;
        private System.Windows.Forms.Label lblNroEntrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
    }
}