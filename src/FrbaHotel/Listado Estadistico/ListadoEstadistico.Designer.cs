namespace FrbaHotel.Listado_Estadistico
{
    partial class ListadoEstadistico
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
            this.dateTimeAnioEstadistica = new System.Windows.Forms.DateTimePicker();
            this.comboTrimestre = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonMostrarListado = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboTipoDeListado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridReportes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trimestre*";
            // 
            // dateTimeAnioEstadistica
            // 
            this.dateTimeAnioEstadistica.CustomFormat = "yyyy";
            this.dateTimeAnioEstadistica.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAnioEstadistica.Location = new System.Drawing.Point(78, 20);
            this.dateTimeAnioEstadistica.Name = "dateTimeAnioEstadistica";
            this.dateTimeAnioEstadistica.Size = new System.Drawing.Size(62, 20);
            this.dateTimeAnioEstadistica.TabIndex = 3;
            // 
            // comboTrimestre
            // 
            this.comboTrimestre.FormattingEnabled = true;
            this.comboTrimestre.Location = new System.Drawing.Point(77, 47);
            this.comboTrimestre.Name = "comboTrimestre";
            this.comboTrimestre.Size = new System.Drawing.Size(63, 21);
            this.comboTrimestre.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboTrimestre);
            this.groupBox1.Controls.Add(this.dateTimeAnioEstadistica);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Año y trimestre";
            // 
            // botonMostrarListado
            // 
            this.botonMostrarListado.Location = new System.Drawing.Point(92, 50);
            this.botonMostrarListado.Name = "botonMostrarListado";
            this.botonMostrarListado.Size = new System.Drawing.Size(100, 30);
            this.botonMostrarListado.TabIndex = 2;
            this.botonMostrarListado.Text = "Mostrar listado";
            this.botonMostrarListado.UseVisualStyleBackColor = true;
            this.botonMostrarListado.Click += new System.EventHandler(this.botonMostrarListado_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboTipoDeListado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.botonMostrarListado);
            this.groupBox2.Location = new System.Drawing.Point(172, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 86);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Año y trimestre";
            // 
            // comboTipoDeListado
            // 
            this.comboTipoDeListado.FormattingEnabled = true;
            this.comboTipoDeListado.Location = new System.Drawing.Point(72, 23);
            this.comboTipoDeListado.Name = "comboTipoDeListado";
            this.comboTipoDeListado.Size = new System.Drawing.Size(276, 21);
            this.comboTipoDeListado.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Listado*";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridReportes);
            this.groupBox3.Location = new System.Drawing.Point(20, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 186);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado Top5";
            // 
            // dataGridReportes
            // 
            this.dataGridReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReportes.Location = new System.Drawing.Point(12, 19);
            this.dataGridReportes.Name = "dataGridReportes";
            this.dataGridReportes.Size = new System.Drawing.Size(480, 156);
            this.dataGridReportes.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccione el año, el trimestre y el tipo de listado.";
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 346);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoEstadistico";
            this.Text = "Listado Estadístico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeAnioEstadistica;
        private System.Windows.Forms.ComboBox comboTrimestre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonMostrarListado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboTipoDeListado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridReportes;
        private System.Windows.Forms.Label label3;

    }
}