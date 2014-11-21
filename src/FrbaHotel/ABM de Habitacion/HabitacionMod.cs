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
        Habitacion habitacion;
        public HabitacionMod(int codHabitacion)
        {
            InitializeComponent();
            habitacion = DAOHabitacion.obtener(codHabitacion, hotel.CodHotel);
        }

        private void HabitacionMod_Load(object sender, EventArgs e)
        {

            comboUbicacion.Items.Add("N");
            comboUbicacion.Items.Add("S");
            comboEstado.Items.Add("Habilitado");
            comboEstado.Items.Add("Deshabilitado");
        }

        private void limpiarDatos()
        {
            textNumero.Text = habitacion.Id_Habitacion.ToString();
            textPiso.Text = habitacion.Piso.ToString();
            textDescripcion.Text = habitacion.Descripcion;

            //Combo Estado

            //Seleccionar Tipo

            //Seleccionar Ubicacion

            
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
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
             nuevaHabitacion.CampoBaja=(comboUbicacion.SelectedItem.ToString()=="Habilitado")?true:false;
            #endregion //QUE ASCO DE CODIGO!! QUIEN FUE EL HDP JAJAJA - TOMAS 21/11
            DAOHabitacion.actualizar(nuevaHabitacion);
        }

        private void textNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solo números.", textNumero, textNumero.Location);
        }

        private void textPiso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solo números.", textPiso, textPiso.Location);
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
        }
    }
}
