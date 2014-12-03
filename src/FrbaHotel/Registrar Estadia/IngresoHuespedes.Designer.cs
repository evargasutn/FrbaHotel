namespace FrbaHotel.Registrar_Estadia
{
    partial class IngresoHuespedes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textNroDoc = new System.Windows.Forms.MaskedTextBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.buttonRegistrarCliente = new System.Windows.Forms.Button();
            this.textMail = new System.Windows.Forms.TextBox();
            this.comboTipoDoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNroDoc);
            this.groupBox1.Controls.Add(this.botonBuscar);
            this.groupBox1.Controls.Add(this.dataGridClientes);
            this.groupBox1.Controls.Add(this.buttonRegistrarCliente);
            this.groupBox1.Controls.Add(this.textMail);
            this.groupBox1.Controls.Add(this.comboTipoDoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 274);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente registrado";
            // 
            // textNroDoc
            // 
            this.textNroDoc.Location = new System.Drawing.Point(128, 45);
            this.textNroDoc.Mask = "99999999999999999";
            this.textNroDoc.Name = "textNroDoc";
            this.textNroDoc.Size = new System.Drawing.Size(137, 20);
            this.textNroDoc.TabIndex = 8;
            this.textNroDoc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textNroDoc_MaskInputRejected);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(128, 95);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(138, 21);
            this.botonBuscar.TabIndex = 7;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            this.dataGridClientes.AllowUserToResizeColumns = false;
            this.dataGridClientes.AllowUserToResizeRows = false;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(6, 122);
            this.dataGridClientes.MultiSelect = false;
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientes.Size = new System.Drawing.Size(510, 140);
            this.dataGridClientes.TabIndex = 0;
            // 
            // buttonRegistrarCliente
            // 
            this.buttonRegistrarCliente.Location = new System.Drawing.Point(332, 19);
            this.buttonRegistrarCliente.Name = "buttonRegistrarCliente";
            this.buttonRegistrarCliente.Size = new System.Drawing.Size(184, 66);
            this.buttonRegistrarCliente.TabIndex = 4;
            this.buttonRegistrarCliente.Text = "Registrar nuevo cliente";
            this.buttonRegistrarCliente.UseVisualStyleBackColor = true;
            this.buttonRegistrarCliente.Click += new System.EventHandler(this.buttonRegistrarCliente_Click);
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(128, 69);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(138, 20);
            this.textMail.TabIndex = 6;
            // 
            // comboTipoDoc
            // 
            this.comboTipoDoc.FormattingEnabled = true;
            this.comboTipoDoc.Location = new System.Drawing.Point(128, 21);
            this.comboTipoDoc.Name = "comboTipoDoc";
            this.comboTipoDoc.Size = new System.Drawing.Size(137, 21);
            this.comboTipoDoc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mail*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Número de documento*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de documento*";
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(391, 292);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(145, 23);
            this.botonVolver.TabIndex = 4;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            // 
            // IngresoHuespedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 323);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IngresoHuespedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Huespedes en el Sistema";
            this.Load += new System.EventHandler(this.IngresoHuespedes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox textNroDoc;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Button buttonRegistrarCliente;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.ComboBox comboTipoDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.ToolTip toolTip;

    }
}