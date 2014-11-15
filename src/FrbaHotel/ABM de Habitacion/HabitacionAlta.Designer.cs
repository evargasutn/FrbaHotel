namespace FrbaHotel.ABM_de_Habitacion
{
    partial class HabitacionAlta
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
            this.comboTipoHab = new System.Windows.Forms.ComboBox();
            this.comboUbicacion = new System.Windows.Forms.ComboBox();
            this.nota = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.textPiso = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.lblTipoHab = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(12, 218);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(106, 27);
            this.botonLimpiar.TabIndex = 32;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(197, 218);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(106, 27);
            this.botonGuardar.TabIndex = 31;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboTipoHab);
            this.groupBox2.Controls.Add(this.comboUbicacion);
            this.groupBox2.Controls.Add(this.nota);
            this.groupBox2.Controls.Add(this.textDescripcion);
            this.groupBox2.Controls.Add(this.lblDescripcion);
            this.groupBox2.Controls.Add(this.textPiso);
            this.groupBox2.Controls.Add(this.textNumero);
            this.groupBox2.Controls.Add(this.lblTipoHab);
            this.groupBox2.Controls.Add(this.lblUbicacion);
            this.groupBox2.Controls.Add(this.lblPiso);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 200);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos identificatorios";
            // 
            // comboTipoHab
            // 
            this.comboTipoHab.FormattingEnabled = true;
            this.comboTipoHab.Location = new System.Drawing.Point(138, 104);
            this.comboTipoHab.Name = "comboTipoHab";
            this.comboTipoHab.Size = new System.Drawing.Size(141, 21);
            this.comboTipoHab.TabIndex = 39;
            // 
            // comboUbicacion
            // 
            this.comboUbicacion.FormattingEnabled = true;
            this.comboUbicacion.Location = new System.Drawing.Point(138, 77);
            this.comboUbicacion.Name = "comboUbicacion";
            this.comboUbicacion.Size = new System.Drawing.Size(141, 21);
            this.comboUbicacion.TabIndex = 38;
            // 
            // nota
            // 
            this.nota.AutoSize = true;
            this.nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota.Location = new System.Drawing.Point(6, 169);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(127, 13);
            this.nota.TabIndex = 33;
            this.nota.Text = "*Campos Obligatorios";
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
            this.lblDescripcion.Size = new System.Drawing.Size(67, 13);
            this.lblDescripcion.TabIndex = 27;
            this.lblDescripcion.Text = "Descripcion*";
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
            // lblTipoHab
            // 
            this.lblTipoHab.AutoSize = true;
            this.lblTipoHab.Location = new System.Drawing.Point(6, 107);
            this.lblTipoHab.Name = "lblTipoHab";
            this.lblTipoHab.Size = new System.Drawing.Size(101, 13);
            this.lblTipoHab.TabIndex = 9;
            this.lblTipoHab.Text = "Tipo de Habitacion*";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(6, 80);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(59, 13);
            this.lblUbicacion.TabIndex = 8;
            this.lblUbicacion.Text = "Ubicación*";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(6, 54);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(76, 13);
            this.lblPiso.TabIndex = 7;
            this.lblPiso.Text = "Piso del Hotel*";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 29);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(117, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número de Habitacion*";
            // 
            // HabitacionAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 259);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.groupBox2);
            this.Name = "HabitacionAlta";
            this.Text = "Alta de Habitacion";
            this.Load += new System.EventHandler(this.HabitacionAlta_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboUbicacion;
        private System.Windows.Forms.Label nota;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox textPiso;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label lblTipoHab;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox comboTipoHab;
    }
}