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
                dataGridCliente.Columns["campoBaja"].Visible = false;
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

        private void dataGridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Modificar.DisplayIndex) ModificarHuesped(e.RowIndex);
            if (e.ColumnIndex == Baja.DisplayIndex) BajaHuesped(e.RowIndex);
        }

        private void BajaHuesped(int p)
        {
            var rta = MessageBox.Show("¿Dar Baja al Rol?", "Baja de Rol", MessageBoxButtons.YesNo);
            int id = (int)dataGridCliente["idHuesped", p].Value;
            if (rta == DialogResult.Yes)
                DAOHuesped.borrar(id);
        }

        private void ModificarHuesped(int p)
        {
            int id = (int)dataGridCliente["idHuesped", p].Value;
            new ClienteMod(id).Show();
            Base.establecerVentanaAnterior(this);
        }
    }
}
