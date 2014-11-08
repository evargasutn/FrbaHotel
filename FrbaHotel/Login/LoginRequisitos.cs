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

namespace FrbaHotel.Login
{
    public partial class LoginRequisitos : Form
    {

        List<Hotel> hotelesDeUsuario;
        List<Rol> rolesDeUsuario;
        Usuario usuario=Globals.logueado.User;

        public LoginRequisitos()
        {
            InitializeComponent();

            if (usuario != null)
            {
                hotelesDeUsuario = DAOHotel.obtenerTodos(usuario.Usr);               
                rolesDeUsuario = DAORol.obtenerTodos(usuario.Usr);                
            }
            else { //Se ingresa como huesped
            hotelesDeUsuario = DAOHotel.obtenerTodos();
            rolesDeUsuario = new List<Rol>();
            rolesDeUsuario.Add(Globals.logueado.Rol);
            comboRoles.SelectedItem = Globals.logueado.Rol.Nombre;
            comboRoles.Enabled = false;
            }

            //Completamos los comboBox's, con los objetos
            foreach (Hotel unHotel in hotelesDeUsuario)
                comboHoteles.Items.Add(unHotel);            
            foreach (Rol unRol in rolesDeUsuario)
                comboRoles.Items.Add(unRol);
            comboHoteles.DisplayMember="Nombre";
            comboRoles.DisplayMember = "Nombre";
            comboHoteles.SelectedIndex=0;
            comboRoles.SelectedIndex=0; 

           
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            var hotelSeleccionado = comboHoteles.SelectedItem;
            var rolSeleccionado = comboRoles.SelectedItem;

            if (hotelSeleccionado != null || rolSeleccionado != null)
            {
                ///Inicializo Hotel                
                Globals.logueado.Hotel = (Hotel)hotelSeleccionado;
                //inicializo Rol              
                Globals.logueado.Rol=(Rol)rolSeleccionado;
                //abro formulario
                MessageBox.Show("Hotel:" + Globals.logueado.Hotel.Nombre + 
                    " rol:" + Globals.logueado.Rol.Nombre, "");
                new MainPanel().Show();
            }
            else
                MessageBox.Show("Seleccione el hotel y el rol", "Error:Hotel o rol no seleccionados ");
        }

    }
}
