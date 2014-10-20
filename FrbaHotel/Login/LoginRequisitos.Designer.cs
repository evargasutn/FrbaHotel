namespace FrbaHotel
{
    partial class Form2
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
            this.labelMod = new System.Windows.Forms.Label();
            this.comboMod = new System.Windows.Forms.ComboBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMod
            // 
            this.labelMod.AutoSize = true;
            this.labelMod.Location = new System.Drawing.Point(12, 54);
            this.labelMod.Name = "labelMod";
            this.labelMod.Size = new System.Drawing.Size(134, 26);
            this.labelMod.TabIndex = 0;
            this.labelMod.Text = "Ingrese la modalidad con \r\nla que quiere iniciar sesion:";
            // 
            // comboMod
            // 
            this.comboMod.FormattingEnabled = true;
            this.comboMod.Location = new System.Drawing.Point(152, 59);
            this.comboMod.Name = "comboMod";
            this.comboMod.Size = new System.Drawing.Size(120, 21);
            this.comboMod.TabIndex = 1;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(74, 111);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(163, 43);
            this.botonAceptar.TabIndex = 2;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 183);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.comboMod);
            this.Controls.Add(this.labelMod);
            this.Name = "Form2";
            this.Text = "Tipo de Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMod;
        private System.Windows.Forms.ComboBox comboMod;
        private System.Windows.Forms.Button botonAceptar;
    }
}