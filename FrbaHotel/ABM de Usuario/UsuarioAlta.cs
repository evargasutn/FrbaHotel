using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM;
namespace FrbaHotel.ABM_de_Usuario
{
    public partial class UsuarioAlta : Form
    {
        Usuario user = new Usuario();

        public UsuarioAlta()
        {
            InitializeComponent();
        }


        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (camposCompletos())
            {
                if (textPassword1 == textPassword2)
                    completarEstructuras();
                else
                    MessageBox.Show("Error:Password no identicos");
            }
            else
                MessageBox.Show("Error:campos incompletos");
        }

        public void completarEstructuras()
        {
 
            user.Usr = textUsername.Text;
            user.Nombre = textApellido.Text;
            user.Apellido = textApellido.Text;
            user.Password = textPassword1.Text;////pasar a sha 256
            user.TipoDocu = comboTipoDoc.SelectedIndex;
            user.NroDocu = Convert.ToInt16(textNumDoc.Text);
            user.Mail = textMail.Text;
            user.Telefono = Convert.ToInt16(textTelefono.Text);
            user.Direccion.calle_direccion = textDirCalle.Text;
            user.Direccion.calle_altura = Convert.ToInt16(textDirAltura.Text);
            user.Direccion.calle_piso = Convert.ToInt16(textDirPiso.Text);
            user.Direccion.calle_dpto = textDirDpto.Text;
            user.Fecha_nacimiento = Convert.ToString(dateTimeNacimiento.Value);
            user.CampoBaja = true;
        }

        public Boolean camposCompletos()
        {

            if (textUsername.Text == "")
            {
                return false;
            }
            else if (textNombre.Text == "")
            {
                return false;
            }
            else if (textApellido.Text == "")
            {
                return false;
            }
            else if (textPassword1.Text == "")
            {
                return false;
            }
            else if (textNumDoc.Text == "")
            {
                return false;
            }
            else if (textDirCalle.Text == "")
            {
                return false;

            }
            else if (textDirAltura.Text == "")
            {
                return false;
            }
            else if (dateTimeNacimiento.Text == "")
            {
                return false;
            }
            return true;
        }



    }
}
