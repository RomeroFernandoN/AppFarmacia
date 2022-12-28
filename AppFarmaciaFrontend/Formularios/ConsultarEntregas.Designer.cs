namespace AppFarmaciaFrontend.Formularios
{
    partial class ConsultarEntregas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarEntregas));
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblSeleccione = new System.Windows.Forms.Label();
            this.dgvEntregas = new System.Windows.Forms.DataGridView();
            this.colNroEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar.Location = new System.Drawing.Point(503, 110);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(122, 37);
            this.btnConsultar.TabIndex = 62;
            this.btnConsultar.Text = "Consultar.";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.dtpFechaHasta.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.dtpFechaHasta.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.dtpFechaHasta.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.dtpFechaHasta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaHasta.Location = new System.Drawing.Point(114, 121);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(368, 26);
            this.dtpFechaHasta.TabIndex = 61;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.BackColor = System.Drawing.Color.Transparent;
            this.lblHasta.Location = new System.Drawing.Point(40, 124);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(52, 18);
            this.lblHasta.TabIndex = 60;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.dtpFechaDesde.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.dtpFechaDesde.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.dtpFechaDesde.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(75)))));
            this.dtpFechaDesde.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaDesde.Location = new System.Drawing.Point(114, 86);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(368, 26);
            this.dtpFechaDesde.TabIndex = 54;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.BackColor = System.Drawing.Color.Transparent;
            this.lblDesde.Location = new System.Drawing.Point(40, 89);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(59, 18);
            this.lblDesde.TabIndex = 53;
            this.lblDesde.Text = "Desde:";
            // 
            // lblConsultar
            // 
            this.lblConsultar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.BackColor = System.Drawing.Color.Transparent;
            this.lblConsultar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.lblConsultar.Location = new System.Drawing.Point(38, 21);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(204, 22);
            this.lblConsultar.TabIndex = 59;
            this.lblConsultar.Text = "Consulte las entregas.";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(503, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 37);
            this.btnSalir.TabIndex = 58;
            this.btnSalir.Text = "Salir.";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(43, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 37);
            this.btnCancelar.TabIndex = 57;
            this.btnCancelar.Text = "Cancelar.";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSeleccione
            // 
            this.lblSeleccione.AutoSize = true;
            this.lblSeleccione.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccione.ForeColor = System.Drawing.Color.Black;
            this.lblSeleccione.Location = new System.Drawing.Point(37, 57);
            this.lblSeleccione.Name = "lblSeleccione";
            this.lblSeleccione.Size = new System.Drawing.Size(375, 18);
            this.lblSeleccione.TabIndex = 56;
            this.lblSeleccione.Text = "Seleccione las fechas en las que desea consultar.";
            // 
            // dgvEntregas
            // 
            this.dgvEntregas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntregas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroEntrega,
            this.colProveedor,
            this.colCantidad,
            this.colEliminar,
            this.colEditar});
            this.dgvEntregas.Location = new System.Drawing.Point(43, 177);
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEntregas.RowHeadersWidth = 51;
            this.dgvEntregas.RowTemplate.Height = 24;
            this.dgvEntregas.Size = new System.Drawing.Size(582, 216);
            this.dgvEntregas.TabIndex = 55;
            this.dgvEntregas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntregas_CellContentClick);
            // 
            // colNroEntrega
            // 
            this.colNroEntrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colNroEntrega.FillWeight = 50.53467F;
            this.colNroEntrega.HeaderText = "Nro. Entrega";
            this.colNroEntrega.MinimumWidth = 6;
            this.colNroEntrega.Name = "colNroEntrega";
            this.colNroEntrega.Width = 129;
            // 
            // colProveedor
            // 
            this.colProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colProveedor.FillWeight = 366.6306F;
            this.colProveedor.HeaderText = "Proveedor";
            this.colProveedor.MinimumWidth = 6;
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.Width = 129;
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
            // ConsultarEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(167)))), ((int)(((byte)(158)))));
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
            this.Controls.Add(this.dgvEntregas);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(900, 300);
            this.Name = "ConsultarEntregas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ConsultarEntregas";
            this.Load += new System.EventHandler(this.ConsultarEntregas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblSeleccione;
        private System.Windows.Forms.DataGridView dgvEntregas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
    }
}