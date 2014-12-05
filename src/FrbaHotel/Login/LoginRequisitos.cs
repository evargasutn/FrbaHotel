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
        Usuario usuario = Globals.infoSesion.User;
        Rol rol = Globals.infoSesion.Rol;
        public LoginRequisitos()
        {
            InitializeComponent();
            
            if (usuario.Usr != "GUEST")
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
            if (hotelesDeUsuario.Count > 0)
            {
                comboHoteles.ValueMember = "Nombre";
                comboHoteles.SelectedIndex = 0;
            }
            comboRoles.ValueMember = "Nombre";
            comboRoles.SelectedIndex = 0;            
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (comboHoteles.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un hotel válido.", "Error:Hotel no seleccionados");
            }
            if (comboRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un rol válido.", "Error:Rol no seleccionados");
            }

            Hotel hotelSeleccionado = hotelesDeUsuario.Find(x => x.Nombre == ((Hotel)comboHoteles.SelectedItem).Nombre);
            Rol rolSeleccionado;
            if (usuario.Usr != "GUEST")
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
            Globals.infoSesion.User = null;
            Globals.infoSesion.Rol = null;
            Globals.habilitarAnterior();
        }
    }
}
