namespace FrbaHotel.ABM_de_Hotel
{
    partial class NuevaInhabilitacion
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
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.textMotivo = new System.Windows.Forms.TextBox();
            this.labelInicio = new System.Windows.Forms.Label();
            this.labelFin = new System.Windows.Forms.Label();
            this.labelMotivo = new System.Windows.Forms.Label();
            this.labelHotel = new System.Windows.Forms.Label();
            this.textHotel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(12, 213);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 0;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(176, 213);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 1;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInicio.Location = new System.Drawing.Point(147, 39);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(104, 20);
            this.dateTimeInicio.TabIndex = 2;
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFin.Location = new System.Drawing.Point(147, 67);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(104, 20);
            this.dateTimeFin.TabIndex = 3;
            // 
            // textMotivo
            // 
            this.textMotivo.Location = new System.Drawing.Point(12, 111);
            this.textMotivo.Multiline = true;
            this.textMotivo.Name = "textMotivo";
            this.textMotivo.Size = new System.Drawing.Size(239, 96);
            this.textMotivo.TabIndex = 4;
            // 
            // labelInicio
            // 
            this.labelInicio.Location = new System.Drawing.Point(9, 41);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(109, 20);
            this.labelInicio.TabIndex = 5;
            this.labelInicio.Text = "Fecha de Inicio";
            this.labelInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFin
            // 
            this.labelFin.Location = new System.Drawing.Point(9, 67);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(109, 20);
            this.labelFin.TabIndex = 6;
            this.labelFin.Text = "Fecha de Fin";
            this.labelFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMotivo
            // 
            this.labelMotivo.Location = new System.Drawing.Point(12, 90);
            this.labelMotivo.Name = "labelMotivo";
            this.labelMotivo.Size = new System.Drawing.Size(239, 18);
            this.labelMotivo.TabIndex = 7;
            this.labelMotivo.Text = "Motivo";
            this.labelMotivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHotel
            // 
            this.labelHotel.Location = new System.Drawing.Point(9, 13);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(100, 20);
            this.labelHotel.TabIndex = 8;
            this.labelHotel.Text = "Código de Hotel";
            this.labelHotel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textHotel
            // 
            this.textHotel.Location = new System.Drawing.Point(147, 13);
            this.textHotel.Name = "textHotel";
            this.textHotel.ReadOnly = true;
            this.textHotel.Size = new System.Drawing.Size(104, 20);
            this.textHotel.TabIndex = 9;
            // 
            // NuevaInhabilitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 248);
            this.Controls.Add(this.textHotel);
            this.Controls.Add(this.labelHotel);
            this.Controls.Add(this.labelMotivo);
            this.Controls.Add(this.labelFin);
            this.Controls.Add(this.labelInicio);
            this.Controls.Add(this.textMotivo);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.dateTimeInicio);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NuevaInhabilitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Inhabilitación";
            this.Load += new System.EventHandler(this.NuevaInhabilitacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.TextBox textMotivo;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.Label labelFin;
        private System.Windows.Forms.Label labelMotivo;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.TextBox textHotel;
    }
}