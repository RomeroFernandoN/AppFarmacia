namespace AppFarmaciaFrontend.Formularios
{
    partial class InsertarInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarInsumos));
            this.cboTipoInsumo = new System.Windows.Forms.ComboBox();
            this.lblVenta = new System.Windows.Forms.Label();
            this.lblNombreInsumo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ckSi = new System.Windows.Forms.CheckBox();
            this.ckNo = new System.Windows.Forms.CheckBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCompletar = new System.Windows.Forms.Label();
            this.lblEstadoInsumo = new System.Windows.Forms.Label();
            this.gbCaracteristicas = new System.Windows.Forms.GroupBox();
            this.txtNombreInsumo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cboInsumos = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbModificar = new System.Windows.Forms.CheckBox();
            this.cbInsertar = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCaracteristicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTipoInsumo
            // 
            this.cboTipoInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoInsumo.ForeColor = System.Drawing.Color.Black;
            this.cboTipoInsumo.FormattingEnabled = true;
            this.cboTipoInsumo.Location = new System.Drawing.Point(131, 83);
            this.cboTipoInsumo.Name = "cboTipoInsumo";
            this.cboTipoInsumo.Size = new System.Drawing.Size(369, 26);
            this.cboTipoInsumo.TabIndex = 44;
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblVenta.Location = new System.Drawing.Point(16, 57);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(93, 18);
            this.lblVenta.TabIndex = 43;
            this.lblVenta.Text = "Venta libre:";
            // 
            // lblNombreInsumo
            // 
            this.lblNombreInsumo.AutoSize = true;
            this.lblNombreInsumo.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreInsumo.Location = new System.Drawing.Point(42, 121);
            this.lblNombreInsumo.Name = "lblNombreInsumo";
            this.lblNombreInsumo.Size = new System.Drawing.Size(64, 18);
            this.lblNombreInsumo.TabIndex = 49;
            this.lblNombreInsumo.Text = "Insumo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "Registre un insumo.";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(370, 359);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(95, 37);
            this.btnConfirmar.TabIndex = 48;
            this.btnConfirmar.Text = "Confirmar.";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(471, 359);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 37);
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
            this.btnCancelar.Location = new System.Drawing.Point(35, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 37);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar.";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // ckSi
            // 
            this.ckSi.AutoSize = true;
            this.ckSi.BackColor = System.Drawing.Color.Transparent;
            this.ckSi.Location = new System.Drawing.Point(131, 58);
            this.ckSi.Name = "ckSi";
            this.ckSi.Size = new System.Drawing.Size(46, 22);
            this.ckSi.TabIndex = 52;
            this.ckSi.Text = "Si.";
            this.ckSi.UseVisualStyleBackColor = false;
            this.ckSi.CheckedChanged += new System.EventHandler(this.ckSi_CheckedChanged);
            // 
            // ckNo
            // 
            this.ckNo.AutoSize = true;
            this.ckNo.BackColor = System.Drawing.Color.Transparent;
            this.ckNo.Location = new System.Drawing.Point(239, 58);
            this.ckNo.Name = "ckNo";
            this.ckNo.Size = new System.Drawing.Size(55, 22);
            this.ckNo.TabIndex = 53;
            this.ckNo.Text = "No.";
            this.ckNo.UseVisualStyleBackColor = false;
            this.ckNo.CheckedChanged += new System.EventHandler(this.ckNo_CheckedChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Location = new System.Drawing.Point(18, 86);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(98, 18);
            this.lblTipo.TabIndex = 54;
            this.lblTipo.Text = "Tipo Insumo:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(83, 120);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(417, 26);
            this.txtPrecio.TabIndex = 56;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Location = new System.Drawing.Point(18, 123);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(59, 18);
            this.lblPrecio.TabIndex = 55;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCompletar
            // 
            this.lblCompletar.AutoSize = true;
            this.lblCompletar.BackColor = System.Drawing.Color.Transparent;
            this.lblCompletar.Location = new System.Drawing.Point(42, 56);
            this.lblCompletar.Name = "lblCompletar";
            this.lblCompletar.Size = new System.Drawing.Size(250, 18);
            this.lblCompletar.TabIndex = 63;
            this.lblCompletar.Text = "Complete los siguientes campos.";
            // 
            // lblEstadoInsumo
            // 
            this.lblEstadoInsumo.AutoSize = true;
            this.lblEstadoInsumo.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoInsumo.Location = new System.Drawing.Point(110, 142);
            this.lblEstadoInsumo.Name = "lblEstadoInsumo";
            this.lblEstadoInsumo.Size = new System.Drawing.Size(0, 18);
            this.lblEstadoInsumo.TabIndex = 66;
            // 
            // gbCaracteristicas
            // 
            this.gbCaracteristicas.BackColor = System.Drawing.Color.Transparent;
            this.gbCaracteristicas.Controls.Add(this.txtNombreInsumo);
            this.gbCaracteristicas.Controls.Add(this.lblNombre);
            this.gbCaracteristicas.Controls.Add(this.txtPrecio);
            this.gbCaracteristicas.Controls.Add(this.lblPrecio);
            this.gbCaracteristicas.Controls.Add(this.lblTipo);
            this.gbCaracteristicas.Controls.Add(this.ckNo);
            this.gbCaracteristicas.Controls.Add(this.ckSi);
            this.gbCaracteristicas.Controls.Add(this.cboTipoInsumo);
            this.gbCaracteristicas.Controls.Add(this.lblVenta);
            this.gbCaracteristicas.Location = new System.Drawing.Point(35, 190);
            this.gbCaracteristicas.Name = "gbCaracteristicas";
            this.gbCaracteristicas.Size = new System.Drawing.Size(524, 162);
            this.gbCaracteristicas.TabIndex = 67;
            this.gbCaracteristicas.TabStop = false;
            this.gbCaracteristicas.Text = "Características.";
            // 
            // txtNombreInsumo
            // 
            this.txtNombreInsumo.ForeColor = System.Drawing.Color.Black;
            this.txtNombreInsumo.Location = new System.Drawing.Point(97, 25);
            this.txtNombreInsumo.Name = "txtNombreInsumo";
            this.txtNombreInsumo.Size = new System.Drawing.Size(406, 26);
            this.txtNombreInsumo.TabIndex = 58;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Location = new System.Drawing.Point(19, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(72, 18);
            this.lblNombre.TabIndex = 57;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(460, 154);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 33);
            this.btnEditar.TabIndex = 68;
            this.btnEditar.Text = "Editar.";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cboInsumos
            // 
            this.cboInsumos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInsumos.ForeColor = System.Drawing.Color.Black;
            this.cboInsumos.FormattingEnabled = true;
            this.cboInsumos.Location = new System.Drawing.Point(120, 118);
            this.cboInsumos.Name = "cboInsumos";
            this.cboInsumos.Size = new System.Drawing.Size(439, 26);
            this.cboInsumos.TabIndex = 57;
            this.cboInsumos.SelectedIndexChanged += new System.EventHandler(this.cboInsumos_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(355, 154);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 33);
            this.btnEliminar.TabIndex = 69;
            this.btnEliminar.Text = "Eliminar.";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnDarBaja_Click);
            // 
            // cbModificar
            // 
            this.cbModificar.AutoSize = true;
            this.cbModificar.BackColor = System.Drawing.Color.Transparent;
            this.cbModificar.Location = new System.Drawing.Point(267, 86);
            this.cbModificar.Name = "cbModificar";
            this.cbModificar.Size = new System.Drawing.Size(105, 22);
            this.cbModificar.TabIndex = 61;
            this.cbModificar.Text = "Modificar.";
            this.cbModificar.UseVisualStyleBackColor = false;
            this.cbModificar.CheckedChanged += new System.EventHandler(this.cbModificar_CheckedChanged);
            // 
            // cbInsertar
            // 
            this.cbInsertar.AutoSize = true;
            this.cbInsertar.BackColor = System.Drawing.Color.Transparent;
            this.cbInsertar.Location = new System.Drawing.Point(162, 86);
            this.cbInsertar.Name = "cbInsertar";
            this.cbInsertar.Size = new System.Drawing.Size(87, 22);
            this.cbInsertar.TabIndex = 60;
            this.cbInsertar.Text = "Insertar.";
            this.cbInsertar.UseVisualStyleBackColor = false;
            this.cbInsertar.CheckedChanged += new System.EventHandler(this.cbInsertar_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(42, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 59;
            this.label2.Text = "Operación.";
            // 
            // InsertarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(594, 425);
            this.Controls.Add(this.cbModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cbInsertar);
            this.Controls.Add(this.cboInsumos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbCaracteristicas);
            this.Controls.Add(this.lblEstadoInsumo);
            this.Controls.Add(this.lblCompletar);
            this.Controls.Add(this.lblNombreInsumo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(900, 325);
            this.Name = "InsertarInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.InsertarInsumos_Load);
            this.gbCaracteristicas.ResumeLayout(false);
            this.gbCaracteristicas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoInsumo;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.Label lblNombreInsumo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox ckSi;
        private System.Windows.Forms.CheckBox ckNo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCompletar;
        private System.Windows.Forms.Label lblEstadoInsumo;
        private System.Windows.Forms.GroupBox gbCaracteristicas;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtNombreInsumo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cboInsumos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox cbModificar;
        private System.Windows.Forms.CheckBox cbInsertar;
        private System.Windows.Forms.Label label2;
    }
}