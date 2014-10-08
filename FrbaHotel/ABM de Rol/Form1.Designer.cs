namespace FrbaHotel.ABM_de_Rol
{
    partial class Form1
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
            this.buttonAlta = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.buttonAlta.Location = new System.Drawing.Point(82, 37);
            this.buttonAlta.Name = "button1";
            this.buttonAlta.Size = new System.Drawing.Size(130, 37);
            this.buttonAlta.TabIndex = 0;
            this.buttonAlta.Text = "Alta";
            this.buttonAlta.UseVisualStyleBackColor = true;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // button2
            // 
            this.buttonMod.Location = new System.Drawing.Point(82, 96);
            this.buttonMod.Name = "button2";
            this.buttonMod.Size = new System.Drawing.Size(130, 37);
            this.buttonMod.TabIndex = 1;
            this.buttonMod.Text = "Modificar";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // button3
            // 
            this.buttonBaja.Location = new System.Drawing.Point(82, 160);
            this.buttonBaja.Name = "button3";
            this.buttonBaja.Size = new System.Drawing.Size(130, 37);
            this.buttonBaja.TabIndex = 2;
            this.buttonBaja.Text = "baja";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonAlta);
            this.Name = "Form1";
            this.Text = "ABM de Rol";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAlta;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonBaja;
    }
}