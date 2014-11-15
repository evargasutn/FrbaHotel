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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridHuespedes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.comboTipoDeDNI = new System.Windows.Forms.ComboBox();
            this.textIdHuesped = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botonIngresarHuesped = new System.Windows.Forms.Button();
            this.ColumnIngresar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textCantHuespedesIngresados = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textCapacidadHuespedes = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHuespedes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridHuespedes);
            this.groupBox1.Location = new System.Drawing.Point(42, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Huespedes";
            // 
            // dataGridHuespedes
            // 
            this.dataGridHuespedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHuespedes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIngresar});
            this.dataGridHuespedes.Location = new System.Drawing.Point(6, 19);
            this.dataGridHuespedes.Name = "dataGridHuespedes";
            this.dataGridHuespedes.Size = new System.Drawing.Size(463, 144);
            this.dataGridHuespedes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textIdHuesped);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboTipoDeDNI);
            this.groupBox2.Controls.Add(this.textDNI);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textApellido);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textNombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(42, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de huespedes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(62, 45);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(105, 20);
            this.textNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(62, 71);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(105, 20);
            this.textApellido.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "DNI";
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(267, 45);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(111, 20);
            this.textDNI.TabIndex = 6;
            // 
            // comboTipoDeDNI
            // 
            this.comboTipoDeDNI.FormattingEnabled = true;
            this.comboTipoDeDNI.Location = new System.Drawing.Point(267, 19);
            this.comboTipoDeDNI.Name = "comboTipoDeDNI";
            this.comboTipoDeDNI.Size = new System.Drawing.Size(111, 21);
            this.comboTipoDeDNI.TabIndex = 7;
            // 
            // textIdHuesped
            // 
            this.textIdHuesped.Location = new System.Drawing.Point(62, 19);
            this.textIdHuesped.Name = "textIdHuesped";
            this.textIdHuesped.Size = new System.Drawing.Size(105, 20);
            this.textIdHuesped.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Id huesped";
            // 
            // botonIngresarHuesped
            // 
            this.botonIngresarHuesped.Location = new System.Drawing.Point(217, 380);
            this.botonIngresarHuesped.Name = "botonIngresarHuesped";
            this.botonIngresarHuesped.Size = new System.Drawing.Size(117, 28);
            this.botonIngresarHuesped.TabIndex = 2;
            this.botonIngresarHuesped.Text = "Huesped nuevo";
            this.botonIngresarHuesped.UseVisualStyleBackColor = true;
            // 
            // ColumnIngresar
            // 
            this.ColumnIngresar.HeaderText = "Ingresar";
            this.ColumnIngresar.Name = "ColumnIngresar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(29, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(455, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ingrese los huespedes restantes de la estadia al hotel,en caso de no estar regist" +
                "rado registrelo.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textCapacidadHuespedes);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textCantHuespedesIngresados);
            this.groupBox3.Location = new System.Drawing.Point(48, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 39);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Huespedes a la habitacion";
            // 
            // textCantHuespedesIngresados
            // 
            this.textCantHuespedesIngresados.Location = new System.Drawing.Point(130, 13);
            this.textCantHuespedesIngresados.Name = "textCantHuespedesIngresados";
            this.textCantHuespedesIngresados.ReadOnly = true;
            this.textCantHuespedesIngresados.Size = new System.Drawing.Size(30, 20);
            this.textCantHuespedesIngresados.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Huespedes ingresados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Capacidad de huespedes";
            // 
            // textCapacidadHuespedes
            // 
            this.textCapacidadHuespedes.Location = new System.Drawing.Point(363, 13);
            this.textCapacidadHuespedes.Name = "textCapacidadHuespedes";
            this.textCapacidadHuespedes.ReadOnly = true;
            this.textCapacidadHuespedes.Size = new System.Drawing.Size(30, 20);
            this.textCapacidadHuespedes.TabIndex = 2;
            // 
            // IngresoHuespedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 418);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.botonIngresarHuesped);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IngresoHuespedes";
            this.Text = "Ingreso de restantes huespedes";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHuespedes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridHuespedes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textIdHuesped;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboTipoDeDNI;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonIngresarHuesped;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnIngresar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textCapacidadHuespedes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCantHuespedesIngresados;
    }
}