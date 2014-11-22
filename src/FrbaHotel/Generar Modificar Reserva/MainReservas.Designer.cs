namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class MainReservas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altaDeRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textReserva = new System.Windows.Forms.MaskedTextBox();
            this.labelReserva = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonModificar = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeRolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaDeRolToolStripMenuItem
            // 
            this.altaDeRolToolStripMenuItem.Name = "altaDeRolToolStripMenuItem";
            this.altaDeRolToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.altaDeRolToolStripMenuItem.Text = "Nueva Reserva";
            this.altaDeRolToolStripMenuItem.Click += new System.EventHandler(this.altaDeRolToolStripMenuItem_Click);
            // 
            // textReserva
            // 
            this.textReserva.Location = new System.Drawing.Point(110, 37);
            this.textReserva.Mask = "9999999999999999999";
            this.textReserva.Name = "textReserva";
            this.textReserva.Size = new System.Drawing.Size(100, 20);
            this.textReserva.TabIndex = 7;
            this.textReserva.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textReserva_MaskInputRejected);
            // 
            // labelReserva
            // 
            this.labelReserva.AutoSize = true;
            this.labelReserva.Location = new System.Drawing.Point(6, 40);
            this.labelReserva.Name = "labelReserva";
            this.labelReserva.Size = new System.Drawing.Size(98, 13);
            this.labelReserva.TabIndex = 8;
            this.labelReserva.Text = "Codigo de Reserva";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelReserva);
            this.groupBox1.Controls.Add(this.textReserva);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 78);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Reserva";
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(159, 126);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(75, 23);
            this.botonModificar.TabIndex = 10;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // MainReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 161);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Reservas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altaDeRolToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox textReserva;
        private System.Windows.Forms.Label labelReserva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.ToolTip toolTip;


    }
}