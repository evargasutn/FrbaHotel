namespace FrbaHotel.ABM_de_Habitacion
{
    partial class HabitacionBajaMod
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altaDeHabitaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.dataGridHabitacion = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Baja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboUbicacion = new System.Windows.Forms.ComboBox();
            this.textPiso = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabitacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeHabitaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaDeHabitaciónToolStripMenuItem
            // 
            this.altaDeHabitaciónToolStripMenuItem.Name = "altaDeHabitaciónToolStripMenuItem";
            this.altaDeHabitaciónToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.altaDeHabitaciónToolStripMenuItem.Text = "Alta de Habitación";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(393, 126);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(120, 29);
            this.botonBuscar.TabIndex = 23;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(12, 126);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(120, 29);
            this.botonLimpiar.TabIndex = 22;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            // 
            // dataGridHabitacion
            // 
            this.dataGridHabitacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHabitacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Baja});
            this.dataGridHabitacion.Location = new System.Drawing.Point(12, 161);
            this.dataGridHabitacion.MultiSelect = false;
            this.dataGridHabitacion.Name = "dataGridHabitacion";
            this.dataGridHabitacion.Size = new System.Drawing.Size(501, 298);
            this.dataGridHabitacion.TabIndex = 21;
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
            this.groupBox1.Controls.Add(this.comboUbicacion);
            this.groupBox1.Controls.Add(this.textPiso);
            this.groupBox1.Controls.Add(this.textNumero);
            this.groupBox1.Controls.Add(this.lblUbicacion);
            this.groupBox1.Controls.Add(this.lblPiso);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 93);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // comboUbicacion
            // 
            this.comboUbicacion.FormattingEnabled = true;
            this.comboUbicacion.Location = new System.Drawing.Point(141, 57);
            this.comboUbicacion.Name = "comboUbicacion";
            this.comboUbicacion.Size = new System.Drawing.Size(116, 21);
            this.comboUbicacion.TabIndex = 11;
            // 
            // textPiso
            // 
            this.textPiso.Location = new System.Drawing.Point(353, 31);
            this.textPiso.Name = "textPiso";
            this.textPiso.Size = new System.Drawing.Size(113, 20);
            this.textPiso.TabIndex = 10;
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(141, 31);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(116, 20);
            this.textNumero.TabIndex = 9;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(18, 60);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(58, 13);
            this.lblUbicacion.TabIndex = 7;
            this.lblUbicacion.Text = "Ubicación:";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(295, 34);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(30, 13);
            this.lblPiso.TabIndex = 6;
            this.lblPiso.Text = "Piso:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(18, 34);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(116, 13);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Número de Habitación:";
            // 
            // HabitacionBajaMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 471);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.dataGridHabitacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HabitacionBajaMod";
            this.Text = "Modificación/Baja de Habitaciones";
            this.Load += new System.EventHandler(this.HabitacionBajaMod_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabitacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altaDeHabitaciónToolStripMenuItem;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.DataGridView dataGridHabitacion;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Baja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboUbicacion;
        private System.Windows.Forms.TextBox textPiso;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblNumero;
    }
}