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
        List<Funcionalidad> funcionalidades;

        public RolBajaMod()
        {
            InitializeComponent();
            funcionalidades = DAOFuncionalidad.obtenerTodas();
            foreach (Funcionalidad func in funcionalidades)
                comboFuncionalidad.Items.Add(func.Descripcion);
            comboEstado.Items.Add("Activo");
            comboEstado.Items.Add("No Activo");

        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiamos la DataGrid
            cleanGrid();
            //Limiamos lo demas?
            textRol.Text = "";
            comboFuncionalidad.SelectedItem = null;
            comboEstado.SelectedItem = null;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            DataTable respuesta = FiltrarRol(textRol.Text,(string) comboFuncionalidad.SelectedItem, (string) comboEstado.SelectedItem);
            dataGridViewRol.DataSource = respuesta;
            dataGridViewRol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewRol.AutoResizeColumns();
            dataGridViewRol.AutoResizeRows();
        }
        private DataTable FiltrarRol(string nombreRol, string nombreFuncionalidad, string estado)
        {
            DataTable tabla_rol = DAORol.obtenerTabla();
            DataTable tabla_func = DAOFuncionalidad.obtenerPorRolTable(nombreRol);
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
            bool noTengoFuncionalidad = true;
            if (tabla_rol != null) {
                if (nombreFuncionalidad != null && tabla_func != null) {
                    int i = 0;
                    while(i < tabla_rol.Rows.Count)
                    {
                        string rol = Convert.ToString(tabla_rol.Rows[i]["nombreRol"]);
                        foreach (DataRow row2 in tabla_func.Rows)
                        {
                            if (rol == Convert.ToString(row2["nombreRol"]))
                                if (Convert.ToString(row2["descripcion"]) == nombreFuncionalidad)
                                    noTengoFuncionalidad = false;
                        }
                        if (noTengoFuncionalidad)
                            tabla_rol.Rows.RemoveAt(i);
                        else i++;
                        noTengoFuncionalidad = true;
                    }
                }
                tabla_rol.DefaultView.RowFilter = final_rol;
            }
            return tabla_rol;
        }

        private void altaDeRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolAlta alta = new RolAlta();
            alta.Show();
            Globals.deshabilitarAnterior(this);
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewRol.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un Rol a modificar.",
                "", MessageBoxButtons.OK);
                return;
            }
            string nombreRol = dataGridViewRol.CurrentRow.Cells["nombreRol"].Value.ToString();
            DialogResult dr = MessageBox.Show("Desea modificar datos del Rol " + nombreRol + "?", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    //Nuevo Form que sele pasa el nombre de usuario a Modificar
                    ModificarRol(nombreRol);
                    break;
                case DialogResult.No: break;
            }
        }

        private void botonBaja_Click(object sender, EventArgs e)
        {
            if (dataGridViewRol.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un Rol a dar de baja.",
                "", MessageBoxButtons.OK);
                return;
            }
            if (!(bool)dataGridViewRol.CurrentRow.Cells["estado"].Value)
            {
                MessageBox.Show("Rol ya deshabilitado.",
                "",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            string nombreRol = dataGridViewRol.CurrentRow.Cells["nombreRol"].Value.ToString();
            DialogResult dr = MessageBox.Show("Desea dar de Baja al Rol " + nombreRol + "?",
            "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    BajaRol(nombreRol);
                    break;
                case DialogResult.No: break;
            }
        }

        private void BajaRol(string rolAbaja)
        {
            DAORol.borrar(rolAbaja);
            updateGrid();
        }

        private void ModificarRol(string rolElegido)
        {
            new RolMod(rolElegido).Show();
            Globals.deshabilitarAnterior(this);
        }
        public void cleanGrid()
        {
            dataGridViewRol.DataSource = null;
            dataGridViewRol.Update();
        }
        public void updateGrid()
        {
            buttonBuscar_Click(null, null);
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
