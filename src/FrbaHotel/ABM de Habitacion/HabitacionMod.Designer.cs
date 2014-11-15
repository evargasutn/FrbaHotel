namespace FrbaHotel.ABM_de_Habitacion
{
    partial class HabitacionMod
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
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.comboUbicacion = new System.Windows.Forms.ComboBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.textPiso = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(12, 189);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(106, 27);
            this.botonLimpiar.TabIndex = 35;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(199, 189);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(106, 27);
            this.botonGuardar.TabIndex = 34;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboEstado);
            this.groupBox2.Controls.Add(this.comboUbicacion);
            this.groupBox2.Controls.Add(this.textDescripcion);
            this.groupBox2.Controls.Add(this.lblDescripcion);
            this.groupBox2.Controls.Add(this.textPiso);
            this.groupBox2.Controls.Add(this.textNumero);
            this.groupBox2.Controls.Add(this.lblEstado);
            this.groupBox2.Controls.Add(this.lblUbicacion);
            this.groupBox2.Controls.Add(this.lblPiso);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 171);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos identificatorios";
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(138, 104);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(141, 21);
            this.comboEstado.TabIndex = 39;
            // 
            // comboUbicacion
            // 
            this.comboUbicacion.FormattingEnabled = true;
            this.comboUbicacion.Location = new System.Drawing.Point(138, 77);
            this.comboUbicacion.Name = "comboUbicacion";
            this.comboUbicacion.Size = new System.Drawing.Size(141, 21);
            this.comboUbicacion.TabIndex = 38;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(138, 131);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(141, 20);
            this.textDescripcion.TabIndex = 28;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 134);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 27;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // textPiso
            // 
            this.textPiso.Location = new System.Drawing.Point(138, 51);
            this.textPiso.Name = "textPiso";
            this.textPiso.Size = new System.Drawing.Size(141, 20);
            this.textPiso.TabIndex = 17;
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(138, 26);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(141, 20);
            this.textNumero.TabIndex = 14;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(6, 107);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(6, 80);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(55, 13);
            this.lblUbicacion.TabIndex = 8;
            this.lblUbicacion.Text = "Ubicación";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(6, 54);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(72, 13);
            this.lblPiso.TabIndex = 7;
            this.lblPiso.Text = "Piso del Hotel";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 29);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(113, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número de Habitacion";
            // 
            // HabitacionMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 230);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.groupBox2);
            this.Name = "HabitacionMod";
            this.Text = "Modificar Habitacion";
            this.Load += new System.EventHandler(this.HabitacionMod_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboUbicacion;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox textPiso;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}