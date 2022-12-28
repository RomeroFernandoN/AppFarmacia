namespace AppFarmaciaFrontend.Formularios
{
    partial class ModificarFacturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarFacturas));
            this.lblModificar = new System.Windows.Forms.Label();
            this.GbInsumos = new System.Windows.Forms.GroupBox();
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
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.txtNroDocCli = new System.Windows.Forms.TextBox();
            this.lblNroDocCli = new System.Windows.Forms.Label();
            this.txtApellidoCli = new System.Windows.Forms.TextBox();
            this.lblApellidoCli = new System.Windows.Forms.Label();
            this.txtNombreCli = new System.Windows.Forms.TextBox();
            this.lblNombreCli = new System.Windows.Forms.Label();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.gpInsumosPrevios = new System.Windows.Forms.GroupBox();
            this.dgvInsumosPrevios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.GbInsumos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadInsumos)).BeginInit();
            this.GbSucursal.SuspendLayout();
            this.GbCliente.SuspendLayout();
            this.gpInsumosPrevios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumosPrevios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.BackColor = System.Drawing.Color.Transparent;
            this.lblModificar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.lblModificar.Location = new System.Drawing.Point(26, 19);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(210, 22);
            this.lblModificar.TabIndex = 48;
            this.lblModificar.Text = "Modifique una factura.";
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
            this.GbInsumos.Location = new System.Drawing.Point(27, 393);
            this.GbInsumos.Name = "GbInsumos";
            this.GbInsumos.Size = new System.Drawing.Size(904, 222);
            this.GbInsumos.TabIndex = 45;
            this.GbInsumos.TabStop = false;
            this.GbInsumos.Text = "Insumos actuales.";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInsumos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInsumos.Location = new System.Drawing.Point(26, 70);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInsumos.RowHeadersWidth = 51;
            this.dgvInsumos.RowTemplate.Height = 24;
            this.dgvInsumos.Size = new System.Drawing.Size(851, 137);
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
            // nudCantidadInsumos
            // 
            this.nudCantidadInsumos.Location = new System.Drawing.Point(585, 27);
            this.nudCantidadInsumos.Name = "nudCantidadInsumos";
            this.nudCantidadInsumos.Size = new System.Drawing.Size(135, 26);
            this.nudCantidadInsumos.TabIndex = 28;
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
            // cboInsumo
            // 
            this.cboInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInsumo.FormattingEnabled = true;
            this.cboInsumo.Location = new System.Drawing.Point(114, 25);
            this.cboInsumo.Name = "cboInsumo";
            this.cboInsumo.Size = new System.Drawing.Size(324, 26);
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
            this.btnConfirmar.Location = new System.Drawing.Point(652, 620);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(132, 36);
            this.btnConfirmar.TabIndex = 44;
            this.btnConfirmar.Text = "Confirmar.";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(801, 620);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 36);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Salir.";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(29, 620);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 36);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar.";
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            this.GbSucursal.Location = new System.Drawing.Point(487, 77);
            this.GbSucursal.Name = "GbSucursal";
            this.GbSucursal.Size = new System.Drawing.Size(449, 146);
            this.GbSucursal.TabIndex = 41;
            this.GbSucursal.TabStop = false;
            this.GbSucursal.Text = "Sucursal";
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
            // cboEmpleado
            // 
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(128, 23);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(293, 26);
            this.cboEmpleado.TabIndex = 23;
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
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(98, 101);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(324, 26);
            this.dtpFecha.TabIndex = 20;
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
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(30, 28);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(88, 18);
            this.lblEmpleado.TabIndex = 16;
            this.lblEmpleado.Text = "Empleado:";
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
            this.GbCliente.Location = new System.Drawing.Point(29, 77);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Size = new System.Drawing.Size(439, 147);
            this.GbCliente.TabIndex = 40;
            this.GbCliente.TabStop = false;
            this.GbCliente.Text = "Cliente";
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
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblNroFactura.Location = new System.Drawing.Point(26, 52);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(151, 18);
            this.lblNroFactura.TabIndex = 38;
            this.lblNroFactura.Text = "Número de factura:";
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(236)))));
            this.txtNroFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNroFactura.Enabled = false;
            this.txtNroFactura.Location = new System.Drawing.Point(183, 52);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(73, 19);
            this.txtNroFactura.TabIndex = 49;
            // 
            // gpInsumosPrevios
            // 
            this.gpInsumosPrevios.BackColor = System.Drawing.Color.Transparent;
            this.gpInsumosPrevios.Controls.Add(this.dgvInsumosPrevios);
            this.gpInsumosPrevios.ForeColor = System.Drawing.SystemColors.MenuText;
            this.gpInsumosPrevios.Location = new System.Drawing.Point(29, 231);
            this.gpInsumosPrevios.Name = "gpInsumosPrevios";
            this.gpInsumosPrevios.Size = new System.Drawing.Size(904, 156);
            this.gpInsumosPrevios.TabIndex = 46;
            this.gpInsumosPrevios.TabStop = false;
            this.gpInsumosPrevios.Text = "Insumos previos.";
            // 
            // dgvInsumosPrevios
            // 
            this.dgvInsumosPrevios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInsumosPrevios.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsumosPrevios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInsumosPrevios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumosPrevios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInsumosPrevios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInsumosPrevios.GridColor = System.Drawing.SystemColors.Control;
            this.dgvInsumosPrevios.Location = new System.Drawing.Point(26, 25);
            this.dgvInsumosPrevios.Name = "dgvInsumosPrevios";
            this.dgvInsumosPrevios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsumosPrevios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInsumosPrevios.RowHeadersWidth = 51;
            this.dgvInsumosPrevios.RowTemplate.Height = 24;
            this.dgvInsumosPrevios.Size = new System.Drawing.Size(851, 114);
            this.dgvInsumosPrevios.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Insumo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // txtMonto
            // 
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMonto.Location = new System.Drawing.Point(779, 25);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(157, 45);
            this.txtMonto.TabIndex = 50;
            // 
            // ModificarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(953, 678);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.gpInsumosPrevios);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.GbInsumos);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.GbSucursal);
            this.Controls.Add(this.GbCliente);
            this.Controls.Add(this.lblNroFactura);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(800, 200);
            this.Name = "ModificarFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Modificar Factura.";
            this.Load += new System.EventHandler(this.ModificarFacturas_Load);
            this.GbInsumos.ResumeLayout(false);
            this.GbInsumos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadInsumos)).EndInit();
            this.GbSucursal.ResumeLayout(false);
            this.GbSucursal.PerformLayout();
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            this.gpInsumosPrevios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumosPrevios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.GroupBox GbInsumos;
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
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.TextBox txtNroDocCli;
        private System.Windows.Forms.Label lblNroDocCli;
        private System.Windows.Forms.TextBox txtApellidoCli;
        private System.Windows.Forms.Label lblApellidoCli;
        private System.Windows.Forms.TextBox txtNombreCli;
        private System.Windows.Forms.Label lblNombreCli;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.GroupBox gpInsumosPrevios;
        private System.Windows.Forms.DataGridView dgvInsumosPrevios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
        private TextBox txtMonto;
    }
}