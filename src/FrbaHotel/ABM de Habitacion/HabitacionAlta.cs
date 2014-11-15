using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM;
using DOM.DAO;
using DOM.Dominio;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class HabitacionAlta : Form
    {
        Hotel hotel = Globals.infoSesion.Hotel;

        public HabitacionAlta()
        {
            InitializeComponent();
        }

        public Boolean camposCompletos(){
            if (textDescripcion.Text == "")
                return false;
            else if (textNumero.Text == "")
                return false;
            else if (textPiso.Text == "")
                return false;
            else if (comboTipoHab.SelectedItem == null)
                return false;
            else if (comboUbicacion == null)
                return false;
            return true;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {

            textDescripcion.Text = "";
            textNumero.Text = "";
            textPiso.Text = "";
            comboTipoHab.SelectedItem = null;
            comboUbicacion.SelectedItem = null;

        }

        private void HabitacionAlta_Load(object sender, EventArgs e)
        {
            comboUbicacion.Items.Add("S");
            comboUbicacion.Items.Add("N");
            comboUbicacion.SelectedIndex = 0;           
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {

            if (camposCompletos())
            {

                Habitacion nuevaHabitacion = new Habitacion();
               
                #region SeCompletaCamposDeHabitacion
                nuevaHabitacion.Id_Habitacion = Convert.ToInt32(textNumero.Text);
                nuevaHabitacion.CodHotel = hotel.CodHotel;
                nuevaHabitacion.Tipo_codigo = (int)comboTipoHab.SelectedItem;
                nuevaHabitacion.Piso = Convert.ToInt32(textPiso.Text);
                nuevaHabitacion.Ubicacion = comboTipoHab.SelectedItem.ToString();
                nuevaHabitacion.Descripcion = textDescripcion.Text;
                #endregion
                DAOHabitacion.insertar(nuevaHabitacion);

            }

            else {
                MessageBox.Show("Por favor complete los campos correctamente","Error: campos incompletos");
            }






        }

    }
}
