namespace DockAndAnchorExample
{
    partial class Form1
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
            this.btnShowDockingForm = new System.Windows.Forms.Button();
            this.btnShowAnchoringForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowDockingForm
            // 
            this.btnShowDockingForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowDockingForm.Location = new System.Drawing.Point(12, 12);
            this.btnShowDockingForm.Name = "btnShowDockingForm";
            this.btnShowDockingForm.Size = new System.Drawing.Size(256, 23);
            this.btnShowDockingForm.TabIndex = 0;
            this.btnShowDockingForm.Text = "Show Docking Example Form";
            this.btnShowDockingForm.UseVisualStyleBackColor = true;
            this.btnShowDockingForm.Click += new System.EventHandler(this.btnShowDockingForm_Click);
            // 
            // btnShowAnchoringForm
            // 
            this.btnShowAnchoringForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAnchoringForm.Location = new System.Drawing.Point(12, 41);
            this.btnShowAnchoringForm.Name = "btnShowAnchoringForm";
            this.btnShowAnchoringForm.Size = new System.Drawing.Size(256, 23);
            this.btnShowAnchoringForm.TabIndex = 1;
            this.btnShowAnchoringForm.Text = "Show Anchoring Example Form";
            this.btnShowAnchoringForm.UseVisualStyleBackColor = true;
            this.btnShowAnchoringForm.Click += new System.EventHandler(this.btnShowAnchoringForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 77);
            this.Controls.Add(this.btnShowAnchoringForm);
            this.Controls.Add(this.btnShowDockingForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WinForm Control Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowDockingForm;
        private System.Windows.Forms.Button btnShowAnchoringForm;
    }
}

