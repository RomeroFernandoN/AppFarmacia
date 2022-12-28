namespace AppFarmaciaFrontend.Formularios
{
    partial class FormFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactura));
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.txtNombreMed = new System.Windows.Forms.TextBox();
            this.lblNombreMed = new System.Windows.Forms.Label();
            this.txtApellidoMed = new System.Windows.Forms.TextBox();
            this.lblApellidoMed = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatriculaMed = new System.Windows.Forms.TextBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.txtDianostico = new System.Windows.Forms.TextBox();
            this.lblInsumo = new System.Windows.Forms.Label();
            this.cboInsumo = new System.Windows.Forms.ComboBox();
            this.btnAgregarInsumo = new System.Windows.Forms.Button();
            this.GbReceta = new System.Windows.Forms.GroupBox();
            this.cboObraSocial = new System.Windows.Forms.ComboBox();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.txtNroDocCli = new System.Windows.Forms.TextBox();
            this.lblNroDocCli = new System.Windows.Forms.Label();
            this.txtApellidoCli = new System.Windows.Forms.TextBox();
            this.lblApellidoCli = new System.Windows.Forms.Label();
            this.txtNombreCli = new System.Windows.Forms.TextBox();
            this.lblNombreCli = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.GbSucursal = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidadInsumos = new System.Windows.Forms.NumericUpDown();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.GbInsumos = new System.Windows.Forms.GroupBox();
            this.lblTipoCompra = new System.Windows.Forms.Label();
            this.CbObraSocial = new System.Windows.Forms.CheckBox();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.GbReceta.SuspendLayout();
            this.GbCliente.SuspendLayout();
            this.GbSucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadInsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.GbInsumos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblNroFactura.Location = new System.Drawing.Point(26, 53);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(151, 18);
            this.lblNroFactura.TabIndex = 0;
            this.lblNroFactura.Text = "Número de factura:";
            // 
            // txtNombreMed
            // 
            this.txtNombreMed.Location = new System.Drawing.Point(193, 31);
            this.txtNombreMed.Name = "txtNombreMed";
            this.txtNombreMed.Size = new System.Drawing.Size(235, 26);
            this.txtNombreMed.TabIndex = 3;
            // 
            // lblNombreMed
            // 
            this.lblNombreMed.AutoSize = true;
            this.lblNombreMed.Location = new System.Drawing.Point(21, 35);
            this.lblNombreMed.Name = "lblNombreMed";
            this.lblNombreMed.Size = new System.Drawing.Size(162, 18);
            this.lblNombreMed.TabIndex = 2;
            this.lblNombreMed.Text = "Nombre del médico:";
            // 
            // txtApellidoMed
            // 
            this.txtApellidoMed.Location = new System.Drawing.Point(193, 69);
            this.txtApellidoMed.Name = "txtApellidoMed";
            this.txtApellidoMed.Size = new System.Drawing.Size(234, 26);
            this.txtApellidoMed.TabIndex = 5;
            // 
            // lblApellidoMed
            // 
            this.lblApellidoMed.AutoSize = true;
            this.lblApellidoMed.Location = new System.Drawing.Point(22, 72);
            this.lblApellidoMed.Name = "lblApellidoMed";
            this.lblApellidoMed.Size = new System.Drawing.Size(165, 18);
            this.lblApellidoMed.TabIndex = 4;
            this.lblApellidoMed.Text = "Apellido del médico:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(24, 111);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(82, 18);
            this.lblMatricula.TabIndex = 6;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // txtMatriculaMed
            // 
            this.txtMatriculaMed.Location = new System.Drawing.Point(115, 108);
            this.txtMatriculaMed.Name = "txtMatriculaMed";
            this.txtMatriculaMed.Size = new System.Drawing.Size(312, 26);
            this.txtMatriculaMed.TabIndex = 7;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(457, 36);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(199, 18);
            this.lblDiagnostico.TabIndex = 8;
            this.lblDiagnostico.Text = "Diágnostico del paciente:";
            // 
            // txtDianostico
            // 
            this.txtDianostico.Location = new System.Drawing.Point(457, 71);
            this.txtDianostico.Multiline = true;
            this.txtDianostico.Name = "txtDianostico";
            this.txtDianostico.Size = new System.Drawing.Size(421, 24);
            this.txtDianostico.TabIndex = 9;
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
            // cboInsumo
            // 
            this.cboInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInsumo.FormattingEnabled = true;
            this.cboInsumo.Location = new System.Drawing.Point(114, 25);
            this.cboInsumo.Name = "cboInsumo";
            this.cboInsumo.Size = new System.Drawing.Size(324, 26);
            this.cboInsumo.TabIndex = 11;
            // 
            // btnAgregarInsumo
            // 
            this.btnAgregarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnAgregarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarInsumo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarInsumo.Location = new System.Drawing.Point(747, 26);
            this.btnAgregarInsumo.Name = "btnAgregarInsumo";
            this.btnAgregarInsumo.Size = new System.Drawing.Size(132, 28);
            this.btnAgregarInsumo.TabIndex = 12;
            this.btnAgregarInsumo.Text = "Agregar.";
            this.btnAgregarInsumo.UseVisualStyleBackColor = false;
            this.btnAgregarInsumo.Click += new System.EventHandler(this.btnAgregarInsumo_Click);
            // 
            // GbReceta
            // 
            this.GbReceta.BackColor = System.Drawing.Color.Transparent;
            this.GbReceta.Controls.Add(this.cboObraSocial);
            this.GbReceta.Controls.Add(this.lblObraSocial);
            this.GbReceta.Controls.Add(this.txtDianostico);
            this.GbReceta.Controls.Add(this.lblDiagnostico);
            this.GbReceta.Controls.Add(this.txtMatriculaMed);
            this.GbReceta.Controls.Add(this.lblMatricula);
            this.GbReceta.Controls.Add(this.txtApellidoMed);
            this.GbReceta.Controls.Add(this.lblApellidoMed);
            this.GbReceta.Controls.Add(this.txtNombreMed);
            this.GbReceta.Controls.Add(this.lblNombreMed);
            this.GbReceta.Location = new System.Drawing.Point(26, 86);
            this.GbReceta.Name = "GbReceta";
            this.GbReceta.Size = new System.Drawing.Size(907, 153);
            this.GbReceta.TabIndex = 13;
            this.GbReceta.TabStop = false;
            this.GbReceta.Text = "Receta";
            this.GbReceta.Enter += new System.EventHandler(this.GbReceta_Enter);
            // 
            // cboObraSocial
            // 
            this.cboObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObraSocial.FormattingEnabled = true;
            this.cboObraSocial.Location = new System.Drawing.Point(563, 108);
            this.cboObraSocial.Name = "cboObraSocial";
            this.cboObraSocial.Size = new System.Drawing.Size(315, 26);
            this.cboObraSocial.TabIndex = 25;
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Location = new System.Drawing.Point(457, 115);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(100, 18);
            this.lblObraSocial.TabIndex = 10;
            this.lblObraSocial.Text = "Obra Social:";
            // 
            // txtNroDocCli
            // 
            this.txtNroDocCli.Location = new System.Drawing.Point(138, 101);
            this.txtNroDocCli.Name = "txtNroDocCli";
            this.txtNroDocCli.Size = new System.Drawing.Size(268, 26);
            this.txtNroDocCli.TabIndex = 15;
            // 
            // lblNroDocCli
            // 
            this.lblNroDocCli.AutoSize = true;
            this.lblNroDocCli.Location = new System.Drawing.Point(25, 104);
            this.lblNroDocCli.Name = "lblNroDocCli";
            this.lblNroDocCli.Size = new System.Drawing.Size(99, 18);
            this.lblNroDocCli.TabIndex = 14;
            this.lblNroDocCli.Text = "Documento:";
            // 
            // txtApellidoCli
            // 
            this.txtApellidoCli.Location = new System.Drawing.Point(193, 61);
            this.txtApellidoCli.Name = "txtApellidoCli";
            this.txtApellidoCli.Size = new System.Drawing.Size(212, 26);
            this.txtApellidoCli.TabIndex = 13;
            // 
            // lblApellidoCli
            // 
            this.lblApellidoCli.AutoSize = true;
            this.lblApellidoCli.Location = new System.Drawing.Point(24, 65);
            this.lblApellidoCli.Name = "lblApellidoCli";
            this.lblApellidoCli.Size = new System.Drawing.Size(158, 18);
            this.lblApellidoCli.TabIndex = 12;
            this.lblApellidoCli.Text = "Apellido del cliente:";
            // 
            // txtNombreCli
            // 
            this.txtNombreCli.Location = new System.Drawing.Point(193, 23);
            this.txtNombreCli.Name = "txtNombreCli";
            this.txtNombreCli.Size = new System.Drawing.Size(213, 26);
            this.txtNombreCli.TabIndex = 11;
            // 
            // lblNombreCli
            // 
            this.lblNombreCli.AutoSize = true;
            this.lblNombreCli.Location = new System.Drawing.Point(22, 26);
            this.lblNombreCli.Name = "lblNombreCli";
            this.lblNombreCli.Size = new System.Drawing.Size(155, 18);
            this.lblNombreCli.TabIndex = 10;
            this.lblNombreCli.Text = "Nombre del cliente:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(30, 28);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(88, 18);
            this.lblEmpleado.TabIndex = 16;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(32, 104);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 18);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(98, 101);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(324, 26);
            this.dtpFecha.TabIndex = 20;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(30, 67);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(73, 18);
            this.lblSucursal.TabIndex = 21;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(128, 23);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(293, 26);
            this.cboEmpleado.TabIndex = 23;
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(128, 62);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(293, 26);
            this.cboSucursal.TabIndex = 24;
            // 
            // GbCliente
            // 
            this.GbCliente.BackColor = System.Drawing.Color.Transparent;
            this.GbCliente.Controls.Add(this.txtNroDocCli);
            this.GbCliente.Controls.Add(this.lblNroDocCli);
            this.GbCliente.Controls.Add(this.txtApellidoCli);
            this.GbCliente.Controls.Add(this.lblApellidoCli);
            this.GbCliente.Controls.Add(this.txtNombreCli);
            this.GbCliente.Controls.Add(this.lblNombreCli);
            this.GbCliente.Location = new System.Drawing.Point(26, 245);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Size = new System.Drawing.Size(439, 147);
            this.GbCliente.TabIndex = 25;
            this.GbCliente.TabStop = false;
            this.GbCliente.Text = "Cliente";
            // 
            // GbSucursal
            // 
            this.GbSucursal.BackColor = System.Drawing.Color.Transparent;
            this.GbSucursal.Controls.Add(this.cboSucursal);
            this.GbSucursal.Controls.Add(this.cboEmpleado);
            this.GbSucursal.Controls.Add(this.lblSucursal);
            this.GbSucursal.Controls.Add(this.dtpFecha);
            this.GbSucursal.Controls.Add(this.lblFecha);
            this.GbSucursal.Controls.Add(this.lblEmpleado);
            this.GbSucursal.Location = new System.Drawing.Point(484, 245);
            this.GbSucursal.Name = "GbSucursal";
            this.GbSucursal.Size = new System.Drawing.Size(449, 146);
            this.GbSucursal.TabIndex = 26;
            this.GbSucursal.TabStop = false;
            this.GbSucursal.Text = "Sucursal";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(488, 29);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(81, 18);
            this.lblCantidad.TabIndex = 27;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // nudCantidadInsumos
            // 
            this.nudCantidadInsumos.Location = new System.Drawing.Point(585, 27);
            this.nudCantidadInsumos.Name = "nudCantidadInsumos";
            this.nudCantidadInsumos.Size = new System.Drawing.Size(135, 26);
            this.nudCantidadInsumos.TabIndex = 28;
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
            this.dgvInsumos.Location = new System.Drawing.Point(26, 70);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInsumos.RowHeadersWidth = 51;
            this.dgvInsumos.RowTemplate.Height = 24;
            this.dgvInsumos.Size = new System.Drawing.Size(852, 137);
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
            this.colAcciones.Text = "Eliminar.";
            this.colAcciones.UseColumnTextForButtonValue = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(29, 621);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 36);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar.";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(801, 621);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 36);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.Text = "Salir.";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(652, 621);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(132, 36);
            this.btnConfirmar.TabIndex = 32;
            this.btnConfirmar.Text = "Confirmar.";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // GbInsumos
            // 
            this.GbInsumos.BackColor = System.Drawing.Color.Transparent;
            this.GbInsumos.Controls.Add(this.dgvInsumos);
            this.GbInsumos.Controls.Add(this.nudCantidadInsumos);
            this.GbInsumos.Controls.Add(this.lblCantidad);
            this.GbInsumos.Controls.Add(this.btnAgregarInsumo);
            this.GbInsumos.Controls.Add(this.cboInsumo);
            this.GbInsumos.Controls.Add(this.lblInsumo);
            this.GbInsumos.Location = new System.Drawing.Point(27, 394);
            this.GbInsumos.Name = "GbInsumos";
            this.GbInsumos.Size = new System.Drawing.Size(904, 222);
            this.GbInsumos.TabIndex = 33;
            this.GbInsumos.TabStop = false;
            this.GbInsumos.Text = "Insumos.";
            // 
            // lblTipoCompra
            // 
            this.lblTipoCompra.AutoSize = true;
            this.lblTipoCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoCompra.Location = new System.Drawing.Point(434, 55);
            this.lblTipoCompra.Name = "lblTipoCompra";
            this.lblTipoCompra.Size = new System.Drawing.Size(107, 18);
            this.lblTipoCompra.TabIndex = 34;
            this.lblTipoCompra.Text = "Tipo Compra:";
            // 
            // CbObraSocial
            // 
            this.CbObraSocial.AutoSize = true;
            this.CbObraSocial.BackColor = System.Drawing.Color.Transparent;
            this.CbObraSocial.Location = new System.Drawing.Point(557, 53);
            this.CbObraSocial.Name = "CbObraSocial";
            this.CbObraSocial.Size = new System.Drawing.Size(122, 22);
            this.CbObraSocial.TabIndex = 35;
            this.CbObraSocial.Text = "Obra Social.";
            this.CbObraSocial.UseVisualStyleBackColor = false;
            this.CbObraSocial.CheckedChanged += new System.EventHandler(this.CbObraSocial_CheckedChanged);
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(236)))));
            this.txtNroFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNroFactura.Enabled = false;
            this.txtNroFactura.Location = new System.Drawing.Point(178, 52);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(73, 19);
            this.txtNroFactura.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "Registre una factura.";
            // 
            // txtMonto
            // 
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMonto.Location = new System.Drawing.Point(774, 38);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(157, 45);
            this.txtMonto.TabIndex = 26;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(953, 678);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.CbObraSocial);
            this.Controls.Add(this.lblTipoCompra);
            this.Controls.Add(this.GbInsumos);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.GbSucursal);
            this.Controls.Add(this.GbCliente);
            this.Controls.Add(this.GbReceta);
            this.Controls.Add(this.lblNroFactura);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(800, 200);
            this.Name = "FormFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Registro Factura.";
            this.Load += new System.EventHandler(this.FormFactura_Load);
            this.GbReceta.ResumeLayout(false);
            this.GbReceta.PerformLayout();
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            this.GbSucursal.ResumeLayout(false);
            this.GbSucursal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadInsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.GbInsumos.ResumeLayout(false);
            this.GbInsumos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.TextBox txtNombreMed;
        private System.Windows.Forms.Label lblNombreMed;
        private System.Windows.Forms.TextBox txtApellidoMed;
        private System.Windows.Forms.Label lblApellidoMed;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatriculaMed;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.TextBox txtDianostico;
        private System.Windows.Forms.Label lblInsumo;
        private System.Windows.Forms.ComboBox cboInsumo;
        private System.Windows.Forms.Button btnAgregarInsumo;
        private System.Windows.Forms.GroupBox GbReceta;
        private System.Windows.Forms.TextBox txtNroDocCli;
        private System.Windows.Forms.Label lblNroDocCli;
        private System.Windows.Forms.TextBox txtApellidoCli;
        private System.Windows.Forms.Label lblApellidoCli;
        private System.Windows.Forms.TextBox txtNombreCli;
        private System.Windows.Forms.Label lblNombreCli;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.GroupBox GbSucursal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cboObraSocial;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.NumericUpDown nudCantidadInsumos;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox GbInsumos;
        private System.Windows.Forms.Label lblTipoCompra;
        private System.Windows.Forms.CheckBox CbObraSocial;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
        private System.Windows.Forms.TextBox txtMonto;
    }
}