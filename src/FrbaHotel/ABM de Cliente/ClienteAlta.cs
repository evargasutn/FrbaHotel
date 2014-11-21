using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using DOM.DAO;
using DOM.Dominio;
using DOM;
using DOM.Auxiliares;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class ClienteAlta : Form
    {
        public ClienteAlta()
        {
            InitializeComponent();
            foreach (string tipo in Documento.string_docu)
                comboTipoDoc.Items.Add(tipo);
            foreach (string pais in Globals.paises)
                textPais.Items.Add(pais);
            limpiar();

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            toolTip.Hide(this.textApellido);
            if (chequearDatos())
            {
                Huesped huesped = new Huesped();
                huesped.Nombre = textNombre.Text;
                huesped.Apellido = textApellido.Text;
                huesped.TipoDocu = Documento.string_docu[comboTipoDoc.SelectedIndex];
                huesped.NroDocu = Int32.Parse(textNumDoc.Text);
                huesped.Fecha_nacimiento = dateTimeNacimiento.Text;
                huesped.Mail = textMail.Text;
                huesped.Telefono = Int32.Parse(textTelefono.Text);
                huesped.Direccion.calle_direccion = textDirCalle.Text;
                huesped.Direccion.calle_altura = Int32.Parse(textDirAltura.Text);
                if (textDirPiso.Text != "")
                    huesped.Direccion.calle_piso = Int32.Parse(textDirPiso.Text);
                if (textDirDpto.Text != "")
                    huesped.Direccion.calle_dpto = textDirDpto.Text;
                huesped.Localidad = textLocalidad.Text;
                huesped.Nacionalidad = (string) textPais.SelectedItem;
                if (!DAOHuesped.insertar(huesped))
                {
                    MessageBox.Show("Error al crear el cliente.", "Error al crear Nuevo Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cliente Creado Correctamente.", "Nuevo Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    ((ClienteBajaMod)Globals.VentanaAnterior).updateGrid();
                    this.Close();
                }
            }
        }

        private void textNumDoc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente numeros.", textNumDoc, textNumDoc.Location);
        }

        private void textTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente numeros.", textTelefono, textTelefono.Location);
        }

        private void textDirAltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente numeros.", textDirAltura, textDirAltura.Location);
        }

        private void textDirPiso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente numeros.", textDirPiso, textDirPiso.Location);
        }
        
        private void limpiar()
        {
            textNombre.Text = "";
            textApellido.Text = "";
            comboTipoDoc.SelectedIndex = -1;
            textNumDoc.Text = "";
            dateTimeNacimiento.Text = "";
            textMail.Text = "";
            textTelefono.Text = "";
            textDirCalle.Text = "";
            textDirAltura.Text = "";
            textDirDpto.Text = "";
            textDirPiso.Text = "";
            textLocalidad.Text = "";
            textPais.SelectedIndex = -1;
        }

        private bool chequearDatos()
        {
            if (textNombre.Text == "")
            {
                showToolTip("Ingrese un nombre valido.", textNombre, textNombre.Location);
                return false;
            }
            if (textApellido.Text == "")
            {
                showToolTip("Ingrese un apellido valido.", textApellido, textApellido.Location);
                return false;
            }
            if (comboTipoDoc.SelectedIndex < 0)
            {
                showToolTip("Seleccione un tipo de documento.", comboTipoDoc, comboTipoDoc.Location);
                return false;
            }
            if (textNumDoc.Text == "")
            {
                showToolTip("Ingrese un documento o pasaporte.", textNumDoc, textNumDoc.Location);
                return false;
            }
            if (DateTime.Parse(dateTimeNacimiento.Text) >= DateTime.Today)
            {
                showToolTip("Seleccione una fecha valida.", dateTimeNacimiento, dateTimeNacimiento.Location);
                return false;
            }
            if (textMail.Text == "")
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
                    showToolTip("Ingrese un email valido.", textMail, textMail.Location);
                    return false;
                }
            }
            if (textTelefono.Text == "(   )    -")
            {
                showToolTip("Ingrese un telefono.", textTelefono, textTelefono.Location);
                return false;
            }
            if (textDirCalle.Text == "")
            {
                showToolTip("Ingrese una calle.", textDirCalle, textDirCalle.Location);
                return false;
            }
            if (textDirAltura.Text == "")
            {
                showToolTip("Ingrese una altura.", textDirAltura, textDirAltura.Location);
                return false;
            }
            if (textLocalidad.Text == "")
            {
                showToolTip("Ingrese una localidad.", textLocalidad, textLocalidad.Location);
                return false;
            }
            if (textPais.SelectedIndex < 0)
            {
                showToolTip("Ingrese una pais.", textPais, textPais.Location);
                return false;
            }
            return true;
        }
        
        private void showToolTip(string msj, Control ventana, Point pos)
        {
            toolTip.Hide(ventana);
            toolTip.SetToolTip(ventana, "Entrada Invalida");
            toolTip.Show(msj, ventana, 50,10, 5000);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            Globals.habilitarAnterior();
        }
    }
}
