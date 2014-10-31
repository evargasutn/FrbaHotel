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

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class HotelAlta : Form
    {
        Hotel hotelNuevo = new Hotel();


        public HotelAlta()
        {
            InitializeComponent();
        }



        public void completarEstructura() {

            hotelNuevo.Nombre = textNombre.Text;
            hotelNuevo.Mail = textMail.Text;
            hotelNuevo.Telefono = Convert.ToInt32(textTelefono.Text);
            hotelNuevo.Direccion.calle_altura = Convert.ToInt32(textDirAltura.Text);
            hotelNuevo.Direccion.calle_direccion = textDirCalle.Text;
            hotelNuevo.Estrellas = Convert.ToInt32(comboCantEstrellas.SelectedItem);
            //hotelNuevo.Fecha_creacion =(string)fecha del sistema;
            hotelNuevo.Ciudad = textCiudad.Text;
            hotelNuevo.Pais = textPais.Text;
        }
       

        private Boolean camposCompletos()
        {
            // all field are obligatories
            if (textNombre.Text == "")
                return false;
            else if (textMail.Text == "")
                return false;
            else if (textTelefono.Text == "")
                return false;
            else if (textDirCalle.Text == "")
                return false;
            else if (textDirAltura.Text == "")
                return false;
            else if (textCiudad.Text == "")
                return false;
            else if (textPais.Text == "")
                return false;
            else if (listaRegimenes.SelectedItems == null)
                return false;
            return true;
        }



        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textNombre.Text = "";
            textMail.Text = "";
            textTelefono.Text = "";
            textDirCalle.Text = "";
            textDirAltura.Text = "";
            comboCantEstrellas.SelectedItem = null;
            textCiudad.Text = "";
            textPais.Text = "";
            for (int item = 0; item < listaRegimenes.Items.Count; item++)
                listaRegimenes.SetItemChecked(item, false);

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (camposCompletos())
            {
                completarEstructura();
                DAOHotel.insertar(hotelNuevo);///falta el dataTime
                foreach (var unRegimen in listaRegimenes.SelectedItems)
                    unRegimen.ToString();




            }
            else MessageBox.Show("Por favor complete todos los campos","Error:campos incompletos");
        }
    }
}
