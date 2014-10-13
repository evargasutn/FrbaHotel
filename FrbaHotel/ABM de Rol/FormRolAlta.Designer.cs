using DOM;
namespace FrbaHotel.ABM_de_Rol
{
    partial class FormRolAlta
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
            Globals.VentanaAnterior.Enabled = true;
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
            this.labelRol = new System.Windows.Forms.Label();
            this.labelFuncionalidad = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.comboFuncionalidades = new System.Windows.Forms.ComboBox();
            this.textRol = new System.Windows.Forms.TextBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Location = new System.Drawing.Point(30, 36);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(78, 13);
            this.labelRol.TabIndex = 0;
            this.labelRol.Text = "Nombre de Rol";
            // 
            // labelFuncionalidad
            // 
            this.labelFuncionalidad.AutoSize = true;
            this.labelFuncionalidad.Location = new System.Drawing.Point(30, 77);
            this.labelFuncionalidad.Name = "labelFuncionalidad";
            this.labelFuncionalidad.Size = new System.Drawing.Size(73, 13);
            this.labelFuncionalidad.TabIndex = 1;
            this.labelFuncionalidad.Text = "Funcionalidad";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(30, 126);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 2;
            this.labelEstado.Text = "Estado";
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(74, 173);
            this.botonGuardar.Name = "button1";
            this.botonGuardar.Size = new System.Drawing.Size(136, 28);
            this.botonGuardar.TabIndex = 5;
            this.botonGuardar.Text = "guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // comboFuncionalidades
            // 
            this.comboFuncionalidades.FormattingEnabled = true;
            this.comboFuncionalidades.Location = new System.Drawing.Point(132, 74);
            this.comboFuncionalidades.Name = "comboFuncionalidades";
            this.comboFuncionalidades.Size = new System.Drawing.Size(130, 21);
            this.comboFuncionalidades.TabIndex = 6;
            // 
            // textRol
            // 
            this.textRol.Location = new System.Drawing.Point(133, 33);
            this.textRol.Name = "textRol";
            this.textRol.Size = new System.Drawing.Size(129, 20);
            this.textRol.TabIndex = 7;
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(132, 118);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(130, 21);
            this.comboEstado.TabIndex = 8;
            // 
            // FormRolAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 235);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.textRol);
            this.Controls.Add(this.comboFuncionalidades);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelFuncionalidad);
            this.Controls.Add(this.labelRol);
            this.Name = "FormRolAlta";
            this.Text = "Alta de Rol";
            this.Load += new System.EventHandler(this.FormRolAlta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelFuncionalidad;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.ComboBox comboFuncionalidades;
        private System.Windows.Forms.TextBox textRol;
        private System.Windows.Forms.ComboBox comboEstado;
    }
}