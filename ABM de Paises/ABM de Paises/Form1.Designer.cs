namespace ABM_de_Paises
{
    partial class ABM
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
            this.txtPaises = new System.Windows.Forms.TextBox();
            this.txtCiudades = new System.Windows.Forms.TextBox();
            this.txtProvincias = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.lblPaises = new System.Windows.Forms.Label();
            this.lblCiudades = new System.Windows.Forms.Label();
            this.lblProvincias = new System.Windows.Forms.Label();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPaises
            // 
            this.txtPaises.Location = new System.Drawing.Point(13, 13);
            this.txtPaises.Name = "txtPaises";
            this.txtPaises.Size = new System.Drawing.Size(100, 20);
            this.txtPaises.TabIndex = 0;
            // 
            // txtCiudades
            // 
            this.txtCiudades.Location = new System.Drawing.Point(13, 55);
            this.txtCiudades.Name = "txtCiudades";
            this.txtCiudades.Size = new System.Drawing.Size(100, 20);
            this.txtCiudades.TabIndex = 1;
            // 
            // txtProvincias
            // 
            this.txtProvincias.Location = new System.Drawing.Point(13, 101);
            this.txtProvincias.Name = "txtProvincias";
            this.txtProvincias.Size = new System.Drawing.Size(100, 20);
            this.txtProvincias.TabIndex = 2;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(13, 156);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 4;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(119, 156);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 5;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(226, 156);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 6;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(119, 222);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 7;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // lblPaises
            // 
            this.lblPaises.AutoSize = true;
            this.lblPaises.Location = new System.Drawing.Point(136, 19);
            this.lblPaises.Name = "lblPaises";
            this.lblPaises.Size = new System.Drawing.Size(29, 13);
            this.lblPaises.TabIndex = 8;
            this.lblPaises.Text = "País";
            // 
            // lblCiudades
            // 
            this.lblCiudades.AutoSize = true;
            this.lblCiudades.Location = new System.Drawing.Point(139, 61);
            this.lblCiudades.Name = "lblCiudades";
            this.lblCiudades.Size = new System.Drawing.Size(40, 13);
            this.lblCiudades.TabIndex = 9;
            this.lblCiudades.Text = "Ciudad";
            // 
            // lblProvincias
            // 
            this.lblProvincias.AutoSize = true;
            this.lblProvincias.Location = new System.Drawing.Point(139, 107);
            this.lblProvincias.Name = "lblProvincias";
            this.lblProvincias.Size = new System.Drawing.Size(51, 13);
            this.lblProvincias.TabIndex = 10;
            this.lblProvincias.Text = "Provincia";
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(3, 281);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(307, 150);
            this.dgvMostrar.TabIndex = 11;
            // 
            // ABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 435);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.lblProvincias);
            this.Controls.Add(this.lblCiudades);
            this.Controls.Add(this.lblPaises);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtProvincias);
            this.Controls.Add(this.txtCiudades);
            this.Controls.Add(this.txtPaises);
            this.Name = "ABM";
            this.Text = "ABM Paises";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPaises;
        private System.Windows.Forms.TextBox txtCiudades;
        private System.Windows.Forms.TextBox txtProvincias;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label lblPaises;
        private System.Windows.Forms.Label lblCiudades;
        private System.Windows.Forms.Label lblProvincias;
        private System.Windows.Forms.DataGridView dgvMostrar;
    }
}

