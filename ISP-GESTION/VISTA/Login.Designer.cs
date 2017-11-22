namespace VISTA
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
            this.btnACEPTAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnACEPTAR
            // 
            this.btnACEPTAR.Location = new System.Drawing.Point(46, 210);
            this.btnACEPTAR.Name = "btnACEPTAR";
            this.btnACEPTAR.Size = new System.Drawing.Size(75, 23);
            this.btnACEPTAR.TabIndex = 0;
            this.btnACEPTAR.Text = "Aceptar";
            this.btnACEPTAR.UseVisualStyleBackColor = true;
            this.btnACEPTAR.Click += new System.EventHandler(this.btnACEPTAR_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnACEPTAR);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnACEPTAR;
    }
}