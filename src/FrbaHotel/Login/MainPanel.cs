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
        Usuario usuario = Globals.infoSesion.User;
        Hotel hotel = Globals.infoSesion.Hotel;
        Rol rol = Globals.infoSesion.Rol;

        public MainPanel()
        {
            InitializeComponent();
            funcsDelRolDelUser = DAOFuncionalidad.getFuncionalidad(rol.Nombre);
            foreach (Funcionalidad unFuncs in funcsDelRolDelUser)
                comboFuncionalidades.Items.Add(unFuncs);
            comboFuncionalidades.ValueMember="Descripcion";
            comboFuncionalidades.SelectedIndex = 0;
        }
        

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            Funcionalidad funcionalidadElegida = (Funcionalidad)comboFuncionalidades.SelectedItem;
            if (funcionalidadElegida != null)
                abrirFormulario(funcionalidadElegida.Descripcion);
            else MessageBox.Show("Seleccione una funcionalidad", "Error no selecciono funcionalidad");
        }




        private void abrirFormulario(string unaFuncionalidad)
        {

            switch (unaFuncionalidad)
            {

                case "ABM de Rol":
                    new ABM_de_Rol.RolBajaMod().Show();
                    break;

                case "ABM de Usuario":
                    new ABM_de_Usuario.UsuarioBajaMod().Show();
                    break;

                case "ABM de Huespedes":
                    new ABM_de_Cliente.ClienteBajaMod().Show();
                    break;

                case "ABM de Hotel":
                    new ABM_de_Hotel.HotelBajaMod().Show();
                    break;

                case "ABM de Habitacion":
                    new ABM_de_Habitacion.HabitacionBajaMod().Show();
                    break;

                case "ABM de Regimen":
                    new ABM_de_Regimen.RegimenBajaMod().Show();
                    break;

                case "Generar o Modificar una Reserva":
                    new Generar_Modificar_Reserva.GenerarReserva().Show();
                    break;
                case "Cancelar Reserva":
                    new Cancelar_Reserva.CancelarReserva(usuario, "ww").Show();
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
            Globals.deshabilitarAnterior(this);

        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            textHotel.Enabled = false;
            textRol.Enabled = false;
            textUser.Enabled = false;
            textHotel.Text = hotel.Nombre;
            textRol.Text = rol.Nombre;

            if (usuario != null)
                textUser.Text = usuario.Usr;
            else
            {
                textUser.Visible = false;
                label2.Text = "Invitado";
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold); 
            }
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            Globals.habilitarAnterior();
            Globals.VentanaAnterior.Dispose();
            Globals.habilitarAnterior(); //Porque vuelve al login, no a los requisitos
            this.Dispose();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            Application.Exit();
        }
    }
}
