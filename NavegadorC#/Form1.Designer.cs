namespace Navegador
{
    partial class Form1
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
            this.bBuscar = new System.Windows.Forms.Button();
            this.tBuscar = new System.Windows.Forms.TextBox();
            this.textBuscar = new System.Windows.Forms.Label();
            this.lBuscar = new System.Windows.Forms.Label();
            this.bRojo = new System.Windows.Forms.Button();
            this.bVerde = new System.Windows.Forms.Button();
            this.bAzul = new System.Windows.Forms.Button();
            this.bVer = new System.Windows.Forms.Button();
            this.bIr = new System.Windows.Forms.Button();
            this.lIr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(176)))), ((int)(((byte)(254)))));
            this.bBuscar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.Location = new System.Drawing.Point(218, 46);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(137, 31);
            this.bBuscar.TabIndex = 0;
            this.bBuscar.Text = "Buscar en Google";
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // tBuscar
            // 
            this.tBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.tBuscar.Location = new System.Drawing.Point(218, 18);
            this.tBuscar.Name = "tBuscar";
            this.tBuscar.Size = new System.Drawing.Size(357, 20);
            this.tBuscar.TabIndex = 1;
            this.tBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBuscar
            // 
            this.textBuscar.AutoSize = true;
            this.textBuscar.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(8, 17);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(204, 21);
            this.textBuscar.TabIndex = 2;
            this.textBuscar.Text = "Escriba su Busqueda";
            this.textBuscar.Click += new System.EventHandler(this.label1_Click);
            // 
            // lBuscar
            // 
            this.lBuscar.AutoSize = true;
            this.lBuscar.Location = new System.Drawing.Point(240, 80);
            this.lBuscar.Name = "lBuscar";
            this.lBuscar.Size = new System.Drawing.Size(90, 13);
            this.lBuscar.TabIndex = 3;
            this.lBuscar.Text = "Click para Buscar";
            this.lBuscar.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // bRojo
            // 
            this.bRojo.BackColor = System.Drawing.Color.Red;
            this.bRojo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRojo.Location = new System.Drawing.Point(620, 42);
            this.bRojo.Name = "bRojo";
            this.bRojo.Size = new System.Drawing.Size(103, 27);
            this.bRojo.TabIndex = 4;
            this.bRojo.Text = "Fondo Rojo";
            this.bRojo.UseVisualStyleBackColor = false;
            this.bRojo.Click += new System.EventHandler(this.bRojo_Click);
            // 
            // bVerde
            // 
            this.bVerde.BackColor = System.Drawing.Color.Green;
            this.bVerde.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVerde.Location = new System.Drawing.Point(738, 42);
            this.bVerde.Name = "bVerde";
            this.bVerde.Size = new System.Drawing.Size(104, 27);
            this.bVerde.TabIndex = 5;
            this.bVerde.Text = "Fondo Verde";
            this.bVerde.UseVisualStyleBackColor = false;
            this.bVerde.Click += new System.EventHandler(this.bVerde_Click);
            // 
            // bAzul
            // 
            this.bAzul.BackColor = System.Drawing.Color.Blue;
            this.bAzul.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAzul.Location = new System.Drawing.Point(620, 89);
            this.bAzul.Name = "bAzul";
            this.bAzul.Size = new System.Drawing.Size(103, 27);
            this.bAzul.TabIndex = 6;
            this.bAzul.Text = "Fondo Azul";
            this.bAzul.UseVisualStyleBackColor = false;
            this.bAzul.Click += new System.EventHandler(this.bAzul_Click);
            // 
            // bVer
            // 
            this.bVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVer.Location = new System.Drawing.Point(729, 89);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(113, 27);
            this.bVer.TabIndex = 7;
            this.bVer.Text = "Ocultar Botones";
            this.bVer.UseVisualStyleBackColor = true;
            this.bVer.Click += new System.EventHandler(this.button1_Click);
            // 
            // bIr
            // 
            this.bIr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(176)))), ((int)(((byte)(254)))));
            this.bIr.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIr.Location = new System.Drawing.Point(425, 46);
            this.bIr.Name = "bIr";
            this.bIr.Size = new System.Drawing.Size(137, 31);
            this.bIr.TabIndex = 8;
            this.bIr.Text = "Ir a URL";
            this.bIr.UseVisualStyleBackColor = false;
            this.bIr.Click += new System.EventHandler(this.bIr_Click);
            // 
            // lIr
            // 
            this.lIr.AutoSize = true;
            this.lIr.Location = new System.Drawing.Point(446, 80);
            this.lIr.Name = "lIr";
            this.lIr.Size = new System.Drawing.Size(108, 13);
            this.lIr.TabIndex = 9;
            this.lIr.Text = "Click para Ir a la URL";
            this.lIr.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(686, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Opciones";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(25, 122);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(843, 306);
            this.webBrowser1.TabIndex = 11;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(255)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(896, 432);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lIr);
            this.Controls.Add(this.bIr);
            this.Controls.Add(this.bVer);
            this.Controls.Add(this.bAzul);
            this.Controls.Add(this.bVerde);
            this.Controls.Add(this.bRojo);
            this.Controls.Add(this.lBuscar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.tBuscar);
            this.Controls.Add(this.bBuscar);
            this.Name = "Form1";
            this.Text = "Buscador Google";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox tBuscar;
        private System.Windows.Forms.Label textBuscar;
        private System.Windows.Forms.Label lBuscar;
        private System.Windows.Forms.Button bRojo;
        private System.Windows.Forms.Button bVerde;
        private System.Windows.Forms.Button bAzul;
        private System.Windows.Forms.Button bVer;
        private System.Windows.Forms.Button bIr;
        private System.Windows.Forms.Label lIr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

