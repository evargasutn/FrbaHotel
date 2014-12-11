using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM.Dominio;
using DOM.DAO;
using DOM;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class HabitacionBajaMod : Form
    {
        Hotel hotel = Globals.infoSesion.Hotel;// = DAOHotel.obtener(2);
        Usuario usuario = Globals.infoSesion.User;

        public HabitacionBajaMod()
        {
            InitializeComponent();
        }

        private void HabitacionBajaMod_Load(object sender, EventArgs e)
        {
            comboUbicacion.Items.Add("S");
            comboUbicacion.Items.Add("N");
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {

            DataTable respuesta = FiltrarHuesped(textPiso.Text, textNumero.Text, comboUbicacion.SelectedIndex);
            dataGridHabitacion.DataSource = respuesta;
            if (respuesta != null)
            {
                dataGridHabitacion.Columns["descripcion1"].Visible = false;
                dataGridHabitacion.Columns["tipoCodigo"].Visible = false;
                dataGridHabitacion.Columns["codHotel"].Visible = false;
            }
            dataGridHabitacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridHabitacion.AutoResizeColumns();
            dataGridHabitacion.AutoResizeRows();
        }

        private DataTable FiltrarHuesped(string piso, string nroHabitacion, int tipoUbicacion)
        {
            DataTable tabla_habitacion = DAOHabitacion.obtenerTabla(hotel.CodHotel);
            var final_rol = "";
            var posFiltro = true;
            var filtrosBusqueda = new List<string>();
            if (nroHabitacion != "") filtrosBusqueda.Add("habitacion = " + nroHabitacion + "");
            if (piso != "") filtrosBusqueda.Add("piso = " + piso + "");
            if (tipoUbicacion != -1) filtrosBusqueda.Add("ubicacion LIKE '%" + comboUbicacion.Items[tipoUbicacion] + "%'");

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
            if (tabla_habitacion != null)
                tabla_habitacion.DefaultView.RowFilter = final_rol;
            return tabla_habitacion;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textNumero.Text = "";
            textPiso.Text = "";
            comboUbicacion.SelectedIndex = -1;
            cleanGrid();
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridHabitacion.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un Habitacion a modificar.",
                "", MessageBoxButtons.OK);
                return;
            }

            int numHab = Convert.ToInt32(dataGridHabitacion.CurrentRow.Cells["habitacion"].Value);

            DialogResult dr = MessageBox.Show("Desea modificar datos de la habitacion?", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    //Nuevo Form que sele pasa el nombre de usuario a Modificar
                    ModificarHabitacion(numHab);
                    break;
                case DialogResult.No: break;
            }

        }

        private void botonBaja_Click(object sender, EventArgs e)
        {
            if (dataGridHabitacion.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una Habitacion a dar de baja.",
                "", MessageBoxButtons.OK);
                return;
            }
            if ((bool)dataGridHabitacion.CurrentRow.Cells["campoBaja"].Value)
            {
                MessageBox.Show("Habitacion ya deshabilitada.",
                "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int codHab = Convert.ToInt32(dataGridHabitacion.CurrentRow.Cells["habitacion"].Value);

            DialogResult dr = MessageBox.Show("Desea dar de Baja a la habitacion " + codHab.ToString() + "?",
            "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    BajaHabitacion(codHab);
                    break;
                case DialogResult.No: break;
            }
        }

        private void BajaHabitacion(int habitacion)
        {
            DAOHabitacion.borrar(habitacion, Globals.infoSesion.Hotel.CodHotel);
            updateGrid();
        }

        private void ModificarHabitacion(int habitacion)
        {
            new HabitacionMod(habitacion).Show();
            Globals.deshabilitarAnterior(this);
        }

        private void altaDeHabitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HabitacionAlta().Show();
            Globals.deshabilitarAnterior(this);
        }

        public void cleanGrid()
        {
            dataGridHabitacion.DataSource = null;
            dataGridHabitacion.Update();
        }
        public void updateGrid()
        {
            botonBuscar_Click(null, null);
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

