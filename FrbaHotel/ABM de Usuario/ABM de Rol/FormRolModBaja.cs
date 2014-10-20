using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM;
using DOM.Dominio;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class FormRolModBaja : Form
    {
        List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

        public FormRolModBaja()
        {
            InitializeComponent();
            funcionalidades = DAOFuncionalidad.getAllFuncionalidades();
            foreach (Funcionalidad func in funcionalidades)
                comboFuncionalidad.Items.Add(func.Descripcion);
            comboFuncionalidad.SelectedItem = comboFuncionalidad.Items[0];

        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiamos la DataGrid
            foreach (DataGridViewRow dgvr in dataGridViewRol.Rows)
                if (dgvr.Selected == true)
                    dataGridViewRol.Rows.Remove(dgvr);
            //Limiamos lo demas?
            textRol.Text = "";
            comboFuncionalidad.SelectedItem = null;
            comboEstado.SelectedItem = null;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            DataTable respuesta = FiltrarRol(textRol.Text,(string) comboFuncionalidad.SelectedItem, (string) comboEstado.SelectedItem);
            dataGridViewRol.DataSource = respuesta;
            dataGridViewRol.AutoResizeColumns();
            dataGridViewRol.AutoResizeRows();
        }
        private DataTable FiltrarRol(string nombreRol, string nombreFuncionalidad, string estado)
        {
            DataTable dt = DAORol.getRolTable();
            var final = "";
            var posFiltro = true;
            var filtrosBusqueda = new List<string>();
            if (nombreRol != "") filtrosBusqueda.Add("nombreRol LIKE '%" + nombreRol + "%'");
            if (nombreFuncionalidad != null) filtrosBusqueda.Add("descripcion LIKE '%" + nombreFuncionalidad + "%'");
            if (estado != null) 
                if(estado == "Activo")
                    filtrosBusqueda.Add("estado LIKE '%1%'");
                else
                    filtrosBusqueda.Add("estado LIKE '%0%'");

            foreach(var filtro in filtrosBusqueda)
            {
                if(!posFiltro)
                    final += " AND " + filtro;
                else
                {
                    final += filtro;
                    posFiltro = false;
                }
            }
            dt.DefaultView.RowFilter = final;
            return dt;

        }

        private void dataGridViewRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Modificar.DisplayIndex) ModificarRol(e.RowIndex);
            if (e.ColumnIndex == Baja.DisplayIndex) BajaRol(e.RowIndex);
        }

        private void BajaRol(int p)
        {
            var rta = MessageBox.Show("¿Dar Baja al Rol?", "Baja de Rol", MessageBoxButtons.YesNo);
            string rolAbaja = (string) dataGridViewRol["nombreRol", p].Value;
            if(rta == DialogResult.Yes)
                DAORol.deleteRol(rolAbaja);
        }

        private void ModificarRol(int p)
        {
            string rolElegido = (string)dataGridViewRol["nombreRol", p].Value;
            new FormRolMod(rolElegido).Show();
            Base.establecerVentanaAnterior(this);
        }

        private void altaDeRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRolAlta alta = new FormRolAlta();
            alta.Show();
            Globals.deshabilitarAnterior(this);
        }

    }
}
