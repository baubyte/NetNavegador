namespace sistema
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.ncliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApeYNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.tBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.pnlBordeBuscar = new System.Windows.Forms.Panel();
            this.pnlBordeNuevo = new System.Windows.Forms.Panel();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.pnlBordeEditar = new System.Windows.Forms.Panel();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.pnlBordeBorrar = new System.Windows.Forms.Panel();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.lIdCliente = new System.Windows.Forms.Label();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.tDNI = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.tDireccion = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.tCP = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.tProvincia = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label12 = new System.Windows.Forms.Label();
            this.tComentario = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.tLocalidad = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.tCUIT = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.tClave = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.AllowUserToOrderColumns = true;
            this.gridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.gridClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridClientes.ColumnHeadersHeight = 30;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ncliente,
            this.ApeYNom,
            this.cuit});
            this.gridClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridClientes.EnableHeadersVisualStyles = false;
            this.gridClientes.Location = new System.Drawing.Point(526, 82);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridClientes.Size = new System.Drawing.Size(508, 239);
            this.gridClientes.TabIndex = 15;
            this.gridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellContentClick);
            this.gridClientes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellEnter);
            // 
            // ncliente
            // 
            this.ncliente.DataPropertyName = "ncliente";
            this.ncliente.HeaderText = "ncliente";
            this.ncliente.Name = "ncliente";
            this.ncliente.ReadOnly = true;
            this.ncliente.Visible = false;
            // 
            // ApeYNom
            // 
            this.ApeYNom.DataPropertyName = "ApeYNom";
            this.ApeYNom.HeaderText = "Apellido y Nombre";
            this.ApeYNom.Name = "ApeYNom";
            this.ApeYNom.ReadOnly = true;
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "CUIT";
            this.cuit.HeaderText = "CUIT";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(622, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(151, 16);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "*Si dejas Vacio Trae Todo";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(555, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(319, 23);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Ingrese Nombre para Buscar un Cliente";
            // 
            // tBuscar
            // 
            this.tBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBuscar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBuscar.Location = new System.Drawing.Point(559, 32);
            this.tBuscar.Name = "tBuscar";
            this.tBuscar.Size = new System.Drawing.Size(305, 30);
            this.tBuscar.TabIndex = 12;
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
            this.btnBuscar.Location = new System.Drawing.Point(899, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0D;
            this.btnBuscar.Size = new System.Drawing.Size(110, 47);
            this.btnBuscar.TabIndex = 76;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlBordeBuscar
            // 
            this.pnlBordeBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlBordeBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlBordeBuscar.Location = new System.Drawing.Point(893, 23);
            this.pnlBordeBuscar.Name = "pnlBordeBuscar";
            this.pnlBordeBuscar.Size = new System.Drawing.Size(8, 47);
            this.pnlBordeBuscar.TabIndex = 77;
            // 
            // pnlBordeNuevo
            // 
            this.pnlBordeNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBordeNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(253)))), ((int)(((byte)(114)))));
            this.pnlBordeNuevo.Location = new System.Drawing.Point(591, 349);
            this.pnlBordeNuevo.Name = "pnlBordeNuevo";
            this.pnlBordeNuevo.Size = new System.Drawing.Size(8, 47);
            this.pnlBordeNuevo.TabIndex = 79;
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
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnNuevo.IconColor = System.Drawing.Color.White;
            this.btnNuevo.IconSize = 32;
            this.btnNuevo.Location = new System.Drawing.Point(597, 349);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Rotation = 0D;
            this.btnNuevo.Size = new System.Drawing.Size(110, 47);
            this.btnNuevo.TabIndex = 78;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pnlBordeEditar
            // 
            this.pnlBordeEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBordeEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlBordeEditar.Location = new System.Drawing.Point(735, 349);
            this.pnlBordeEditar.Name = "pnlBordeEditar";
            this.pnlBordeEditar.Size = new System.Drawing.Size(8, 47);
            this.pnlBordeEditar.TabIndex = 81;
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
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconSize = 32;
            this.btnEditar.Location = new System.Drawing.Point(741, 349);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Rotation = 0D;
            this.btnEditar.Size = new System.Drawing.Size(113, 47);
            this.btnEditar.TabIndex = 80;
            this.btnEditar.Text = "Guardar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnlBordeBorrar
            // 
            this.pnlBordeBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBordeBorrar.BackColor = System.Drawing.Color.Red;
            this.pnlBordeBorrar.Location = new System.Drawing.Point(881, 349);
            this.pnlBordeBorrar.Name = "pnlBordeBorrar";
            this.pnlBordeBorrar.Size = new System.Drawing.Size(8, 47);
            this.pnlBordeBorrar.TabIndex = 83;
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
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.btnBorrar.IconColor = System.Drawing.Color.White;
            this.btnBorrar.IconSize = 32;
            this.btnBorrar.Location = new System.Drawing.Point(887, 349);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Rotation = 0D;
            this.btnBorrar.Size = new System.Drawing.Size(110, 47);
            this.btnBorrar.TabIndex = 82;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lIdCliente
            // 
            this.lIdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lIdCliente.AutoSize = true;
            this.lIdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lIdCliente.ForeColor = System.Drawing.Color.White;
            this.lIdCliente.Location = new System.Drawing.Point(534, 63);
            this.lIdCliente.Name = "lIdCliente";
            this.lIdCliente.Size = new System.Drawing.Size(15, 16);
            this.lIdCliente.TabIndex = 96;
            this.lIdCliente.Text = "0";
            // 
            // tApellido
            // 
            this.tApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tApellido.Location = new System.Drawing.Point(135, 9);
            this.tApellido.MaxLength = 30;
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(359, 23);
            this.tApellido.TabIndex = 48;
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(25, 12);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 16);
            this.Label4.TabIndex = 47;
            this.Label4.Text = "Apellido/s:";
            // 
            // tNombre
            // 
            this.tNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tNombre.Location = new System.Drawing.Point(135, 45);
            this.tNombre.MaxLength = 30;
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(359, 23);
            this.tNombre.TabIndex = 49;
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(25, 48);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(66, 16);
            this.Label5.TabIndex = 50;
            this.Label5.Text = "Nombre/s:";
            // 
            // tDNI
            // 
            this.tDNI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tDNI.Location = new System.Drawing.Point(135, 81);
            this.tDNI.MaxLength = 8;
            this.tDNI.Name = "tDNI";
            this.tDNI.Size = new System.Drawing.Size(359, 23);
            this.tDNI.TabIndex = 51;
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(25, 84);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(95, 16);
            this.Label6.TabIndex = 57;
            this.Label6.Text = "DNI (solo núm.)";
            // 
            // tDireccion
            // 
            this.tDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tDireccion.Location = new System.Drawing.Point(135, 262);
            this.tDireccion.MaxLength = 50;
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(359, 23);
            this.tDireccion.TabIndex = 52;
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(25, 265);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(62, 16);
            this.Label8.TabIndex = 59;
            this.Label8.Text = "Dirección:";
            // 
            // tCP
            // 
            this.tCP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tCP.Location = new System.Drawing.Point(395, 298);
            this.tCP.MaxLength = 10;
            this.tCP.Name = "tCP";
            this.tCP.Size = new System.Drawing.Size(99, 23);
            this.tCP.TabIndex = 53;
            // 
            // Label9
            // 
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(25, 301);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(61, 16);
            this.Label9.TabIndex = 60;
            this.Label9.Text = "Localidad:";
            // 
            // tProvincia
            // 
            this.tProvincia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tProvincia.Location = new System.Drawing.Point(135, 334);
            this.tProvincia.MaxLength = 30;
            this.tProvincia.Name = "tProvincia";
            this.tProvincia.Size = new System.Drawing.Size(359, 23);
            this.tProvincia.TabIndex = 54;
            // 
            // Label10
            // 
            this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label10.AutoSize = true;
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(25, 376);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(60, 16);
            this.Label10.TabIndex = 61;
            this.Label10.Text = "Teléfono:";
            // 
            // tTelefono
            // 
            this.tTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tTelefono.Location = new System.Drawing.Point(135, 373);
            this.tTelefono.MaxLength = 35;
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(359, 23);
            this.tTelefono.TabIndex = 55;
            // 
            // Label11
            // 
            this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label11.AutoSize = true;
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(25, 417);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(41, 16);
            this.Label11.TabIndex = 62;
            this.Label11.Text = "Email:";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(156, 118);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(168, 23);
            this.DateTimePicker1.TabIndex = 56;
            // 
            // Label12
            // 
            this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label12.AutoSize = true;
            this.Label12.ForeColor = System.Drawing.Color.White;
            this.Label12.Location = new System.Drawing.Point(25, 123);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(125, 16);
            this.Label12.TabIndex = 63;
            this.Label12.Text = "Fecha de Nacimiento:";
            // 
            // tComentario
            // 
            this.tComentario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tComentario.Location = new System.Drawing.Point(135, 446);
            this.tComentario.MaxLength = 200;
            this.tComentario.Multiline = true;
            this.tComentario.Name = "tComentario";
            this.tComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tComentario.Size = new System.Drawing.Size(359, 61);
            this.tComentario.TabIndex = 58;
            // 
            // Label16
            // 
            this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label16.AutoSize = true;
            this.Label16.ForeColor = System.Drawing.Color.White;
            this.Label16.Location = new System.Drawing.Point(25, 459);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(77, 16);
            this.Label16.TabIndex = 64;
            this.Label16.Text = "Comentarios:";
            // 
            // tLocalidad
            // 
            this.tLocalidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tLocalidad.Location = new System.Drawing.Point(135, 298);
            this.tLocalidad.MaxLength = 20;
            this.tLocalidad.Name = "tLocalidad";
            this.tLocalidad.Size = new System.Drawing.Size(218, 23);
            this.tLocalidad.TabIndex = 65;
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(25, 340);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(59, 16);
            this.Label3.TabIndex = 66;
            this.Label3.Text = "Provincia:";
            // 
            // CheckBox1
            // 
            this.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.ForeColor = System.Drawing.Color.White;
            this.CheckBox1.Location = new System.Drawing.Point(428, 121);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(72, 20);
            this.CheckBox1.TabIndex = 67;
            this.CheckBox1.Text = "¿Activo?";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // tCUIT
            // 
            this.tCUIT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tCUIT.Location = new System.Drawing.Point(135, 153);
            this.tCUIT.MaxLength = 30;
            this.tCUIT.Name = "tCUIT";
            this.tCUIT.Size = new System.Drawing.Size(359, 23);
            this.tCUIT.TabIndex = 68;
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(25, 156);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(101, 16);
            this.Label7.TabIndex = 69;
            this.Label7.Text = "CUIT (solo núm.)";
            // 
            // tUsuario
            // 
            this.tUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tUsuario.Location = new System.Drawing.Point(135, 189);
            this.tUsuario.MaxLength = 10;
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(359, 23);
            this.tUsuario.TabIndex = 70;
            // 
            // Label13
            // 
            this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label13.AutoSize = true;
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(25, 192);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(52, 16);
            this.Label13.TabIndex = 71;
            this.Label13.Text = "Usuario:";
            // 
            // tClave
            // 
            this.tClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tClave.Location = new System.Drawing.Point(135, 225);
            this.tClave.MaxLength = 30;
            this.tClave.Name = "tClave";
            this.tClave.Size = new System.Drawing.Size(359, 23);
            this.tClave.TabIndex = 72;
            // 
            // Label14
            // 
            this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label14.AutoSize = true;
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(25, 232);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(71, 16);
            this.Label14.TabIndex = 73;
            this.Label14.Text = "Contraseña:";
            // 
            // Label15
            // 
            this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label15.AutoSize = true;
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(362, 301);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(26, 16);
            this.Label15.TabIndex = 74;
            this.Label15.Text = "CP:";
            // 
            // tEmail
            // 
            this.tEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tEmail.Location = new System.Drawing.Point(135, 410);
            this.tEmail.MaxLength = 35;
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(359, 23);
            this.tEmail.TabIndex = 75;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(374, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 16);
            this.label17.TabIndex = 97;
            this.label17.Text = "Estado:";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1046, 497);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lIdCliente);
            this.Controls.Add(this.pnlBordeBorrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.pnlBordeEditar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pnlBordeNuevo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlBordeBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.tClave);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.tCUIT);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.tLocalidad);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.tComentario);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.tProvincia);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.tCP);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.tDireccion);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.tDNI);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.tApellido);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tBuscar);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView gridClientes;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ncliente;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ApeYNom;
        internal System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox tBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Panel pnlBordeBuscar;
        private System.Windows.Forms.Panel pnlBordeNuevo;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private System.Windows.Forms.Panel pnlBordeEditar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.Panel pnlBordeBorrar;
        private FontAwesome.Sharp.IconButton btnBorrar;
        internal System.Windows.Forms.Label lIdCliente;
        internal System.Windows.Forms.TextBox tApellido;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox tNombre;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox tDNI;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox tDireccion;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox tCP;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox tProvincia;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox tTelefono;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox tComentario;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox tLocalidad;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.TextBox tCUIT;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox tUsuario;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox tClave;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox tEmail;
        internal System.Windows.Forms.Label label17;
    }
}