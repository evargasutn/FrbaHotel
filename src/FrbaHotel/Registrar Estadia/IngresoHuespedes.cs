using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM;
using DOM.Auxiliares;
using System.Net.Mail;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class IngresoHuespedes : Form
    {
        public IngresoHuespedes()
        {
            InitializeComponent();
        }
                
        private void IngresoHuespedes_Load(object sender, EventArgs e)
        {
            foreach (string tipo in Documento.string_docu)
                comboTipoDoc.Items.Add(tipo);
        }

        private void buttonRegistrarCliente_Click(object sender, EventArgs e)
        {
            new ABM_de_Cliente.ClienteAlta().Show();
            Globals.deshabilitarAnterior(this);
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (chequearDatos())
            {
                //Mostrar en DataGrid el Cliente
                dataGridClientes.DataSource = DAOHuesped.obtenerTabla(comboTipoDoc.SelectedItem.ToString(), Int32.Parse(textNroDoc.Text), textMail.Text);
                dataGridClientes.Columns["campoBaja"].Visible = false;
                dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridClientes.AutoResizeColumns();
                dataGridClientes.AutoResizeRows();
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool chequearDatos()
        {
            if (comboTipoDoc.SelectedIndex == -1)
            {
                showToolTip("Ingrese un tipo de documento.", comboTipoDoc, comboTipoDoc.Location);
                return false;
            }
            if (textNroDoc.Text == "")
            {
                showToolTip("Ingrese un número de documento.", textNroDoc, textNroDoc.Location);
                return false;
            }
            else if (textMail.Text == "")
            {
                showToolTip("Ingrese un email.", textMail, textMail.Location);
                return false;
            }
            else
            {
                try
                {
                    new MailAddress(textMail.Text);
                }
                catch
                {
                    showToolTip("Ingrese un email válido.", textMail, textMail.Location);
                    return false;
                }
            }
            return true;
        }

        private void textNroDoc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese números solamente", textNroDoc, textNroDoc.Location);
        }

        private void showToolTip(string msj, Control ventana, Point pos)
        {
            toolTip.Hide(ventana);
            toolTip.SetToolTip(ventana, "Entrada Invalida");
            toolTip.Show(msj, ventana, 50, 10, 5000);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            Globals.habilitarAnterior();
            ((EstadiasMain)Globals.VentanaAnterior).limpiar();
        }
    }
}
