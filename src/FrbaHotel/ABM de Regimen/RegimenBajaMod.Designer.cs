namespace FrbaHotel.ABM_de_Regimen
{
    partial class RegimenBajaMod
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
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonBaja = new System.Windows.Forms.Button();
            this.dataGridViewRol = new System.Windows.Forms.DataGridView();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.groupFiltros = new System.Windows.Forms.GroupBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altaDeRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textPrecioBase = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRol)).BeginInit();
            this.groupFiltros.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(289, 348);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(120, 29);
            this.botonModificar.TabIndex = 27;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // botonBaja
            // 
            this.botonBaja.Location = new System.Drawing.Point(12, 348);
            this.botonBaja.Name = "botonBaja";
            this.botonBaja.Size = new System.Drawing.Size(120, 29);
            this.botonBaja.TabIndex = 26;
            this.botonBaja.Text = "Baja";
            this.botonBaja.UseVisualStyleBackColor = true;
            this.botonBaja.Click += new System.EventHandler(this.botonBaja_Click);
            // 
            // dataGridViewRol
            // 
            this.dataGridViewRol.AllowUserToAddRows = false;
            this.dataGridViewRol.AllowUserToDeleteRows = false;
            this.dataGridViewRol.AllowUserToResizeColumns = false;
            this.dataGridViewRol.AllowUserToResizeRows = false;
            this.dataGridViewRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRol.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridViewRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRol.Location = new System.Drawing.Point(12, 195);
            this.dataGridViewRol.MultiSelect = false;
            this.dataGridViewRol.Name = "dataGridViewRol";
            this.dataGridViewRol.ReadOnly = true;
            this.dataGridViewRol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRol.Size = new System.Drawing.Size(395, 147);
            this.dataGridViewRol.TabIndex = 24;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(12, 162);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(121, 27);
            this.buttonLimpiar.TabIndex = 23;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(288, 162);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(121, 27);
            this.buttonBuscar.TabIndex = 22;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // groupFiltros
            // 
            this.groupFiltros.Controls.Add(this.textPrecioBase);
            this.groupFiltros.Controls.Add(this.label2);
            this.groupFiltros.Controls.Add(this.comboEstado);
            this.groupFiltros.Controls.Add(this.labelEstado);
            this.groupFiltros.Controls.Add(this.labelDescripcion);
            this.groupFiltros.Controls.Add(this.textDescripcion);
            this.groupFiltros.Location = new System.Drawing.Point(58, 27);
            this.groupFiltros.Name = "groupFiltros";
            this.groupFiltros.Size = new System.Drawing.Size(306, 129);
            this.groupFiltros.TabIndex = 21;
            this.groupFiltros.TabStop = false;
            this.groupFiltros.Text = "Filtros de busqueda";
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(146, 91);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(120, 21);
            this.comboEstado.TabIndex = 5;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(15, 94);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 4;
            this.labelEstado.Text = "Estado";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(15, 39);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(125, 13);
            this.labelDescripcion.TabIndex = 1;
            this.labelDescripcion.Text = "Descripción del Régimen";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(146, 36);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(120, 20);
            this.textDescripcion.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeRolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaDeRolToolStripMenuItem
            // 
            this.altaDeRolToolStripMenuItem.Name = "altaDeRolToolStripMenuItem";
            this.altaDeRolToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.altaDeRolToolStripMenuItem.Text = "Alta de Régimen";
            this.altaDeRolToolStripMenuItem.Click += new System.EventHandler(this.altaDeRolToolStripMenuItem_Click);
            // 
            // textPrecioBase
            // 
            this.textPrecioBase.Location = new System.Drawing.Point(146, 62);
            this.textPrecioBase.Name = "textPrecioBase";
            this.textPrecioBase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textPrecioBase.Size = new System.Drawing.Size(120, 20);
            this.textPrecioBase.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Precio base(US$)*";
            // 
            // RegimenBajaMod
            // 
            this.AcceptButton = this.buttonBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 383);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonBaja);
            this.Controls.Add(this.dataGridViewRol);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.groupFiltros);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegimenBajaMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegimenBajaMod";
            this.Load += new System.EventHandler(this.RegimenBajaMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRol)).EndInit();
            this.groupFiltros.ResumeLayout(false);
            this.groupFiltros.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonBaja;
        private System.Windows.Forms.DataGridView dataGridViewRol;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.GroupBox groupFiltros;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altaDeRolToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox textPrecioBase;
        private System.Windows.Forms.Label label2;
    }
}