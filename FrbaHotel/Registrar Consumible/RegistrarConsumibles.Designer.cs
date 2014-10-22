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
            this.dataGridConsumibles = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.AgregarConsumible = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridConsumibleXEstadia = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnaModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsumibles)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsumibleXEstadia)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dataGridConsumibles);
            this.groupBox1.Location = new System.Drawing.Point(50, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consumibles";
            // 
            // dataGridConsumibles
            // 
            this.dataGridConsumibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsumibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AgregarConsumible});
            this.dataGridConsumibles.Location = new System.Drawing.Point(6, 100);
            this.dataGridConsumibles.Name = "dataGridConsumibles";
            this.dataGridConsumibles.Size = new System.Drawing.Size(517, 127);
            this.dataGridConsumibles.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonBuscar);
            this.groupBox2.Controls.Add(this.textCodigo);
            this.groupBox2.Controls.Add(this.textDescripcion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(25, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 45);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(75, 15);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(108, 20);
            this.textDescripcion.TabIndex = 2;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(255, 15);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(108, 20);
            this.textCodigo.TabIndex = 3;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(386, 15);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(80, 19);
            this.botonBuscar.TabIndex = 4;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            // 
            // AgregarConsumible
            // 
            this.AgregarConsumible.HeaderText = "Agregar";
            this.AgregarConsumible.Name = "AgregarConsumible";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Registrar los consumibles por estadia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Previo agregado de un consumible indique la cantidad.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad*";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(360, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dataGridConsumibleXEstadia
            // 
            this.dataGridConsumibleXEstadia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsumibleXEstadia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.ColumnaModificar});
            this.dataGridConsumibleXEstadia.Location = new System.Drawing.Point(6, 19);
            this.dataGridConsumibleXEstadia.Name = "dataGridConsumibleXEstadia";
            this.dataGridConsumibleXEstadia.Size = new System.Drawing.Size(517, 127);
            this.dataGridConsumibleXEstadia.TabIndex = 5;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Agregar";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // ColumnaModificar
            // 
            this.ColumnaModificar.HeaderText = "Modificar cantidad";
            this.ColumnaModificar.Name = "ColumnaModificar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridConsumibleXEstadia);
            this.groupBox3.Location = new System.Drawing.Point(50, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(532, 151);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consumibles a registrar por la estadia";
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Location = new System.Drawing.Point(230, 424);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(149, 28);
            this.botonRegistrar.TabIndex = 7;
            this.botonRegistrar.Text = "Registrar";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            // 
            // RegistrarConsumibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 456);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarConsumibles";
            this.Text = "Registrar consumibles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsumibles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsumibleXEstadia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridConsumibles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.DataGridViewButtonColumn AgregarConsumible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridConsumibleXEstadia;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnaModificar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button botonRegistrar;
    }
}