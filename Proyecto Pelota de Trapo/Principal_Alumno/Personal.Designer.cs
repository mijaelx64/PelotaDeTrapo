namespace principal
{
    partial class Personal
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
            this.mostrarP = new System.Windows.Forms.DataGridView();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.CodE = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.txtAM = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.FI = new System.Windows.Forms.Label();
            this.Salario = new System.Windows.Forms.Label();
            this.Cargo = new System.Windows.Forms.Label();
            this.ApellidoMaterno = new System.Windows.Forms.Label();
            this.ApellidoPaterno = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btngu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarP)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrarP
            // 
            this.mostrarP.AllowUserToOrderColumns = true;
            this.mostrarP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.mostrarP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarP.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.mostrarP.Location = new System.Drawing.Point(445, 186);
            this.mostrarP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.mostrarP.Name = "mostrarP";
            this.mostrarP.Size = new System.Drawing.Size(523, 185);
            this.mostrarP.TabIndex = 39;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(225, 92);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(200, 20);
            this.txtCod.TabIndex = 38;
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_KeyPress);
            // 
            // CodE
            // 
            this.CodE.AutoSize = true;
            this.CodE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CodE.Location = new System.Drawing.Point(50, 92);
            this.CodE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodE.Name = "CodE";
            this.CodE.Size = new System.Drawing.Size(148, 20);
            this.CodE.TabIndex = 37;
            this.CodE.Text = "Codigo de Emplado";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(582, 86);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 29);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(445, 88);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 29);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorrar.Location = new System.Drawing.Point(715, 86);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(97, 29);
            this.btnBorrar.TabIndex = 34;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.Location = new System.Drawing.Point(445, 153);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(97, 29);
            this.btnNuevo.TabIndex = 33;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAceptar.Location = new System.Drawing.Point(582, 153);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 29);
            this.btnAceptar.TabIndex = 32;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtAP
            // 
            this.txtAP.Location = new System.Drawing.Point(225, 172);
            this.txtAP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(200, 20);
            this.txtAP.TabIndex = 31;
            this.txtAP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAP_KeyPress);
            // 
            // txtAM
            // 
            this.txtAM.Location = new System.Drawing.Point(225, 213);
            this.txtAM.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAM.Name = "txtAM";
            this.txtAM.Size = new System.Drawing.Size(200, 20);
            this.txtAM.TabIndex = 30;
            this.txtAM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAM_KeyPress);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(225, 291);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(200, 20);
            this.txtSalario.TabIndex = 28;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(225, 251);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(200, 20);
            this.txtCargo.TabIndex = 27;
            this.txtCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCargo_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(225, 133);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // FI
            // 
            this.FI.AutoSize = true;
            this.FI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FI.Location = new System.Drawing.Point(50, 335);
            this.FI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FI.Name = "FI";
            this.FI.Size = new System.Drawing.Size(134, 20);
            this.FI.TabIndex = 25;
            this.FI.Text = "Fecha de Ingreso";
            // 
            // Salario
            // 
            this.Salario.AutoSize = true;
            this.Salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Salario.Location = new System.Drawing.Point(50, 291);
            this.Salario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(58, 20);
            this.Salario.TabIndex = 24;
            this.Salario.Text = "Salario";
            // 
            // Cargo
            // 
            this.Cargo.AutoSize = true;
            this.Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cargo.Location = new System.Drawing.Point(50, 249);
            this.Cargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(52, 20);
            this.Cargo.TabIndex = 23;
            this.Cargo.Text = "Cargo";
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.AutoSize = true;
            this.ApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoMaterno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ApellidoMaterno.Location = new System.Drawing.Point(50, 213);
            this.ApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.Size = new System.Drawing.Size(128, 20);
            this.ApellidoMaterno.TabIndex = 22;
            this.ApellidoMaterno.Text = "Apellido Materno";
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.AutoSize = true;
            this.ApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoPaterno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ApellidoPaterno.Location = new System.Drawing.Point(50, 172);
            this.ApellidoPaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.Size = new System.Drawing.Size(125, 20);
            this.ApellidoPaterno.TabIndex = 21;
            this.ApellidoPaterno.Text = "Apellido Paterno";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nombre.Location = new System.Drawing.Point(50, 131);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(65, 20);
            this.Nombre.TabIndex = 20;
            this.Nombre.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(544, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 40;
            this.button1.Text = "salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 337);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 41;
            // 
            // btngu
            // 
            this.btngu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngu.Location = new System.Drawing.Point(445, 125);
            this.btngu.Name = "btngu";
            this.btngu.Size = new System.Drawing.Size(97, 28);
            this.btngu.TabIndex = 42;
            this.btngu.Text = "Guardar";
            this.btngu.UseVisualStyleBackColor = true;
            this.btngu.Click += new System.EventHandler(this.btngu_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 461);
            this.Controls.Add(this.btngu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.FI);
            this.Controls.Add(this.Salario);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.ApellidoMaterno);
            this.Controls.Add(this.ApellidoPaterno);
            this.Controls.Add(this.Nombre);
            this.Name = "Personal";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mostrarP;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label CodE;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.TextBox txtAM;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label FI;
        private System.Windows.Forms.Label Salario;
        private System.Windows.Forms.Label Cargo;
        private System.Windows.Forms.Label ApellidoMaterno;
        private System.Windows.Forms.Label ApellidoPaterno;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btngu;
    }
}