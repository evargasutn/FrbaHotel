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
        public LoginRequisitos(Usuario usuario)
        {
            InitializeComponent();
            ///Completa combo hoteles
            hotelesDeUsuario = DAOHotel.obtenerTodos(usuario.Usr);
            foreach (Hotel unHotel in hotelesDeUsuario)
                comboHoteles.Items.Add(unHotel.Nombre);

            ///Completa combo hoteles
            rolesDeUsuario = DAORol.obtenerTodos(usuario.Usr);
            foreach (Rol unRol in rolesDeUsuario)
                comboRoles.Items.Add(unRol.Nombre);
           
   
        
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {

            if (comboHoteles.SelectedItem != null || comboRoles.SelectedItem != null)
                ;//////////
            else
                MessageBox.Show("Seleccione el hotel y el rol", "Error:Hotel o rol no seleccionados ");
        }

    }
}
