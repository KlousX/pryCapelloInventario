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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gBoxInventario = new System.Windows.Forms.GroupBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtDecrip = new System.Windows.Forms.TextBox();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.txtEgreso = new System.Windows.Forms.TextBox();
            this.lblEgreso = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gBoxInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 502);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gBoxInventario
            // 
            this.gBoxInventario.Controls.Add(this.btnCancelar);
            this.gBoxInventario.Controls.Add(this.btnConfirmar);
            this.gBoxInventario.Controls.Add(this.txtPrecio);
            this.gBoxInventario.Controls.Add(this.lblPrecio);
            this.gBoxInventario.Controls.Add(this.lblStockActual);
            this.gBoxInventario.Controls.Add(this.lblStock);
            this.gBoxInventario.Controls.Add(this.txtEgreso);
            this.gBoxInventario.Controls.Add(this.lblEgreso);
            this.gBoxInventario.Controls.Add(this.txtIngreso);
            this.gBoxInventario.Controls.Add(this.lblIngreso);
            this.gBoxInventario.Controls.Add(this.txtCategoria);
            this.gBoxInventario.Controls.Add(this.lblCategoria);
            this.gBoxInventario.Controls.Add(this.txtCode);
            this.gBoxInventario.Controls.Add(this.lblCódigo);
            this.gBoxInventario.Controls.Add(this.txtDecrip);
            this.gBoxInventario.Controls.Add(this.lblProducto);
            this.gBoxInventario.Location = new System.Drawing.Point(112, 57);
            this.gBoxInventario.Name = "gBoxInventario";
            this.gBoxInventario.Size = new System.Drawing.Size(575, 332);
            this.gBoxInventario.TabIndex = 1;
            this.gBoxInventario.TabStop = false;
            this.gBoxInventario.Text = "Inventario";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblProducto.Location = new System.Drawing.Point(51, 38);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(91, 18);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Descripción:";
            this.lblProducto.Click += new System.EventHandler(this.lblProducto_Click);
            // 
            // txtDecrip
            // 
            this.txtDecrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtDecrip.Location = new System.Drawing.Point(153, 35);
            this.txtDecrip.Name = "txtDecrip";
            this.txtDecrip.Size = new System.Drawing.Size(110, 24);
            this.txtDecrip.TabIndex = 1;
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCódigo.Location = new System.Drawing.Point(303, 37);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(60, 18);
            this.lblCódigo.TabIndex = 2;
            this.lblCódigo.Text = "Código:";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCode.Location = new System.Drawing.Point(369, 34);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(110, 24);
            this.txtCode.TabIndex = 3;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCategoria.Location = new System.Drawing.Point(143, 80);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(110, 24);
            this.txtCategoria.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCategoria.Location = new System.Drawing.Point(53, 81);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 18);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIngreso.Location = new System.Drawing.Point(57, 148);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(61, 18);
            this.lblIngreso.TabIndex = 6;
            this.lblIngreso.Text = "Ingreso:";
            this.lblIngreso.Click += new System.EventHandler(this.lblIngreso_Click);
            // 
            // txtIngreso
            // 
            this.txtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtIngreso.Location = new System.Drawing.Point(143, 145);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(29, 24);
            this.txtIngreso.TabIndex = 7;
            this.txtIngreso.TextChanged += new System.EventHandler(this.txtIngreso_TextChanged);
            // 
            // txtEgreso
            // 
            this.txtEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtEgreso.Location = new System.Drawing.Point(143, 181);
            this.txtEgreso.Name = "txtEgreso";
            this.txtEgreso.Size = new System.Drawing.Size(29, 24);
            this.txtEgreso.TabIndex = 9;
            // 
            // lblEgreso
            // 
            this.lblEgreso.AutoSize = true;
            this.lblEgreso.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEgreso.Location = new System.Drawing.Point(58, 183);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(60, 18);
            this.lblEgreso.TabIndex = 8;
            this.lblEgreso.Text = "Egreso:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblStock.Location = new System.Drawing.Point(214, 165);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(174, 18);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Cantidad de stock actual:";
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblStockActual.Location = new System.Drawing.Point(428, 165);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(15, 18);
            this.lblStockActual.TabIndex = 12;
            this.lblStockActual.Text = "x";
            this.lblStockActual.Click += new System.EventHandler(this.lblStockActual_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPrecio.Location = new System.Drawing.Point(58, 247);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 18);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtPrecio.Location = new System.Drawing.Point(143, 247);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(71, 24);
            this.txtPrecio.TabIndex = 14;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnConfirmar.Location = new System.Drawing.Point(337, 262);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(91, 31);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCancelar.Location = new System.Drawing.Point(449, 262);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 31);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBoxInventario);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProyecto";
            this.Text = "Gestión de Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gBoxInventario.ResumeLayout(false);
            this.gBoxInventario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gBoxInventario;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtEgreso;
        private System.Windows.Forms.Label lblEgreso;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.TextBox txtDecrip;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}

