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
        bool datos_alterados;
        bool hab_confirmadas;
        int cantPersonas_originales;
        List<Detalle_Reserva> detallesAremover = new List<Detalle_Reserva>();
        Reserva nueva_reserva;

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
            regimen_elegido = DAORegimen.obtener(reserva_elegida.CodigoRegimen);

            tipos_habitacion = DAOHabitacion.obtenerTipoTodos();
            tipo_elegido = DAOHabitacion.obtenerTipoByReserva(reserva_elegida.CodigoReserva);

            //Rellenar Tipo Habitacion
            foreach (Tipo_Habitacion tipo in tipos_habitacion)
                comboTipoHab.Items.Add(tipo.Descripcion);
            //Rellenar Regimenes
            foreach (Regimen reg in lista_regimenes)
                comboTipoRegimen.Items.Add(reg.Descripcion);
            limpiarDatos();
        }

        private void limpiarDatos()
        {
            dateTimeInicio.Value = (DateTime) reserva_elegida.Fecha_Inicio_struct;
            dateTimeFin.Value = (DateTime) reserva_elegida.Fecha_Fin_struct;


            for (int i = 0; i < comboTipoHab.Items.Count; i++)
                if ((string)comboTipoHab.Items[i] == tipo_elegido.Descripcion)
                    comboTipoHab.SelectedIndex = i;
            for (int i = 0; i < comboTipoRegimen.Items.Count; i++)
                if ((string)comboTipoRegimen.Items[i] == regimen_elegido.Descripcion)
                    comboTipoRegimen.SelectedIndex = i;
            cantPersonas_originales = DAOHabitacion.obtenerCantHabitacionesByReserva(reserva_elegida.CodigoReserva);
            textCant.Text = cantPersonas_originales.ToString();
            textPrecio.Text = Globals.obtenerPrecio(regimen_elegido.CodRegimen, cantPersonas_originales,
                Globals.infoSesion.Hotel.Recargo).ToString();
            datos_alterados = false;
            hab_confirmadas = false;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void botonDisponibilidad_Click(object sender, EventArgs e)
        {
            if (!datos_alterados)
            {
                showToolTip("Hay disponibilidad ya que no se modificaron los datos.", botonDisponibilidad, botonDisponibilidad.Location);
                return;
            }
            if (chequearDatos())
            {
                nueva_reserva = duplicarReserva(reserva_elegida);
                nueva_reserva.Fecha_Inicio_struct = dateTimeInicio.Value;
                nueva_reserva.Fecha_Fin_struct = dateTimeFin.Value;
                nueva_reserva.tipo_habitacion = tipos_habitacion[comboTipoHab.SelectedIndex];
                nueva_reserva.CodigoRegimen = lista_regimenes[comboTipoRegimen.SelectedIndex].CodRegimen;
                int cantPersonas = Int32.Parse(textCant.Text);
                //Si se mantiene el tipo de habitacion, entonces solo tenemos que agregar o retirar habitaciones, que no sean las originales
                if (tipo_elegido.TipoCodigo == nueva_reserva.tipo_habitacion.TipoCodigo)
                    cantPersonas = cantPersonas - cantPersonas_originales;                
                
                List<Habitacion> habitaciones_disponibles;
                habitaciones_disponibles = DAOReserva.habitacionDisponibles(Globals.infoSesion.Hotel.CodHotel,
                    nueva_reserva.tipo_habitacion.TipoCodigo,
                    nueva_reserva.Fecha_Inicio, nueva_reserva.Fecha_Fin);
                int cantAreservar = cantPersonas / nueva_reserva.tipo_habitacion.CantPersonas;
                if (habitaciones_disponibles.Count < cantAreservar)
                {
                    MessageBox.Show("No existen suficientes habitaciones disponibles para efectuar la reserva.",
                    "", MessageBoxButtons.OK);
                    return;
                }

                //Si es que faltan habitaciones (Tanto se mantenga o no el tipo de habitacion)
                for (int i = 0; i < cantAreservar; i++)
                {
                    Detalle_Reserva det = new Detalle_Reserva();
                    det.CodigoHotel = Globals.infoSesion.Hotel.CodHotel;
                    det.CodigoReserva = reserva_elegida.CodigoReserva;
                    det.Habitacion = habitaciones_disponibles[i].Id_Habitacion;
                    nueva_reserva.detalles_reserva.Add(det);
                }
                //Si es que sobran habitaciones (Si el tipo de habitacion se cambia, el numero es negativo y no cicla y queda vacio)
                for (int i = 0; i < -cantAreservar; i++)
                {
                    Detalle_Reserva det = new Detalle_Reserva();
                    det.CodigoHotel = Globals.infoSesion.Hotel.CodHotel;
                    det.CodigoReserva = reserva_elegida.CodigoReserva;
                    det.Habitacion = habitaciones_disponibles[i].Id_Habitacion;
                    detallesAremover.Add(det);
                }
                textPrecio.Text = Globals.obtenerPrecio(nueva_reserva.CodigoRegimen, cantPersonas + cantPersonas_originales,
                    Globals.infoSesion.Hotel.Recargo).ToString();
                //Simamos la cantPersonas_originales para obtener la cantidad total de personas ingresadas y no tener que levantar todo de nuevo
                MessageBox.Show("Hay disponibilidad para modificar la reserva.",
                "", MessageBoxButtons.OK);
                hab_confirmadas = true;
            }
        }
        private bool chequearDatos()
        {
            if (dateTimeInicio.Value == null)
            {
                showToolTip("Seleccione una fecha de Entrada.", dateTimeInicio, dateTimeInicio.Location);
                return false;
            }
            if (dateTimeFin.Value == null)
            {
                showToolTip("Seleccione una fecha de Salida.", dateTimeFin, dateTimeFin.Location);
                return false;
            }
            if (dateTimeInicio.Value.CompareTo(dateTimeFin.Value) >= 0)
            {
                showToolTip("Seleccione un rango de fechas válido.", dateTimeInicio, dateTimeInicio.Location);
                return false;
            }
            if (reserva_elegida.Fecha_Reserva_struct.Value.CompareTo(dateTimeInicio.Value) >= 0)
            {
                showToolTip("Seleccione un rango de fechas válido.", dateTimeInicio, dateTimeInicio.Location);
                return false;
            }
            if (comboTipoHab.SelectedIndex == -1)
            {
                showToolTip("Seleccione un tipo de habitacion a reservar", comboTipoHab, comboTipoHab.Location);
                return false;
            }
            if (textCant.Text == "")
            {
                showToolTip("Ingrese la cantidad de huéspedes de la reserva.", textCant, textCant.Location);
                return false;
            }
            if (comboTipoRegimen.SelectedIndex == -1)
            {
                showToolTip("Seleccione un tipo de régimen a reservar", comboTipoRegimen, comboTipoRegimen.Location);
                return false;
            }
            return true;
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            if(!datos_alterados)
            {
                showToolTip("Primero chequee disponibilidad ya que se modificaron los datos.", botonModificar, botonModificar.Location);
                return;
            }
            if (hab_confirmadas)
            {
                //Cambiamos el estado de la reserva a modificada
                List<EstadoReservas> estados = DAOReserva.obtenerEstadosReservas();
                foreach (EstadoReservas estado in estados)
                    if (estado.descripcion == "Reserva modificada")
                        nueva_reserva.Estado = estado.codEstado;

                //Actualizamos la reserva
                if (!DAOReserva.actualizar(nueva_reserva))
                {
                    MessageBox.Show("Error al modificar la reserva.",
                    "", MessageBoxButtons.OK);
                    return;
                }
                if (tipo_elegido.TipoCodigo == nueva_reserva.tipo_habitacion.TipoCodigo)
                {
                    if (detallesAremover.Count != 0)
                        foreach (Detalle_Reserva detalle in detallesAremover)
                            DAOReserva.quitarHabitacion(detalle);
                    else
                        foreach (Detalle_Reserva detalle in nueva_reserva.detalles_reserva)
                            DAOReserva.agregarHabitacion(detalle);
                }
                else
                {
                    //Quitar TODOS los detalles_Reservas ya existentes
                    DAOReserva.quitarTodasHabitaciones(nueva_reserva.CodigoReserva);

                    //Agregar los nuevos de nueva_reserva
                    foreach (Detalle_Reserva detalle in nueva_reserva.detalles_reserva)
                        DAOReserva.agregarHabitacion(detalle);
                }
                MessageBox.Show("Reserva modificada Correctamente.",
                    "", MessageBoxButtons.OK);
                this.Close();

            }
            else
                showToolTip("No se han modificado ninguno de los valores de la reserva.", botonModificar, botonModificar.Location);

        }

        private Reserva duplicarReserva(Reserva reserva_elegida)
        {
            Reserva reserva = new Reserva();
            reserva.CodigoReserva = reserva_elegida.CodigoReserva;
            reserva.CodigoRegimen = reserva_elegida.CodigoRegimen;
            reserva.Estado = reserva_elegida.Estado;
            reserva.Fecha_Fin_struct = reserva_elegida.Fecha_Fin_struct;
            reserva.Fecha_Inicio_struct = reserva_elegida.Fecha_Inicio_struct;
            reserva.Fecha_Reserva_struct = reserva_elegida.Fecha_Reserva_struct;
            reserva.Huesped = reserva_elegida.Huesped;
            reserva.Usr = reserva_elegida.Usr;

            return reserva;
        }
        
        private void dateTimeInicio_ValueChanged(object sender, EventArgs e)
        {
            datos_alterados = true;
        }

        private void dateTimeFin_ValueChanged(object sender, EventArgs e)
        {
            datos_alterados = true;        
        }

        private void comboTipoHab_SelectedIndexChanged(object sender, EventArgs e)
        {
            datos_alterados = true;        
        }

        private void comboTipoRegimen_SelectedIndexChanged(object sender, EventArgs e)
        {
            datos_alterados = true;        
        }

        private void textCant_TextChanged(object sender, EventArgs e)
        {
            datos_alterados = true;        
        }

        private void textCant_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente números.", textCant, textCant.Location);
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
