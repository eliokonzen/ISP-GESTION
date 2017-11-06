namespace VISTA.Conexiones
{
    partial class frmGestionarConexiones
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
            this.dgvConexiones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConexiones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConexiones
            // 
            this.dgvConexiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConexiones.Location = new System.Drawing.Point(28, 51);
            this.dgvConexiones.Name = "dgvConexiones";
            this.dgvConexiones.Size = new System.Drawing.Size(868, 216);
            this.dgvConexiones.TabIndex = 0;
            // 
            // frmGestionarConexiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 321);
            this.Controls.Add(this.dgvConexiones);
            this.Name = "frmGestionarConexiones";
            this.Text = "frmGestionarConexiones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConexiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConexiones;
    }
}