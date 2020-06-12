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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBordeBorrar = new System.Windows.Forms.Panel();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.pnlBordeEditar = new System.Windows.Forms.Panel();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.pnlBordeNuevo = new System.Windows.Forms.Panel();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.lIdProveedor = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.tBuscar = new System.Windows.Forms.TextBox();
            this.pnlBordeBuscar = new System.Windows.Forms.Panel();
            this.nproveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApeYNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProductos.ColumnHeadersHeight = 30;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nproveedor,
            this.ApeYNom,
            this.cuit});
            this.gridProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridProductos.EnableHeadersVisualStyles = false;
            this.gridProductos.Location = new System.Drawing.Point(526, 86);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProductos.Size = new System.Drawing.Size(508, 239);
            this.gridProductos.TabIndex = 115;
            // 
            // lIdProveedor
            // 
            this.lIdProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lIdProveedor.AutoSize = true;
            this.lIdProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lIdProveedor.ForeColor = System.Drawing.Color.White;
            this.lIdProveedor.Location = new System.Drawing.Point(534, 67);
            this.lIdProveedor.Name = "lIdProveedor";
            this.lIdProveedor.Size = new System.Drawing.Size(15, 16);
            this.lIdProveedor.TabIndex = 114;
            this.lIdProveedor.Text = "0";
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
            // nproveedor
            // 
            this.nproveedor.DataPropertyName = "nproducto";
            this.nproveedor.HeaderText = "nproveedor";
            this.nproveedor.Name = "nproveedor";
            this.nproveedor.ReadOnly = true;
            this.nproveedor.Visible = false;
            // 
            // ApeYNom
            // 
            this.ApeYNom.DataPropertyName = "ApeYNom";
            this.ApeYNom.HeaderText = "Descripción Producto";
            this.ApeYNom.Name = "ApeYNom";
            this.ApeYNom.ReadOnly = true;
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "CUIT";
            this.cuit.HeaderText = "Precio";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1046, 497);
            this.Controls.Add(this.pnlBordeBuscar);
            this.Controls.Add(this.pnlBordeBorrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.pnlBordeEditar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pnlBordeNuevo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.lIdProveedor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tBuscar);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Productos";
            this.Text = "Productos";
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
        internal System.Windows.Forms.Label lIdProveedor;
        private FontAwesome.Sharp.IconButton btnBuscar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox tBuscar;
        private System.Windows.Forms.Panel pnlBordeBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nproveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApeYNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
    }
}