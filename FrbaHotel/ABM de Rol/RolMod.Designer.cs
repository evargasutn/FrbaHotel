using DOM;
namespace FrbaHotel.ABM_de_Rol
{
    partial class RolMod
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
            Globals.habilitarAnterior();
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
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.textRol = new System.Windows.Forms.TextBox();
            this.comboFuncionalidad = new System.Windows.Forms.ComboBox();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelFuncionalidad = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelDisponibles = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonQuitar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(194, 73);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(130, 21);
            this.comboEstado.TabIndex = 15;
            // 
            // textRol
            // 
            this.textRol.Location = new System.Drawing.Point(193, 36);
            this.textRol.Name = "textRol";
            this.textRol.Size = new System.Drawing.Size(130, 20);
            this.textRol.TabIndex = 14;
            // 
            // comboFuncionalidad
            // 
            this.comboFuncionalidad.FormattingEnabled = true;
            this.comboFuncionalidad.Location = new System.Drawing.Point(156, 45);
            this.comboFuncionalidad.Name = "comboFuncionalidad";
            this.comboFuncionalidad.Size = new System.Drawing.Size(138, 21);
            this.comboFuncionalidad.TabIndex = 13;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(215, 262);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(109, 28);
            this.botonGuardar.TabIndex = 12;
            this.botonGuardar.Text = "guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(12, 76);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 11;
            this.labelEstado.Text = "Estado";
            // 
            // labelFuncionalidad
            // 
            this.labelFuncionalidad.AutoSize = true;
            this.labelFuncionalidad.Location = new System.Drawing.Point(14, 17);
            this.labelFuncionalidad.Name = "labelFuncionalidad";
            this.labelFuncionalidad.Size = new System.Drawing.Size(84, 13);
            this.labelFuncionalidad.TabIndex = 10;
            this.labelFuncionalidad.Text = "Funcionalidades";
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Location = new System.Drawing.Point(12, 39);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(78, 13);
            this.labelRol.TabIndex = 9;
            this.labelRol.Text = "Nombre de Rol";
            // 
            // labelDisponibles
            // 
            this.labelDisponibles.AutoSize = true;
            this.labelDisponibles.Location = new System.Drawing.Point(153, 17);
            this.labelDisponibles.Name = "labelDisponibles";
            this.labelDisponibles.Size = new System.Drawing.Size(141, 13);
            this.labelDisponibles.TabIndex = 16;
            this.labelDisponibles.Text = "Funcionalidades Disponibles";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(17, 33);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(128, 108);
            this.listBox.TabIndex = 17;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(156, 72);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(64, 24);
            this.botonAgregar.TabIndex = 18;
            this.botonAgregar.Text = "+";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonQuitar
            // 
            this.botonQuitar.Location = new System.Drawing.Point(230, 72);
            this.botonQuitar.Name = "botonQuitar";
            this.botonQuitar.Size = new System.Drawing.Size(64, 24);
            this.botonQuitar.TabIndex = 19;
            this.botonQuitar.Text = "-";
            this.botonQuitar.UseVisualStyleBackColor = true;
            this.botonQuitar.Click += new System.EventHandler(this.botonQuitar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.botonAgregar);
            this.panel1.Controls.Add(this.botonQuitar);
            this.panel1.Controls.Add(this.listBox);
            this.panel1.Controls.Add(this.labelDisponibles);
            this.panel1.Controls.Add(this.labelFuncionalidad);
            this.panel1.Controls.Add(this.comboFuncionalidad);
            this.panel1.Location = new System.Drawing.Point(12, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 155);
            this.panel1.TabIndex = 20;
            // 
            // RolMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 302);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.textRol);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelRol);
            this.Name = "RolMod";
            this.Text = "Modificar Rol";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.TextBox textRol;
        private System.Windows.Forms.ComboBox comboFuncionalidad;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelFuncionalidad;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelDisponibles;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonQuitar;
        private System.Windows.Forms.Panel panel1;

    }
}