using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using DOM;
using DOM.DAO;
using DOM.Dominio;
using DOM.Auxiliares;
namespace FrbaHotel.ABM_de_Usuario
{
    public partial class UsuarioAlta : Form
    {
        Usuario userNuevo = new Usuario();
        List<Rol> rolesPosibles;
        List<Hotel> hotelesPosibles;
        public UsuarioAlta()
        {
            InitializeComponent();
            
        ////Se carga el listRol
            rolesPosibles=DAORol.traerTodosLosRolesPosibles();
            foreach (Rol unRol in rolesPosibles)
                listRol.Items.Add(unRol.Nombre);
        
        //// Agregar una opción al combo 
            comboTipoDoc.SelectedIndex = 0;
            
        ////Carga de hoteles
            hotelesPosibles = DAOHotel.obtenerTodos();
            foreach (Hotel unHotel in hotelesPosibles)
                listHotel.Items.Add(unHotel.Nombre);
            
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (camposCompletos())
            {
                if (Equals(textPassword1.Text, textPassword2.Text)){
                    completarEstructuraUserNuevo();
                    if (DAOUsuario.insertar(userNuevo))
                        MessageBox.Show("Alta de Usuario correcta");
                    else
                        MessageBox.Show("Alta de Usuario erronea");

                    //Guarda los distintos Roles asignados al Usuario
                    foreach (var item in listRol.SelectedItems)
                    {
                        DAORol.insertarRolUsuario(item.ToString(), userNuevo.Usr);
                    }

                    //Guarda los distintos Hoteles asignados al Usuario
                    DAOUsuario.insertarHotelUsuario(userNuevo.Usr, listHotel.SelectedItem.ToString());


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
            userNuevo.Nombre = textNombre.Text;
            userNuevo.Apellido = textApellido.Text;
            userNuevo.Password = DAOUsuario.hashPassword(textPassword1.Text);
            userNuevo.TipoDocu = Documento.string_docu[comboTipoDoc.SelectedIndex];
            userNuevo.NroDocu = Convert.ToInt32(textNumDoc.Text);
            userNuevo.Mail = textMail.Text;
            userNuevo.Telefono = Convert.ToInt32(textTelefono.Text);
            userNuevo.Direccion.calle_direccion = textDirCalle.Text;
            userNuevo.Direccion.calle_altura = Convert.ToInt32(textDirAltura.Text);
            userNuevo.Direccion.calle_piso = textDirPiso.Text != "" ? Convert.ToInt32(textDirPiso.Text) : 0;
            userNuevo.Direccion.calle_dpto = textDirDpto.Text != "" ? textDirDpto.Text : "";
            userNuevo.Fecha_nacimiento = Convert.ToString(dateTimeNacimiento.Value);

            userNuevo.CampoBaja = false;
        }

        private Boolean camposCompletos()
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
            else if (listRol.SelectedItems == null)
                return false;
            else if (listHotel.SelectedItems == null)
                return false;
            return true;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textUsername.Text = " ";
            textPassword1.Text = "";
            textPassword2.Text = "";
            textNombre.Text = " ";
            textApellido.Text = " ";
            textNumDoc.Text = " ";
            textMail.Text = " ";
            textDirCalle.Text = " ";
            textDirAltura.Text = " ";
            textDirPiso.Text = " ";
            textDirDpto.Text = " ";
            textTelefono.Text = " ";
            listRol.SelectedItem = null;
            comboTipoDoc.SelectedItem = null;
            listHotel.SelectedItem = null;
            for (int itemRol = 0; itemRol < listRol.Items.Count; itemRol++)
            {
                listRol.SetItemChecked(itemRol, false);
            }
            for (int itemHotel = 0; itemHotel < listHotel.Items.Count; itemHotel++)
            {
                listHotel.SetItemChecked(itemHotel, false);
            }

        }

    }
}
