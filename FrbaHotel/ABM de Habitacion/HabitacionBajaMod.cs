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
        Hotel hotel = Globals.infoSesion.Hotel = DAOHotel.obtener(2);
        Usuario usuario = Globals.infoSesion.User;

        public HabitacionBajaMod()
        {
            InitializeComponent();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {

            DataTable respuesta = FiltrarHuesped(textPiso.Text, textNumero.Text, comboUbicacion.SelectedIndex);
            dataGridHabitacion.DataSource = respuesta;
            if (respuesta != null)
            {
                dataGridHabitacion.Columns["codHotel"].Visible = false;
            }
            dataGridHabitacion.AutoResizeColumns();
            dataGridHabitacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridHabitacion.AutoResizeRows();
        }

        private DataTable FiltrarHuesped(string piso, string nroHabitacion, int tipoUbicacion)
        {
            DataTable tabla_habitacion = DAOHabitacion.obtenerTabla(-1, hotel.CodHotel);
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

        private void HabitacionBajaMod_Load(object sender, EventArgs e)
        {
            comboUbicacion.Items.Add("S");
            comboUbicacion.Items.Add("N");
        }

        private void altaDeHabitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new HabitacionAlta().Show();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textNumero.Text = "";
            textPiso.Text = "";
            comboUbicacion.SelectedIndex = -1;
            dataGridHabitacion.DataSource = null;
            dataGridHabitacion.Update();
        }
        
        /// <summary>
        /// basicamente aca se da de baja o alta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridHabitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int numHabitacion = Convert.ToInt32(dataGridHabitacion.Rows[e.RowIndex].Cells[3].Value);

            if (e.ColumnIndex == 0)
            {

                ///preguntamos si se quiere dar de Baja
                DialogResult dr = MessageBox.Show("Desea Modificar la habitacion " + numHabitacion.ToString() + "?",
            "", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        ///le paso el codigo de la habitacion, en tal caso deberia tener un parametro
                        ///para poder modificar
                        new HabitacionMod(numHabitacion).Show(this);
                        botonBuscar_Click(null, null);
                        break;
                    case DialogResult.No: break;
                }

            }
            if (e.ColumnIndex == 1)
            {
                ///preguntamos si se quiere dar de alta
                DialogResult dr = MessageBox.Show("Desea dar de Baja a la habitacion " + numHabitacion.ToString() + "?",
            "", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        DAOHabitacion.borrar(numHabitacion, hotel.CodHotel);
                        botonBuscar_Click(null, null);
                        break;
                    case DialogResult.No: break;
                }
            }
        }

    }

}

