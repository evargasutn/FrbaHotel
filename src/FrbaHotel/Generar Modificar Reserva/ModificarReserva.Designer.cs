namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class ModificarReserva
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
            this.labelNroReserva = new System.Windows.Forms.Label();
            this.textNroReserva = new System.Windows.Forms.TextBox();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.comboTipoHab = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboTipoRegimen = new System.Windows.Forms.ComboBox();
            this.labelFechaDesde = new System.Windows.Forms.Label();
            this.labelFechaHasta = new System.Windows.Forms.Label();
            this.labelHabitacion = new System.Windows.Forms.Label();
            this.labelPersonas = new System.Windows.Forms.Label();
            this.labelRegimen = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textHuesped = new System.Windows.Forms.TextBox();
            this.labelHuesped = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonDisponibilidad = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNroReserva
            // 
            this.labelNroReserva.AutoSize = true;
            this.labelNroReserva.Location = new System.Drawing.Point(12, 9);
            this.labelNroReserva.Name = "labelNroReserva";
            this.labelNroReserva.Size = new System.Drawing.Size(102, 13);
            this.labelNroReserva.TabIndex = 0;
            this.labelNroReserva.Text = "Número de Reserva";
            // 
            // textNroReserva
            // 
            this.textNroReserva.Location = new System.Drawing.Point(145, 6);
            this.textNroReserva.Name = "textNroReserva";
            this.textNroReserva.ReadOnly = true;
            this.textNroReserva.Size = new System.Drawing.Size(100, 20);
            this.textNroReserva.TabIndex = 1;
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInicio.Location = new System.Drawing.Point(139, 28);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(100, 20);
            this.dateTimeInicio.TabIndex = 3;
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFin.Location = new System.Drawing.Point(139, 54);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(100, 20);
            this.dateTimeFin.TabIndex = 4;
            // 
            // comboTipoHab
            // 
            this.comboTipoHab.FormattingEnabled = true;
            this.comboTipoHab.Location = new System.Drawing.Point(139, 80);
            this.comboTipoHab.Name = "comboTipoHab";
            this.comboTipoHab.Size = new System.Drawing.Size(100, 21);
            this.comboTipoHab.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(172, 104);
            this.maskedTextBox1.Mask = "99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // comboTipoRegimen
            // 
            this.comboTipoRegimen.FormattingEnabled = true;
            this.comboTipoRegimen.Location = new System.Drawing.Point(139, 130);
            this.comboTipoRegimen.Name = "comboTipoRegimen";
            this.comboTipoRegimen.Size = new System.Drawing.Size(100, 21);
            this.comboTipoRegimen.TabIndex = 7;
            // 
            // labelFechaDesde
            // 
            this.labelFechaDesde.AutoSize = true;
            this.labelFechaDesde.Location = new System.Drawing.Point(6, 28);
            this.labelFechaDesde.Name = "labelFechaDesde";
            this.labelFechaDesde.Size = new System.Drawing.Size(80, 13);
            this.labelFechaDesde.TabIndex = 8;
            this.labelFechaDesde.Text = "Fecha de Inicio";
            // 
            // labelFechaHasta
            // 
            this.labelFechaHasta.AutoSize = true;
            this.labelFechaHasta.Location = new System.Drawing.Point(6, 54);
            this.labelFechaHasta.Name = "labelFechaHasta";
            this.labelFechaHasta.Size = new System.Drawing.Size(69, 13);
            this.labelFechaHasta.TabIndex = 9;
            this.labelFechaHasta.Text = "Fecha de Fin";
            // 
            // labelHabitacion
            // 
            this.labelHabitacion.AutoSize = true;
            this.labelHabitacion.Location = new System.Drawing.Point(6, 80);
            this.labelHabitacion.Name = "labelHabitacion";
            this.labelHabitacion.Size = new System.Drawing.Size(97, 13);
            this.labelHabitacion.TabIndex = 10;
            this.labelHabitacion.Text = "Tipo de Habitación";
            // 
            // labelPersonas
            // 
            this.labelPersonas.AutoSize = true;
            this.labelPersonas.Location = new System.Drawing.Point(6, 107);
            this.labelPersonas.Name = "labelPersonas";
            this.labelPersonas.Size = new System.Drawing.Size(160, 13);
            this.labelPersonas.TabIndex = 11;
            this.labelPersonas.Text = "Cantidad Máxima de Huéspedes";
            // 
            // labelRegimen
            // 
            this.labelRegimen.AutoSize = true;
            this.labelRegimen.Location = new System.Drawing.Point(6, 133);
            this.labelRegimen.Name = "labelRegimen";
            this.labelRegimen.Size = new System.Drawing.Size(88, 13);
            this.labelRegimen.TabIndex = 12;
            this.labelRegimen.Text = "Tipo de Régimen";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(6, 163);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(103, 13);
            this.labelPrecio.TabIndex = 13;
            this.labelPrecio.Text = "Costo de la Reserva";
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(139, 160);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.ReadOnly = true;
            this.textPrecio.Size = new System.Drawing.Size(100, 20);
            this.textPrecio.TabIndex = 14;
            // 
            // textHuesped
            // 
            this.textHuesped.Location = new System.Drawing.Point(145, 32);
            this.textHuesped.Name = "textHuesped";
            this.textHuesped.ReadOnly = true;
            this.textHuesped.Size = new System.Drawing.Size(100, 20);
            this.textHuesped.TabIndex = 15;
            // 
            // labelHuesped
            // 
            this.labelHuesped.AutoSize = true;
            this.labelHuesped.Location = new System.Drawing.Point(12, 35);
            this.labelHuesped.Name = "labelHuesped";
            this.labelHuesped.Size = new System.Drawing.Size(111, 13);
            this.labelHuesped.TabIndex = 16;
            this.labelHuesped.Text = "Reserva a Nombre de";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonDisponibilidad);
            this.groupBox1.Controls.Add(this.textPrecio);
            this.groupBox1.Controls.Add(this.labelPrecio);
            this.groupBox1.Controls.Add(this.labelRegimen);
            this.groupBox1.Controls.Add(this.labelPersonas);
            this.groupBox1.Controls.Add(this.labelHabitacion);
            this.groupBox1.Controls.Add(this.labelFechaHasta);
            this.groupBox1.Controls.Add(this.labelFechaDesde);
            this.groupBox1.Controls.Add(this.comboTipoRegimen);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.comboTipoHab);
            this.groupBox1.Controls.Add(this.dateTimeFin);
            this.groupBox1.Controls.Add(this.dateTimeInicio);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 221);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Reserva";
            // 
            // botonDisponibilidad
            // 
            this.botonDisponibilidad.Location = new System.Drawing.Point(73, 186);
            this.botonDisponibilidad.Name = "botonDisponibilidad";
            this.botonDisponibilidad.Size = new System.Drawing.Size(166, 23);
            this.botonDisponibilidad.TabIndex = 15;
            this.botonDisponibilidad.Text = "Chequear Disponibilidad";
            this.botonDisponibilidad.UseVisualStyleBackColor = true;
            this.botonDisponibilidad.Click += new System.EventHandler(this.botonDisponibilidad_Click);
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(145, 285);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(122, 31);
            this.botonModificar.TabIndex = 18;
            this.botonModificar.Text = "Modificar Reserva";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(12, 285);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(109, 31);
            this.botonLimpiar.TabIndex = 19;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // ModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 328);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelHuesped);
            this.Controls.Add(this.textHuesped);
            this.Controls.Add(this.textNroReserva);
            this.Controls.Add(this.labelNroReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModificarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Reserva";
            this.Load += new System.EventHandler(this.ModificarReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNroReserva;
        private System.Windows.Forms.TextBox textNroReserva;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.ComboBox comboTipoHab;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboTipoRegimen;
        private System.Windows.Forms.Label labelFechaDesde;
        private System.Windows.Forms.Label labelFechaHasta;
        private System.Windows.Forms.Label labelHabitacion;
        private System.Windows.Forms.Label labelPersonas;
        private System.Windows.Forms.Label labelRegimen;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textHuesped;
        private System.Windows.Forms.Label labelHuesped;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonDisponibilidad;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonLimpiar;
    }
}