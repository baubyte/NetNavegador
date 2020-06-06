namespace DockAndAnchorExample
{
    partial class DockingForm
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
            this.lblLeftDock = new System.Windows.Forms.Label();
            this.lblRightDock = new System.Windows.Forms.Label();
            this.lblTopDock = new System.Windows.Forms.Label();
            this.lblBottomDock = new System.Windows.Forms.Label();
            this.lblFillDock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLeftDock
            // 
            this.lblLeftDock.BackColor = System.Drawing.Color.DimGray;
            this.lblLeftDock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLeftDock.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLeftDock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLeftDock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftDock.ForeColor = System.Drawing.Color.White;
            this.lblLeftDock.Location = new System.Drawing.Point(0, 0);
            this.lblLeftDock.Name = "lblLeftDock";
            this.lblLeftDock.Size = new System.Drawing.Size(48, 243);
            this.lblLeftDock.TabIndex = 0;
            this.lblLeftDock.Text = "Left Dock";
            this.lblLeftDock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRightDock
            // 
            this.lblRightDock.BackColor = System.Drawing.Color.DimGray;
            this.lblRightDock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRightDock.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRightDock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRightDock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightDock.ForeColor = System.Drawing.Color.White;
            this.lblRightDock.Location = new System.Drawing.Point(295, 0);
            this.lblRightDock.Name = "lblRightDock";
            this.lblRightDock.Size = new System.Drawing.Size(48, 243);
            this.lblRightDock.TabIndex = 1;
            this.lblRightDock.Text = "Right Dock";
            this.lblRightDock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopDock
            // 
            this.lblTopDock.BackColor = System.Drawing.Color.DimGray;
            this.lblTopDock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTopDock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopDock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTopDock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopDock.ForeColor = System.Drawing.Color.White;
            this.lblTopDock.Location = new System.Drawing.Point(48, 0);
            this.lblTopDock.Name = "lblTopDock";
            this.lblTopDock.Size = new System.Drawing.Size(247, 54);
            this.lblTopDock.TabIndex = 2;
            this.lblTopDock.Text = "Top Dock (Click To Resize)";
            this.lblTopDock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTopDock.Click += new System.EventHandler(this.lblTopDock_Click);
            // 
            // lblBottomDock
            // 
            this.lblBottomDock.BackColor = System.Drawing.Color.DimGray;
            this.lblBottomDock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBottomDock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBottomDock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblBottomDock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomDock.ForeColor = System.Drawing.Color.White;
            this.lblBottomDock.Location = new System.Drawing.Point(48, 189);
            this.lblBottomDock.Name = "lblBottomDock";
            this.lblBottomDock.Size = new System.Drawing.Size(247, 54);
            this.lblBottomDock.TabIndex = 3;
            this.lblBottomDock.Text = "Bottom Dock (Click To Resize)";
            this.lblBottomDock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBottomDock.Click += new System.EventHandler(this.lblBottomDock_Click);
            // 
            // lblFillDock
            // 
            this.lblFillDock.BackColor = System.Drawing.Color.DimGray;
            this.lblFillDock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFillDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFillDock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFillDock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFillDock.ForeColor = System.Drawing.Color.White;
            this.lblFillDock.Location = new System.Drawing.Point(48, 54);
            this.lblFillDock.Name = "lblFillDock";
            this.lblFillDock.Size = new System.Drawing.Size(247, 135);
            this.lblFillDock.TabIndex = 4;
            this.lblFillDock.Text = "Fill Dock";
            this.lblFillDock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DockingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 243);
            this.Controls.Add(this.lblFillDock);
            this.Controls.Add(this.lblTopDock);
            this.Controls.Add(this.lblBottomDock);
            this.Controls.Add(this.lblRightDock);
            this.Controls.Add(this.lblLeftDock);
            this.Name = "DockingForm";
            this.Text = "DockingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLeftDock;
        private System.Windows.Forms.Label lblRightDock;
        private System.Windows.Forms.Label lblTopDock;
        private System.Windows.Forms.Label lblBottomDock;
        private System.Windows.Forms.Label lblFillDock;
    }
}