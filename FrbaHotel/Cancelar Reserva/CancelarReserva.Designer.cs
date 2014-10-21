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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMotivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNroReserva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeCancelacion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.buttonBuscarNroReserva = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonCancelarReserva = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motivo";
            // 
            // textBoxMotivo
            // 
            this.textBoxMotivo.Location = new System.Drawing.Point(147, 58);
            this.textBoxMotivo.Name = "textBoxMotivo";
            this.textBoxMotivo.Size = new System.Drawing.Size(111, 20);
            this.textBoxMotivo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de reserva*";
            // 
            // textBoxNroReserva
            // 
            this.textBoxNroReserva.Location = new System.Drawing.Point(147, 20);
            this.textBoxNroReserva.Name = "textBoxNroReserva";
            this.textBoxNroReserva.ReadOnly = true;
            this.textBoxNroReserva.Size = new System.Drawing.Size(111, 20);
            this.textBoxNroReserva.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de cancelación*";
            // 
            // dateTimeCancelacion
            // 
            this.dateTimeCancelacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCancelacion.Location = new System.Drawing.Point(147, 100);
            this.dateTimeCancelacion.Name = "dateTimeCancelacion";
            this.dateTimeCancelacion.Size = new System.Drawing.Size(116, 20);
            this.dateTimeCancelacion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario*";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(147, 136);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.ReadOnly = true;
            this.textBoxUsuario.Size = new System.Drawing.Size(111, 20);
            this.textBoxUsuario.TabIndex = 7;
            // 
            // buttonBuscarNroReserva
            // 
            this.buttonBuscarNroReserva.Location = new System.Drawing.Point(264, 20);
            this.buttonBuscarNroReserva.Name = "buttonBuscarNroReserva";
            this.buttonBuscarNroReserva.Size = new System.Drawing.Size(73, 19);
            this.buttonBuscarNroReserva.TabIndex = 8;
            this.buttonBuscarNroReserva.Text = "Buscar";
            this.buttonBuscarNroReserva.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBuscarNroReserva);
            this.groupBox1.Controls.Add(this.textBoxUsuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimeCancelacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNroReserva);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxMotivo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 183);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos  para cancelacion";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(26, 212);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(125, 31);
            this.buttonLimpiar.TabIndex = 10;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarReserva
            // 
            this.buttonCancelarReserva.Location = new System.Drawing.Point(253, 212);
            this.buttonCancelarReserva.Name = "buttonCancelarReserva";
            this.buttonCancelarReserva.Size = new System.Drawing.Size(121, 31);
            this.buttonCancelarReserva.TabIndex = 11;
            this.buttonCancelarReserva.Text = "Cancelar reserva";
            this.buttonCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // CancelarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 252);
            this.Controls.Add(this.buttonCancelarReserva);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "CancelarReserva";
            this.Text = "Cancelacion de reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMotivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNroReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeCancelacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Button buttonBuscarNroReserva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCancelarReserva;
    }
}