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
using DOM.DAO;
using DOM.Auxiliares;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class ModificarReserva : Form
    {
        Hotel hotel = Globals.infoSesion.Hotel;
        Reserva reserva_elegida;
        List<Regimen> lista_regimenes;
        List<Tipo_Habitacion> tipos_habitacion;
        Regimen regimen_elegido;
        Tipo_Habitacion tipo_elegido;

        public ModificarReserva(Reserva reserva)
        {
            InitializeComponent();
            reserva_elegida = reserva;
        }

        private void ModificarReserva_Load(object sender, EventArgs e)
        {
            textNroReserva.Text = reserva_elegida.CodigoReserva.ToString();
            Huesped huesped = DAOHuesped.obtener(reserva_elegida.Huesped);
            if (huesped == null)
            {
                MessageBox.Show("Error al obtener los datos de la Base de Datos. Se volverá a la ventana anterior.",
                "", MessageBoxButtons.OK);
                this.Close();
                return;
            }
            textHuesped.Text = huesped.Nombre + " " + huesped.Apellido;
            lista_regimenes = DAORegimen.obtenerByHotel(hotel.CodHotel);
            tipos_habitacion = DAOHabitacion.obtenerTipoTodos();
            //Rellenar Regimenes
            foreach (Tipo_Habitacion tipo in tipos_habitacion)
                comboTipoHab.Items.Add(tipo.Descripcion);
            //Rellenar Tipo Habitacion
            foreach (Regimen reg in lista_regimenes)
                comboTipoRegimen.Items.Add(reg.Descripcion);
            limpiarDatos();
        }

        private void limpiarDatos()
        {
            dateTimeInicio.Value = (DateTime) reserva_elegida.Fecha_Inicio_struct;
            dateTimeFin.Value = (DateTime) reserva_elegida.Fecha_Fin_struct;
            //Faltan cargar los demas datos
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void botonDisponibilidad_Click(object sender, EventArgs e)
        {

        }

        private void botonModificar_Click(object sender, EventArgs e)
        {

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
