namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class ListarRegimenes
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
            this.dataGridRegimen = new System.Windows.Forms.DataGridView();
            this.botonSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegimen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRegimen
            // 
            this.dataGridRegimen.AllowUserToAddRows = false;
            this.dataGridRegimen.AllowUserToDeleteRows = false;
            this.dataGridRegimen.AllowUserToResizeColumns = false;
            this.dataGridRegimen.AllowUserToResizeRows = false;
            this.dataGridRegimen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRegimen.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridRegimen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegimen.Location = new System.Drawing.Point(12, 12);
            this.dataGridRegimen.MultiSelect = false;
            this.dataGridRegimen.Name = "dataGridRegimen";
            this.dataGridRegimen.ReadOnly = true;
            this.dataGridRegimen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridRegimen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRegimen.Size = new System.Drawing.Size(399, 186);
            this.dataGridRegimen.TabIndex = 5;
            // 
            // botonSeleccionar
            // 
            this.botonSeleccionar.Location = new System.Drawing.Point(12, 204);
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.Size = new System.Drawing.Size(399, 23);
            this.botonSeleccionar.TabIndex = 6;
            this.botonSeleccionar.Text = "Seleccionar";
            this.botonSeleccionar.UseVisualStyleBackColor = true;
            this.botonSeleccionar.Click += new System.EventHandler(this.botonSeleccionar_Click);
            // 
            // ListarRegimenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 238);
            this.Controls.Add(this.botonSeleccionar);
            this.Controls.Add(this.dataGridRegimen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListarRegimenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regímenes Disponibles";
            this.Load += new System.EventHandler(this.ListarRegimenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegimen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRegimen;
        private System.Windows.Forms.Button botonSeleccionar;
    }
}