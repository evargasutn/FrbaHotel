using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM.DAO;
using DOM;
using DOM.Dominio;
namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class HabitacionMod : Form
    {

        Hotel hotel = Globals.infoSesion.Hotel;

        public HabitacionMod()
        {
            InitializeComponent();
            comboUbicacion.SelectedIndex = 0;
            comboEstado.SelectedIndex = 0;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textDescripcion.Text = "";
            textNumero.Text = "";
            textPiso.Text = "";
            
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            Habitacion nuevaHabitacion = new Habitacion();
            //falta tipo de codigo
            #region SeCompletaCamposDeHabitacion
            nuevaHabitacion.Id_Habitacion = Convert.ToInt32(textNumero.Text);
            nuevaHabitacion.CodHotel = hotel.CodHotel;
            nuevaHabitacion.Tipo_codigo= 0;
            nuevaHabitacion.Ubicacion = comboUbicacion.SelectedItem.ToString();
            nuevaHabitacion.Descripcion = textDescripcion.Text;
            #endregion
            DAOHabitacion.actualizar(nuevaHabitacion);
        }






    }
}
