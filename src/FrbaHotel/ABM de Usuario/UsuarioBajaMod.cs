using System;
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

            if (String.IsNullOrEmpty(textUsuario.Text) && String.IsNullOrEmpty(textNombre.Text) &&
                String.IsNullOrEmpty(textApellido.Text) && String.IsNullOrEmpty((string)(comboListRol.SelectedItem)))
            {
                dataGridUsuario.DataSource = DAOUsuario.obtenerTabla("");
                //Solo muestra las primeras 6 columnas de la tabla resultante
                for (int item = 6; item < dataGridUsuario.ColumnCount; item++)
                    dataGridUsuario.Columns[item].Visible = false; 
            }
            else
            {
                //Aplica criterios de búsqueda
                DataTable respuesta = FiltrarUsuario(textUsuario.Text, textNombre.Text, textApellido.Text, comboListRol.SelectedItem.ToString());
                //Llena el DataGrid con los datos de la tabla devuelta
                dataGridUsuario.DataSource = respuesta;
                //Muestra solo las primeras 6 columnas
                for (int item = 6; item < dataGridUsuario.ColumnCount; item++)
                    dataGridUsuario.Columns[item].Visible = false;
             }

            dataGridUsuario.AutoResizeColumns();
            dataGridUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            if (rol != "") filtrosBusqueda.Add("nombreRol LIKE '%" + rol + "%'");
            
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
            

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            UsuarioAlta usrAlta = new UsuarioAlta();
            usrAlta.Show(this);
        }

        private void botonBaja_Click(object sender, System.EventArgs e)
        {
            string usrDelete = dataGridUsuario.CurrentRow.Cells["usr"].Value.ToString();
            DialogResult dr = MessageBox.Show("Desea dar de Baja al usuario "+usrDelete+"?",
            "", MessageBoxButtons.YesNo);
            switch (dr){
                case DialogResult.Yes: 
                DAOUsuario.borrar(usrDelete); 
                break;
                case DialogResult.No: break;
            }
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            string usrModif = dataGridUsuario.CurrentRow.Cells["usr"].Value.ToString();
            DialogResult dr = MessageBox.Show("Desea modificar datos del usuario " + usrModif + "?",
            "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    //Nuevo Form que sele pasa el nombre de usuario a Modificar
                    UsuarioMod usrMod = new UsuarioMod(usrModif);
                    usrMod.Show(this);
                    break;
                case DialogResult.No: break;
            }
        }

    }
}
