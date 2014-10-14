using DOM;
namespace FrbaHotel.ABM_de_Rol
{
    partial class FormRolBaja
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
            Globals.VentanaAnterior.Enabled = true;
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
            this.marcoBusqueda = new System.Windows.Forms.GroupBox();
            this.comboFuncionalidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textRol = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.dataGridViewRol = new System.Windows.Forms.DataGridView();
            this.ColumnSelecBaja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.marcoBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRol)).BeginInit();
            this.SuspendLayout();
            // 
            // marcoBusqueda
            // 
            this.marcoBusqueda.Controls.Add(this.comboFuncionalidad);
            this.marcoBusqueda.Controls.Add(this.label2);
            this.marcoBusqueda.Controls.Add(this.label1);
            this.marcoBusqueda.Controls.Add(this.textRol);
            this.marcoBusqueda.Location = new System.Drawing.Point(35, 30);
            this.marcoBusqueda.Name = "marcoBusqueda";
            this.marcoBusqueda.Size = new System.Drawing.Size(281, 129);
            this.marcoBusqueda.TabIndex = 1;
            this.marcoBusqueda.TabStop = false;
            this.marcoBusqueda.Text = "Filtros de busqueda";
            // 
            // comboFuncionalidad
            // 
            this.comboFuncionalidad.FormattingEnabled = true;
            this.comboFuncionalidad.Location = new System.Drawing.Point(109, 63);
            this.comboFuncionalidad.Name = "comboFuncionalidad";
            this.comboFuncionalidad.Size = new System.Drawing.Size(120, 21);
            this.comboFuncionalidad.TabIndex = 3;
            this.comboFuncionalidad.SelectedIndexChanged += new System.EventHandler(this.comboDeFuncionalidades_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Funcionalidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de Rol";
            // 
            // textRol
            // 
            this.textRol.Location = new System.Drawing.Point(109, 36);
            this.textRol.Name = "textRol";
            this.textRol.Size = new System.Drawing.Size(120, 20);
            this.textRol.TabIndex = 0;
            this.textRol.TextChanged += new System.EventHandler(this.textBoxNombreRol_TextChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(25, 165);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(130, 34);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(228, 165);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(130, 34);
            this.buttonLimpiar.TabIndex = 4;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // dataGridViewRol
            // 
            this.dataGridViewRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSelecBaja});
            this.dataGridViewRol.Location = new System.Drawing.Point(19, 213);
            this.dataGridViewRol.Name = "dataGridViewRol";
            this.dataGridViewRol.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewRol.Size = new System.Drawing.Size(383, 118);
            this.dataGridViewRol.TabIndex = 5;
            this.dataGridViewRol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRol_CellContentClick);
            // 
            // ColumnSelecBaja
            // 
            this.ColumnSelecBaja.HeaderText = "Seleccionar";
            this.ColumnSelecBaja.Name = "ColumnSelecBaja";
            // 
            // FormRolBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 347);
            this.Controls.Add(this.dataGridViewRol);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.marcoBusqueda);
            this.Name = "FormRolBaja";
            this.Text = "Listado de Seleccion/Baja";
            this.Load += new System.EventHandler(this.FormLsBaja_Load);
            this.marcoBusqueda.ResumeLayout(false);
            this.marcoBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox marcoBusqueda;
        private System.Windows.Forms.ComboBox comboFuncionalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRol;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.DataGridView dataGridViewRol;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnSelecBaja;
    }
}