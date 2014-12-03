using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM;
using DOM.Dominio;
using DOM.Auxiliares;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class EstadiasMain : Form
    {
        Reserva reserva_seleccionada;
        Huesped datos_huesped;
        public EstadiasMain()
        {
            InitializeComponent();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            limpiar();
            if(textEstadia.Text == "")
            {
                showToolTip("Ingrese un número de reserva.", textEstadia, textEstadia.Location);
                return;
            }
            reserva_seleccionada = DAOReserva.obtener(Int32.Parse(textEstadia.Text));
            if (reserva_seleccionada == null)
            {
                showToolTip("Ingrese un número de reserva válido.", textEstadia, textEstadia.Location);
                return;
            }
            //DAOReserva
            if (reserva_seleccionada.Estado > 2 && reserva_seleccionada.Estado < 6)
            {
                MessageBox.Show("La reserva seleccionada se encuentra cancelada.", "", MessageBoxButtons.OK);
                return;
            }

            datos_huesped = DAOHuesped.obtener(reserva_seleccionada.Huesped);
            textHuesped.Text = datos_huesped.Nombre + " " + datos_huesped.Apellido;
            textFecReserva.Text = reserva_seleccionada.Fecha_Reserva_struct.Value.ToShortDateString();
            textFecInicio.Text = reserva_seleccionada.Fecha_Inicio_struct.Value.ToShortDateString();
            textFecFin.Text = reserva_seleccionada.Fecha_Fin_struct.Value.ToShortDateString(); 

        }

        private void botonCheckIn_Click(object sender, EventArgs e)
        {
            if (textHuesped.Text != "")
            {
                if (!reservaCancelada()) //Y de paso la cancela si no cumple
                {
                    if (reserva_seleccionada.Estado == 6) //Osea, ya tiene hecho el checkin
                    {
                        showToolTip("La reserva ya posee realizado el checkIn", botonCheckIn, botonCheckIn.Location);
                        return;
                    }
                    Estadia nueva_estadia = new Estadia();
                    nueva_estadia.CodigoReserva = reserva_seleccionada.CodigoReserva;
                    nueva_estadia.Fecha_Ingreso_struct = Globals.getFechaSistema();
                    nueva_estadia.Usuario_Ingreso = Globals.infoSesion.User;
                    if (!DAOEstadia.ingresarEntrada(nueva_estadia))
                    {
                        MessageBox.Show("Error al ingresar la reserva",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //Ponemos que se efectivizo la reserva
                    reserva_seleccionada.Estado = 6;
                    if(!DAOReserva.actualizar(reserva_seleccionada))
                    {
                        MessageBox.Show("Error al ingresar la reserva",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    MessageBox.Show("Check In realizado correctamente. A continuacion, por favor busque los huespedes en el sistema. Si los mismos no existen, registrelos.",
                        "", MessageBoxButtons.OK);

                    //Ingresamos los huespedes a alojarse
                    new IngresoHuespedes().Show();
                    Globals.deshabilitarAnterior(this);
                }
            }
            else
                showToolTip("Debe ingresar un número de reserva para poder hacer el Check In", textEstadia, textEstadia.Location);

        }

        private void botonCheckOut_Click(object sender, EventArgs e)
        {
            if (textHuesped.Text != "")
            {
                if (!reservaCancelada()) //Y de paso la cancela si no cumple
                {
                    if(reserva_seleccionada.Estado != 6)
                    {
                        MessageBox.Show("La reserva seleccionada no se encuentra efectivizada. Por favor, realize el check in primero.",
                            "", MessageBoxButtons.OK);
                        return;
                    }
                    Estadia estadia_realizada = DAOEstadia.obtener(reserva_seleccionada.CodigoReserva);
                    if (estadia_realizada.Usuario_Egreso == null)
                    {
                        estadia_realizada.Fecha_Egreso_struct = Globals.getFechaSistema();
                        estadia_realizada.Usuario_Egreso = Globals.infoSesion.User;
                        if (!DAOEstadia.ingresarSalida(estadia_realizada))
                        {
                            MessageBox.Show("Error al realizar el check out.",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("Check out realizado correctamente.",
                            "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                        MessageBox.Show("La reserva selecciona ya posee el check out realizado.",
                            "", MessageBoxButtons.OK);                        
                }
            }
            else
                showToolTip("Debe ingresar un número de reserva para poder hacer el Check Out", textEstadia, textEstadia.Location);
        }

        public void limpiar()
        {
            textHuesped.Text = "";
            textFecInicio.Text = "";
            textFecFin.Text = "";
            textFecReserva.Text = "";
        }

        private bool reservaCancelada()
        {
            if (!Globals.esElMismoDia(Globals.getFechaSistema(),(DateTime)reserva_seleccionada.Fecha_Reserva_struct))
            {
                MessageBox.Show("La reserva seleccionada se encuentra cancelada debido a que se encuentra vencida.", "", MessageBoxButtons.OK);
                if (reserva_seleccionada.Estado > 2 && reserva_seleccionada.Estado < 6)
                    return true; //Significa que ya esta dada de baja y pulso nuevamente

                //Creamos la cancelacion
                CancelacionReserva cancelacion = new CancelacionReserva();
                cancelacion.Codigo_Reserva = reserva_seleccionada.CodigoReserva;
                cancelacion.Fecha_Cancelacion_struct = Globals.getFechaSistema();
                cancelacion.Usr = Globals.infoSesion.User.Usr;
                //Le ponemos el codigo de No-Show
                List<EstadoReservas> estados = DAOReserva.obtenerEstadosReservas();
                cancelacion.Motivo = Globals.motivosBaja[2];
                for (int i = 0; i < estados.Count; i++)
                    if (estados[i].descripcion == cancelacion.Motivo)
                        cancelacion.Estado = estados[i].codEstado;
                //Actualizamos la reserva
                reserva_seleccionada.Estado = cancelacion.Estado;
                DAOReserva.actualizar(reserva_seleccionada);
                //Cancelamos la reserva
                DAOReserva.agregarCancelacion(cancelacion);
                return true;
            }
            return false;
        }
        
        private void textEstadia_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente números.", textEstadia, textEstadia.Location);
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
