using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM;
using DOM.Auxiliares;
namespace FrbaHotel.ABM_de_Usuario
{
    public partial class UsuarioAlta : Form
    {
        Usuario userNuevo = new Usuario();

        public UsuarioAlta()
        {
            InitializeComponent();
        }


        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (camposCompletos())
            {
                if (textPassword1 == textPassword2){
                    completarEstructuraUserNuevo();
                    DAOUsuario.insertar(userNuevo);
                }
                else
                    MessageBox.Show("Vuelva a ingresar el password","Error:Password no identicos");
            }
            else
                MessageBox.Show("Asegurese de ingresar los campos obligatorios", "Error:campos incompletos");
        }

        public void completarEstructuraUserNuevo()
        {
            userNuevo.Usr = textUsername.Text;
            userNuevo.Nombre = textApellido.Text;
            userNuevo.Apellido = textApellido.Text;
            userNuevo.Password = textPassword1.Text;////pasar a sha 256
            userNuevo.TipoDocu = Documento.string_docu[comboTipoDoc.SelectedIndex];
            userNuevo.NroDocu = Convert.ToInt16(textNumDoc.Text);
            userNuevo.Mail = textMail.Text;
            userNuevo.Telefono = Convert.ToInt16(textTelefono.Text);
            userNuevo.Direccion.calle_direccion = textDirCalle.Text;
            userNuevo.Direccion.calle_altura = Convert.ToInt16(textDirAltura.Text);
            userNuevo.Direccion.calle_piso = Convert.ToInt16(textDirPiso.Text);
            userNuevo.Direccion.calle_dpto = textDirDpto.Text;
            userNuevo.Fecha_nacimiento = Convert.ToString(dateTimeNacimiento.Value);
            userNuevo.CampoBaja = true;
        }

        public Boolean camposCompletos()
        {
            if (textUsername.Text == "")
                return false;
            else if (textNombre.Text == "")
                return false;
            else if (textApellido.Text == "")
                return false;
            else if (textPassword1.Text == "")
                return false;
            else if (textNumDoc.Text == "")
                return false;
            else if (textDirCalle.Text == "")
                return false;
            else if (textDirAltura.Text == "")
                return false;
            else if (dateTimeNacimiento.Text == "")
                return false;
            return true;
        }



    }
}
