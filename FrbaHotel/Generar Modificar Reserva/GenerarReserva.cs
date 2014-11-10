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
namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class GenerarReserva : Form
    {
        Hotel hotel;        
        public GenerarReserva()
        {
            InitializeComponent();
                     
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (comboBoxCantPersonas.SelectedIndex!=-1 )
            {
                if (fechasCorrectas()) 
                { 
               
                }
                else
                    MessageBox.Show("Asegurese de ingresar las fechas correctamente","Error:fechas incorrectas ");
            }
            else
                MessageBox.Show("Ingrese la cantidad de clientes","Error:cantidad de clientes");

            
        }

       

        private Boolean fechasCorrectas()
        {            
            int cmpFechas=DateTime.Compare(dateTimeFechaEntrada.Value,dateTimeFechaSalida.Value);
            int cmpFechaEntr=DateTime.Compare(Globals.getFechaSistema(),dateTimeFechaEntrada.Value);
            //si fechas son igualaes 

            if (cmpFechas <= 0)
            {
                // la fecha de entrada es menor que el de salida
                if (cmpFechas < 0)
                    // la fecha de entrada es menor que el de salida
                    return true;
                else
                    // la fecha de entrada es mayor que el de salida o igual
                    return false;
            }
            else return false;///la fecha de entrada > fecha del Sistema 
        
        
        
        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {
            //se establecen las fechas
            dateTimeFechaEntrada.Format = DateTimePickerFormat.Custom;
            dateTimeFechaEntrada.CustomFormat = "dd/MM/yyyy";
            dateTimeFechaSalida.Format = DateTimePickerFormat.Custom;
            dateTimeFechaSalida.CustomFormat = "dd/MM/yyyy";
            
            //no me tira la fecha correcta tengo miedo
            //
            //
            //
            //
            textBoxFechaReserva.Text = Globals.getFechaSistema().ToString("dd/MM/yyyy");
           
            //Completamos los regimenes del hotel
            /*
             List<Regimen> regimenes=DAORegimen.obtenerByHotel(Hotel.codHotel);
             *foreach(Regimen unRegimen in regimenes)
             * comoboBoxTipoRegimen.Items.Add(unRegimen);
             * comboBoxTipoRegimen.ValueMember="descripcion"
             */
            
            



        }
    


    }
}
