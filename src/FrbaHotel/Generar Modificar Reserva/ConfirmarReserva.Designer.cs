﻿namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class ConfirmarReserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.textCostoReserva = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textNroDoc = new System.Windows.Forms.MaskedTextBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.buttonRegistrarCliente = new System.Windows.Forms.Button();
            this.textMail = new System.Windows.Forms.TextBox();
            this.comboTipoDoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonConfirmar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "El costo total de la reserva es:";
            // 
            // textCostoReserva
            // 
            this.textCostoReserva.Location = new System.Drawing.Point(229, 38);
            this.textCostoReserva.Name = "textCostoReserva";
            this.textCostoReserva.ReadOnly = true;
            this.textCostoReserva.Size = new System.Drawing.Size(162, 20);
            this.textCostoReserva.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNroDoc);
            this.groupBox1.Controls.Add(this.botonBuscar);
            this.groupBox1.Controls.Add(this.dataGridClientes);
            this.groupBox1.Controls.Add(this.buttonRegistrarCliente);
            this.groupBox1.Controls.Add(this.textMail);
            this.groupBox1.Controls.Add(this.comboTipoDoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 283);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente registrado";
            // 
            // textNroDoc
            // 
            this.textNroDoc.Location = new System.Drawing.Point(128, 45);
            this.textNroDoc.Mask = "99999999999999999";
            this.textNroDoc.Name = "textNroDoc";
            this.textNroDoc.Size = new System.Drawing.Size(137, 20);
            this.textNroDoc.TabIndex = 8;
            this.textNroDoc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textNroDoc_MaskInputRejected);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(399, 241);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(117, 33);
            this.botonBuscar.TabIndex = 7;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            this.dataGridClientes.AllowUserToResizeColumns = false;
            this.dataGridClientes.AllowUserToResizeRows = false;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(6, 95);
            this.dataGridClientes.MultiSelect = false;
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientes.Size = new System.Drawing.Size(510, 140);
            this.dataGridClientes.TabIndex = 0;
            // 
            // buttonRegistrarCliente
            // 
            this.buttonRegistrarCliente.Location = new System.Drawing.Point(332, 19);
            this.buttonRegistrarCliente.Name = "buttonRegistrarCliente";
            this.buttonRegistrarCliente.Size = new System.Drawing.Size(184, 66);
            this.buttonRegistrarCliente.TabIndex = 4;
            this.buttonRegistrarCliente.Text = "Registrar nuevo cliente";
            this.buttonRegistrarCliente.UseVisualStyleBackColor = true;
            this.buttonRegistrarCliente.Click += new System.EventHandler(this.buttonRegistrarCliente_Click);
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(128, 69);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(138, 20);
            this.textMail.TabIndex = 6;
            // 
            // comboTipoDoc
            // 
            this.comboTipoDoc.FormattingEnabled = true;
            this.comboTipoDoc.Location = new System.Drawing.Point(128, 21);
            this.comboTipoDoc.Name = "comboTipoDoc";
            this.comboTipoDoc.Size = new System.Drawing.Size(137, 21);
            this.comboTipoDoc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mail*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Número de documento*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de documento*";
            // 
            // botonConfirmar
            // 
            this.botonConfirmar.Location = new System.Drawing.Point(15, 404);
            this.botonConfirmar.Name = "botonConfirmar";
            this.botonConfirmar.Size = new System.Drawing.Size(516, 33);
            this.botonConfirmar.TabIndex = 3;
            this.botonConfirmar.Text = "Confirmar reserva";
            this.botonConfirmar.UseVisualStyleBackColor = true;
            this.botonConfirmar.Click += new System.EventHandler(this.botonConfirmar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(510, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Por favor buscar cliente para confirmar, en caso de no encontrarse en la planilla" +
                " registre\r\n al cliente previa confirmación.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.label5);
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(15, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 38);
            this.panel1.TabIndex = 6;
            // 
            // ConfirmarReserva
            // 
            this.AcceptButton = this.botonBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.botonConfirmar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textCostoReserva);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConfirmarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmacion de reserva";
            this.Load += new System.EventHandler(this.ConfirmarReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCostoReserva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.ComboBox comboTipoDoc;
        private System.Windows.Forms.Button botonConfirmar;
        private System.Windows.Forms.Button buttonRegistrarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.MaskedTextBox textNroDoc;
        private System.Windows.Forms.ToolTip toolTip;
    }
}