namespace FrbaHotel.ABM_de_Usuario
{
    partial class FormUser
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
            this.buttonAltaUser = new System.Windows.Forms.Button();
            this.buttonModifUser = new System.Windows.Forms.Button();
            this.buttonBajaUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAltaUser
            // 
            this.buttonAltaUser.Location = new System.Drawing.Point(64, 49);
            this.buttonAltaUser.Name = "buttonAltaUser";
            this.buttonAltaUser.Size = new System.Drawing.Size(132, 41);
            this.buttonAltaUser.TabIndex = 0;
            this.buttonAltaUser.Text = "Alta de usuario";
            this.buttonAltaUser.UseVisualStyleBackColor = true;
            this.buttonAltaUser.Click += new System.EventHandler(this.buttonAltaUser_Click);
            // 
            // buttonModifUser
            // 
            this.buttonModifUser.Location = new System.Drawing.Point(64, 111);
            this.buttonModifUser.Name = "buttonModifUser";
            this.buttonModifUser.Size = new System.Drawing.Size(132, 39);
            this.buttonModifUser.TabIndex = 1;
            this.buttonModifUser.Text = "Modificacion de usuario";
            this.buttonModifUser.UseVisualStyleBackColor = true;
            // 
            // buttonBajaUser
            // 
            this.buttonBajaUser.Location = new System.Drawing.Point(64, 172);
            this.buttonBajaUser.Name = "buttonBajaUser";
            this.buttonBajaUser.Size = new System.Drawing.Size(132, 42);
            this.buttonBajaUser.TabIndex = 2;
            this.buttonBajaUser.Text = "Baja de usuario";
            this.buttonBajaUser.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonBajaUser);
            this.Controls.Add(this.buttonModifUser);
            this.Controls.Add(this.buttonAltaUser);
            this.Name = "Form1";
            this.Text = "ABM De Usuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAltaUser;
        private System.Windows.Forms.Button buttonModifUser;
        private System.Windows.Forms.Button buttonBajaUser;
    }
}