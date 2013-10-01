namespace principal
{
    partial class Empleados
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nombre = new System.Windows.Forms.Label();
            this.ApellidoPaterno = new System.Windows.Forms.Label();
            this.ApellidoMaterno = new System.Windows.Forms.Label();
            this.Cargo = new System.Windows.Forms.Label();
            this.Salario = new System.Windows.Forms.Label();
            this.FI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtFI = new System.Windows.Forms.TextBox();
            this.txtAM = new System.Windows.Forms.TextBox();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.CodE = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.mostrarP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarP)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nombre.Location = new System.Drawing.Point(43, 71);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(70, 22);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.AutoSize = true;
            this.ApellidoPaterno.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoPaterno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ApellidoPaterno.Location = new System.Drawing.Point(43, 112);
            this.ApellidoPaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.Size = new System.Drawing.Size(142, 22);
            this.ApellidoPaterno.TabIndex = 1;
            this.ApellidoPaterno.Text = "Apellido Paterno";
            this.ApellidoPaterno.Click += new System.EventHandler(this.ApellidoPaterno_Click);
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.AutoSize = true;
            this.ApellidoMaterno.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoMaterno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ApellidoMaterno.Location = new System.Drawing.Point(43, 153);
            this.ApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.Size = new System.Drawing.Size(148, 22);
            this.ApellidoMaterno.TabIndex = 2;
            this.ApellidoMaterno.Text = "Apellido Materno";
            // 
            // Cargo
            // 
            this.Cargo.AutoSize = true;
            this.Cargo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cargo.Location = new System.Drawing.Point(43, 189);
            this.Cargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(55, 22);
            this.Cargo.TabIndex = 3;
            this.Cargo.Text = "Cargo";
            // 
            // Salario
            // 
            this.Salario.AutoSize = true;
            this.Salario.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Salario.Location = new System.Drawing.Point(43, 231);
            this.Salario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(66, 22);
            this.Salario.TabIndex = 4;
            this.Salario.Text = "Salario";
            // 
            // FI
            // 
            this.FI.AutoSize = true;
            this.FI.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FI.Location = new System.Drawing.Point(43, 275);
            this.FI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FI.Name = "FI";
            this.FI.Size = new System.Drawing.Size(141, 22);
            this.FI.TabIndex = 5;
            this.FI.Text = "Fecha de Ingreso";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(209, 71);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(267, 24);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(209, 189);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(267, 24);
            this.txtCargo.TabIndex = 7;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(209, 229);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(267, 24);
            this.txtSalario.TabIndex = 8;
            // 
            // txtFI
            // 
            this.txtFI.Location = new System.Drawing.Point(209, 273);
            this.txtFI.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtFI.Name = "txtFI";
            this.txtFI.Size = new System.Drawing.Size(267, 24);
            this.txtFI.TabIndex = 9;
            // 
            // txtAM
            // 
            this.txtAM.Location = new System.Drawing.Point(209, 151);
            this.txtAM.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAM.Name = "txtAM";
            this.txtAM.Size = new System.Drawing.Size(267, 24);
            this.txtAM.TabIndex = 10;
            // 
            // txtAP
            // 
            this.txtAP.Location = new System.Drawing.Point(209, 110);
            this.txtAP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(267, 24);
            this.txtAP.TabIndex = 11;
            this.txtAP.TextChanged += new System.EventHandler(this.txtAP_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Red;
            this.btnAceptar.Location = new System.Drawing.Point(828, 88);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 29);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevo.Location = new System.Drawing.Point(682, 88);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(97, 29);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Beige;
            this.btnBorrar.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Red;
            this.btnBorrar.Location = new System.Drawing.Point(981, 23);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(97, 29);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Location = new System.Drawing.Point(682, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 29);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Location = new System.Drawing.Point(828, 23);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 29);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // CodE
            // 
            this.CodE.AutoSize = true;
            this.CodE.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CodE.Location = new System.Drawing.Point(43, 32);
            this.CodE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodE.Name = "CodE";
            this.CodE.Size = new System.Drawing.Size(158, 22);
            this.CodE.TabIndex = 17;
            this.CodE.Text = "Codigo de Emplado";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(209, 30);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(267, 24);
            this.txtCod.TabIndex = 18;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // mostrarP
            // 
            this.mostrarP.AllowUserToOrderColumns = true;
            this.mostrarP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.mostrarP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarP.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.mostrarP.Location = new System.Drawing.Point(514, 122);
            this.mostrarP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.mostrarP.Name = "mostrarP";
            this.mostrarP.Size = new System.Drawing.Size(574, 185);
            this.mostrarP.TabIndex = 19;
            this.mostrarP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mostrarP_CellContentClick);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1028, 406);
            this.Controls.Add(this.mostrarP);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.CodE);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtAP);
            this.Controls.Add(this.txtAM);
            this.Controls.Add(this.txtFI);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.FI);
            this.Controls.Add(this.Salario);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.ApellidoMaterno);
            this.Controls.Add(this.ApellidoPaterno);
            this.Controls.Add(this.Nombre);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label ApellidoPaterno;
        private System.Windows.Forms.Label ApellidoMaterno;
        private System.Windows.Forms.Label Cargo;
        private System.Windows.Forms.Label Salario;
        private System.Windows.Forms.Label FI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtFI;
        private System.Windows.Forms.TextBox txtAM;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label CodE;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.DataGridView mostrarP;
    }
}

