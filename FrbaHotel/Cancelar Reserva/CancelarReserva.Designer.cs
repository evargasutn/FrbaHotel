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
            this.textMotivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNroReserva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeCancelacion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.buttonBuscarNroReserva = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonCancelarReserva = new System.Windows.Forms.Button();
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
            // textMotivo
            // 
            this.textMotivo.Location = new System.Drawing.Point(147, 58);
            this.textMotivo.Name = "textMotivo";
            this.textMotivo.Size = new System.Drawing.Size(111, 20);
            this.textMotivo.TabIndex = 1;
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
            // textNroReserva
            // 
            this.textNroReserva.Location = new System.Drawing.Point(147, 20);
            this.textNroReserva.Name = "textNroReserva";
            this.textNroReserva.ReadOnly = true;
            this.textNroReserva.Size = new System.Drawing.Size(111, 20);
            this.textNroReserva.TabIndex = 3;
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
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(147, 136);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.ReadOnly = true;
            this.textUsuario.Size = new System.Drawing.Size(111, 20);
            this.textUsuario.TabIndex = 7;
            // 
            // buttonBuscarNroReserva
            // 
            this.buttonBuscarNroReserva.Location = new System.Drawing.Point(264, 20);
            this.buttonBuscarNroReserva.Name = "buttonBuscarNroReserva";
            this.buttonBuscarNroReserva.Size = new System.Drawing.Size(73, 19);
            this.buttonBuscarNroReserva.TabIndex = 8;
            this.buttonBuscarNroReserva.Text = "Buscar";
            this.buttonBuscarNroReserva.UseVisualStyleBackColor = true;
            this.buttonBuscarNroReserva.Click += new System.EventHandler(this.buttonBuscarNroReserva_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBuscarNroReserva);
            this.groupBox1.Controls.Add(this.textUsuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimeCancelacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textNroReserva);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textMotivo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 183);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos  para cancelacion";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(26, 212);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(125, 31);
            this.botonLimpiar.TabIndex = 10;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonCancelarReserva
            // 
            this.botonCancelarReserva.Location = new System.Drawing.Point(253, 212);
            this.botonCancelarReserva.Name = "botonCancelarReserva";
            this.botonCancelarReserva.Size = new System.Drawing.Size(121, 31);
            this.botonCancelarReserva.TabIndex = 11;
            this.botonCancelarReserva.Text = "Cancelar reserva";
            this.botonCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // CancelarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 252);
            this.Controls.Add(this.botonCancelarReserva);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "CancelarReserva";
            this.Text = "Cancelacion de reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMotivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNroReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeCancelacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Button buttonBuscarNroReserva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonCancelarReserva;
    }
}