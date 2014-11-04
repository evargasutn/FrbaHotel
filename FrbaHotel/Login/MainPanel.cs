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
namespace FrbaHotel.Login
{
    public partial class MainPanel : Form
    {

        List<Funcionalidad> funcsDelRolDelUser;
        Usuario usuario;
        String hotelNombre;



        public MainPanel(Usuario usuario, String hotelNombre, String rolNombre)
        {
            InitializeComponent();
            funcsDelRolDelUser = DAOFuncionalidad.getFuncionalidad(rolNombre);
            foreach (Funcionalidad unFuncs in funcsDelRolDelUser)
                listFuncionalidades.Items.Add(unFuncs.Descripcion);

        }
        public MainPanel()   ///Para invitados
        {
            InitializeComponent();
            ///cargar list funcionalidades para invitados
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            var funcionalidadElegida = listFuncionalidades.SelectedItem;
            if (funcionalidadElegida != null)
                abrirFormulario(funcionalidadElegida.ToString());
            else MessageBox.Show("Seleccione una funcionalidad", "Error no selecciono funcionalidad");
        }




        private void abrirFormulario(string unaFuncionalidad)
        {

            switch (unaFuncionalidad)
            {

                case "ABM de Rol":
                    new ABM_de_Rol.RolAlta().Show();
                    break;

                case "ABM de Usuario":
                    new ABM_de_Usuario.UsuarioAlta().Show();
                    break;

                case "ABM de Huespedes":
                    new ABM_de_Cliente.ClienteAlta().Show();
                    break;

                case "ABM de Hotel":
                    new ABM_de_Hotel.HotelAlta().Show();
                    break;

                case "ABM de Habitacion":
                    new ABM_de_Habitacion.HabitacionAlta().Show();
                    break;

                case "ABM de Regimen":
                    new ABM_de_Regimen.RegimenAlta().Show();
                    break;

                case "Generar o Modificar una Reserva":
                    new Generar_Modificar_Reserva.GenerarReserva().Show();
                    break;
                case "Cancelar Reserva":
                    new Cancelar_Reserva.CancelarReserva(usuario, hotelNombre).Show();
                    break;

                case "Registrar Estadia":
                    new Registrar_Estadia.Check_In().Show();
                    break;

                case "Registrar Consumibles":
                    new Registrar_Consumible.RegistrarConsumibles().Show();
                    break;

                /*Falta ABM facturar*/

                case "Listado Estadistico":
                    new Listado_Estadistico.ListadoEstadistico().Show() ;
                    break;

            }

        }



    }
}
