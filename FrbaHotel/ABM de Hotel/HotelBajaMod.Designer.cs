namespace FrbaHotel.ABM_de_Hotel
{
    partial class HotelBajaMod
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
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.dataGridHotel = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboEstrellas = new System.Windows.Forms.ComboBox();
            this.textCiudad = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textPais = new System.Windows.Forms.TextBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altaDeHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Baja = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHotel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(399, 154);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(120, 29);
            this.botonBuscar.TabIndex = 19;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(18, 154);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(120, 29);
            this.botonLimpiar.TabIndex = 18;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // dataGridHotel
            // 
            this.dataGridHotel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Baja});
            this.dataGridHotel.Location = new System.Drawing.Point(18, 189);
            this.dataGridHotel.MultiSelect = false;
            this.dataGridHotel.Name = "dataGridHotel";
            this.dataGridHotel.Size = new System.Drawing.Size(501, 263);
            this.dataGridHotel.TabIndex = 17;
            this.dataGridHotel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHotel_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboEstrellas);
            this.groupBox1.Controls.Add(this.textCiudad);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.textPais);
            this.groupBox1.Controls.Add(this.lblTipoDoc);
            this.groupBox1.Controls.Add(this.lblCiudad);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Location = new System.Drawing.Point(18, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 121);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // comboEstrellas
            // 
            this.comboEstrellas.FormattingEnabled = true;
            this.comboEstrellas.Location = new System.Drawing.Point(141, 57);
            this.comboEstrellas.Name = "comboEstrellas";
            this.comboEstrellas.Size = new System.Drawing.Size(116, 21);
            this.comboEstrellas.TabIndex = 11;
            // 
            // textCiudad
            // 
            this.textCiudad.Location = new System.Drawing.Point(353, 31);
            this.textCiudad.Name = "textCiudad";
            this.textCiudad.Size = new System.Drawing.Size(113, 20);
            this.textCiudad.TabIndex = 10;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(141, 31);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(116, 20);
            this.textNombre.TabIndex = 9;
            // 
            // textPais
            // 
            this.textPais.Location = new System.Drawing.Point(353, 57);
            this.textPais.Name = "textPais";
            this.textPais.Size = new System.Drawing.Size(113, 20);
            this.textPais.TabIndex = 8;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(18, 60);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(109, 13);
            this.lblTipoDoc.TabIndex = 7;
            this.lblTipoDoc.Text = "Cantidad de Estrellas:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(295, 34);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 6;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(295, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(30, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Pais:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeHotelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaDeHotelToolStripMenuItem
            // 
            this.altaDeHotelToolStripMenuItem.Name = "altaDeHotelToolStripMenuItem";
            this.altaDeHotelToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.altaDeHotelToolStripMenuItem.Text = "Alta de Hotel";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.Text = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
            // 
            // Baja
            // 
            this.Baja.HeaderText = "";
            this.Baja.Name = "Baja";
            this.Baja.Text = "Baja";
            this.Baja.UseColumnTextForButtonValue = true;
            // 
            // HotelBajaMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 459);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.dataGridHotel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HotelBajaMod";
            this.Text = "Modificación/Baja de un Hotel";
            this.Load += new System.EventHandler(this.HotelBajaMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHotel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.DataGridView dataGridHotel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboEstrellas;
        private System.Windows.Forms.TextBox textCiudad;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textPais;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altaDeHotelToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Baja;
    }
}