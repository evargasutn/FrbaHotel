namespace FrbaHotel.ABM_de_Cliente
{
    partial class Presentacion
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
            this.botonAlta = new System.Windows.Forms.Button();
            this.botonBaja = new System.Windows.Forms.Button();
            this.botonModificacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione la opcion para acceder a la funcionalidad \r\ncorrespondiente.";
            // 
            // botonAlta
            // 
            this.botonAlta.Location = new System.Drawing.Point(85, 51);
            this.botonAlta.Name = "botonAlta";
            this.botonAlta.Size = new System.Drawing.Size(114, 43);
            this.botonAlta.TabIndex = 5;
            this.botonAlta.Text = "Registrar Cliente";
            this.botonAlta.UseVisualStyleBackColor = true;
            // 
            // botonBaja
            // 
            this.botonBaja.Location = new System.Drawing.Point(85, 109);
            this.botonBaja.Name = "botonBaja";
            this.botonBaja.Size = new System.Drawing.Size(114, 43);
            this.botonBaja.TabIndex = 6;
            this.botonBaja.Text = "Dar de baja a Cliente";
            this.botonBaja.UseVisualStyleBackColor = true;
            // 
            // botonModificacion
            // 
            this.botonModificacion.Location = new System.Drawing.Point(85, 169);
            this.botonModificacion.Name = "botonModificacion";
            this.botonModificacion.Size = new System.Drawing.Size(114, 43);
            this.botonModificacion.TabIndex = 7;
            this.botonModificacion.Text = "Modificar Cliente";
            this.botonModificacion.UseVisualStyleBackColor = true;
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.botonModificacion);
            this.Controls.Add(this.botonBaja);
            this.Controls.Add(this.botonAlta);
            this.Controls.Add(this.label1);
            this.Name = "Presentacion";
            this.Text = "ABM de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonAlta;
        private System.Windows.Forms.Button botonBaja;
        private System.Windows.Forms.Button botonModificacion;
    }
}