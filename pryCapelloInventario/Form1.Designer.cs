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
            this.listLista = new System.Windows.Forms.ListBox();
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
            this.txtDecrip = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodeLista = new System.Windows.Forms.Label();
            this.lblNombreLista = new System.Windows.Forms.Label();
            this.lblDescripLista = new System.Windows.Forms.Label();
            this.lblCategoriaLista = new System.Windows.Forms.Label();
            this.lblIngresoLista = new System.Windows.Forms.Label();
            this.lblPrecioLista = new System.Windows.Forms.Label();
            this.lblIndexCodigo = new System.Windows.Forms.Label();
            this.lblIndexNombre = new System.Windows.Forms.Label();
            this.lblIndexDescrip = new System.Windows.Forms.Label();
            this.lblIndexCategoria = new System.Windows.Forms.Label();
            this.lblIndexIngreso = new System.Windows.Forms.Label();
            this.lblIndexPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gBoxInventario.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 452);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gBoxInventario
            // 
            this.gBoxInventario.Controls.Add(this.listLista);
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
            this.gBoxInventario.Controls.Add(this.txtDecrip);
            this.gBoxInventario.Controls.Add(this.lblProducto);
            this.gBoxInventario.Location = new System.Drawing.Point(25, 22);
            this.gBoxInventario.Name = "gBoxInventario";
            this.gBoxInventario.Size = new System.Drawing.Size(530, 315);
            this.gBoxInventario.TabIndex = 1;
            this.gBoxInventario.TabStop = false;
            this.gBoxInventario.Text = "Inventario";
            // 
            // listLista
            // 
            this.listLista.Enabled = false;
            this.listLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.listLista.FormattingEnabled = true;
            this.listLista.ItemHeight = 18;
            this.listLista.Items.AddRange(new object[] {
            "Bujia",
            "Juntas",
            "Silenciadores",
            "Transmisión"});
            this.listLista.Location = new System.Drawing.Point(135, 122);
            this.listLista.Name = "listLista";
            this.listLista.Size = new System.Drawing.Size(120, 22);
            this.listLista.TabIndex = 3;
            this.listLista.SelectedIndexChanged += new System.EventHandler(this.listLista_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNombre.Location = new System.Drawing.Point(135, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombre.Location = new System.Drawing.Point(45, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblSimboloPrecio
            // 
            this.lblSimboloPrecio.AutoSize = true;
            this.lblSimboloPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSimboloPrecio.Location = new System.Drawing.Point(116, 230);
            this.lblSimboloPrecio.Name = "lblSimboloPrecio";
            this.lblSimboloPrecio.Size = new System.Drawing.Size(16, 18);
            this.lblSimboloPrecio.TabIndex = 21;
            this.lblSimboloPrecio.Text = "$";
            // 
            // maskedTxtPrecio
            // 
            this.maskedTxtPrecio.Enabled = false;
            this.maskedTxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.maskedTxtPrecio.Location = new System.Drawing.Point(131, 227);
            this.maskedTxtPrecio.Mask = "99999999";
            this.maskedTxtPrecio.Name = "maskedTxtPrecio";
            this.maskedTxtPrecio.Size = new System.Drawing.Size(68, 24);
            this.maskedTxtPrecio.TabIndex = 6;
            this.maskedTxtPrecio.ValidatingType = typeof(int);
            this.maskedTxtPrecio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTxtPrecio_MaskInputRejected);
            // 
            // maskedTxtEgreso
            // 
            this.maskedTxtEgreso.Enabled = false;
            this.maskedTxtEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.maskedTxtEgreso.Location = new System.Drawing.Point(131, 193);
            this.maskedTxtEgreso.Mask = "99999";
            this.maskedTxtEgreso.Name = "maskedTxtEgreso";
            this.maskedTxtEgreso.Size = new System.Drawing.Size(32, 24);
            this.maskedTxtEgreso.TabIndex = 5;
            this.maskedTxtEgreso.ValidatingType = typeof(int);
            this.maskedTxtEgreso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTxtEgreso_MaskInputRejected);
            // 
            // maskedTxtIngreso
            // 
            this.maskedTxtIngreso.Enabled = false;
            this.maskedTxtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.maskedTxtIngreso.Location = new System.Drawing.Point(132, 158);
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
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCancelar.Location = new System.Drawing.Point(419, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 31);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnRegistrar.Location = new System.Drawing.Point(322, 264);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(91, 31);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPrecio.Location = new System.Drawing.Point(50, 230);
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
            this.lblStock.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.lblEgreso.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEgreso.Location = new System.Drawing.Point(45, 193);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(60, 18);
            this.lblEgreso.TabIndex = 8;
            this.lblEgreso.Text = "Egreso:";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIngreso.Location = new System.Drawing.Point(44, 161);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(61, 18);
            this.lblIngreso.TabIndex = 6;
            this.lblIngreso.Text = "Ingreso:";
            this.lblIngreso.Click += new System.EventHandler(this.lblIngreso_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCategoria.Location = new System.Drawing.Point(44, 122);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 18);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCode.Location = new System.Drawing.Point(134, 28);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(147, 24);
            this.txtCode.TabIndex = 0;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCódigo.Location = new System.Drawing.Point(45, 31);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(60, 18);
            this.lblCódigo.TabIndex = 2;
            this.lblCódigo.Text = "Código:";
            // 
            // txtDecrip
            // 
            this.txtDecrip.Enabled = false;
            this.txtDecrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtDecrip.Location = new System.Drawing.Point(303, 49);
            this.txtDecrip.Multiline = true;
            this.txtDecrip.Name = "txtDecrip";
            this.txtDecrip.Size = new System.Drawing.Size(183, 80);
            this.txtDecrip.TabIndex = 2;
            this.txtDecrip.TextChanged += new System.EventHandler(this.txtDecrip_TextChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblProducto.Location = new System.Drawing.Point(308, 28);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(91, 18);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Descripción:";
            this.lblProducto.Click += new System.EventHandler(this.lblProducto_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.89743F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.10256F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Controls.Add(this.lblIndexPrecio, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIndexIngreso, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIndexCategoria, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIndexDescrip, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPrecioLista, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCategoriaLista, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescripLista, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNombreLista, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCodeLista, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIngresoLista, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIndexCodigo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIndexNombre, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 343);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 98);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblCodeLista
            // 
            this.lblCodeLista.AutoSize = true;
            this.lblCodeLista.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCodeLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblCodeLista.Location = new System.Drawing.Point(3, 0);
            this.lblCodeLista.Name = "lblCodeLista";
            this.lblCodeLista.Size = new System.Drawing.Size(40, 13);
            this.lblCodeLista.TabIndex = 23;
            this.lblCodeLista.Text = "Código";
            this.lblCodeLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreLista
            // 
            this.lblNombreLista.AutoSize = true;
            this.lblNombreLista.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNombreLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblNombreLista.Location = new System.Drawing.Point(55, 0);
            this.lblNombreLista.Name = "lblNombreLista";
            this.lblNombreLista.Size = new System.Drawing.Size(44, 13);
            this.lblNombreLista.TabIndex = 23;
            this.lblNombreLista.Text = "Nombre";
            this.lblNombreLista.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDescripLista
            // 
            this.lblDescripLista.AutoSize = true;
            this.lblDescripLista.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDescripLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDescripLista.Location = new System.Drawing.Point(147, 0);
            this.lblDescripLista.Name = "lblDescripLista";
            this.lblDescripLista.Size = new System.Drawing.Size(63, 13);
            this.lblDescripLista.TabIndex = 23;
            this.lblDescripLista.Text = "Descripción";
            this.lblDescripLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategoriaLista
            // 
            this.lblCategoriaLista.AutoSize = true;
            this.lblCategoriaLista.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCategoriaLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblCategoriaLista.Location = new System.Drawing.Point(286, 0);
            this.lblCategoriaLista.Name = "lblCategoriaLista";
            this.lblCategoriaLista.Size = new System.Drawing.Size(54, 13);
            this.lblCategoriaLista.TabIndex = 23;
            this.lblCategoriaLista.Text = "Categoría";
            this.lblCategoriaLista.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIngresoLista
            // 
            this.lblIngresoLista.AutoSize = true;
            this.lblIngresoLista.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblIngresoLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblIngresoLista.Location = new System.Drawing.Point(405, 0);
            this.lblIngresoLista.Name = "lblIngresoLista";
            this.lblIngresoLista.Size = new System.Drawing.Size(42, 13);
            this.lblIngresoLista.TabIndex = 23;
            this.lblIngresoLista.Text = "Ingreso";
            this.lblIngresoLista.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrecioLista
            // 
            this.lblPrecioLista.AutoSize = true;
            this.lblPrecioLista.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPrecioLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblPrecioLista.Location = new System.Drawing.Point(468, 0);
            this.lblPrecioLista.Name = "lblPrecioLista";
            this.lblPrecioLista.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioLista.TabIndex = 23;
            this.lblPrecioLista.Text = "Precio";
            this.lblPrecioLista.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIndexCodigo
            // 
            this.lblIndexCodigo.AutoSize = true;
            this.lblIndexCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblIndexCodigo.Location = new System.Drawing.Point(3, 14);
            this.lblIndexCodigo.Name = "lblIndexCodigo";
            this.lblIndexCodigo.Size = new System.Drawing.Size(31, 13);
            this.lblIndexCodigo.TabIndex = 24;
            this.lblIndexCodigo.Text = "code";
            // 
            // lblIndexNombre
            // 
            this.lblIndexNombre.AutoSize = true;
            this.lblIndexNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblIndexNombre.Location = new System.Drawing.Point(55, 14);
            this.lblIndexNombre.Name = "lblIndexNombre";
            this.lblIndexNombre.Size = new System.Drawing.Size(29, 13);
            this.lblIndexNombre.TabIndex = 25;
            this.lblIndexNombre.Text = "Nom";
            // 
            // lblIndexDescrip
            // 
            this.lblIndexDescrip.AutoSize = true;
            this.lblIndexDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblIndexDescrip.Location = new System.Drawing.Point(147, 14);
            this.lblIndexDescrip.Name = "lblIndexDescrip";
            this.lblIndexDescrip.Size = new System.Drawing.Size(63, 13);
            this.lblIndexDescrip.TabIndex = 26;
            this.lblIndexDescrip.Text = "Descripcion";
            // 
            // lblIndexCategoria
            // 
            this.lblIndexCategoria.AutoSize = true;
            this.lblIndexCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblIndexCategoria.Location = new System.Drawing.Point(286, 14);
            this.lblIndexCategoria.Name = "lblIndexCategoria";
            this.lblIndexCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblIndexCategoria.TabIndex = 27;
            this.lblIndexCategoria.Text = "Categoria";
            // 
            // lblIndexIngreso
            // 
            this.lblIndexIngreso.AutoSize = true;
            this.lblIndexIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblIndexIngreso.Location = new System.Drawing.Point(405, 14);
            this.lblIndexIngreso.Name = "lblIndexIngreso";
            this.lblIndexIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblIndexIngreso.TabIndex = 28;
            this.lblIndexIngreso.Text = "Ingreso";
            // 
            // lblIndexPrecio
            // 
            this.lblIndexPrecio.AutoSize = true;
            this.lblIndexPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblIndexPrecio.Location = new System.Drawing.Point(468, 14);
            this.lblIndexPrecio.Name = "lblIndexPrecio";
            this.lblIndexPrecio.Size = new System.Drawing.Size(19, 13);
            this.lblIndexPrecio.TabIndex = 29;
            this.lblIndexPrecio.Text = "$$";
            // 
            // frmProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gBoxInventario);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Inventario";
            this.Load += new System.EventHandler(this.frmProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gBoxInventario.ResumeLayout(false);
            this.gBoxInventario.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gBoxInventario;
        private System.Windows.Forms.Label lblEgreso;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.TextBox txtDecrip;
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
        private System.Windows.Forms.ListBox listLista;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCodeLista;
        private System.Windows.Forms.Label lblPrecioLista;
        private System.Windows.Forms.Label lblCategoriaLista;
        private System.Windows.Forms.Label lblDescripLista;
        private System.Windows.Forms.Label lblNombreLista;
        private System.Windows.Forms.Label lblIngresoLista;
        private System.Windows.Forms.Label lblIndexPrecio;
        private System.Windows.Forms.Label lblIndexIngreso;
        private System.Windows.Forms.Label lblIndexCategoria;
        private System.Windows.Forms.Label lblIndexDescrip;
        private System.Windows.Forms.Label lblIndexCodigo;
        private System.Windows.Forms.Label lblIndexNombre;
    }
}

