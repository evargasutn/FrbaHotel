namespace FrbaHotel.ABM_de_Cliente
{
    partial class ClienteMod
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
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textDirPiso = new System.Windows.Forms.MaskedTextBox();
            this.textDirAltura = new System.Windows.Forms.MaskedTextBox();
            this.textTelefono = new System.Windows.Forms.MaskedTextBox();
            this.textNumDoc = new System.Windows.Forms.MaskedTextBox();
            this.textPais = new System.Windows.Forms.ComboBox();
            this.textLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.textDirDpto = new System.Windows.Forms.TextBox();
            this.lblDirDpto = new System.Windows.Forms.Label();
            this.lblDirPiso = new System.Windows.Forms.Label();
            this.lblDirAltura = new System.Windows.Forms.Label();
            this.dateTimeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.comboTipoDoc = new System.Windows.Forms.ComboBox();
            this.textDirCalle = new System.Windows.Forms.TextBox();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblDirCalle = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(12, 338);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(106, 27);
            this.botonLimpiar.TabIndex = 29;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(197, 338);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(106, 27);
            this.botonGuardar.TabIndex = 28;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textDirPiso);
            this.groupBox2.Controls.Add(this.textDirAltura);
            this.groupBox2.Controls.Add(this.textTelefono);
            this.groupBox2.Controls.Add(this.textNumDoc);
            this.groupBox2.Controls.Add(this.textPais);
            this.groupBox2.Controls.Add(this.textLocalidad);
            this.groupBox2.Controls.Add(this.lblLocalidad);
            this.groupBox2.Controls.Add(this.textDirDpto);
            this.groupBox2.Controls.Add(this.lblDirDpto);
            this.groupBox2.Controls.Add(this.lblDirPiso);
            this.groupBox2.Controls.Add(this.lblDirAltura);
            this.groupBox2.Controls.Add(this.dateTimeNacimiento);
            this.groupBox2.Controls.Add(this.comboTipoDoc);
            this.groupBox2.Controls.Add(this.textDirCalle);
            this.groupBox2.Controls.Add(this.textMail);
            this.groupBox2.Controls.Add(this.textApellido);
            this.groupBox2.Controls.Add(this.textNombre);
            this.groupBox2.Controls.Add(this.lblPais);
            this.groupBox2.Controls.Add(this.lblNacimiento);
            this.groupBox2.Controls.Add(this.lblDirCalle);
            this.groupBox2.Controls.Add(this.lblTelefono);
            this.groupBox2.Controls.Add(this.lblMail);
            this.groupBox2.Controls.Add(this.lblNumDoc);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Controls.Add(this.lblTipoDoc);
            this.groupBox2.Controls.Add(this.lblApellido);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 320);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos identificatorios";
            // 
            // textDirPiso
            // 
            this.textDirPiso.Location = new System.Drawing.Point(157, 235);
            this.textDirPiso.Mask = "99";
            this.textDirPiso.Name = "textDirPiso";
            this.textDirPiso.Size = new System.Drawing.Size(41, 20);
            this.textDirPiso.TabIndex = 43;
            // 
            // textDirAltura
            // 
            this.textDirAltura.Location = new System.Drawing.Point(50, 235);
            this.textDirAltura.Mask = "99999";
            this.textDirAltura.Name = "textDirAltura";
            this.textDirAltura.Size = new System.Drawing.Size(66, 20);
            this.textDirAltura.TabIndex = 42;
            this.textDirAltura.ValidatingType = typeof(int);
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(138, 183);
            this.textTelefono.Mask = "9999999999";
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(141, 20);
            this.textTelefono.TabIndex = 41;
            // 
            // textNumDoc
            // 
            this.textNumDoc.Location = new System.Drawing.Point(138, 105);
            this.textNumDoc.Mask = "999999999";
            this.textNumDoc.Name = "textNumDoc";
            this.textNumDoc.Size = new System.Drawing.Size(141, 20);
            this.textNumDoc.TabIndex = 40;
            // 
            // textPais
            // 
            this.textPais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textPais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.textPais.FormattingEnabled = true;
            this.textPais.Location = new System.Drawing.Point(138, 287);
            this.textPais.Name = "textPais";
            this.textPais.Size = new System.Drawing.Size(141, 21);
            this.textPais.TabIndex = 36;
            // 
            // textLocalidad
            // 
            this.textLocalidad.Location = new System.Drawing.Point(138, 261);
            this.textLocalidad.Name = "textLocalidad";
            this.textLocalidad.Size = new System.Drawing.Size(141, 20);
            this.textLocalidad.TabIndex = 35;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(6, 264);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 34;
            this.lblLocalidad.Text = "Localidad";
            // 
            // textDirDpto
            // 
            this.textDirDpto.Location = new System.Drawing.Point(240, 235);
            this.textDirDpto.Name = "textDirDpto";
            this.textDirDpto.Size = new System.Drawing.Size(39, 20);
            this.textDirDpto.TabIndex = 32;
            // 
            // lblDirDpto
            // 
            this.lblDirDpto.AutoSize = true;
            this.lblDirDpto.Location = new System.Drawing.Point(204, 238);
            this.lblDirDpto.Name = "lblDirDpto";
            this.lblDirDpto.Size = new System.Drawing.Size(30, 13);
            this.lblDirDpto.TabIndex = 30;
            this.lblDirDpto.Text = "Dpto";
            // 
            // lblDirPiso
            // 
            this.lblDirPiso.AutoSize = true;
            this.lblDirPiso.Location = new System.Drawing.Point(124, 238);
            this.lblDirPiso.Name = "lblDirPiso";
            this.lblDirPiso.Size = new System.Drawing.Size(27, 13);
            this.lblDirPiso.TabIndex = 29;
            this.lblDirPiso.Text = "Piso";
            // 
            // lblDirAltura
            // 
            this.lblDirAltura.AutoSize = true;
            this.lblDirAltura.Location = new System.Drawing.Point(6, 238);
            this.lblDirAltura.Name = "lblDirAltura";
            this.lblDirAltura.Size = new System.Drawing.Size(34, 13);
            this.lblDirAltura.TabIndex = 27;
            this.lblDirAltura.Text = "Altura";
            // 
            // dateTimeNacimiento
            // 
            this.dateTimeNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNacimiento.Location = new System.Drawing.Point(138, 131);
            this.dateTimeNacimiento.Name = "dateTimeNacimiento";
            this.dateTimeNacimiento.Size = new System.Drawing.Size(141, 20);
            this.dateTimeNacimiento.TabIndex = 26;
            this.dateTimeNacimiento.Value = new System.DateTime(2014, 10, 20, 0, 0, 0, 0);
            // 
            // comboTipoDoc
            // 
            this.comboTipoDoc.FormattingEnabled = true;
            this.comboTipoDoc.Location = new System.Drawing.Point(138, 78);
            this.comboTipoDoc.Name = "comboTipoDoc";
            this.comboTipoDoc.Size = new System.Drawing.Size(141, 21);
            this.comboTipoDoc.TabIndex = 25;
            // 
            // textDirCalle
            // 
            this.textDirCalle.Location = new System.Drawing.Point(138, 209);
            this.textDirCalle.Name = "textDirCalle";
            this.textDirCalle.Size = new System.Drawing.Size(141, 20);
            this.textDirCalle.TabIndex = 19;
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(138, 157);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(141, 20);
            this.textMail.TabIndex = 17;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(138, 52);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(141, 20);
            this.textApellido.TabIndex = 15;
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
            this.lblPais.Location = new System.Drawing.Point(6, 290);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 11;
            this.lblPais.Text = "Pais";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(6, 131);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lblNacimiento.TabIndex = 10;
            this.lblNacimiento.Text = "Fecha de Nacimento";
            // 
            // lblDirCalle
            // 
            this.lblDirCalle.AutoSize = true;
            this.lblDirCalle.Location = new System.Drawing.Point(6, 212);
            this.lblDirCalle.Name = "lblDirCalle";
            this.lblDirCalle.Size = new System.Drawing.Size(30, 13);
            this.lblDirCalle.TabIndex = 9;
            this.lblDirCalle.Text = "Calle";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 186);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Télefono";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(6, 160);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail";
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Location = new System.Drawing.Point(6, 108);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(117, 13);
            this.lblNumDoc.TabIndex = 6;
            this.lblNumDoc.Text = "Numero de Documento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(6, 81);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(101, 13);
            this.lblTipoDoc.TabIndex = 5;
            this.lblTipoDoc.Text = "Tipo de Documento";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 55);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // ClienteMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 376);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.groupBox2);
            this.Name = "ClienteMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar un Cliente";
            this.Load += new System.EventHandler(this.ClienteMod_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox textDirDpto;
        private System.Windows.Forms.Label lblDirDpto;
        private System.Windows.Forms.Label lblDirPiso;
        private System.Windows.Forms.Label lblDirAltura;
        private System.Windows.Forms.DateTimePicker dateTimeNacimiento;
        private System.Windows.Forms.ComboBox comboTipoDoc;
        private System.Windows.Forms.TextBox textDirCalle;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblDirCalle;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.ComboBox textPais;
        private System.Windows.Forms.MaskedTextBox textDirPiso;
        private System.Windows.Forms.MaskedTextBox textDirAltura;
        private System.Windows.Forms.MaskedTextBox textTelefono;
        private System.Windows.Forms.MaskedTextBox textNumDoc;
        private System.Windows.Forms.ToolTip toolTip;
    }
}