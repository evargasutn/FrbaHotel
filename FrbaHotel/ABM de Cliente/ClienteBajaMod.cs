using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM.Auxiliares;
using DOM;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class ClienteBajaMod : Form
    {
        public ClienteBajaMod()
        {
            InitializeComponent();
            foreach (string tipo in Documento.string_docu)
                comboTipoDoc.Items.Add(tipo);
            limpiar();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            DataTable respuesta = FiltrarHuesped(textNombre.Text,textApellido.Text,textEmail.Text,comboTipoDoc.SelectedIndex,textNumDoc.Text);
            dataGridCliente.DataSource = respuesta;
            if (respuesta != null)
            {
                dataGridCliente.Columns["idHuesped"].Visible = false;
                //dataGridCliente.Columns["campoBaja"].Visible = false;
            }
            dataGridCliente.AutoResizeColumns();
            dataGridCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCliente.AutoResizeRows();
        }

        public void limpiar()
        {
            foreach (DataGridViewRow dgvr in dataGridCliente.Rows)
                if (dgvr.Selected == true)
                    dataGridCliente.Rows.Remove(dgvr);
            textNombre.Text = "";
            textApellido.Text = "";
            textEmail.Text = "";
            textNumDoc.Text = "";
            comboTipoDoc.SelectedIndex = -1;
        }

        private DataTable FiltrarHuesped(string nombre,string apellido,string mail,int tipoDoc,string numDoc)
        {
            DataTable tabla_huesped = DAOHuesped.obtenerTabla();
            var final_rol = "";
            var posFiltro = true;
            var filtrosBusqueda = new List<string>();
            if (nombre != "") filtrosBusqueda.Add("nombre LIKE '%" + nombre + "%'");
            if (apellido != "") filtrosBusqueda.Add("apellido LIKE '%" + apellido + "%'");
            if (mail != "") filtrosBusqueda.Add("mail LIKE '%" + mail + "%'");
            if (numDoc != "") filtrosBusqueda.Add("numDocu LIKE '%" + numDoc + "%'");
            if (tipoDoc != -1) filtrosBusqueda.Add("tipoDocu LIKE '%" + comboTipoDoc.Items[tipoDoc] + "%'");
            foreach (var filtro in filtrosBusqueda)
            {
                if (!posFiltro)
                    final_rol += " AND " + filtro;
                else
                {
                    final_rol += filtro;
                    posFiltro = false;
                }
            }
            if (tabla_huesped != null)
                tabla_huesped.DefaultView.RowFilter = final_rol;
            return tabla_huesped;
        }

        private void botonBaja_Click(object sender, System.EventArgs e)
        {
            int idDelete = (int) dataGridCliente.CurrentRow.Cells["idHuesped"].Value;
            DialogResult dr = MessageBox.Show("Desea dar de Baja al usuario "+idDelete.ToString()+"?",
            "", MessageBoxButtons.YesNo);
            switch (dr){
                case DialogResult.Yes: 
                    BajaHuesped(idDelete); 
                break;
                case DialogResult.No: break;
            }
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridCliente.CurrentRow.Cells["idHuesped"].Value;
            DialogResult dr = MessageBox.Show("Desea modificar datos del usuario " + id.ToString() + "?",
            "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    //Nuevo Form que sele pasa el nombre de usuario a Modificar
                    ModificarHuesped(id);
                    break;
                case DialogResult.No: break;
            }
        }

        private void BajaHuesped(int id)
        {
            DAOHuesped.borrar(id);
        }

        private void ModificarHuesped(int id)
        {
            new ClienteMod(id).Show();
            Base.establecerVentanaAnterior(this);
        }

        private void altaDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ClienteAlta().Show();
            Base.establecerVentanaAnterior(this);
        }


    }
}
