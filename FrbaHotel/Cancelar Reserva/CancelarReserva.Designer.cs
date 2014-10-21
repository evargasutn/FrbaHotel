namespace FrbaHotel.Cancelar_Reserva
{
    partial class CancelarReserva
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.comboBoxNroReserva = new System.Windows.Forms.ComboBox();
            this.dateTimeFechaCancelacion = new System.Windows.Forms.DateTimePicker();
            this.textBoxMotivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLimpiarCampos = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxUsuario);
            this.groupBox1.Controls.Add(this.comboBoxNroReserva);
            this.groupBox1.Controls.Add(this.dateTimeFechaCancelacion);
            this.groupBox1.Controls.Add(this.textBoxMotivo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la reserva";
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(155, 130);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUsuario.TabIndex = 7;
            // 
            // comboBoxNroReserva
            // 
            this.comboBoxNroReserva.FormattingEnabled = true;
            this.comboBoxNroReserva.Location = new System.Drawing.Point(155, 40);
            this.comboBoxNroReserva.Name = "comboBoxNroReserva";
            this.comboBoxNroReserva.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNroReserva.TabIndex = 6;
            // 
            // dateTimeFechaCancelacion
            // 
            this.dateTimeFechaCancelacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaCancelacion.Location = new System.Drawing.Point(155, 99);
            this.dateTimeFechaCancelacion.Name = "dateTimeFechaCancelacion";
            this.dateTimeFechaCancelacion.Size = new System.Drawing.Size(121, 20);
            this.dateTimeFechaCancelacion.TabIndex = 5;
            this.dateTimeFechaCancelacion.Value = new System.DateTime(2014, 10, 20, 0, 0, 0, 0);
            // 
            // textBoxMotivo
            // 
            this.textBoxMotivo.Location = new System.Drawing.Point(155, 70);
            this.textBoxMotivo.Name = "textBoxMotivo";
            this.textBoxMotivo.Size = new System.Drawing.Size(121, 20);
            this.textBoxMotivo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Cancelación*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Motivo*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Reserva*";
            // 
            // buttonLimpiarCampos
            // 
            this.buttonLimpiarCampos.Location = new System.Drawing.Point(47, 238);
            this.buttonLimpiarCampos.Name = "buttonLimpiarCampos";
            this.buttonLimpiarCampos.Size = new System.Drawing.Size(88, 36);
            this.buttonLimpiarCampos.TabIndex = 1;
            this.buttonLimpiarCampos.Text = "Limpiar";
            this.buttonLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(243, 239);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(84, 35);
            this.buttonGuardar.TabIndex = 2;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // CancelarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 307);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonLimpiarCampos);
            this.Controls.Add(this.groupBox1);
            this.Name = "CancelarReserva";
            this.Text = "Cancelar Reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMotivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeFechaCancelacion;
        private System.Windows.Forms.ComboBox comboBoxNroReserva;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.Button buttonLimpiarCampos;
        private System.Windows.Forms.Button buttonGuardar;
    }
}