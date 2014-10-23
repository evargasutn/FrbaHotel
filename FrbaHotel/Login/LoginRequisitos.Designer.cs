namespace FrbaHotel.Login
{
    partial class LoginRequisitos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listHoteles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listRoles = new System.Windows.Forms.ListBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listHoteles);
            this.groupBox2.Location = new System.Drawing.Point(12, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 126);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hoteles";
            // 
            // listHoteles
            // 
            this.listHoteles.FormattingEnabled = true;
            this.listHoteles.Location = new System.Drawing.Point(18, 19);
            this.listHoteles.Name = "listHoteles";
            this.listHoteles.Size = new System.Drawing.Size(129, 95);
            this.listHoteles.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccione el Hotel al que quiere entrar y el rol.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listRoles);
            this.groupBox1.Location = new System.Drawing.Point(179, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 126);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            // 
            // listRoles
            // 
            this.listRoles.FormattingEnabled = true;
            this.listRoles.Location = new System.Drawing.Point(18, 19);
            this.listRoles.Name = "listRoles";
            this.listRoles.Size = new System.Drawing.Size(129, 95);
            this.listRoles.TabIndex = 3;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(129, 182);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(97, 29);
            this.botonAceptar.TabIndex = 6;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            // 
            // LoginRequisitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 217);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonAceptar);
            this.Name = "LoginRequisitos";
            this.Text = "LoginRequisitos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listHoteles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listRoles;
        private System.Windows.Forms.Button botonAceptar;
    }
}