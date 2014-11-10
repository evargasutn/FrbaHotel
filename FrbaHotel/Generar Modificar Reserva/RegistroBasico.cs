using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM.DAO;
using DOM.Dominio;
using DOM;
using DOM.Auxiliares;
namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class RegistroBasico : Form
    {
        public RegistroBasico()
        {
            InitializeComponent();
            foreach (string tipo in Documento.string_docu)
                comboTipoDoc.Items.Add(tipo);
            foreach (string pais in Globals.paises)
                comboPais.Items.Add(pais);
        }

        private Boolean camposCompletos()
        {
            if (textNombre.Text == "")
                return false;
            else if (textApellido.Text == "")
                return false;
            else if (textMail.Text == "")
                return false;
            else if (textTelefono.Text == "")
                return false;
            else if (textCalle.Text == "")
                return false;
            else if (textAltura.Text == "")
                return false;
            else if (textLocalidad.Text == "")
                return false;
            else if (textPiso.Text == "")
                return false;
            else if (textNroDoc.Text == "")
                return false;
            else if (comboTipoDoc.SelectedIndex == -1)
                return false;
            else if (comboPais.SelectedIndex == -1)
                return false;
            return true;
        }



        private void botonRegistrar_Click(object sender, EventArgs e)
        {


            if (camposCompletos())
            {
                Huesped huesped = new Huesped();
                huesped.Nombre = textNombre.Text;
                huesped.Apellido = textApellido.Text;
                huesped.TipoDocu = Documento.string_docu[comboTipoDoc.SelectedIndex];
                huesped.NroDocu = Int32.Parse(textNroDoc.Text);
                // huesped.Fecha_nacimiento;
                huesped.Mail = textMail.Text;
                huesped.Telefono = Int32.Parse(textTelefono.Text);
                huesped.Direccion.calle_direccion = textCalle.Text;
                huesped.Direccion.calle_altura = Int32.Parse(textAltura.Text);

                ////el piso y el dpto no son obligatorios
                if (textPiso.Text != "")
                    huesped.Direccion.calle_piso = Int32.Parse(textPiso.Text);
                if (textDpto.Text != "")
                    huesped.Direccion.calle_dpto = textDpto.Text;
                huesped.Localidad = textLocalidad.Text;

                huesped.Nacionalidad = (string)comboPais.SelectedItem;

                /////Se ingresa el huesped
                ////Falta ingresar el huesped en la reserva
        if (!DAOHuesped.insertar(huesped))
                {
                    MessageBox.Show("Error al crear el cliente.", "Error al crear Nuevo Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cliente Creado Correctamente.", "Nuevo Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
            }

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textNombre.Text = "";
            textApellido.Text = "";
            textMail.Text = "";
            textTelefono.Text = "";
            textCalle.Text = "";
            textAltura.Text = "";
            textLocalidad.Text = "";
            textPiso.Text = "";
            textNroDoc.Text = "";
}





    }
}
