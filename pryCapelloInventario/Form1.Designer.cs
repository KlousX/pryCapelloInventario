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
            this.txtDecripcion = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIndexPrecio = new System.Windows.Forms.Label();
            this.lblIndexIngreso = new System.Windows.Forms.Label();
            this.lblIndexCategoria = new System.Windows.Forms.Label();
            this.lblIndexDescripcion = new System.Windows.Forms.Label();
            this.lblPrecioLista = new System.Windows.Forms.Label();
            this.lblCategoriaLista = new System.Windows.Forms.Label();
            this.lblDescripLista = new System.Windows.Forms.Label();
            this.lblNombreLista = new System.Windows.Forms.Label();
            this.lblCodeLista = new System.Windows.Forms.Label();
            this.lblStockLista = new System.Windows.Forms.Label();
            this.lblIndexCodigo = new System.Windows.Forms.Label();
            this.lblIndexNombre = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gBoxInventario.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(791, 556);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gBoxInventario
            // 
            this.gBoxInventario.Controls.Add(this.dgvProductos);
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
            this.gBoxInventario.Controls.Add(this.txtDecripcion);
            this.gBoxInventario.Controls.Add(this.lblProducto);
            this.gBoxInventario.Location = new System.Drawing.Point(33, 27);
            this.gBoxInventario.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxInventario.Name = "gBoxInventario";
            this.gBoxInventario.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxInventario.Size = new System.Drawing.Size(707, 388);
            this.gBoxInventario.TabIndex = 1;
            this.gBoxInventario.TabStop = false;
            this.gBoxInventario.Text = "Inventario";
            this.gBoxInventario.Enter += new System.EventHandler(this.gBoxInventario_Enter);
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Bujía",
            "Transmisión",
            "Silenciador",
            "Juntas",
            "Cubiertas"});
            this.cboCategoria.Location = new System.Drawing.Point(180, 151);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(160, 24);
            this.cboCategoria.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNombre.Location = new System.Drawing.Point(180, 92);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 29);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombre.Location = new System.Drawing.Point(59, 92);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 24);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblSimboloPrecio
            // 
            this.lblSimboloPrecio.AutoSize = true;
            this.lblSimboloPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSimboloPrecio.Location = new System.Drawing.Point(163, 283);
            this.lblSimboloPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSimboloPrecio.Name = "lblSimboloPrecio";
            this.lblSimboloPrecio.Size = new System.Drawing.Size(20, 24);
            this.lblSimboloPrecio.TabIndex = 6;
            this.lblSimboloPrecio.Text = "$";
            // 
            // maskedTxtPrecio
            // 
            this.maskedTxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.maskedTxtPrecio.Location = new System.Drawing.Point(180, 279);
            this.maskedTxtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTxtPrecio.Mask = "99999999";
            this.maskedTxtPrecio.Name = "maskedTxtPrecio";
            this.maskedTxtPrecio.Size = new System.Drawing.Size(89, 29);
            this.maskedTxtPrecio.TabIndex = 7;
            this.maskedTxtPrecio.ValidatingType = typeof(int);
            this.maskedTxtPrecio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTxtPrecio_MaskInputRejected);
            // 
            // maskedTxtEgreso
            // 
            this.maskedTxtEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.maskedTxtEgreso.Location = new System.Drawing.Point(180, 238);
            this.maskedTxtEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTxtEgreso.Mask = "99999";
            this.maskedTxtEgreso.Name = "maskedTxtEgreso";
            this.maskedTxtEgreso.Size = new System.Drawing.Size(41, 29);
            this.maskedTxtEgreso.TabIndex = 5;
            this.maskedTxtEgreso.ValidatingType = typeof(int);
            this.maskedTxtEgreso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTxtEgreso_MaskInputRejected);
            // 
            // maskedTxtIngreso
            // 
            this.maskedTxtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.maskedTxtIngreso.Location = new System.Drawing.Point(181, 194);
            this.maskedTxtIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTxtIngreso.Mask = "99999";
            this.maskedTxtIngreso.Name = "maskedTxtIngreso";
            this.maskedTxtIngreso.Size = new System.Drawing.Size(41, 29);
            this.maskedTxtIngreso.TabIndex = 4;
            this.maskedTxtIngreso.ValidatingType = typeof(int);
            this.maskedTxtIngreso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTxtIngreso_MaskInputRejected);
            this.maskedTxtIngreso.TextChanged += new System.EventHandler(this.maskedTxtIngreso_TextChanged_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCancelar.Location = new System.Drawing.Point(559, 325);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 38);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnRegistrar.Location = new System.Drawing.Point(429, 325);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(121, 38);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPrecio.Location = new System.Drawing.Point(59, 283);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(69, 24);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblStockActual.Location = new System.Drawing.Point(613, 222);
            this.lblStockActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(20, 24);
            this.lblStockActual.TabIndex = 12;
            this.lblStockActual.Text = "x";
            this.lblStockActual.Click += new System.EventHandler(this.lblStockActual_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblStock.Location = new System.Drawing.Point(319, 222);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(218, 24);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Cantidad de stock actual:";
            // 
            // lblEgreso
            // 
            this.lblEgreso.AutoSize = true;
            this.lblEgreso.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEgreso.Location = new System.Drawing.Point(59, 238);
            this.lblEgreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(76, 24);
            this.lblEgreso.TabIndex = 8;
            this.lblEgreso.Text = "Egreso:";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIngreso.Location = new System.Drawing.Point(59, 198);
            this.lblIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(78, 24);
            this.lblIngreso.TabIndex = 6;
            this.lblIngreso.Text = "Ingreso:";
            this.lblIngreso.Click += new System.EventHandler(this.lblIngreso_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCategoria.Location = new System.Drawing.Point(59, 151);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(95, 24);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCode.Location = new System.Drawing.Point(179, 34);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(195, 29);
            this.txtCode.TabIndex = 0;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCódigo.Location = new System.Drawing.Point(59, 38);
            this.lblCódigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(76, 24);
            this.lblCódigo.TabIndex = 2;
            this.lblCódigo.Text = "Código:";
            // 
            // txtDecripcion
            // 
            this.txtDecripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtDecripcion.Location = new System.Drawing.Point(404, 60);
            this.txtDecripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDecripcion.Multiline = true;
            this.txtDecripcion.Name = "txtDecripcion";
            this.txtDecripcion.Size = new System.Drawing.Size(243, 98);
            this.txtDecripcion.TabIndex = 2;
            this.txtDecripcion.TextChanged += new System.EventHandler(this.txtDecrip_TextChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblProducto.Location = new System.Drawing.Point(411, 34);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(115, 24);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Descripción:";
            this.lblProducto.Click += new System.EventHandler(this.lblProducto_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.89743F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.10256F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.Controls.Add(this.lblIndexPrecio, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIndexIngreso, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIndexCategoria, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIndexDescripcion, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPrecioLista, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCategoriaLista, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescripLista, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNombreLista, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCodeLista, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStockLista, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIndexCodigo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIndexNombre, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 422);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(707, 121);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblIndexPrecio
            // 
            this.lblIndexPrecio.AutoSize = true;
            this.lblIndexPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblIndexPrecio.Location = new System.Drawing.Point(618, 18);
            this.lblIndexPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndexPrecio.Name = "lblIndexPrecio";
            this.lblIndexPrecio.Size = new System.Drawing.Size(24, 17);
            this.lblIndexPrecio.TabIndex = 29;
            this.lblIndexPrecio.Text = "$$";
            // 
            // lblIndexIngreso
            // 
            this.lblIndexIngreso.AutoSize = true;
            this.lblIndexIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblIndexIngreso.Location = new System.Drawing.Point(534, 18);
            this.lblIndexIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndexIngreso.Name = "lblIndexIngreso";
            this.lblIndexIngreso.Size = new System.Drawing.Size(55, 17);
            this.lblIndexIngreso.TabIndex = 28;
            this.lblIndexIngreso.Text = "Ingreso";
            this.lblIndexIngreso.Click += new System.EventHandler(this.lblIndexIngreso_Click);
            // 
            // lblIndexCategoria
            // 
            this.lblIndexCategoria.AutoSize = true;
            this.lblIndexCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblIndexCategoria.Location = new System.Drawing.Point(375, 18);
            this.lblIndexCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndexCategoria.Name = "lblIndexCategoria";
            this.lblIndexCategoria.Size = new System.Drawing.Size(69, 17);
            this.lblIndexCategoria.TabIndex = 27;
            this.lblIndexCategoria.Text = "Categoria";
            // 
            // lblIndexDescripcion
            // 
            this.lblIndexDescripcion.AutoSize = true;
            this.lblIndexDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblIndexDescripcion.Location = new System.Drawing.Point(190, 18);
            this.lblIndexDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndexDescripcion.Name = "lblIndexDescripcion";
            this.lblIndexDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblIndexDescripcion.TabIndex = 26;
            this.lblIndexDescripcion.Text = "Descripcion";
            // 
            // lblPrecioLista
            // 
            this.lblPrecioLista.AutoSize = true;
            this.lblPrecioLista.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPrecioLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblPrecioLista.Location = new System.Drawing.Point(618, 0);
            this.lblPrecioLista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioLista.Name = "lblPrecioLista";
            this.lblPrecioLista.Size = new System.Drawing.Size(48, 17);
            this.lblPrecioLista.TabIndex = 23;
            this.lblPrecioLista.Text = "Precio";
            this.lblPrecioLista.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCategoriaLista
            // 
            this.lblCategoriaLista.AutoSize = true;
            this.lblCategoriaLista.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCategoriaLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblCategoriaLista.Location = new System.Drawing.Point(375, 0);
            this.lblCategoriaLista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriaLista.Name = "lblCategoriaLista";
            this.lblCategoriaLista.Size = new System.Drawing.Size(69, 17);
            this.lblCategoriaLista.TabIndex = 23;
            this.lblCategoriaLista.Text = "Categoría";
            this.lblCategoriaLista.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDescripLista
            // 
            this.lblDescripLista.AutoSize = true;
            this.lblDescripLista.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDescripLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDescripLista.Location = new System.Drawing.Point(190, 0);
            this.lblDescripLista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripLista.Name = "lblDescripLista";
            this.lblDescripLista.Size = new System.Drawing.Size(82, 17);
            this.lblDescripLista.TabIndex = 23;
            this.lblDescripLista.Text = "Descripción";
            this.lblDescripLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreLista
            // 
            this.lblNombreLista.AutoSize = true;
            this.lblNombreLista.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNombreLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblNombreLista.Location = new System.Drawing.Point(71, 0);
            this.lblNombreLista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreLista.Name = "lblNombreLista";
            this.lblNombreLista.Size = new System.Drawing.Size(58, 17);
            this.lblNombreLista.TabIndex = 23;
            this.lblNombreLista.Text = "Nombre";
            this.lblNombreLista.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCodeLista
            // 
            this.lblCodeLista.AutoSize = true;
            this.lblCodeLista.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCodeLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblCodeLista.Location = new System.Drawing.Point(4, 0);
            this.lblCodeLista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeLista.Name = "lblCodeLista";
            this.lblCodeLista.Size = new System.Drawing.Size(52, 17);
            this.lblCodeLista.TabIndex = 23;
            this.lblCodeLista.Text = "Código";
            this.lblCodeLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStockLista
            // 
            this.lblStockLista.AutoSize = true;
            this.lblStockLista.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblStockLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblStockLista.Location = new System.Drawing.Point(534, 0);
            this.lblStockLista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockLista.Name = "lblStockLista";
            this.lblStockLista.Size = new System.Drawing.Size(43, 17);
            this.lblStockLista.TabIndex = 23;
            this.lblStockLista.Text = "Stock";
            this.lblStockLista.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIndexCodigo
            // 
            this.lblIndexCodigo.AutoSize = true;
            this.lblIndexCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblIndexCodigo.Location = new System.Drawing.Point(4, 18);
            this.lblIndexCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndexCodigo.Name = "lblIndexCodigo";
            this.lblIndexCodigo.Size = new System.Drawing.Size(39, 17);
            this.lblIndexCodigo.TabIndex = 24;
            this.lblIndexCodigo.Text = "code";
            // 
            // lblIndexNombre
            // 
            this.lblIndexNombre.AutoSize = true;
            this.lblIndexNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblIndexNombre.Location = new System.Drawing.Point(71, 18);
            this.lblIndexNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndexNombre.Name = "lblIndexNombre";
            this.lblIndexNombre.Size = new System.Drawing.Size(37, 17);
            this.lblIndexNombre.TabIndex = 25;
            this.lblIndexNombre.Text = "Nom";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(407, 151);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(240, 150);
            this.dgvProductos.TabIndex = 23;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // frmProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gBoxInventario);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Inventario";
            this.Load += new System.EventHandler(this.frmProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gBoxInventario.ResumeLayout(false);
            this.gBoxInventario.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gBoxInventario;
        private System.Windows.Forms.Label lblEgreso;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.TextBox txtDecripcion;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCodeLista;
        private System.Windows.Forms.Label lblPrecioLista;
        private System.Windows.Forms.Label lblCategoriaLista;
        private System.Windows.Forms.Label lblDescripLista;
        private System.Windows.Forms.Label lblNombreLista;
        private System.Windows.Forms.Label lblStockLista;
        private System.Windows.Forms.Label lblIndexPrecio;
        private System.Windows.Forms.Label lblIndexIngreso;
        private System.Windows.Forms.Label lblIndexCategoria;
        private System.Windows.Forms.Label lblIndexDescripcion;
        private System.Windows.Forms.Label lblIndexCodigo;
        private System.Windows.Forms.Label lblIndexNombre;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}

