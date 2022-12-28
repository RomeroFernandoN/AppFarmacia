namespace AppFarmaciaFrontend.Formularios
{
    partial class ConsultaFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFacturas));
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblSeleccione = new System.Windows.Forms.Label();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.colNroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.dtpFechaDesde.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.dtpFechaDesde.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.dtpFechaDesde.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.dtpFechaDesde.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaDesde.Location = new System.Drawing.Point(109, 84);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(368, 26);
            this.dtpFechaDesde.TabIndex = 43;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.BackColor = System.Drawing.Color.Transparent;
            this.lblDesde.Location = new System.Drawing.Point(35, 87);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(59, 18);
            this.lblDesde.TabIndex = 42;
            this.lblDesde.Text = "Desde:";
            // 
            // lblConsultar
            // 
            this.lblConsultar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.BackColor = System.Drawing.Color.Transparent;
            this.lblConsultar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.lblConsultar.Location = new System.Drawing.Point(33, 19);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(197, 22);
            this.lblConsultar.TabIndex = 49;
            this.lblConsultar.Text = "Consulte las facturas.";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(498, 413);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 37);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "Salir.";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(38, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 37);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar.";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSeleccione
            // 
            this.lblSeleccione.AutoSize = true;
            this.lblSeleccione.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccione.ForeColor = System.Drawing.Color.Black;
            this.lblSeleccione.Location = new System.Drawing.Point(32, 55);
            this.lblSeleccione.Name = "lblSeleccione";
            this.lblSeleccione.Size = new System.Drawing.Size(375, 18);
            this.lblSeleccione.TabIndex = 45;
            this.lblSeleccione.Text = "Seleccione las fechas en las que desea consultar.";
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroFactura,
            this.colInsumo,
            this.colCantidad,
            this.colEliminar,
            this.colEditar});
            this.dgvFacturas.Location = new System.Drawing.Point(38, 175);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFacturas.RowHeadersWidth = 51;
            this.dgvFacturas.RowTemplate.Height = 24;
            this.dgvFacturas.Size = new System.Drawing.Size(582, 216);
            this.dgvFacturas.TabIndex = 44;
            this.dgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellContentClick_1);
            // 
            // colNroFactura
            // 
            this.colNroFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colNroFactura.FillWeight = 50.53467F;
            this.colNroFactura.HeaderText = "Nro. Factura";
            this.colNroFactura.MinimumWidth = 6;
            this.colNroFactura.Name = "colNroFactura";
            this.colNroFactura.Width = 129;
            // 
            // colInsumo
            // 
            this.colInsumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colInsumo.FillWeight = 366.6306F;
            this.colInsumo.HeaderText = "Cliente";
            this.colInsumo.MinimumWidth = 6;
            this.colInsumo.Name = "colInsumo";
            this.colInsumo.Width = 129;
            // 
            // colCantidad
            // 
            this.colCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCantidad.FillWeight = 75.16722F;
            this.colCantidad.HeaderText = "Fecha";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 130;
            // 
            // colEliminar
            // 
            this.colEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEliminar.FillWeight = 3.648191F;
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.MinimumWidth = 6;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEliminar.Text = "Eliminar.";
            this.colEliminar.UseColumnTextForButtonValue = true;
            this.colEliminar.Width = 70;
            // 
            // colEditar
            // 
            this.colEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEditar.HeaderText = "Editar";
            this.colEditar.MinimumWidth = 6;
            this.colEditar.Name = "colEditar";
            this.colEditar.Text = "Editar.";
            this.colEditar.UseColumnTextForButtonValue = true;
            this.colEditar.Width = 70;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.dtpFechaHasta.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.dtpFechaHasta.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.dtpFechaHasta.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.dtpFechaHasta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaHasta.Location = new System.Drawing.Point(109, 119);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(368, 26);
            this.dtpFechaHasta.TabIndex = 51;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.BackColor = System.Drawing.Color.Transparent;
            this.lblHasta.Location = new System.Drawing.Point(35, 122);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(52, 18);
            this.lblHasta.TabIndex = 50;
            this.lblHasta.Text = "Hasta:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar.Location = new System.Drawing.Point(498, 108);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(122, 37);
            this.btnConsultar.TabIndex = 52;
            this.btnConsultar.Text = "Consultar.";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // ConsultaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(663, 473);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.lblConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblSeleccione);
            this.Controls.Add(this.dgvFacturas);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(900, 300);
            this.Name = "ConsultaFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ConsultaFacturas";
            this.Load += new System.EventHandler(this.ConsultaFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblSeleccione;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
    }
}