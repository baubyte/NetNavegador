namespace sistema
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnProveedores = new FontAwesome.Sharp.IconButton();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            this.pnlLogotipo = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.lGestion = new System.Windows.Forms.Label();
            this.pLogoTipo = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.ntnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.bntClose = new FontAwesome.Sharp.IconPictureBox();
            this.lTitleFormActive = new System.Windows.Forms.Label();
            this.iconFromActive = new FontAwesome.Sharp.IconButton();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblInicio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lLastNameUser = new System.Windows.Forms.Label();
            this.lNameUser = new System.Windows.Forms.Label();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.lFecha = new System.Windows.Forms.Label();
            this.lHora = new System.Windows.Forms.Label();
            this.tmExpandirMenu = new System.Windows.Forms.Timer(this.components);
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlLogotipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogoTipo)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntClose)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlMenu.Controls.Add(this.btnSalir);
            this.pnlMenu.Controls.Add(this.btnProveedores);
            this.pnlMenu.Controls.Add(this.btnCliente);
            this.pnlMenu.Controls.Add(this.pnlLogotipo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 611);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSalir.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconSize = 32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 253);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Rotation = 0D;
            this.btnSalir.Size = new System.Drawing.Size(220, 60);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProveedores.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            this.btnProveedores.IconColor = System.Drawing.Color.White;
            this.btnProveedores.IconSize = 32;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(0, 193);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Rotation = 0D;
            this.btnProveedores.Size = new System.Drawing.Size(220, 60);
            this.btnProveedores.TabIndex = 2;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCliente.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnCliente.IconColor = System.Drawing.Color.White;
            this.btnCliente.IconSize = 32;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 133);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Rotation = 0D;
            this.btnCliente.Size = new System.Drawing.Size(220, 60);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pnlLogotipo
            // 
            this.pnlLogotipo.Controls.Add(this.btnMenu);
            this.pnlLogotipo.Controls.Add(this.lGestion);
            this.pnlLogotipo.Controls.Add(this.pLogoTipo);
            this.pnlLogotipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogotipo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogotipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLogotipo.Name = "pnlLogotipo";
            this.pnlLogotipo.Size = new System.Drawing.Size(220, 133);
            this.pnlLogotipo.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconSize = 32;
            this.btnMenu.Location = new System.Drawing.Point(170, 96);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Rotation = 0D;
            this.btnMenu.Size = new System.Drawing.Size(47, 31);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lGestion
            // 
            this.lGestion.AutoSize = true;
            this.lGestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lGestion.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGestion.ForeColor = System.Drawing.Color.White;
            this.lGestion.Location = new System.Drawing.Point(107, 0);
            this.lGestion.Name = "lGestion";
            this.lGestion.Size = new System.Drawing.Size(94, 90);
            this.lGestion.TabIndex = 1;
            this.lGestion.Text = "Sistema\r\nde\r\nGestión";
            this.lGestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lGestion.Click += new System.EventHandler(this.lGestion_Click);
            // 
            // pLogoTipo
            // 
            this.pLogoTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pLogoTipo.Image = global::sistema.Properties.Resources.gestion;
            this.pLogoTipo.Location = new System.Drawing.Point(0, 0);
            this.pLogoTipo.Name = "pLogoTipo";
            this.pLogoTipo.Size = new System.Drawing.Size(87, 90);
            this.pLogoTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pLogoTipo.TabIndex = 0;
            this.pLogoTipo.TabStop = false;
            this.pLogoTipo.Click += new System.EventHandler(this.pLogoTipo_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.pnlTitulo.Controls.Add(this.btnMinimize);
            this.pnlTitulo.Controls.Add(this.ntnMaximize);
            this.pnlTitulo.Controls.Add(this.bntClose);
            this.pnlTitulo.Controls.Add(this.lTitleFormActive);
            this.pnlTitulo.Controls.Add(this.iconFromActive);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(220, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1064, 65);
            this.pnlTitulo.TabIndex = 1;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconSize = 22;
            this.btnMinimize.Location = new System.Drawing.Point(983, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 22);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // ntnMaximize
            // 
            this.ntnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ntnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ntnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ntnMaximize.IconChar = FontAwesome.Sharp.IconChar.CompressAlt;
            this.ntnMaximize.IconColor = System.Drawing.Color.White;
            this.ntnMaximize.IconSize = 22;
            this.ntnMaximize.Location = new System.Drawing.Point(1011, 3);
            this.ntnMaximize.Name = "ntnMaximize";
            this.ntnMaximize.Size = new System.Drawing.Size(22, 22);
            this.ntnMaximize.TabIndex = 4;
            this.ntnMaximize.TabStop = false;
            this.ntnMaximize.Click += new System.EventHandler(this.ntnMaximize_Click);
            // 
            // bntClose
            // 
            this.bntClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.bntClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.bntClose.IconColor = System.Drawing.Color.White;
            this.bntClose.IconSize = 22;
            this.bntClose.Location = new System.Drawing.Point(1039, 3);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(22, 22);
            this.bntClose.TabIndex = 3;
            this.bntClose.TabStop = false;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // lTitleFormActive
            // 
            this.lTitleFormActive.AutoSize = true;
            this.lTitleFormActive.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitleFormActive.ForeColor = System.Drawing.Color.White;
            this.lTitleFormActive.Location = new System.Drawing.Point(34, 15);
            this.lTitleFormActive.Name = "lTitleFormActive";
            this.lTitleFormActive.Size = new System.Drawing.Size(46, 19);
            this.lTitleFormActive.TabIndex = 2;
            this.lTitleFormActive.Text = "Inicio";
            // 
            // iconFromActive
            // 
            this.iconFromActive.FlatAppearance.BorderSize = 0;
            this.iconFromActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconFromActive.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconFromActive.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconFromActive.IconColor = System.Drawing.Color.White;
            this.iconFromActive.IconSize = 32;
            this.iconFromActive.Location = new System.Drawing.Point(3, 12);
            this.iconFromActive.Name = "iconFromActive";
            this.iconFromActive.Rotation = 0D;
            this.iconFromActive.Size = new System.Drawing.Size(32, 32);
            this.iconFromActive.TabIndex = 1;
            this.iconFromActive.UseVisualStyleBackColor = true;
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadow.Location = new System.Drawing.Point(220, 65);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(1064, 10);
            this.pnlShadow.TabIndex = 2;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnlContent.Controls.Add(this.lblInicio);
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 75);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1064, 536);
            this.pnlContent.TabIndex = 3;
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(353, 84);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(400, 266);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Bienvenido al\r\nSistema de Gestion\r\nde\r\nClientes y Proveedores\r\n\r\nElija Algunas de" +
    " las Opciones\r\nDisponibles";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lLastNameUser);
            this.panel1.Controls.Add(this.lNameUser);
            this.panel1.Controls.Add(this.iconUser);
            this.panel1.Controls.Add(this.lFecha);
            this.panel1.Controls.Add(this.lHora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 60);
            this.panel1.TabIndex = 0;
            // 
            // lLastNameUser
            // 
            this.lLastNameUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lLastNameUser.AutoSize = true;
            this.lLastNameUser.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLastNameUser.ForeColor = System.Drawing.Color.White;
            this.lLastNameUser.Location = new System.Drawing.Point(62, 32);
            this.lLastNameUser.Name = "lLastNameUser";
            this.lLastNameUser.Size = new System.Drawing.Size(79, 19);
            this.lLastNameUser.TabIndex = 4;
            this.lLastNameUser.Text = "Pared Baez";
            // 
            // lNameUser
            // 
            this.lNameUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lNameUser.AutoSize = true;
            this.lNameUser.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameUser.ForeColor = System.Drawing.Color.White;
            this.lNameUser.Location = new System.Drawing.Point(62, 13);
            this.lNameUser.Name = "lNameUser";
            this.lNameUser.Size = new System.Drawing.Size(85, 19);
            this.lNameUser.TabIndex = 3;
            this.lNameUser.Text = "Martin Jose";
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.iconUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconUser.IconColor = System.Drawing.Color.White;
            this.iconUser.IconSize = 60;
            this.iconUser.Location = new System.Drawing.Point(0, 0);
            this.iconUser.Name = "iconUser";
            this.iconUser.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconUser.Size = new System.Drawing.Size(62, 60);
            this.iconUser.TabIndex = 2;
            this.iconUser.TabStop = false;
            // 
            // lFecha
            // 
            this.lFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.ForeColor = System.Drawing.Color.White;
            this.lFecha.Location = new System.Drawing.Point(838, 36);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(183, 19);
            this.lFecha.TabIndex = 1;
            this.lFecha.Text = "Lunes, 1 de Junio de 2020";
            // 
            // lHora
            // 
            this.lHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lHora.AutoSize = true;
            this.lHora.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHora.ForeColor = System.Drawing.Color.White;
            this.lHora.Location = new System.Drawing.Point(866, 2);
            this.lHora.Name = "lHora";
            this.lHora.Size = new System.Drawing.Size(125, 34);
            this.lHora.TabIndex = 0;
            this.lHora.Text = "23:46:42";
            // 
            // tmExpandirMenu
            // 
            this.tmExpandirMenu.Interval = 15;
            this.tmExpandirMenu.Tick += new System.EventHandler(this.tmExpandirMenu_Tick);
            // 
            // tmContraerMenu
            // 
            this.tmContraerMenu.Interval = 15;
            this.tmContraerMenu.Tick += new System.EventHandler(this.tmContraerMenu_Tick);
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "Inicio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Resize += new System.EventHandler(this.Inicio_Resize);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogotipo.ResumeLayout(false);
            this.pnlLogotipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogoTipo)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntClose)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogotipo;
        private FontAwesome.Sharp.IconButton btnCliente;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private System.Windows.Forms.Label lGestion;
        private System.Windows.Forms.PictureBox pLogoTipo;
        private System.Windows.Forms.Panel pnlTitulo;
        private FontAwesome.Sharp.IconButton iconFromActive;
        private System.Windows.Forms.Label lTitleFormActive;
        private System.Windows.Forms.Panel pnlShadow;
        private System.Windows.Forms.Panel pnlContent;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox ntnMaximize;
        private FontAwesome.Sharp.IconPictureBox bntClose;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Timer tmExpandirMenu;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmFechaHora;
        private System.Windows.Forms.Label lHora;
        private System.Windows.Forms.Label lFecha;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private System.Windows.Forms.Label lLastNameUser;
        private System.Windows.Forms.Label lNameUser;
        internal System.Windows.Forms.Label lblInicio;
    }
}

