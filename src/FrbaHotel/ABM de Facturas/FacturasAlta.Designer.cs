namespace FrbaHotel.ABM_de_Facturas
{
    partial class FacturasAlta
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
            this.labelEstadia = new System.Windows.Forms.Label();
            this.textEstadia = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textConsumibles = new System.Windows.Forms.TextBox();
            this.textBase = new System.Windows.Forms.TextBox();
            this.labelBase = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonFacturar = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelPago = new System.Windows.Forms.Label();
            this.comboTipoPago = new System.Windows.Forms.ComboBox();
            this.labelTarjeta = new System.Windows.Forms.Label();
            this.textTarjeta = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEstadia
            // 
            this.labelEstadia.AutoSize = true;
            this.labelEstadia.Location = new System.Drawing.Point(6, 31);
            this.labelEstadia.Name = "labelEstadia";
            this.labelEstadia.Size = new System.Drawing.Size(77, 13);
            this.labelEstadia.TabIndex = 0;
            this.labelEstadia.Text = "Nro de Estadia";
            // 
            // textEstadia
            // 
            this.textEstadia.Location = new System.Drawing.Point(149, 31);
            this.textEstadia.Mask = "9999999999";
            this.textEstadia.Name = "textEstadia";
            this.textEstadia.Size = new System.Drawing.Size(64, 20);
            this.textEstadia.TabIndex = 1;
            this.textEstadia.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textEstadia_MaskInputRejected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textTotal);
            this.groupBox1.Controls.Add(this.textConsumibles);
            this.groupBox1.Controls.Add(this.textBase);
            this.groupBox1.Controls.Add(this.labelBase);
            this.groupBox1.Controls.Add(this.botonBuscar);
            this.groupBox1.Controls.Add(this.labelEstadia);
            this.groupBox1.Controls.Add(this.textEstadia);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Estadia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Precio Total a Pagar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Acumulado Consumibles";
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(134, 111);
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(79, 20);
            this.textTotal.TabIndex = 6;
            // 
            // textConsumibles
            // 
            this.textConsumibles.Location = new System.Drawing.Point(134, 85);
            this.textConsumibles.Name = "textConsumibles";
            this.textConsumibles.ReadOnly = true;
            this.textConsumibles.Size = new System.Drawing.Size(79, 20);
            this.textConsumibles.TabIndex = 5;
            // 
            // textBase
            // 
            this.textBase.Location = new System.Drawing.Point(134, 59);
            this.textBase.Name = "textBase";
            this.textBase.ReadOnly = true;
            this.textBase.Size = new System.Drawing.Size(79, 20);
            this.textBase.TabIndex = 4;
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(6, 62);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(64, 13);
            this.labelBase.TabIndex = 3;
            this.labelBase.Text = "Precio Base";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(113, 137);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(110, 22);
            this.botonBuscar.TabIndex = 2;
            this.botonBuscar.Text = "Buscar Datos";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonFacturar
            // 
            this.botonFacturar.Location = new System.Drawing.Point(12, 258);
            this.botonFacturar.Name = "botonFacturar";
            this.botonFacturar.Size = new System.Drawing.Size(229, 39);
            this.botonFacturar.TabIndex = 3;
            this.botonFacturar.Text = "Facturar";
            this.botonFacturar.UseVisualStyleBackColor = true;
            this.botonFacturar.Click += new System.EventHandler(this.botonFacturar_Click);
            // 
            // labelPago
            // 
            this.labelPago.AutoSize = true;
            this.labelPago.Location = new System.Drawing.Point(12, 190);
            this.labelPago.Name = "labelPago";
            this.labelPago.Size = new System.Drawing.Size(71, 13);
            this.labelPago.TabIndex = 4;
            this.labelPago.Text = "Tipo de Pago";
            // 
            // comboTipoPago
            // 
            this.comboTipoPago.FormattingEnabled = true;
            this.comboTipoPago.Location = new System.Drawing.Point(120, 187);
            this.comboTipoPago.Name = "comboTipoPago";
            this.comboTipoPago.Size = new System.Drawing.Size(121, 21);
            this.comboTipoPago.TabIndex = 5;
            // 
            // labelTarjeta
            // 
            this.labelTarjeta.AutoSize = true;
            this.labelTarjeta.Location = new System.Drawing.Point(13, 216);
            this.labelTarjeta.Name = "labelTarjeta";
            this.labelTarjeta.Size = new System.Drawing.Size(60, 13);
            this.labelTarjeta.TabIndex = 6;
            this.labelTarjeta.Text = "Nro Tarjeta";
            // 
            // textTarjeta
            // 
            this.textTarjeta.Location = new System.Drawing.Point(120, 215);
            this.textTarjeta.Name = "textTarjeta";
            this.textTarjeta.Size = new System.Drawing.Size(120, 20);
            this.textTarjeta.TabIndex = 7;
            // 
            // FacturasAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 309);
            this.Controls.Add(this.textTarjeta);
            this.Controls.Add(this.labelTarjeta);
            this.Controls.Add(this.comboTipoPago);
            this.Controls.Add(this.labelPago);
            this.Controls.Add(this.botonFacturar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FacturasAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creación de Factura";
            this.Load += new System.EventHandler(this.FacturasAlta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEstadia;
        private System.Windows.Forms.MaskedTextBox textEstadia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.TextBox textConsumibles;
        private System.Windows.Forms.TextBox textBase;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonFacturar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labelPago;
        private System.Windows.Forms.ComboBox comboTipoPago;
        private System.Windows.Forms.Label labelTarjeta;
        private System.Windows.Forms.TextBox textTarjeta;
    }
}