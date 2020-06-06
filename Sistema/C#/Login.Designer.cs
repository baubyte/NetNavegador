namespace sistema
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.bntClose = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lGestion = new System.Windows.Forms.Label();
            this.pLogoTipo = new System.Windows.Forms.PictureBox();
            this.pnlShadowButtom = new System.Windows.Forms.Panel();
            this.pnlShadowTop = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconLogin = new FontAwesome.Sharp.IconPictureBox();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.iconClave = new FontAwesome.Sharp.IconPictureBox();
            this.iconUsuario = new FontAwesome.Sharp.IconPictureBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLogoTipo)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.pnlTitulo.Controls.Add(this.btnMinimize);
            this.pnlTitulo.Controls.Add(this.bntClose);
            this.pnlTitulo.Controls.Add(this.label3);
            this.pnlTitulo.Controls.Add(this.lGestion);
            this.pnlTitulo.Controls.Add(this.pLogoTipo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(634, 62);
            this.pnlTitulo.TabIndex = 2;
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
            this.btnMinimize.Location = new System.Drawing.Point(579, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 22);
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // bntClose
            // 
            this.bntClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.bntClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.bntClose.IconColor = System.Drawing.Color.White;
            this.bntClose.IconSize = 22;
            this.bntClose.Location = new System.Drawing.Point(609, 3);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(22, 22);
            this.bntClose.TabIndex = 12;
            this.bntClose.TabStop = false;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(250, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Iniciar Sesión";
            // 
            // lGestion
            // 
            this.lGestion.AutoSize = true;
            this.lGestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lGestion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGestion.ForeColor = System.Drawing.Color.White;
            this.lGestion.Location = new System.Drawing.Point(73, 0);
            this.lGestion.Name = "lGestion";
            this.lGestion.Size = new System.Drawing.Size(58, 57);
            this.lGestion.TabIndex = 3;
            this.lGestion.Text = "Sistema\r\nde\r\nGestión";
            this.lGestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLogoTipo
            // 
            this.pLogoTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pLogoTipo.Image = global::sistema.Properties.Resources.gestion;
            this.pLogoTipo.Location = new System.Drawing.Point(0, 3);
            this.pLogoTipo.Name = "pLogoTipo";
            this.pLogoTipo.Size = new System.Drawing.Size(64, 50);
            this.pLogoTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pLogoTipo.TabIndex = 2;
            this.pLogoTipo.TabStop = false;
            // 
            // pnlShadowButtom
            // 
            this.pnlShadowButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.pnlShadowButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlShadowButtom.Location = new System.Drawing.Point(0, 601);
            this.pnlShadowButtom.Name = "pnlShadowButtom";
            this.pnlShadowButtom.Size = new System.Drawing.Size(634, 10);
            this.pnlShadowButtom.TabIndex = 4;
            // 
            // pnlShadowTop
            // 
            this.pnlShadowTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.pnlShadowTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadowTop.Location = new System.Drawing.Point(0, 62);
            this.pnlShadowTop.Name = "pnlShadowTop";
            this.pnlShadowTop.Size = new System.Drawing.Size(634, 10);
            this.pnlShadowTop.TabIndex = 5;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.iconLogin);
            this.pnlContent.Controls.Add(this.btnSalir);
            this.pnlContent.Controls.Add(this.iconClave);
            this.pnlContent.Controls.Add(this.iconUsuario);
            this.pnlContent.Controls.Add(this.txtClave);
            this.pnlContent.Controls.Add(this.txtUsuario);
            this.pnlContent.Controls.Add(this.btnLogin);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 72);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(634, 529);
            this.pnlContent.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario";
            // 
            // iconLogin
            // 
            this.iconLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.iconLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.iconLogin.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.iconLogin.IconSize = 205;
            this.iconLogin.Location = new System.Drawing.Point(203, 26);
            this.iconLogin.Name = "iconLogin";
            this.iconLogin.Size = new System.Drawing.Size(250, 205);
            this.iconLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconLogin.TabIndex = 8;
            this.iconLogin.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSalir.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir.IconColor = System.Drawing.Color.Red;
            this.btnSalir.IconSize = 32;
            this.btnSalir.Location = new System.Drawing.Point(108, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Rotation = 0D;
            this.btnSalir.Size = new System.Drawing.Size(145, 60);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // iconClave
            // 
            this.iconClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.iconClave.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconClave.IconColor = System.Drawing.Color.White;
            this.iconClave.IconSize = 40;
            this.iconClave.Location = new System.Drawing.Point(61, 309);
            this.iconClave.Name = "iconClave";
            this.iconClave.Size = new System.Drawing.Size(40, 40);
            this.iconClave.TabIndex = 6;
            this.iconClave.TabStop = false;
            // 
            // iconUsuario
            // 
            this.iconUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.iconUsuario.IconChar = FontAwesome.Sharp.IconChar.UserNinja;
            this.iconUsuario.IconColor = System.Drawing.Color.White;
            this.iconUsuario.IconSize = 40;
            this.iconUsuario.Location = new System.Drawing.Point(91, 253);
            this.iconUsuario.Name = "iconUsuario";
            this.iconUsuario.Size = new System.Drawing.Size(40, 40);
            this.iconUsuario.TabIndex = 5;
            this.iconUsuario.TabStop = false;
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClave.Location = new System.Drawing.Point(234, 318);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(297, 26);
            this.txtClave.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(232, 261);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(297, 26);
            this.txtUsuario.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnLogin.IconColor = System.Drawing.Color.Chartreuse;
            this.btnLogin.IconSize = 32;
            this.btnLogin.Location = new System.Drawing.Point(386, 385);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Rotation = 0D;
            this.btnLogin.Size = new System.Drawing.Size(145, 60);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlShadowTop);
            this.Controls.Add(this.pnlShadowButtom);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(650, 650);
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLogoTipo)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lGestion;
        private System.Windows.Forms.PictureBox pLogoTipo;
        private System.Windows.Forms.Panel pnlShadowButtom;
        private System.Windows.Forms.Panel pnlShadowTop;
        private System.Windows.Forms.Panel pnlContent;
        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private FontAwesome.Sharp.IconPictureBox iconUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private FontAwesome.Sharp.IconPictureBox iconClave;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconPictureBox iconLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox bntClose;
    }
}