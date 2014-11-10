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
namespace FrbaHotel.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "" || textContrasenia.Text == "")
                MessageBox.Show("Complete los campos", "Error:Campos incompletos");
            else
            {
                Usuario usuarioALoguear = DAOUsuario.obtener(textUsuario.Text);
                if (usuarioALoguear != null)
                {
                    string passwordHash = DAOUsuario.hashPassword(textContrasenia.Text);
                    if (usuarioALoguear.Password == passwordHash)
                    {
                        Globals.infoSesion.User = usuarioALoguear;
                        MessageBox.Show("Inicio de sesion exitosa", "Logueo!!");
                        new LoginRequisitos().Show(this);
                    }
                    else
                    {
                        DAOUsuario.registrarIntentoFallido(usuarioALoguear.Nombre);
                        MessageBox.Show("Error:usuario o contraseña incorrecto");
                    }
                }
                else
                    MessageBox.Show("Error:usuario o contraseña incorrecto");
            }
        }

        private void botonInvitado_Click(object sender, EventArgs e)
        {
            Globals.infoSesion.Rol = DAORol.obtener("GUEST");
            new LoginRequisitos().Show(this);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
