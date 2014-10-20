namespace FrbaHotel
{
    partial class Inicial
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
            this.botonIniciarSesion = new System.Windows.Forms.Button();
            this.botonInvitado = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textContrasenia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonIniciarSesion
            // 
            this.botonIniciarSesion.Location = new System.Drawing.Point(32, 123);
            this.botonIniciarSesion.Name = "botonIniciarSesion";
            this.botonIniciarSesion.Size = new System.Drawing.Size(105, 31);
            this.botonIniciarSesion.TabIndex = 0;
            this.botonIniciarSesion.Text = "Iniciar Sesión";
            this.botonIniciarSesion.UseVisualStyleBackColor = true;
            this.botonIniciarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonInvitado
            // 
            this.botonInvitado.Location = new System.Drawing.Point(165, 123);
            this.botonInvitado.Name = "botonInvitado";
            this.botonInvitado.Size = new System.Drawing.Size(95, 31);
            this.botonInvitado.TabIndex = 1;
            this.botonInvitado.Text = "Invitado";
            this.botonInvitado.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(38, 51);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(99, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Nombre de usuario:";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(73, 77);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(64, 13);
            this.lblContrasenia.TabIndex = 3;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(152, 44);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(108, 20);
            this.textUsuario.TabIndex = 4;
            // 
            // textContrasenia
            // 
            this.textContrasenia.Location = new System.Drawing.Point(152, 74);
            this.textContrasenia.Name = "textContrasenia";
            this.textContrasenia.Size = new System.Drawing.Size(108, 20);
            this.textContrasenia.TabIndex = 5;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.textContrasenia);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.botonInvitado);
            this.Controls.Add(this.botonIniciarSesion);
            this.Name = "Inicial";
            this.Text = "Inicio de Sesión";
            this.Load += new System.EventHandler(this.Inicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonIniciarSesion;
        private System.Windows.Forms.Button botonInvitado;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textContrasenia;
    }
}

