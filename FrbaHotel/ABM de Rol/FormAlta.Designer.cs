namespace FrbaHotel.ABM_de_Rol
{
    partial class FormAlta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboDeFuncionalidades = new System.Windows.Forms.ComboBox();
            this.textRol = new System.Windows.Forms.TextBox();
            this.comboDeEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Funcionalidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // comboDeFuncionalidades
            // 
            this.comboDeFuncionalidades.FormattingEnabled = true;
            this.comboDeFuncionalidades.Location = new System.Drawing.Point(132, 74);
            this.comboDeFuncionalidades.Name = "comboDeFuncionalidades";
            this.comboDeFuncionalidades.Size = new System.Drawing.Size(130, 21);
            this.comboDeFuncionalidades.TabIndex = 6;
            this.comboDeFuncionalidades.SelectedIndexChanged += new System.EventHandler(this.comboDeFuncionalidades_SelectedIndexChanged);
            // 
            // textRol
            // 
            this.textRol.Location = new System.Drawing.Point(133, 33);
            this.textRol.Name = "textRol";
            this.textRol.Size = new System.Drawing.Size(129, 20);
            this.textRol.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboDeEstado.FormattingEnabled = true;
            this.comboDeEstado.Location = new System.Drawing.Point(132, 118);
            this.comboDeEstado.Name = "comboBox1";
            this.comboDeEstado.Size = new System.Drawing.Size(130, 21);
            this.comboDeEstado.TabIndex = 8;
            this.comboDeEstado.SelectedIndexChanged += new System.EventHandler(this.comboDeEstado_SelectedIndexChanged);
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 235);
            this.Controls.Add(this.comboDeEstado);
            this.Controls.Add(this.textRol);
            this.Controls.Add(this.comboDeFuncionalidades);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAlta";
            this.Text = "Alta de Rol";
            this.Load += new System.EventHandler(this.FormAlta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboDeFuncionalidades;
        private System.Windows.Forms.TextBox textRol;
        private System.Windows.Forms.ComboBox comboDeEstado;
    }
}