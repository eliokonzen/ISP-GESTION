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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnFlitrar = new System.Windows.Forms.Button();
            this.txtCampoFiltrado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConexiones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConexiones
            // 
            this.dgvConexiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConexiones.Location = new System.Drawing.Point(10, 41);
            this.dgvConexiones.Name = "dgvConexiones";
            this.dgvConexiones.Size = new System.Drawing.Size(911, 342);
            this.dgvConexiones.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(846, 401);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(172, 401);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(91, 401);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(10, 401);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnFlitrar
            // 
            this.btnFlitrar.Location = new System.Drawing.Point(240, 13);
            this.btnFlitrar.Name = "btnFlitrar";
            this.btnFlitrar.Size = new System.Drawing.Size(75, 23);
            this.btnFlitrar.TabIndex = 5;
            this.btnFlitrar.Text = "Filtar";
            this.btnFlitrar.UseVisualStyleBackColor = true;
            // 
            // txtCampoFiltrado
            // 
            this.txtCampoFiltrado.Location = new System.Drawing.Point(12, 15);
            this.txtCampoFiltrado.Name = "txtCampoFiltrado";
            this.txtCampoFiltrado.Size = new System.Drawing.Size(222, 20);
            this.txtCampoFiltrado.TabIndex = 6;
            // 
            // frmGestionarConexiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 436);
            this.Controls.Add(this.txtCampoFiltrado);
            this.Controls.Add(this.btnFlitrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvConexiones);
            this.Name = "frmGestionarConexiones";
            this.Text = "::.. Gestionar Conexiones";
            this.Load += new System.EventHandler(this.frmGestionarConexiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConexiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConexiones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnFlitrar;
        private System.Windows.Forms.TextBox txtCampoFiltrado;
    }
}