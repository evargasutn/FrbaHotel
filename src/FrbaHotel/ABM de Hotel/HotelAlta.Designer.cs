namespace FrbaHotel.ABM_de_Hotel
{
    partial class HotelAlta
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
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboCantEstrellas = new System.Windows.Forms.ComboBox();
            this.listaRegimenes = new System.Windows.Forms.CheckedListBox();
            this.lblRegimen = new System.Windows.Forms.Label();
            this.textCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.nota = new System.Windows.Forms.Label();
            this.lblEstrellas = new System.Windows.Forms.Label();
            this.textDirAltura = new System.Windows.Forms.TextBox();
            this.lblDirAltura = new System.Windows.Forms.Label();
            this.textPais = new System.Windows.Forms.TextBox();
            this.textDirCalle = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblDirCalle = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(12, 380);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(106, 27);
            this.botonLimpiar.TabIndex = 29;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(197, 380);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(106, 27);
            this.botonGuardar.TabIndex = 28;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboCantEstrellas);
            this.groupBox2.Controls.Add(this.listaRegimenes);
            this.groupBox2.Controls.Add(this.lblRegimen);
            this.groupBox2.Controls.Add(this.textCiudad);
            this.groupBox2.Controls.Add(this.lblCiudad);
            this.groupBox2.Controls.Add(this.nota);
            this.groupBox2.Controls.Add(this.lblEstrellas);
            this.groupBox2.Controls.Add(this.textDirAltura);
            this.groupBox2.Controls.Add(this.lblDirAltura);
            this.groupBox2.Controls.Add(this.textPais);
            this.groupBox2.Controls.Add(this.textDirCalle);
            this.groupBox2.Controls.Add(this.textTelefono);
            this.groupBox2.Controls.Add(this.textMail);
            this.groupBox2.Controls.Add(this.textNombre);
            this.groupBox2.Controls.Add(this.lblPais);
            this.groupBox2.Controls.Add(this.lblDirCalle);
            this.groupBox2.Controls.Add(this.lblTelefono);
            this.groupBox2.Controls.Add(this.lblMail);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 362);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos identificatorios";
            // 
            // comboCantEstrellas
            // 
            this.comboCantEstrellas.FormattingEnabled = true;
            this.comboCantEstrellas.Location = new System.Drawing.Point(138, 155);
            this.comboCantEstrellas.Name = "comboCantEstrellas";
            this.comboCantEstrellas.Size = new System.Drawing.Size(141, 21);
            this.comboCantEstrellas.TabIndex = 38;
            // 
            // listaRegimenes
            // 
            this.listaRegimenes.FormattingEnabled = true;
            this.listaRegimenes.Location = new System.Drawing.Point(138, 234);
            this.listaRegimenes.Name = "listaRegimenes";
            this.listaRegimenes.Size = new System.Drawing.Size(141, 94);
            this.listaRegimenes.TabIndex = 37;
            // 
            // lblRegimen
            // 
            this.lblRegimen.AutoSize = true;
            this.lblRegimen.Location = new System.Drawing.Point(6, 234);
            this.lblRegimen.Name = "lblRegimen";
            this.lblRegimen.Size = new System.Drawing.Size(67, 13);
            this.lblRegimen.TabIndex = 36;
            this.lblRegimen.Text = "Regimenes:*";
            // 
            // textCiudad
            // 
            this.textCiudad.Location = new System.Drawing.Point(138, 182);
            this.textCiudad.Name = "textCiudad";
            this.textCiudad.Size = new System.Drawing.Size(141, 20);
            this.textCiudad.TabIndex = 35;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(6, 185);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(44, 13);
            this.lblCiudad.TabIndex = 34;
            this.lblCiudad.Text = "Ciudad*";
            // 
            // nota
            // 
            this.nota.AutoSize = true;
            this.nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota.Location = new System.Drawing.Point(6, 337);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(127, 13);
            this.nota.TabIndex = 33;
            this.nota.Text = "*Campos Obligatorios";
            // 
            // lblEstrellas
            // 
            this.lblEstrellas.AutoSize = true;
            this.lblEstrellas.Location = new System.Drawing.Point(6, 158);
            this.lblEstrellas.Name = "lblEstrellas";
            this.lblEstrellas.Size = new System.Drawing.Size(110, 13);
            this.lblEstrellas.TabIndex = 29;
            this.lblEstrellas.Text = "Cantidad de Estrellas*";
            // 
            // textDirAltura
            // 
            this.textDirAltura.Location = new System.Drawing.Point(138, 129);
            this.textDirAltura.Name = "textDirAltura";
            this.textDirAltura.Size = new System.Drawing.Size(141, 20);
            this.textDirAltura.TabIndex = 28;
            // 
            // lblDirAltura
            // 
            this.lblDirAltura.AutoSize = true;
            this.lblDirAltura.Location = new System.Drawing.Point(6, 132);
            this.lblDirAltura.Name = "lblDirAltura";
            this.lblDirAltura.Size = new System.Drawing.Size(38, 13);
            this.lblDirAltura.TabIndex = 27;
            this.lblDirAltura.Text = "Altura*";
            // 
            // textPais
            // 
            this.textPais.Location = new System.Drawing.Point(138, 208);
            this.textPais.Name = "textPais";
            this.textPais.Size = new System.Drawing.Size(141, 20);
            this.textPais.TabIndex = 23;
            // 
            // textDirCalle
            // 
            this.textDirCalle.Location = new System.Drawing.Point(138, 103);
            this.textDirCalle.Name = "textDirCalle";
            this.textDirCalle.Size = new System.Drawing.Size(141, 20);
            this.textDirCalle.TabIndex = 19;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(138, 77);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(141, 20);
            this.textTelefono.TabIndex = 18;
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(138, 51);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(141, 20);
            this.textMail.TabIndex = 17;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(138, 26);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(141, 20);
            this.textNombre.TabIndex = 14;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(6, 211);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(31, 13);
            this.lblPais.TabIndex = 11;
            this.lblPais.Text = "Pais*";
            // 
            // lblDirCalle
            // 
            this.lblDirCalle.AutoSize = true;
            this.lblDirCalle.Location = new System.Drawing.Point(6, 106);
            this.lblDirCalle.Name = "lblDirCalle";
            this.lblDirCalle.Size = new System.Drawing.Size(34, 13);
            this.lblDirCalle.TabIndex = 9;
            this.lblDirCalle.Text = "Calle*";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 80);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(53, 13);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Télefono*";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(6, 54);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(30, 13);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail*";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(48, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre*";
            // 
            // HotelAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 418);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.groupBox2);
            this.Name = "HotelAlta";
            this.Text = "Alta de un Hotel";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label nota;
        private System.Windows.Forms.Label lblEstrellas;
        private System.Windows.Forms.TextBox textDirAltura;
        private System.Windows.Forms.Label lblDirAltura;
        private System.Windows.Forms.TextBox textPais;
        private System.Windows.Forms.TextBox textDirCalle;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblDirCalle;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.CheckedListBox listaRegimenes;
        private System.Windows.Forms.Label lblRegimen;
        private System.Windows.Forms.ComboBox comboCantEstrellas;
    }
}