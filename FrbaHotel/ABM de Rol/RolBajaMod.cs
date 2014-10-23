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
    public partial class RolBajaMod : Form
    {
        List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

        public RolBajaMod()
        {
            InitializeComponent();
            funcionalidades = DAOFuncionalidad.getTodasFuncionalidades();
            foreach (Funcionalidad func in funcionalidades)
                comboFuncionalidad.Items.Add(func.Descripcion);
            comboEstado.Items.Add("Activo");
            comboEstado.Items.Add("No Activo");

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
            dataGridViewRol.Columns["estado"].Visible = false;
            dataGridViewRol.AutoResizeColumns();
            dataGridViewRol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRol.AutoResizeRows();
        }
        private DataTable FiltrarRol(string nombreRol, string nombreFuncionalidad, string estado)
        {
            DataTable tabla_rol = DAORol.getRolTable();
            DataTable tabla_func = DAOFuncionalidad.getFuncionalidadTable(nombreRol);
            var final_rol = "";
            var posFiltro = true;
            var filtrosBusqueda = new List<string>();
            if (nombreRol != "") filtrosBusqueda.Add("nombreRol LIKE '%" + nombreRol + "%'");
            if (estado != null)
                if (estado == "Activo")
                    filtrosBusqueda.Add("estado = 1");
                else
                    filtrosBusqueda.Add("estado = 0");

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
            //Rearmar
            if (tabla_rol != null) {
                if (nombreFuncionalidad != null && tabla_func != null) {
                    for(int i = 0; i < tabla_rol.Rows.Count; i++)
                    {
                        string rol = Convert.ToString(tabla_rol.Rows[i]["nombreRol"]);
                        foreach (DataRow row2 in tabla_func.Rows)
                        {
                            if(rol == Convert.ToString(row2["nombreRol"]))
                                if(Convert.ToString(row2["descripcion"]) == nombreFuncionalidad)
                                    tabla_rol.Rows.RemoveAt(i);
                        }
                    }
                }
                tabla_rol.DefaultView.RowFilter = final_rol;
            }
            return tabla_rol;
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
            new RolMod(rolElegido).Show();
            Base.establecerVentanaAnterior(this);
        }

        private void altaDeRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolAlta alta = new RolAlta();
            alta.Show();
            Globals.deshabilitarAnterior(this);
        }

    }
}
