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

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class UsuarioBajaMod : Form
    {

        List<Rol> rolesPosibles;

        public UsuarioBajaMod()
        {
            InitializeComponent();
            rolesPosibles=DAORol.traerTodosLosRolesPosibles();
            
            //Llena la lista con los checkbox de Roles
            foreach (Rol unRol in rolesPosibles)
                comboListRol.Items.Add(unRol.Nombre);
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiamos la DataGrid
            dataGridUsuario.DataSource = null;
            //Los demas campos también
            textUsuario.Text = null;
            textNombre.Text = null;
            textApellido.Text = null;
            comboListRol.SelectedItem = null;
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            string rol = "";
            if(comboListRol.SelectedIndex != -1)
                rol = comboListRol.SelectedItem.ToString();
            //Aplica criterios de búsqueda
            DataTable respuesta = FiltrarUsuario(textUsuario.Text, textNombre.Text, textApellido.Text, rol);
            //Llena el DataGrid con los datos de la tabla devuelta
            dataGridUsuario.DataSource = respuesta;
            //Muestra solo las primeras 6 columnas
            if (respuesta != null)
            {
                dataGridUsuario.Columns["password"].Visible = false;
                dataGridUsuario.Columns["contador_intentos_login"].Visible = false;
                dataGridUsuario.Columns["primerLog"].Visible = false;
            }

            dataGridUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridUsuario.AutoResizeColumns();
            dataGridUsuario.AutoResizeRows();
        }

        private DataTable FiltrarUsuario(string usr, string nombre, string apellido, string rol)
        {
            DataTable tabla_usuario = DAOUsuario.obtenerTabla(usr);
            var final_usuario = "";
            var posFiltro = true;
            var filtrosBusqueda = new List<string>();
            if (usr != "") filtrosBusqueda.Add("usr LIKE '%" + usr + "%'");
            if (nombre != "") filtrosBusqueda.Add("nombre LIKE '%" + nombre + "%'");
            if (apellido != "") filtrosBusqueda.Add("apellido LIKE '%" + apellido + "%'");
            if (rol != "")
            {
                List<Rol> tabla_rol = DAORol.obtenerRolesDeUsuario(rol);
                if (tabla_rol.Count > 0)
                {
                    bool hayMasFiltros = false;
                    if (filtrosBusqueda.Count != 0)
                        hayMasFiltros = true;
                    string filtro_rol = "";
                    if (hayMasFiltros)
                        filtro_rol += "(";
                    filtro_rol += ("usr = '" + tabla_rol[0].Usr + "'");
                    for (int i = 1; i < tabla_rol.Count; i++)
                    {
                        filtro_rol += " OR ";
                        filtro_rol += ("usr = '" + tabla_rol[i].Usr + "'");
                    }
                    if (hayMasFiltros)
                        filtro_rol += ")";
                    filtrosBusqueda.Add(filtro_rol);
                }
            }
            //Concatena hasta formar la consulta para filtrar
            foreach (var filtro in filtrosBusqueda)
            {
                if (!posFiltro)
                    final_usuario += " AND " + filtro;
                else
                {
                    final_usuario += filtro;
                    posFiltro = false;
                }
            }
            //Filtra las columnas
            tabla_usuario.DefaultView.RowFilter = final_usuario;
            //Devuelve la tabla filtradra 
            return tabla_usuario;
        }

        public void cleanGrid()
        {
            dataGridUsuario.DataSource = null;
            dataGridUsuario.Update();
        }
        public void updateGrid()
        {
            botonBuscar_Click(null, null);
        }
           
        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            new UsuarioAlta().Show(this);
            Globals.deshabilitarAnterior(this);
        }

        private void botonBaja_Click(object sender, System.EventArgs e)
        {
            if (dataGridUsuario.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un Usuario a dar de baja.",
                "", MessageBoxButtons.OK);
                return;
            }
            if ((bool)dataGridUsuario.CurrentRow.Cells["campoBaja"].Value)
            {
                MessageBox.Show("Usuario ya deshabilitado.",
                "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string usrDelete = dataGridUsuario.CurrentRow.Cells["usr"].Value.ToString();
            DialogResult dr = MessageBox.Show("Desea dar de Baja al usuario " + usrDelete + "?",
            "", MessageBoxButtons.YesNo);
            switch (dr){
                case DialogResult.Yes: 
                DAOUsuario.borrar(usrDelete);
                updateGrid();
                break;
                case DialogResult.No: break;
            }
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridUsuario.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un Usuario a modificar.",
                "", MessageBoxButtons.OK);
                return;
            }
            string usrModif = dataGridUsuario.CurrentRow.Cells["usr"].Value.ToString();
            DialogResult dr = MessageBox.Show("Desea modificar datos del usuario " + usrModif + "?",
            "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    //Nuevo Form que se le pasa el nombre de usuario a Modificar
                    new UsuarioMod(usrModif).Show(this);
                    Globals.deshabilitarAnterior(this);
                    break;
                case DialogResult.No: break;
            }
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
