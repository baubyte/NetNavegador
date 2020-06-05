namespace sistema
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.lIdCliente = new System.Windows.Forms.Label();
            this.pnlBordeBuscar = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.tBuscar = new System.Windows.Forms.TextBox();
            this.gridProveedores = new System.Windows.Forms.DataGridView();
            this.nproveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApeYNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBordeBorrar = new System.Windows.Forms.Panel();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.pnlBordeEditar = new System.Windows.Forms.Panel();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.pnlBordeNuevo = new System.Windows.Forms.Panel();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lIdCliente
            // 
            this.lIdCliente.AutoSize = true;
            this.lIdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lIdCliente.ForeColor = System.Drawing.Color.White;
            this.lIdCliente.Location = new System.Drawing.Point(534, 63);
            this.lIdCliente.Name = "lIdCliente";
            this.lIdCliente.Size = new System.Drawing.Size(15, 16);
            this.lIdCliente.TabIndex = 102;
            this.lIdCliente.Text = "0";
            // 
            // pnlBordeBuscar
            // 
            this.pnlBordeBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlBordeBuscar.Location = new System.Drawing.Point(883, 23);
            this.pnlBordeBuscar.Name = "pnlBordeBuscar";
            this.pnlBordeBuscar.Size = new System.Drawing.Size(8, 47);
            this.pnlBordeBuscar.TabIndex = 101;
            // 
            // btnBuscar
            // 
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
            this.btnBuscar.Location = new System.Drawing.Point(889, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0D;
            this.btnBuscar.Size = new System.Drawing.Size(110, 47);
            this.btnBuscar.TabIndex = 100;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(622, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(151, 16);
            this.Label2.TabIndex = 99;
            this.Label2.Text = "*Si dejas Vacio Trae Todo";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(544, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(343, 23);
            this.Label1.TabIndex = 98;
            this.Label1.Text = "Ingrese Nombre para Buscar un Proveedor";
            // 
            // tBuscar
            // 
            this.tBuscar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBuscar.Location = new System.Drawing.Point(559, 32);
            this.tBuscar.Name = "tBuscar";
            this.tBuscar.Size = new System.Drawing.Size(305, 30);
            this.tBuscar.TabIndex = 97;
            // 
            // gridProveedores
            // 
            this.gridProveedores.AllowUserToDeleteRows = false;
            this.gridProveedores.AllowUserToOrderColumns = true;
            this.gridProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.gridProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nproveedor,
            this.ApeYNom,
            this.cuit});
            this.gridProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridProveedores.EnableHeadersVisualStyles = false;
            this.gridProveedores.Location = new System.Drawing.Point(526, 82);
            this.gridProveedores.Name = "gridProveedores";
            this.gridProveedores.ReadOnly = true;
            this.gridProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProveedores.Size = new System.Drawing.Size(508, 239);
            this.gridProveedores.TabIndex = 103;
            // 
            // nproveedor
            // 
            this.nproveedor.DataPropertyName = "nproveedor";
            this.nproveedor.HeaderText = "nproveedor";
            this.nproveedor.Name = "nproveedor";
            this.nproveedor.ReadOnly = true;
            this.nproveedor.Visible = false;
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
            // pnlBordeBorrar
            // 
            this.pnlBordeBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBordeBorrar.BackColor = System.Drawing.Color.Red;
            this.pnlBordeBorrar.Location = new System.Drawing.Point(881, 349);
            this.pnlBordeBorrar.Name = "pnlBordeBorrar";
            this.pnlBordeBorrar.Size = new System.Drawing.Size(8, 47);
            this.pnlBordeBorrar.TabIndex = 109;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnBorrar.TabIndex = 108;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // pnlBordeEditar
            // 
            this.pnlBordeEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBordeEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlBordeEditar.Location = new System.Drawing.Point(735, 349);
            this.pnlBordeEditar.Name = "pnlBordeEditar";
            this.pnlBordeEditar.Size = new System.Drawing.Size(8, 47);
            this.pnlBordeEditar.TabIndex = 107;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnEditar.TabIndex = 106;
            this.btnEditar.Text = "Guardar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // pnlBordeNuevo
            // 
            this.pnlBordeNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBordeNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(253)))), ((int)(((byte)(114)))));
            this.pnlBordeNuevo.Location = new System.Drawing.Point(591, 349);
            this.pnlBordeNuevo.Name = "pnlBordeNuevo";
            this.pnlBordeNuevo.Size = new System.Drawing.Size(8, 47);
            this.pnlBordeNuevo.TabIndex = 105;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnNuevo.TabIndex = 104;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1046, 497);
            this.Controls.Add(this.pnlBordeBorrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.pnlBordeEditar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pnlBordeNuevo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gridProveedores);
            this.Controls.Add(this.lIdCliente);
            this.Controls.Add(this.pnlBordeBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tBuscar);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lIdCliente;
        private System.Windows.Forms.Panel pnlBordeBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox tBuscar;
        internal System.Windows.Forms.DataGridView gridProveedores;
        internal System.Windows.Forms.DataGridViewTextBoxColumn nproveedor;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ApeYNom;
        internal System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.Panel pnlBordeBorrar;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private System.Windows.Forms.Panel pnlBordeEditar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.Panel pnlBordeNuevo;
        private FontAwesome.Sharp.IconButton btnNuevo;
    }
}