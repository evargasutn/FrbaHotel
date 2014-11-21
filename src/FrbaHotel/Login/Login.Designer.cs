
namespace FrbaHotel.Login
{
    partial class Login
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
            this.textContrasenia = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.botonInvitado = new System.Windows.Forms.Button();
            this.botonIniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textContrasenia
            // 
            this.textContrasenia.Location = new System.Drawing.Point(132, 58);
            this.textContrasenia.Name = "textContrasenia";
            this.textContrasenia.PasswordChar = '●';
            this.textContrasenia.Size = new System.Drawing.Size(108, 20);
            this.textContrasenia.TabIndex = 11;
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(132, 28);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(108, 20);
            this.textUsuario.TabIndex = 10;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(53, 61);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(64, 13);
            this.lblContrasenia.TabIndex = 9;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(18, 35);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(99, 13);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Nombre de usuario:";
            // 
            // botonInvitado
            // 
            this.botonInvitado.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonInvitado.Location = new System.Drawing.Point(145, 107);
            this.botonInvitado.Name = "botonInvitado";
            this.botonInvitado.Size = new System.Drawing.Size(95, 31);
            this.botonInvitado.TabIndex = 7;
            this.botonInvitado.Text = "Invitado";
            this.botonInvitado.UseVisualStyleBackColor = true;
            this.botonInvitado.Click += new System.EventHandler(this.botonInvitado_Click);
            // 
            // botonIniciarSesion
            // 
            this.botonIniciarSesion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonIniciarSesion.Location = new System.Drawing.Point(12, 107);
            this.botonIniciarSesion.Name = "botonIniciarSesion";
            this.botonIniciarSesion.Size = new System.Drawing.Size(105, 31);
            this.botonIniciarSesion.TabIndex = 6;
            this.botonIniciarSesion.Text = "Iniciar Sesión";
            this.botonIniciarSesion.UseVisualStyleBackColor = true;
            this.botonIniciarSesion.Click += new System.EventHandler(this.botonIniciarSesion_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.botonIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 163);
            this.Controls.Add(this.textContrasenia);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.botonInvitado);
            this.Controls.Add(this.botonIniciarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textContrasenia;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button botonInvitado;
        private System.Windows.Forms.Button botonIniciarSesion;
    }
}