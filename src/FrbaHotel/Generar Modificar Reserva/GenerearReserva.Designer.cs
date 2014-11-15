namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class GenerearReserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCantHuespedes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxTipoRegimen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonDisponibilidad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de reserva*";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeFechaSalida);
            this.groupBox1.Controls.Add(this.dateTimeFechaEntrada);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(36, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fechas de permanencia";
            // 
            // dateTimeFechaSalida
            // 
            this.dateTimeFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaSalida.Location = new System.Drawing.Point(123, 75);
            this.dateTimeFechaSalida.Name = "dateTimeFechaSalida";
            this.dateTimeFechaSalida.Size = new System.Drawing.Size(107, 20);
            this.dateTimeFechaSalida.TabIndex = 3;
            // 
            // dateTimeFechaEntrada
            // 
            this.dateTimeFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaEntrada.Location = new System.Drawing.Point(123, 39);
            this.dateTimeFechaEntrada.Name = "dateTimeFechaEntrada";
            this.dateTimeFechaEntrada.Size = new System.Drawing.Size(107, 20);
            this.dateTimeFechaEntrada.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha de salida*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de entrada*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de huéspedes*";
            // 
            // comboBoxCantHuespedes
            // 
            this.comboBoxCantHuespedes.FormattingEnabled = true;
            this.comboBoxCantHuespedes.Location = new System.Drawing.Point(159, 197);
            this.comboBoxCantHuespedes.Name = "comboBoxCantHuespedes";
            this.comboBoxCantHuespedes.Size = new System.Drawing.Size(107, 21);
            this.comboBoxCantHuespedes.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxTipoRegimen);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBoxCantHuespedes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(21, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 273);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos para reserva";
            // 
            // comboBoxTipoRegimen
            // 
            this.comboBoxTipoRegimen.FormattingEnabled = true;
            this.comboBoxTipoRegimen.Location = new System.Drawing.Point(159, 226);
            this.comboBoxTipoRegimen.Name = "comboBoxTipoRegimen";
            this.comboBoxTipoRegimen.Size = new System.Drawing.Size(107, 21);
            this.comboBoxTipoRegimen.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo de régimen";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(21, 300);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(120, 34);
            this.buttonLimpiar.TabIndex = 7;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonDisponibilidad
            // 
            this.buttonDisponibilidad.Location = new System.Drawing.Point(237, 300);
            this.buttonDisponibilidad.Name = "buttonDisponibilidad";
            this.buttonDisponibilidad.Size = new System.Drawing.Size(123, 34);
            this.buttonDisponibilidad.TabIndex = 8;
            this.buttonDisponibilidad.Text = "Buscar Disponibilidad";
            this.buttonDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // GenerearReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 353);
            this.Controls.Add(this.buttonDisponibilidad);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Name = "GenerearReserva";
            this.Text = "Generar reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeFechaSalida;
        private System.Windows.Forms.DateTimePicker dateTimeFechaEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCantHuespedes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxTipoRegimen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonDisponibilidad;

    }
}