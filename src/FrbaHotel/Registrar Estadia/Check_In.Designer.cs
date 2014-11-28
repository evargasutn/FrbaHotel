namespace FrbaHotel.Registrar_Estadia
{
    partial class Check_In
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_In));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonRegIngreso = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textFechaEvento = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textCodReserva = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar entrada ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(28, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(540, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // botonRegIngreso
            // 
            this.botonRegIngreso.Location = new System.Drawing.Point(12, 203);
            this.botonRegIngreso.Name = "botonRegIngreso";
            this.botonRegIngreso.Size = new System.Drawing.Size(120, 29);
            this.botonRegIngreso.TabIndex = 7;
            this.botonRegIngreso.Text = "Registrar ingreso";
            this.botonRegIngreso.UseVisualStyleBackColor = true;
            this.botonRegIngreso.Click += new System.EventHandler(this.botonRegIngreso_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textFechaEvento);
            this.groupBox3.Controls.Add(this.textUser);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(16, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 72);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos para la Estadia";
            // 
            // textFechaEvento
            // 
            this.textFechaEvento.Location = new System.Drawing.Point(104, 38);
            this.textFechaEvento.Name = "textFechaEvento";
            this.textFechaEvento.ReadOnly = true;
            this.textFechaEvento.Size = new System.Drawing.Size(111, 20);
            this.textFechaEvento.TabIndex = 3;
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(104, 13);
            this.textUser.Name = "textUser";
            this.textUser.ReadOnly = true;
            this.textUser.Size = new System.Drawing.Size(111, 20);
            this.textUser.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha de ingreso*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Código de Reserva*";
            // 
            // textCodReserva
            // 
            this.textCodReserva.Location = new System.Drawing.Point(120, 177);
            this.textCodReserva.Name = "textCodReserva";
            this.textCodReserva.Size = new System.Drawing.Size(111, 20);
            this.textCodReserva.TabIndex = 10;
            // 
            // Check_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 248);
            this.Controls.Add(this.textCodReserva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.botonRegIngreso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Check_In";
            this.Text = "Check In";
            this.Load += new System.EventHandler(this.Check_In_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonRegIngreso;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textFechaEvento;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCodReserva;
        private System.Windows.Forms.ToolTip toolTip;
    }
}