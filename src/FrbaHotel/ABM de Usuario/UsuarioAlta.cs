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
using System.Net.Mail;
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
        
        ////Combobox mostrando una opción y no queda en blanco
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
                    if (!DAOUsuario.insertar(userNuevo))
                    {
                        MessageBox.Show("Alta de Usuario erronea");
                        return;
                    }

                    //Guarda los distintos Roles asignados al Usuario
                    foreach (var item in listRol.CheckedItems)
                        DAORol.insertarRolUsuario(item.ToString(), userNuevo.Usr);
                    
                    //Guarda los distintos Hoteles asignados al Usuario
                    foreach(var item in listHotel.CheckedItems)
                        DAOUsuario.insertarHotelUsuario(userNuevo.Usr, item.ToString());
                    
                    MessageBox.Show("Alta de Usuario correcta");
                    ((UsuarioBajaMod)Globals.VentanaAnterior).updateGrid();
                    this.Close();
                }
                else
                    MessageBox.Show("Vuelva a ingresar el password","Passwords no coinciden");
            }
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
            userNuevo.Fecha_nacimiento_struct = dateTimeNacimiento.Value;
            userNuevo.CampoBaja = false;
        }

        private Boolean camposCompletos()
        {
            if (textUsername.Text == "")
            {
                showToolTip("Ingrese un usuario válido.", textUsername, textUsername.Location);
                return false;
            }
            else if (textNombre.Text == "")
            {
                showToolTip("Ingrese un nombre.", textNombre, textNombre.Location);
                return false;
            }
            else if (textApellido.Text == "")
            {
                showToolTip("Ingrese un apellido.", textApellido, textApellido.Location);
                return false;
            }
            else if (textPassword1.Text == "")
            {
                showToolTip("Ingrese un password.", textPassword1, textPassword1.Location);
                return false;
            }
            else if (comboTipoDoc.SelectedIndex == -1)
            {
                showToolTip("Seleccione un Tipo de documento.", comboTipoDoc, comboTipoDoc.Location);
                return false;
            }
            else if (textNumDoc.Text == "")
            {
                showToolTip("Ingrese un Documento.", textNumDoc, textNumDoc.Location);
                return false;
            }
            else if (textMail.Text == "")
            {
                showToolTip("Ingrese un email.", textMail, textMail.Location);
                return false;
            }
            else
            {
                try
                {
                    new MailAddress(textMail.Text);
                }
                catch
                {
                    showToolTip("Ingrese un email válido.", textMail, textMail.Location);
                    return false;
                }
            }
            if (textDirCalle.Text == "")
            {
                showToolTip("Ingrese una Direccion válida.", textDirCalle, textDirCalle.Location);
                return false;
            }
            else if (textDirAltura.Text == "")
            {
                showToolTip("Ingrese una Direccion válida.", textDirAltura, textDirAltura.Location);
                return false;
            }
            else if (dateTimeNacimiento.Text == "")
            {
                showToolTip("Ingrese una fecha de Nacimiento.", dateTimeNacimiento, dateTimeNacimiento.Location);
                return false;
            }
            else if (listRol.SelectedItems == null)
            {
                showToolTip("Seleccione al menos un Rol.", listRol, listRol.Location);
                return false;
            }
            else if (listHotel.SelectedItems == null)
            {
                showToolTip("Seleccione al menos un Hotel.", listHotel, listHotel.Location);
                return false;
            }
            return true;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textUsername.Text = " ";
            textPassword1.Text = "";
            textPassword2.Text = "";
            textNombre.Text = " ";
            textApellido.Text = " ";
            comboTipoDoc.SelectedIndex = -1;
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            Globals.habilitarAnterior();
        }

        private void textNumDoc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente numeros.", textNumDoc, textNumDoc.Location);
        }

        private void textDirAltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente numeros.", textDirAltura, textDirAltura.Location);
        }

        private void textDirPiso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente numeros.", textDirPiso, textDirPiso.Location);
        }

        private void textTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente numeros.", textTelefono, textTelefono.Location);
        }

        private void showToolTip(string msj, Control ventana, Point pos)
        {
            toolTip.Hide(ventana);
            toolTip.SetToolTip(ventana, "Entrada Invalida");
            toolTip.Show(msj, ventana, 50, 10, 5000);
        }
    }
}
