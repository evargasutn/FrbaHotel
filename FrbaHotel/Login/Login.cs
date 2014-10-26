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
                    if (usuarioALoguear.Password == textContrasenia.Text)
                    {
                        MessageBox.Show("Inicio de sesion exitosa", "Logueo!!");
                        new LoginRequisitos(usuarioALoguear).Show();
                    }
                    else
                    {
                        DAOUsuario.registrarIntentoFallido(usuarioALoguear.Nombre);
                        MessageBox.Show("Porfavor intentelo de vuelta", "Error:contraseña incorrecta");
                    }
                }
                else
                    MessageBox.Show("Porfavor intentelo de vuelta", "Error:usuario inexistente");
            }
        }

        private void botonInvitado_Click(object sender, EventArgs e)
        {
            new MainPanel().Show();
        }
    }
}
