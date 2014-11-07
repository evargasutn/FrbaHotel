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
            else { MessageBox.Show("Ingreso como huesped","Bienvenido!!");
            hotelesDeUsuario = DAOHotel.obtenerTodos();
            rolesDeUsuario = new List<Rol>();
            rolesDeUsuario.Add(Globals.logueado.Rol);
            comboRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRoles.SelectedItem = Globals.logueado.Rol.Nombre;
            }

            //completamos los hoteles
            foreach (Hotel unHotel in hotelesDeUsuario)
                comboHoteles.Items.Add(unHotel.Nombre);            
            foreach (Rol unRol in rolesDeUsuario)
                comboRoles.Items.Add(unRol.Nombre);
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
                foreach (Hotel unHotel in hotelesDeUsuario)
                    if (unHotel.Nombre == hotelSeleccionado.ToString())
                    {
                        Globals.logueado.Hotel = unHotel;
                        break;
                    }
                //inicializo Rol              
                Globals.logueado.Rol=DAORol.obtener(rolSeleccionado.ToString());
                //abro formulario
                new MainPanel().Show();
            }
            else
                MessageBox.Show("Seleccione el hotel y el rol", "Error:Hotel o rol no seleccionados ");
        }

    }
}
