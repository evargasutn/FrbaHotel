namespace FrbaHotel.Registrar_Estadia
{
    partial class EstadiasMain
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
            this.components = new System.ComponentModel.Container();
            this.textEstadia = new System.Windows.Forms.MaskedTextBox();
            this.labelReserva = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.botonCheckIn = new System.Windows.Forms.Button();
            this.botonCheckOut = new System.Windows.Forms.Button();
            this.labelHuesped = new System.Windows.Forms.Label();
            this.textHuesped = new System.Windows.Forms.TextBox();
            this.textFecInicio = new System.Windows.Forms.MaskedTextBox();
            this.textFecFin = new System.Windows.Forms.MaskedTextBox();
            this.labelFecInicio = new System.Windows.Forms.Label();
            this.labelFecFin = new System.Windows.Forms.Label();
            this.labelFec = new System.Windows.Forms.Label();
            this.textFecReserva = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEstadia
            // 
            this.textEstadia.Location = new System.Drawing.Point(137, 32);
            this.textEstadia.Mask = "99999999";
            this.textEstadia.Name = "textEstadia";
            this.textEstadia.Size = new System.Drawing.Size(50, 20);
            this.textEstadia.TabIndex = 0;
            this.textEstadia.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textEstadia_MaskInputRejected);
            // 
            // labelReserva
            // 
            this.labelReserva.AutoSize = true;
            this.labelReserva.Location = new System.Drawing.Point(19, 35);
            this.labelReserva.Name = "labelReserva";
            this.labelReserva.Size = new System.Drawing.Size(102, 13);
            this.labelReserva.TabIndex = 1;
            this.labelReserva.Text = "Número de Reserva";
            // 
            // botonCheckIn
            // 
            this.botonCheckIn.Location = new System.Drawing.Point(12, 201);
            this.botonCheckIn.Name = "botonCheckIn";
            this.botonCheckIn.Size = new System.Drawing.Size(266, 29);
            this.botonCheckIn.TabIndex = 2;
            this.botonCheckIn.Text = "Check In";
            this.botonCheckIn.UseVisualStyleBackColor = true;
            this.botonCheckIn.Click += new System.EventHandler(this.botonCheckIn_Click);
            // 
            // botonCheckOut
            // 
            this.botonCheckOut.Location = new System.Drawing.Point(12, 236);
            this.botonCheckOut.Name = "botonCheckOut";
            this.botonCheckOut.Size = new System.Drawing.Size(266, 29);
            this.botonCheckOut.TabIndex = 3;
            this.botonCheckOut.Text = "Check Out";
            this.botonCheckOut.UseVisualStyleBackColor = true;
            this.botonCheckOut.Click += new System.EventHandler(this.botonCheckOut_Click);
            // 
            // labelHuesped
            // 
            this.labelHuesped.AutoSize = true;
            this.labelHuesped.Location = new System.Drawing.Point(7, 26);
            this.labelHuesped.Name = "labelHuesped";
            this.labelHuesped.Size = new System.Drawing.Size(112, 13);
            this.labelHuesped.TabIndex = 4;
            this.labelHuesped.Text = "Reserva a nombre de:";
            // 
            // textHuesped
            // 
            this.textHuesped.Location = new System.Drawing.Point(125, 23);
            this.textHuesped.Name = "textHuesped";
            this.textHuesped.ReadOnly = true;
            this.textHuesped.Size = new System.Drawing.Size(124, 20);
            this.textHuesped.TabIndex = 5;
            // 
            // textFecInicio
            // 
            this.textFecInicio.Location = new System.Drawing.Point(125, 49);
            this.textFecInicio.Mask = "00/00/0000";
            this.textFecInicio.Name = "textFecInicio";
            this.textFecInicio.ReadOnly = true;
            this.textFecInicio.Size = new System.Drawing.Size(124, 20);
            this.textFecInicio.TabIndex = 6;
            this.textFecInicio.ValidatingType = typeof(System.DateTime);
            // 
            // textFecFin
            // 
            this.textFecFin.Location = new System.Drawing.Point(125, 75);
            this.textFecFin.Mask = "00/00/0000";
            this.textFecFin.Name = "textFecFin";
            this.textFecFin.ReadOnly = true;
            this.textFecFin.Size = new System.Drawing.Size(124, 20);
            this.textFecFin.TabIndex = 7;
            this.textFecFin.ValidatingType = typeof(System.DateTime);
            // 
            // labelFecInicio
            // 
            this.labelFecInicio.AutoSize = true;
            this.labelFecInicio.Location = new System.Drawing.Point(81, 52);
            this.labelFecInicio.Name = "labelFecInicio";
            this.labelFecInicio.Size = new System.Drawing.Size(38, 13);
            this.labelFecInicio.TabIndex = 8;
            this.labelFecInicio.Text = "Desde";
            // 
            // labelFecFin
            // 
            this.labelFecFin.AutoSize = true;
            this.labelFecFin.Location = new System.Drawing.Point(84, 78);
            this.labelFecFin.Name = "labelFecFin";
            this.labelFecFin.Size = new System.Drawing.Size(35, 13);
            this.labelFecFin.TabIndex = 9;
            this.labelFecFin.Text = "Hasta";
            // 
            // labelFec
            // 
            this.labelFec.AutoSize = true;
            this.labelFec.Location = new System.Drawing.Point(24, 101);
            this.labelFec.Name = "labelFec";
            this.labelFec.Size = new System.Drawing.Size(95, 13);
            this.labelFec.TabIndex = 11;
            this.labelFec.Text = "Fecha de Reserva";
            // 
            // textFecReserva
            // 
            this.textFecReserva.Location = new System.Drawing.Point(125, 101);
            this.textFecReserva.Mask = "00/00/0000";
            this.textFecReserva.Name = "textFecReserva";
            this.textFecReserva.ReadOnly = true;
            this.textFecReserva.Size = new System.Drawing.Size(124, 20);
            this.textFecReserva.TabIndex = 10;
            this.textFecReserva.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelHuesped);
            this.groupBox1.Controls.Add(this.labelFecFin);
            this.groupBox1.Controls.Add(this.labelFec);
            this.groupBox1.Controls.Add(this.labelFecInicio);
            this.groupBox1.Controls.Add(this.textHuesped);
            this.groupBox1.Controls.Add(this.textFecReserva);
            this.groupBox1.Controls.Add(this.textFecInicio);
            this.groupBox1.Controls.Add(this.textFecFin);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 137);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Reserva";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(203, 29);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 13;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // EstadiasMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 292);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonCheckOut);
            this.Controls.Add(this.botonCheckIn);
            this.Controls.Add(this.labelReserva);
            this.Controls.Add(this.textEstadia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EstadiasMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Estadías";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textEstadia;
        private System.Windows.Forms.Label labelReserva;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button botonCheckIn;
        private System.Windows.Forms.Button botonCheckOut;
        private System.Windows.Forms.Label labelHuesped;
        private System.Windows.Forms.TextBox textHuesped;
        private System.Windows.Forms.MaskedTextBox textFecInicio;
        private System.Windows.Forms.MaskedTextBox textFecFin;
        private System.Windows.Forms.Label labelFecInicio;
        private System.Windows.Forms.Label labelFecFin;
        private System.Windows.Forms.Label labelFec;
        private System.Windows.Forms.MaskedTextBox textFecReserva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonBuscar;
    }
}