namespace FrbaHotel.ABM_de_Cliente
{
    partial class ClienteBajaMod
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
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Baja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboTipoDoc = new System.Windows.Forms.ComboBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.textNumDoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(393, 139);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(120, 29);
            this.botonBuscar.TabIndex = 15;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(12, 139);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(120, 29);
            this.botonLimpiar.TabIndex = 14;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            // 
            // dataGridUsuario
            // 
            this.dataGridUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Baja});
            this.dataGridUsuario.Location = new System.Drawing.Point(12, 174);
            this.dataGridUsuario.MultiSelect = false;
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.Size = new System.Drawing.Size(501, 197);
            this.dataGridUsuario.TabIndex = 13;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.Text = "Modificar";
            // 
            // Baja
            // 
            this.Baja.HeaderText = "Baja";
            this.Baja.Name = "Baja";
            this.Baja.Text = "Baja";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNumDoc);
            this.groupBox1.Controls.Add(this.lblNumDoc);
            this.groupBox1.Controls.Add(this.comboTipoDoc);
            this.groupBox1.Controls.Add(this.textApellido);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.lblTipoDoc);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 121);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // comboTipoDoc
            // 
            this.comboTipoDoc.FormattingEnabled = true;
            this.comboTipoDoc.Location = new System.Drawing.Point(173, 57);
            this.comboTipoDoc.Name = "comboTipoDoc";
            this.comboTipoDoc.Size = new System.Drawing.Size(116, 21);
            this.comboTipoDoc.TabIndex = 11;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(353, 31);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(113, 20);
            this.textApellido.TabIndex = 10;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(173, 31);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(116, 20);
            this.textNombre.TabIndex = 9;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(353, 57);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(113, 20);
            this.textEmail.TabIndex = 8;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(50, 60);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(101, 13);
            this.lblTipoDoc.TabIndex = 7;
            this.lblTipoDoc.Text = "Tipo de Documento";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(295, 34);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(50, 34);
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
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Location = new System.Drawing.Point(50, 87);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(117, 13);
            this.lblNumDoc.TabIndex = 12;
            this.lblNumDoc.Text = "Numero de Documento";
            // 
            // textNumDoc
            // 
            this.textNumDoc.Location = new System.Drawing.Point(173, 84);
            this.textNumDoc.Name = "textNumDoc";
            this.textNumDoc.Size = new System.Drawing.Size(116, 20);
            this.textNumDoc.TabIndex = 13;
            // 
            // ClienteBajaMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 383);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.dataGridUsuario);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClienteBajaMod";
            this.Text = "Modificacion/Baja de un Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.DataGridView dataGridUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Baja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboTipoDoc;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.TextBox textNumDoc;
    }
}