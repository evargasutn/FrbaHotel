using DOM;
namespace FrbaHotel.ABM_de_Rol
{
    partial class FormRolModBaja
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
            Globals.habilitarAnterior();
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
            this.groupFiltros = new System.Windows.Forms.GroupBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboFuncionalidad = new System.Windows.Forms.ComboBox();
            this.labelFuncionalidad = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.textRol = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.dataGridViewRol = new System.Windows.Forms.DataGridView();
            this.ColumnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Baja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.titulo = new System.Windows.Forms.Label();
            this.altaDeRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRol)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFiltros
            // 
            this.groupFiltros.Controls.Add(this.comboEstado);
            this.groupFiltros.Controls.Add(this.label3);
            this.groupFiltros.Controls.Add(this.comboFuncionalidad);
            this.groupFiltros.Controls.Add(this.labelFuncionalidad);
            this.groupFiltros.Controls.Add(this.labelRol);
            this.groupFiltros.Controls.Add(this.textRol);
            this.groupFiltros.Location = new System.Drawing.Point(12, 55);
            this.groupFiltros.Name = "groupFiltros";
            this.groupFiltros.Size = new System.Drawing.Size(397, 129);
            this.groupFiltros.TabIndex = 0;
            this.groupFiltros.TabStop = false;
            this.groupFiltros.Text = "Filtros de busqueda";
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(109, 97);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(120, 21);
            this.comboEstado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado";
            // 
            // comboFuncionalidad
            // 
            this.comboFuncionalidad.FormattingEnabled = true;
            this.comboFuncionalidad.Location = new System.Drawing.Point(109, 63);
            this.comboFuncionalidad.Name = "comboFuncionalidad";
            this.comboFuncionalidad.Size = new System.Drawing.Size(120, 21);
            this.comboFuncionalidad.TabIndex = 3;
            // 
            // labelFuncionalidad
            // 
            this.labelFuncionalidad.AutoSize = true;
            this.labelFuncionalidad.Location = new System.Drawing.Point(15, 71);
            this.labelFuncionalidad.Name = "labelFuncionalidad";
            this.labelFuncionalidad.Size = new System.Drawing.Size(73, 13);
            this.labelFuncionalidad.TabIndex = 2;
            this.labelFuncionalidad.Text = "Funcionalidad";
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Location = new System.Drawing.Point(15, 39);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(78, 13);
            this.labelRol.TabIndex = 1;
            this.labelRol.Text = "Nombre de Rol";
            // 
            // textRol
            // 
            this.textRol.Location = new System.Drawing.Point(109, 36);
            this.textRol.Name = "textRol";
            this.textRol.Size = new System.Drawing.Size(120, 20);
            this.textRol.TabIndex = 0;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(12, 190);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(121, 27);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(288, 190);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(121, 27);
            this.buttonLimpiar.TabIndex = 3;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
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
            this.dataGridViewRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSeleccionar,
            this.Baja});
            this.dataGridViewRol.Location = new System.Drawing.Point(12, 223);
            this.dataGridViewRol.Name = "dataGridViewRol";
            this.dataGridViewRol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewRol.Size = new System.Drawing.Size(397, 221);
            this.dataGridViewRol.TabIndex = 4;
            this.dataGridViewRol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRol_CellContentClick);
            // 
            // ColumnSeleccionar
            // 
            this.ColumnSeleccionar.HeaderText = "Modificar";
            this.ColumnSeleccionar.Name = "ColumnSeleccionar";
            this.ColumnSeleccionar.ReadOnly = true;
            // 
            // Baja
            // 
            this.Baja.HeaderText = "Baja";
            this.Baja.Name = "Baja";
            this.Baja.ReadOnly = true;
            // 
            // titulo
            // 
            this.titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(12, 24);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(389, 28);
            this.titulo.TabIndex = 6;
            this.titulo.Text = "Modificación/Baja de Roles";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // altaDeRolToolStripMenuItem
            // 
            this.altaDeRolToolStripMenuItem.Name = "altaDeRolToolStripMenuItem";
            this.altaDeRolToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.altaDeRolToolStripMenuItem.Text = "Alta de Rol";
            this.altaDeRolToolStripMenuItem.Click += new System.EventHandler(this.altaDeRolToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeRolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(421, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // FormRolModBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 456);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.dataGridViewRol);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.groupFiltros);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRolModBaja";
            this.Text = "Gestion de Roles";
            this.groupFiltros.ResumeLayout(false);
            this.groupFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRol)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupFiltros;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.TextBox textRol;
        private System.Windows.Forms.ComboBox comboFuncionalidad;
        private System.Windows.Forms.Label labelFuncionalidad;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.DataGridView dataGridViewRol;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Baja;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnSeleccionar;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ToolStripMenuItem altaDeRolToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;


    }
}