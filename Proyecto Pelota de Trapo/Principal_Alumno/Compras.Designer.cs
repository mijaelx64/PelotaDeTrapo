namespace principal
{
    partial class Compras
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgmostar = new System.Windows.Forms.DataGridView();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblPro = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtPro = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.txtNoM = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtPTO = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblCan = new System.Windows.Forms.Label();
            this.lblpre = new System.Windows.Forms.Label();
            this.lbltota = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnMa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgmostar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(496, 133);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(379, 133);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(496, 88);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(496, 45);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(379, 45);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(379, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgmostar
            // 
            this.dgmostar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmostar.Location = new System.Drawing.Point(12, 208);
            this.dgmostar.Name = "dgmostar";
            this.dgmostar.Size = new System.Drawing.Size(559, 174);
            this.dgmostar.TabIndex = 6;
            this.dgmostar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmostar_CellContentClick);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(42, 45);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 7;
            this.lblCod.Text = "Codigo";
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.Location = new System.Drawing.Point(42, 77);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(56, 13);
            this.lblPro.TabIndex = 8;
            this.lblPro.Text = "Proveedor";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(42, 110);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha";
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(107, 103);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 10;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(376, 395);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(61, 13);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "PrecioTotal";
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCod.Location = new System.Drawing.Point(107, 45);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(200, 20);
            this.txtCod.TabIndex = 12;
            // 
            // txtPro
            // 
            this.txtPro.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPro.Location = new System.Drawing.Point(107, 70);
            this.txtPro.Name = "txtPro";
            this.txtPro.Size = new System.Drawing.Size(200, 20);
            this.txtPro.TabIndex = 13;
            this.txtPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPro_KeyPress);
            // 
            // txtPre
            // 
            this.txtPre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPre.Location = new System.Drawing.Point(460, 388);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(111, 20);
            this.txtPre.TabIndex = 14;
            // 
            // txtNoM
            // 
            this.txtNoM.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNoM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoM.Location = new System.Drawing.Point(12, 182);
            this.txtNoM.Name = "txtNoM";
            this.txtNoM.Size = new System.Drawing.Size(100, 20);
            this.txtNoM.TabIndex = 15;
            this.txtNoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoM_KeyPress);
           
            // 
            // txtCant
            // 
            this.txtCant.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCant.Location = new System.Drawing.Point(157, 182);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 16;
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            // 
            // txtP
            // 
            this.txtP.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtP.Location = new System.Drawing.Point(286, 182);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 20);
            this.txtP.TabIndex = 17;
            this.txtP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtP_KeyPress);
            // 
            // txtPTO
            // 
            this.txtPTO.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTO.Location = new System.Drawing.Point(418, 182);
            this.txtPTO.Name = "txtPTO";
            this.txtPTO.Size = new System.Drawing.Size(100, 20);
            this.txtPTO.TabIndex = 18;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(534, 179);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 19;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(13, 163);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(99, 13);
            this.lblnom.TabIndex = 20;
            this.lblnom.Text = "Nombre de Material";
            // 
            // lblCan
            // 
            this.lblCan.AutoSize = true;
            this.lblCan.Location = new System.Drawing.Point(154, 163);
            this.lblCan.Name = "lblCan";
            this.lblCan.Size = new System.Drawing.Size(49, 13);
            this.lblCan.TabIndex = 21;
            this.lblCan.Text = "Cantidad";
            // 
            // lblpre
            // 
            this.lblpre.AutoSize = true;
            this.lblpre.Location = new System.Drawing.Point(292, 163);
            this.lblpre.Name = "lblpre";
            this.lblpre.Size = new System.Drawing.Size(37, 13);
            this.lblpre.TabIndex = 22;
            this.lblpre.Text = "Precio";
            // 
            // lbltota
            // 
            this.lbltota.AutoSize = true;
            this.lbltota.Location = new System.Drawing.Point(418, 163);
            this.lbltota.Name = "lbltota";
            this.lbltota.Size = new System.Drawing.Size(64, 13);
            this.lbltota.TabIndex = 23;
            this.lbltota.Text = "Precio Total";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(577, 45);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnMa
            // 
            this.btnMa.Location = new System.Drawing.Point(577, 88);
            this.btnMa.Name = "btnMa";
            this.btnMa.Size = new System.Drawing.Size(98, 23);
            this.btnMa.TabIndex = 25;
            this.btnMa.Text = "Nuevo Material";
            this.btnMa.UseVisualStyleBackColor = true;
            this.btnMa.Click += new System.EventHandler(this.btnMa_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(798, 433);
            this.Controls.Add(this.btnMa);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbltota);
            this.Controls.Add(this.lblpre);
            this.Controls.Add(this.lblCan);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtPTO);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtNoM);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.txtPro);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblPro);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.dgmostar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnSalir);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgmostar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgmostar;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtPro;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.TextBox txtNoM;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtPTO;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblCan;
        private System.Windows.Forms.Label lblpre;
        private System.Windows.Forms.Label lbltota;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnMa;
    }
}