using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM.Dominio;
using DOM;
using System.Net.Mail;
using DOM.Auxiliares;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class ClienteMod : Form
    {
        Huesped huesped_seleccionado;
        public ClienteMod(int idHuesped)
        {
            InitializeComponent();
            limpiar();
            huesped_seleccionado = DAOHuesped.obtener(idHuesped);
            if (huesped_seleccionado == null)
            {
                MessageBox.Show("Error al cargar el cliente.", "Error al Modificar Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Globals.habilitarAnterior();
                this.Dispose();
            }
            foreach (string tipo in Documento.string_docu)
                comboTipoDoc.Items.Add(tipo);
            foreach (string pais in Globals.paises)
                textPais.Items.Add(pais);
            cargarDatos();
        }

        private void cargarDatos()
        {
            textNombre.Text = huesped_seleccionado.Nombre;
            textApellido.Text = huesped_seleccionado.Apellido;
            comboTipoDoc.SelectedIndex = (int)huesped_seleccionado.TipoDocu_enum;
            textNumDoc.Text = huesped_seleccionado.NroDocu.ToString();
            dateTimeNacimiento.Text = huesped_seleccionado.Fecha_nacimiento_struct.Value.ToShortDateString();
            textMail.Text = huesped_seleccionado.Mail;
            textTelefono.Text = huesped_seleccionado.Telefono.ToString();
            textDirCalle.Text = huesped_seleccionado.Direccion.calle_direccion;
            textDirAltura.Text = huesped_seleccionado.Direccion.calle_altura.ToString();
            textLocalidad.Text = huesped_seleccionado.Localidad;
            textPais.SelectedIndex = Globals.posPais(huesped_seleccionado.Nacionalidad);
            if(huesped_seleccionado.Direccion.calle_dpto != "''")
                textDirDpto.Text = huesped_seleccionado.Direccion.calle_dpto;
            if(huesped_seleccionado.Direccion.calle_piso != -1)
                textDirPiso.Text = huesped_seleccionado.Direccion.calle_piso.ToString();
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
            toolTip.SetToolTip(ventana, "Entrada Invalida");
            toolTip.Show(msj, ventana, 50, 10, 5000);
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            cargarDatos();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if(chequearDatos())
            {

                huesped_seleccionado.Nombre = textNombre.Text;
                huesped_seleccionado.Apellido = textApellido.Text;
                huesped_seleccionado.TipoDocu = comboTipoDoc.SelectedText;
                huesped_seleccionado.NroDocu = Int32.Parse(textNumDoc.Text);
                huesped_seleccionado.Fecha_nacimiento = dateTimeNacimiento.Text;
                huesped_seleccionado.Mail = textMail.Text;
                huesped_seleccionado.Telefono = Int32.Parse(textTelefono.Text);
                huesped_seleccionado.Direccion.calle_direccion = textDirCalle.Text;
                huesped_seleccionado.Direccion.calle_altura = Int32.Parse(textDirAltura.Text);
                if (textDirPiso.Text != "")
                    huesped_seleccionado.Direccion.calle_piso = Int32.Parse(textDirPiso.Text);
                if (textDirDpto.Text != "")
                    huesped_seleccionado.Direccion.calle_dpto = textDirDpto.Text;
                huesped_seleccionado.Localidad = textLocalidad.Text;
                huesped_seleccionado.Nacionalidad = (string)textPais.SelectedItem;
                if (!DAOHuesped.actualizar(huesped_seleccionado))
                {
                    MessageBox.Show("Error al modificar el huesped.", "Error al Modificar Huesped",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Huesped Modificado Correctamente.", "Modificar Huesped",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    Globals.habilitarAnterior();
                    this.Dispose();
                }
            }
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
