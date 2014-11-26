namespace FrbaHotel.Registrar_Consumible
{
    partial class RegistrarConsumibles
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridConsumibleXEstadia = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.dataGridConsumibles = new System.Windows.Forms.DataGridView();
            this.labelEstadia = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.textEstadia = new System.Windows.Forms.MaskedTextBox();
            this.textCantidad = new System.Windows.Forms.MaskedTextBox();
            this.labelCant = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsumibleXEstadia)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsumibles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textEstadia);
            this.groupBox1.Controls.Add(this.botonBuscar);
            this.groupBox1.Controls.Add(this.labelEstadia);
            this.groupBox1.Controls.Add(this.dataGridConsumibles);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadia";
            // 
            // dataGridConsumibleXEstadia
            // 
            this.dataGridConsumibleXEstadia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsumibleXEstadia.Location = new System.Drawing.Point(9, 18);
            this.dataGridConsumibleXEstadia.Name = "dataGridConsumibleXEstadia";
            this.dataGridConsumibleXEstadia.Size = new System.Drawing.Size(486, 127);
            this.dataGridConsumibleXEstadia.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridConsumibleXEstadia);
            this.groupBox3.Location = new System.Drawing.Point(12, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 151);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consumibles";
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Location = new System.Drawing.Point(364, 199);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(149, 28);
            this.botonRegistrar.TabIndex = 7;
            this.botonRegistrar.Text = "Registrar";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            // 
            // dataGridConsumibles
            // 
            this.dataGridConsumibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsumibles.Location = new System.Drawing.Point(6, 44);
            this.dataGridConsumibles.Name = "dataGridConsumibles";
            this.dataGridConsumibles.Size = new System.Drawing.Size(489, 127);
            this.dataGridConsumibles.TabIndex = 0;
            // 
            // labelEstadia
            // 
            this.labelEstadia.AutoSize = true;
            this.labelEstadia.Location = new System.Drawing.Point(46, 22);
            this.labelEstadia.Name = "labelEstadia";
            this.labelEstadia.Size = new System.Drawing.Size(78, 13);
            this.labelEstadia.TabIndex = 1;
            this.labelEstadia.Text = "Código Estadia";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(236, 18);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(184, 20);
            this.botonBuscar.TabIndex = 4;
            this.botonBuscar.Text = "Mostrar Consumibles";
            this.botonBuscar.UseVisualStyleBackColor = true;
            // 
            // textEstadia
            // 
            this.textEstadia.Location = new System.Drawing.Point(130, 18);
            this.textEstadia.Mask = "9999999999999999";
            this.textEstadia.Name = "textEstadia";
            this.textEstadia.Size = new System.Drawing.Size(100, 20);
            this.textEstadia.TabIndex = 5;
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(315, 204);
            this.textCantidad.Mask = "999999";
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(43, 20);
            this.textCantidad.TabIndex = 8;
            // 
            // labelCant
            // 
            this.labelCant.AutoSize = true;
            this.labelCant.Location = new System.Drawing.Point(176, 207);
            this.labelCant.Name = "labelCant";
            this.labelCant.Size = new System.Drawing.Size(121, 13);
            this.labelCant.TabIndex = 9;
            this.labelCant.Text = "Cantidad de Consumible";
            // 
            // RegistrarConsumibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 394);
            this.Controls.Add(this.labelCant);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarConsumibles";
            this.Text = "Registrar consumibles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsumibleXEstadia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsumibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridConsumibleXEstadia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.DataGridView dataGridConsumibles;
        private System.Windows.Forms.MaskedTextBox textEstadia;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Label labelEstadia;
        private System.Windows.Forms.MaskedTextBox textCantidad;
        private System.Windows.Forms.Label labelCant;
    }
}