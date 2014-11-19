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
        Usuario usuario=Globals.infoSesion.User;
        Rol rol = Globals.infoSesion.Rol;
        public LoginRequisitos()
        {
            InitializeComponent();
            
            if (usuario != null)
            {
                ///Completa combo hoteles
                hotelesDeUsuario = DAOHotel.obtenerTodos(usuario.Usr);
                foreach (Hotel unHotel in hotelesDeUsuario)
                    comboHoteles.Items.Add(unHotel);
                
                ///Completa combo hoteles
                rolesDeUsuario = DAORol.obtenerTodos(usuario.Usr);
                foreach (Rol unRol in rolesDeUsuario)
                    comboRoles.Items.Add(unRol);
                
            }
            else
            {
                hotelesDeUsuario = DAOHotel.obtenerTodos();
                foreach (Hotel unHotel in hotelesDeUsuario)
                    comboHoteles.Items.Add(unHotel);
                comboRoles.Items.Add("GUEST");
                
                comboRoles.Enabled = false;
            }
            
            comboHoteles.ValueMember = "Nombre";
            comboRoles.ValueMember = "Nombre";
            comboHoteles.SelectedIndex = 0;
            comboRoles.SelectedIndex = 0;
            
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            Hotel hotelSeleccionado = hotelesDeUsuario.Find(x => x.Nombre == ((Hotel)comboHoteles.SelectedItem).Nombre);
            Rol rolSeleccionado;
            if (usuario != null)
                rolSeleccionado = rolesDeUsuario.Find(x => x.Nombre == ((Rol)comboRoles.SelectedItem).Nombre);
            else
                rolSeleccionado = rol;

            Globals.infoSesion.Hotel = hotelSeleccionado;
            Globals.infoSesion.Rol   = rolSeleccionado;

            if (hotelSeleccionado != null && rolSeleccionado != null)
            {
                new MainPanel().Show(this);
                Globals.deshabilitarAnterior(this);
            }
            else
                MessageBox.Show("Seleccione el hotel y el rol", "Error:Hotel o rol no seleccionados");
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
