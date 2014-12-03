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
using DOM.Auxiliares;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class Check_In : Form
    {
        Hotel hotel = Globals.infoSesion.Hotel;
        Usuario usuario = Globals.infoSesion.User;
        public Check_In(Reserva rsv)
        {
            InitializeComponent();
        }

        private void botonRegIngreso_Click(object sender, EventArgs e)
        {
            if (camposCompletos() && existeReserva( Convert.ToInt16(textCodReserva.Text))) 
            {
                ///[*]insertar,crear estadia
                //[*]comparamos fecha, si concuerda fichamos estadía, en el otro caso se cancela la reserva
                if(1==1)
                {
              
                }
                
                else
                {                
                MessageBox.Show("El huesped ingreso posteriormente a la fecha pactada en la reserva."
                                , "Alerta:Reserva Cancelada",MessageBoxButtons.OK, MessageBoxIcon.None);
                ///[*] cancelar reserva
                    DialogResult result =MessageBox.Show("Desea hacer una nueva reserva e ingresar al hotel?",
                        "Huesped sin reserva",MessageBoxButtons.YesNo);
                    if (result==DialogResult.Yes)
                    { 
                    ///buscar lista de reservas con dias anteriores que no fueron efectivizadas, 
                    ///y cancelarlas y liberar las habitaciones                   
              
                    }




                    
                }
            }
        }


        public Boolean camposCompletos() {
            if (textCodReserva.Text == "")
            {   
                showToolTip("Ingrese el código de reserva", textCodReserva, textCodReserva.Location);
                return false;
            }
            return true;  
        }


        public Boolean existeReserva(int numeroReserva) {
            //ver existencia de la reserva
            return true;
        }


        private void Check_In_Load(object sender, EventArgs e)
        {
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
