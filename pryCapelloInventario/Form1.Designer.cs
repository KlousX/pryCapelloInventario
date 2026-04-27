namespace pryCapelloInventario
{
    partial class frmProyecto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProyecto));
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.gBoxInventario = new System.Windows.Forms.GroupBox();
            this.btnGrilla = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSimboloPrecio = new System.Windows.Forms.Label();
            this.maskedTxtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtEgreso = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtIngreso = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblEgreso = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.gBoxInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // picFondo
            // 
            this.picFondo.Image = ((System.Drawing.Image)(resources.GetObject("picFondo.Image")));
            this.picFondo.Location = new System.Drawing.Point(0, 0);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(593, 452);
            this.picFondo.TabIndex = 0;
            this.picFondo.TabStop = false;
            // 
            // gBoxInventario
            // 
            this.gBoxInventario.Controls.Add(this.btnGrilla);
            this.gBoxInventario.Controls.Add(this.cboCategoria);
            this.gBoxInventario.Controls.Add(this.txtNombre);
            this.gBoxInventario.Controls.Add(this.lblNombre);
            this.gBoxInventario.Controls.Add(this.lblSimboloPrecio);
            this.gBoxInventario.Controls.Add(this.maskedTxtPrecio);
            this.gBoxInventario.Controls.Add(this.maskedTxtEgreso);
            this.gBoxInventario.Controls.Add(this.maskedTxtIngreso);
            this.gBoxInventario.Controls.Add(this.btnCancelar);
            this.gBoxInventario.Controls.Add(this.btnRegistrar);
            this.gBoxInventario.Controls.Add(this.lblPrecio);
            this.gBoxInventario.Controls.Add(this.lblStockActual);
            this.gBoxInventario.Controls.Add(this.lblStock);
            this.gBoxInventario.Controls.Add(this.lblEgreso);
            this.gBoxInventario.Controls.Add(this.lblIngreso);
            this.gBoxInventario.Controls.Add(this.lblCategoria);
            this.gBoxInventario.Controls.Add(this.txtCode);
            this.gBoxInventario.Controls.Add(this.lblCódigo);
            this.gBoxInventario.Controls.Add(this.txtDescripcion);
            this.gBoxInventario.Controls.Add(this.lblProducto);
            this.gBoxInventario.Location = new System.Drawing.Point(25, 22);
            this.gBoxInventario.Name = "gBoxInventario";
            this.gBoxInventario.Size = new System.Drawing.Size(530, 315);
            this.gBoxInventario.TabIndex = 1;
            this.gBoxInventario.TabStop = false;
            this.gBoxInventario.Text = "Inventario";
            this.gBoxInventario.Enter += new System.EventHandler(this.gBoxInventario_Enter);
            // 
            // btnGrilla
            // 
            this.btnGrilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrilla.Location = new System.Drawing.Point(10, 287);
            this.btnGrilla.Name = "btnGrilla";
            this.btnGrilla.Size = new System.Drawing.Size(79, 22);
            this.btnGrilla.TabIndex = 23;
            this.btnGrilla.Text = "Lista";
            this.btnGrilla.UseVisualStyleBackColor = true;
            this.btnGrilla.Click += new System.EventHandler(this.btnGrilla_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Bujía",
            "Transmisión",
            "Silenciador",
            "Juntas",
            "Cubiertas"});
            this.cboCategoria.Location = new System.Drawing.Point(136, 108);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNombre.Location = new System.Drawing.Point(136, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombre.Location = new System.Drawing.Point(44, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblSimboloPrecio
            // 
            this.lblSimboloPrecio.AutoSize = true;
            this.lblSimboloPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSimboloPrecio.Location = new System.Drawing.Point(123, 228);
            this.lblSimboloPrecio.Name = "lblSimboloPrecio";
            this.lblSimboloPrecio.Size = new System.Drawing.Size(16, 18);
            this.lblSimboloPrecio.TabIndex = 6;
            this.lblSimboloPrecio.Text = "$";
            // 
            // maskedTxtPrecio
            // 
            this.maskedTxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.maskedTxtPrecio.Location = new System.Drawing.Point(136, 228);
            this.maskedTxtPrecio.Mask = "99999999";
            this.maskedTxtPrecio.Name = "maskedTxtPrecio";
            this.maskedTxtPrecio.Size = new System.Drawing.Size(68, 24);
            this.maskedTxtPrecio.TabIndex = 7;
            this.maskedTxtPrecio.ValidatingType = typeof(int);
            this.maskedTxtPrecio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTxtPrecio_MaskInputRejected);
            // 
            // maskedTxtEgreso
            // 
            this.maskedTxtEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.maskedTxtEgreso.Location = new System.Drawing.Point(136, 188);
            this.maskedTxtEgreso.Mask = "99999";
            this.maskedTxtEgreso.Name = "maskedTxtEgreso";
            this.maskedTxtEgreso.Size = new System.Drawing.Size(32, 24);
            this.maskedTxtEgreso.TabIndex = 5;
            this.maskedTxtEgreso.ValidatingType = typeof(int);
            this.maskedTxtEgreso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTxtEgreso_MaskInputRejected);
            // 
            // maskedTxtIngreso
            // 
            this.maskedTxtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.maskedTxtIngreso.Location = new System.Drawing.Point(136, 148);
            this.maskedTxtIngreso.Mask = "99999";
            this.maskedTxtIngreso.Name = "maskedTxtIngreso";
            this.maskedTxtIngreso.Size = new System.Drawing.Size(32, 24);
            this.maskedTxtIngreso.TabIndex = 4;
            this.maskedTxtIngreso.ValidatingType = typeof(int);
            this.maskedTxtIngreso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTxtIngreso_MaskInputRejected);
            this.maskedTxtIngreso.TextChanged += new System.EventHandler(this.maskedTxtIngreso_TextChanged_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(434, 287);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 22);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(336, 287);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(79, 22);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPrecio.Location = new System.Drawing.Point(44, 228);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 18);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblStockActual.Location = new System.Drawing.Point(460, 180);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(15, 18);
            this.lblStockActual.TabIndex = 12;
            this.lblStockActual.Text = "x";
            this.lblStockActual.Click += new System.EventHandler(this.lblStockActual_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblStock.Location = new System.Drawing.Point(239, 180);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(174, 18);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Cantidad de stock actual:";
            // 
            // lblEgreso
            // 
            this.lblEgreso.AutoSize = true;
            this.lblEgreso.BackColor = System.Drawing.Color.Transparent;
            this.lblEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEgreso.Location = new System.Drawing.Point(44, 188);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(60, 18);
            this.lblEgreso.TabIndex = 8;
            this.lblEgreso.Text = "Egreso:";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIngreso.Location = new System.Drawing.Point(44, 148);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(61, 18);
            this.lblIngreso.TabIndex = 6;
            this.lblIngreso.Text = "Ingreso:";
            this.lblIngreso.Click += new System.EventHandler(this.lblIngreso_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCategoria.Location = new System.Drawing.Point(44, 108);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 18);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCode.Location = new System.Drawing.Point(136, 28);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(147, 24);
            this.txtCode.TabIndex = 0;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCódigo.Location = new System.Drawing.Point(44, 28);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(60, 18);
            this.lblCódigo.TabIndex = 2;
            this.lblCódigo.Text = "Código:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(303, 49);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(183, 80);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDecrip_TextChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblProducto.Location = new System.Drawing.Point(300, 28);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(91, 18);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Descripción:";
            this.lblProducto.Click += new System.EventHandler(this.lblProducto_Click);
            // 
            // frmProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 366);
            this.Controls.Add(this.gBoxInventario);
            this.Controls.Add(this.picFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Inventario";
            this.Load += new System.EventHandler(this.frmProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.gBoxInventario.ResumeLayout(false);
            this.gBoxInventario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.GroupBox gBoxInventario;
        private System.Windows.Forms.Label lblEgreso;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblSimboloPrecio;
        private System.Windows.Forms.MaskedTextBox maskedTxtPrecio;
        private System.Windows.Forms.MaskedTextBox maskedTxtEgreso;
        private System.Windows.Forms.MaskedTextBox maskedTxtIngreso;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnGrilla;
    }
}

