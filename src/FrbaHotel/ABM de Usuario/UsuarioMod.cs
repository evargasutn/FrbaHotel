﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM;
using DOM.DAO;
using DOM.Dominio;
using DOM.Auxiliares;
using System.Net.Mail;

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class UsuarioMod : Form
    {   
        Usuario usuarioMod;
        List<Hotel> hotelesPosibles;
        List<Hotel> hotelesUsuario;
        List<Rol> rolesUsuario;
        List<Rol> rolesPosibles;

        string usuarioPedido;
        

        public UsuarioMod(string usuario)
        {
            InitializeComponent();

            usuarioPedido = usuario;

            usuarioMod = DAOUsuario.obtener(usuarioPedido);
            rolesUsuario = DAORol.obtenerTodos(usuario);

            ////Se carga el listRol tildando las opciones que el usuario ya tiene
            int item = 0;
            rolesPosibles = DAORol.traerTodosLosRolesPosibles();
            foreach (Rol rol in rolesPosibles){
                listRol.Items.Add(rol.Nombre);
                if (rolesUsuario.Any(x => x.Nombre == rol.Nombre)){
                    listRol.SetItemChecked(item, true);
                }                   
              item++;
            }
            
            // Carga de listHotel, mismo rezonamiento de arriba
            item = 0;
            hotelesPosibles = DAOHotel.obtenerTodos();
            hotelesUsuario = DAOHotel.obtenerTodos(usuario);
            foreach (Hotel hotel in hotelesPosibles)
            {
                listHotel.Items.Add(hotel.Nombre);
                if (hotelesUsuario.Any(x => x.Nombre == hotel.Nombre))
                {
                    listHotel.SetItemChecked(item, true);
                }
                item++;
            }

            //Seteo check de Baja
            if (usuarioMod.CampoBaja)
                checkBoxBajaUsr.Checked = true;
            else
                checkBoxBajaUsr.Checked = false;
            
            //Llena el resto de los campos con la info que el usuario tiene
            cargarDatos();
        }

        private void cargarDatos()
        {
            textUsername.Text = usuarioMod.Usr;
            textPassword1.Text = usuarioMod.Password;
            textPassword2.Text = usuarioMod.Password;
            textNombre.Text = usuarioMod.Nombre;
            textApellido.Text = usuarioMod.Apellido;
            comboTipoDoc.Text = usuarioMod.TipoDocu;
            textNumDoc.Text = Convert.ToString(usuarioMod.NroDocu);
            dateTimeNacimiento.Text = usuarioMod.Fecha_nacimiento_struct.Value.ToShortDateString();
            textMail.Text = usuarioMod.Mail;
            textDirCalle.Text = usuarioMod.Direccion.calle_direccion;
            textDirAltura.Text = Convert.ToString(usuarioMod.Direccion.calle_altura);
            textDirPiso.Text = Convert.ToString(usuarioMod.Direccion.calle_piso);
            textDirDpto.Text = usuarioMod.Direccion.calle_dpto;
            textTelefono.Text = Convert.ToString(usuarioMod.Telefono);
            checkBoxBajaUsr.Checked = usuarioMod.CampoBaja;
     }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (camposCompletos())
            {
                if (Equals(textPassword1.Text, textPassword2.Text))
                {
                    completarEstructuraUserMod();

                    DAOUsuario.actualizar(usuarioMod);

                    //Guarda los distintos Roles asignados al Usuario
                    for (int index = 0; index < listRol.Items.Count; index++ )
                    {
                        if (listRol.GetItemChecked(index))
                            //Agrego Rol a Usuario en tabla ROLES_X_USUARIO
                            DAORol.insertarRolUsuario(listRol.Items[index].ToString(), usuarioMod.Usr);
                        else
                            DAORol.borrarRolUsuario(listRol.Items[index].ToString(), usuarioMod.Usr);
                     }
                    //Guarda los distintos Hoteles asignados al Usuario
                    for (int index = 0; index < listHotel.Items.Count; index++)
                    {
                        if (listHotel.GetItemChecked(index))
                            //Agrego Rol a Usuario en tabla ROLES_X_USUARIO
                            DAOUsuario.insertarHotelUsuario(usuarioMod.Usr, listHotel.Items[index].ToString());
                        else
                            DAOUsuario.borrarHotelUsuario(usuarioMod.Usr, listHotel.Items[index].ToString());
                    }

                    //Fin de Update de Usuario
                    MessageBox.Show("Update de Usuario correcta");
                    ((UsuarioBajaMod)Globals.VentanaAnterior).updateGrid();
                    this.Close();
                }
                else
                    MessageBox.Show("Vuelva a ingresar el password", "Error:Password no identicos");
            }
            else
                MessageBox.Show("Asegurese de ingresar los campos obligatorios", "Error:campos incompletos");
        }


        public void completarEstructuraUserMod()
        {
            usuarioMod.Usr = textUsername.Text;
            usuarioMod.Nombre = textNombre.Text;
            usuarioMod.Apellido = textApellido.Text;
            usuarioMod.Password = DAOUsuario.hashPassword(textPassword1.Text);
            usuarioMod.TipoDocu = Documento.string_docu[comboTipoDoc.SelectedIndex];
            usuarioMod.NroDocu = Convert.ToInt32(textNumDoc.Text);
            usuarioMod.Mail = textMail.Text;
            usuarioMod.Telefono = Convert.ToInt32(textTelefono.Text);
            usuarioMod.Direccion.calle_direccion = textDirCalle.Text;
            usuarioMod.Direccion.calle_altura = Convert.ToInt32(textDirAltura.Text);
            usuarioMod.Direccion.calle_piso = textDirPiso.Text != "" ? Convert.ToInt32(textDirPiso.Text) : 0;
            usuarioMod.Direccion.calle_dpto = textDirDpto.Text != "" ? textDirDpto.Text : "";
            usuarioMod.Fecha_nacimiento = Convert.ToString(dateTimeNacimiento.Value);
            usuarioMod.CampoBaja = checkBoxBajaUsr.Checked;
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
