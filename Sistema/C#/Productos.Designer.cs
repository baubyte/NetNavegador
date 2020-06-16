namespace sistema
{
    partial class Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBordeBorrar = new System.Windows.Forms.Panel();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.pnlBordeEditar = new System.Windows.Forms.Panel();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.pnlBordeNuevo = new System.Windows.Forms.Panel();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.tBuscar = new System.Windows.Forms.TextBox();
            this.pnlBordeBuscar = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.tDescripcionProducto = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.tProveedor = new System.Windows.Forms.TextBox();
            this.tPrecioVenta = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.tNombreProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tPrecioCosto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tStock = new System.Windows.Forms.TextBox();
            this.btnAddProveedor = new FontAwesome.Sharp.IconButton();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lIdProveedor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tCodProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tMarcaProducto = new System.Windows.Forms.TextBox();
            this.lIdProducto = new System.Windows.Forms.Label();
            this.nproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBordeBorrar
            // 
            this.pnlBordeBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBordeBorrar.BackColor = System.Drawing.Color.Red;
            this.pnlBordeBorrar.Location = new System.Drawing.Point(881, 353);
            this.pnlBordeBorrar.Name = "pnlBordeBorrar";
            this.pnlBordeBorrar.Size = new System.Drawing.Size(8, 47);
            this.pnlBordeBorrar.TabIndex = 121;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBorrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.btnBorrar.IconColor = System.Drawing.Color.White;
            this.btnBorrar.IconSize = 32;
            this.btnBorrar.Location = new System.Drawing.Point(887, 353);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Rotation = 0D;
            this.btnBorrar.Size = new System.Drawing.Size(110, 47);
            this.btnBorrar.TabIndex = 120;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // pnlBordeEditar
            // 
            this.pnlBordeEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBordeEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlBordeEditar.Location = new System.Drawing.Point(735, 353);
            this.pnlBordeEditar.Name = "pnlBordeEditar";
            this.pnlBordeEditar.Size = new System.Drawing.Size(8, 47);
            this.pnlBordeEditar.TabIndex = 119;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEditar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconSize = 32;
            this.btnEditar.Location = new System.Drawing.Point(741, 353);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Rotation = 0D;
            this.btnEditar.Size = new System.Drawing.Size(113, 47);
            this.btnEditar.TabIndex = 118;
            this.btnEditar.Text = "Guardar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnlBordeNuevo
            // 
            this.pnlBordeNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBordeNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(253)))), ((int)(((byte)(114)))));
            this.pnlBordeNuevo.Location = new System.Drawing.Point(591, 353);
            this.pnlBordeNuevo.Name = "pnlBordeNuevo";
            this.pnlBordeNuevo.Size = new System.Drawing.Size(8, 47);
            this.pnlBordeNuevo.TabIndex = 117;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNuevo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnNuevo.IconColor = System.Drawing.Color.White;
            this.btnNuevo.IconSize = 32;
            this.btnNuevo.Location = new System.Drawing.Point(597, 353);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Rotation = 0D;
            this.btnNuevo.Size = new System.Drawing.Size(110, 47);
            this.btnNuevo.TabIndex = 116;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.AllowUserToAddRows = false;
            this.gridProductos.AllowUserToDeleteRows = false;
            this.gridProductos.AllowUserToOrderColumns = true;
            this.gridProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.gridProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridProductos.ColumnHeadersHeight = 30;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nproducto,
            this.CodigoProducto,
            this.producto,
            this.precio});
            this.gridProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProductos.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridProductos.EnableHeadersVisualStyles = false;
            this.gridProductos.Location = new System.Drawing.Point(526, 86);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridProductos.Size = new System.Drawing.Size(508, 239);
            this.gridProductos.TabIndex = 115;
            this.gridProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellContentClick);
            this.gridProductos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellEnter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconSize = 32;
            this.btnBuscar.Location = new System.Drawing.Point(899, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0D;
            this.btnBuscar.Size = new System.Drawing.Size(110, 47);
            this.btnBuscar.TabIndex = 113;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(622, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(151, 16);
            this.Label2.TabIndex = 112;
            this.Label2.Text = "*Si dejas Vacio Trae Todo";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(544, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(333, 23);
            this.Label1.TabIndex = 111;
            this.Label1.Text = "Ingrese Nombre para Buscar un Producto";
            // 
            // tBuscar
            // 
            this.tBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBuscar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBuscar.Location = new System.Drawing.Point(559, 36);
            this.tBuscar.Name = "tBuscar";
            this.tBuscar.Size = new System.Drawing.Size(305, 30);
            this.tBuscar.TabIndex = 110;
            // 
            // pnlBordeBuscar
            // 
            this.pnlBordeBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlBordeBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlBordeBuscar.Location = new System.Drawing.Point(892, 27);
            this.pnlBordeBuscar.Name = "pnlBordeBuscar";
            this.pnlBordeBuscar.Size = new System.Drawing.Size(8, 47);
            this.pnlBordeBuscar.TabIndex = 122;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(289, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 161;
            this.label13.Text = "Estado:";
            // 
            // Label15
            // 
            this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label15.AutoSize = true;
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(27, 255);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(97, 16);
            this.Label15.TabIndex = 159;
            this.Label15.Text = "Precio de Venta:";
            // 
            // CheckBox1
            // 
            this.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.ForeColor = System.Drawing.Color.White;
            this.CheckBox1.Location = new System.Drawing.Point(397, 288);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(72, 20);
            this.CheckBox1.TabIndex = 156;
            this.CheckBox1.Text = "¿Activo?";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(27, 330);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 16);
            this.Label3.TabIndex = 155;
            this.Label3.Text = "Proveedor:";
            // 
            // Label16
            // 
            this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label16.AutoSize = true;
            this.Label16.ForeColor = System.Drawing.Color.White;
            this.Label16.Location = new System.Drawing.Point(27, 182);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(73, 48);
            this.Label16.TabIndex = 153;
            this.Label16.Text = "Descripción \r\ndel \r\nProducto:";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tDescripcionProducto
            // 
            this.tDescripcionProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tDescripcionProducto.Location = new System.Drawing.Point(137, 174);
            this.tDescripcionProducto.MaxLength = 200;
            this.tDescripcionProducto.Multiline = true;
            this.tDescripcionProducto.Name = "tDescripcionProducto";
            this.tDescripcionProducto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tDescripcionProducto.Size = new System.Drawing.Size(359, 66);
            this.tDescripcionProducto.TabIndex = 148;
            // 
            // Label10
            // 
            this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label10.AutoSize = true;
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(27, 366);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(114, 16);
            this.Label10.TabIndex = 150;
            this.Label10.Text = "Categoria Producto:";
            // 
            // tProveedor
            // 
            this.tProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tProveedor.Location = new System.Drawing.Point(137, 324);
            this.tProveedor.MaxLength = 30;
            this.tProveedor.Name = "tProveedor";
            this.tProveedor.ReadOnly = true;
            this.tProveedor.Size = new System.Drawing.Size(246, 23);
            this.tProveedor.TabIndex = 143;
            // 
            // tPrecioVenta
            // 
            this.tPrecioVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tPrecioVenta.Location = new System.Drawing.Point(137, 252);
            this.tPrecioVenta.MaxLength = 10;
            this.tPrecioVenta.Name = "tPrecioVenta";
            this.tPrecioVenta.Size = new System.Drawing.Size(99, 23);
            this.tPrecioVenta.TabIndex = 142;
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(27, 86);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(106, 16);
            this.Label4.TabIndex = 136;
            this.Label4.Text = "Nombre Producto:";
            // 
            // tNombreProducto
            // 
            this.tNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tNombreProducto.Location = new System.Drawing.Point(137, 83);
            this.tNombreProducto.MaxLength = 30;
            this.tNombreProducto.Name = "tNombreProducto";
            this.tNombreProducto.Size = new System.Drawing.Size(359, 23);
            this.tNombreProducto.TabIndex = 137;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(287, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 163;
            this.label5.Text = "Precio de Costo:";
            // 
            // tPrecioCosto
            // 
            this.tPrecioCosto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tPrecioCosto.Location = new System.Drawing.Point(397, 255);
            this.tPrecioCosto.MaxLength = 10;
            this.tPrecioCosto.Name = "tPrecioCosto";
            this.tPrecioCosto.Size = new System.Drawing.Size(99, 23);
            this.tPrecioCosto.TabIndex = 162;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 165;
            this.label6.Text = "Stock Disponible:";
            // 
            // tStock
            // 
            this.tStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tStock.Location = new System.Drawing.Point(137, 286);
            this.tStock.MaxLength = 10;
            this.tStock.Name = "tStock";
            this.tStock.Size = new System.Drawing.Size(99, 23);
            this.tStock.TabIndex = 164;
            // 
            // btnAddProveedor
            // 
            this.btnAddProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProveedor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddProveedor.ForeColor = System.Drawing.Color.White;
            this.btnAddProveedor.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddProveedor.IconColor = System.Drawing.Color.White;
            this.btnAddProveedor.IconSize = 16;
            this.btnAddProveedor.Location = new System.Drawing.Point(397, 318);
            this.btnAddProveedor.Name = "btnAddProveedor";
            this.btnAddProveedor.Rotation = 0D;
            this.btnAddProveedor.Size = new System.Drawing.Size(35, 32);
            this.btnAddProveedor.TabIndex = 166;
            this.btnAddProveedor.UseVisualStyleBackColor = true;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Seleccione Categoria",
            "Alimentos",
            "Panaderia",
            "Art. Limpieza",
            "Bebidas",
            "Fiambres",
            "Art. Varios"});
            this.cmbCategoria.Location = new System.Drawing.Point(138, 363);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(359, 24);
            this.cmbCategoria.TabIndex = 168;
            // 
            // lIdProveedor
            // 
            this.lIdProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lIdProveedor.AutoSize = true;
            this.lIdProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lIdProveedor.ForeColor = System.Drawing.Color.White;
            this.lIdProveedor.Location = new System.Drawing.Point(454, 326);
            this.lIdProveedor.Name = "lIdProveedor";
            this.lIdProveedor.Size = new System.Drawing.Size(15, 16);
            this.lIdProveedor.TabIndex = 169;
            this.lIdProveedor.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 170;
            this.label7.Text = "Código Producto:";
            // 
            // tCodProducto
            // 
            this.tCodProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tCodProducto.Location = new System.Drawing.Point(137, 113);
            this.tCodProducto.MaxLength = 30;
            this.tCodProducto.Name = "tCodProducto";
            this.tCodProducto.Size = new System.Drawing.Size(359, 23);
            this.tCodProducto.TabIndex = 171;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(27, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 172;
            this.label8.Text = "Marca Producto:";
            // 
            // tMarcaProducto
            // 
            this.tMarcaProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tMarcaProducto.Location = new System.Drawing.Point(137, 142);
            this.tMarcaProducto.MaxLength = 30;
            this.tMarcaProducto.Name = "tMarcaProducto";
            this.tMarcaProducto.Size = new System.Drawing.Size(359, 23);
            this.tMarcaProducto.TabIndex = 173;
            // 
            // lIdProducto
            // 
            this.lIdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lIdProducto.AutoSize = true;
            this.lIdProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lIdProducto.ForeColor = System.Drawing.Color.White;
            this.lIdProducto.Location = new System.Drawing.Point(530, 67);
            this.lIdProducto.Name = "lIdProducto";
            this.lIdProducto.Size = new System.Drawing.Size(15, 16);
            this.lIdProducto.TabIndex = 174;
            this.lIdProducto.Text = "0";
            // 
            // nproducto
            // 
            this.nproducto.DataPropertyName = "NProducto";
            this.nproducto.HeaderText = "nproducto";
            this.nproducto.Name = "nproducto";
            this.nproducto.ReadOnly = true;
            this.nproducto.Visible = false;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.DataPropertyName = "CodigoProducto";
            this.CodigoProducto.HeaderText = "Cód, Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.DataPropertyName = "Producto";
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "PrecioVenta";
            this.precio.HeaderText = "Precio Venta";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1046, 497);
            this.Controls.Add(this.lIdProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tMarcaProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tCodProducto);
            this.Controls.Add(this.lIdProveedor);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnAddProveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tPrecioCosto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.tDescripcionProducto);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.tProveedor);
            this.Controls.Add(this.tPrecioVenta);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.tNombreProducto);
            this.Controls.Add(this.pnlBordeBuscar);
            this.Controls.Add(this.pnlBordeBorrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.pnlBordeEditar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pnlBordeNuevo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tBuscar);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBordeBorrar;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private System.Windows.Forms.Panel pnlBordeEditar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.Panel pnlBordeNuevo;
        private FontAwesome.Sharp.IconButton btnNuevo;
        internal System.Windows.Forms.DataGridView gridProductos;
        private FontAwesome.Sharp.IconButton btnBuscar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox tBuscar;
        private System.Windows.Forms.Panel pnlBordeBuscar;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox tDescripcionProducto;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox tProveedor;
        internal System.Windows.Forms.TextBox tPrecioVenta;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox tNombreProducto;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox tPrecioCosto;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox tStock;
        private FontAwesome.Sharp.IconButton btnAddProveedor;
        private System.Windows.Forms.ComboBox cmbCategoria;
        internal System.Windows.Forms.Label lIdProveedor;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox tCodProducto;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox tMarcaProducto;
        internal System.Windows.Forms.Label lIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
    }
}