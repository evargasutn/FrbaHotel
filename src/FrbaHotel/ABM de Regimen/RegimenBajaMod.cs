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

namespace FrbaHotel.ABM_de_Regimen
{
    public partial class RegimenBajaMod : Form
    {
        public RegimenBajaMod()
        {
            InitializeComponent();
        }

        private void RegimenBajaMod_Load(object sender, EventArgs e)
        {
            comboEstado.Items.Add("Activo");
            comboEstado.Items.Add("No Activo");
            limpiar();
        }

        private void altaDeRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegimenAlta().Show();
            Globals.deshabilitarAnterior(this);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            double precio = 0;
            if (textPrecioBase.Text != "")
            {
                try
                {
                    precio = Double.Parse(textPrecioBase.Text);
                }
                catch
                {
                    MessageBox.Show("Ingrese un precio válido.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            DataTable respuesta = FiltrarRegimen(textDescripcion.Text,precio, (string) comboEstado.SelectedItem);
            dataGridViewRol.DataSource = respuesta;
            dataGridViewRol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewRol.AutoResizeColumns();
            dataGridViewRol.AutoResizeRows();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void botonBaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No implementada la Baja de Regimenes", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;

        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No implementada la Modificación de Regimenes", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private DataTable FiltrarRegimen(string descripcion, double precio, string estado)
        {
            DataTable tabla_regimen = DAORegimen.obtenerTabla();
            var final_regimen = "";
            var posFiltro = true;
            var filtrosBusqueda = new List<string>();
            if (descripcion != "") filtrosBusqueda.Add("descripcion LIKE '%" + descripcion + "%'");
            if (precio != 0) filtrosBusqueda.Add("precio = " + precio.ToString());
            if (estado != null)
                if (estado == "Activo")
                    filtrosBusqueda.Add("estado = 1");
                else
                    filtrosBusqueda.Add("estado = 0");

            foreach (var filtro in filtrosBusqueda)
            {
                if (!posFiltro)
                    final_regimen += " AND " + filtro;
                else
                {
                    final_regimen += filtro;
                    posFiltro = false;
                }
            }
            if (tabla_regimen != null)
            {
                tabla_regimen.DefaultView.RowFilter = final_regimen;
            }
            return tabla_regimen;
        }

        private void limpiar()
        {
            textDescripcion.Text = "";
            textPrecioBase.Text = "";
            comboEstado.SelectedIndex = -1;
            cleanGrid();
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
