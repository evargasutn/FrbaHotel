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
namespace FrbaHotel.ABM_de_Hotel
{
    public partial class HotelBajaMod : Form
    {
        Hotel hotel = Globals.infoSesion.Hotel;
        Usuario usuario = Globals.infoSesion.User;

        public HotelBajaMod()
        {
            InitializeComponent();
        }
        
        private void HotelBajaMod_Load(object sender, EventArgs e)
        {
            comboEstrellas.Items.Add(1);
            comboEstrellas.Items.Add(2);
            comboEstrellas.Items.Add(3);
            comboEstrellas.Items.Add(4);
            comboEstrellas.Items.Add(5);
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textNombre.Text = "";
            textCiudad.Text = "";
            textPais.Text = "";
            comboEstrellas.SelectedIndex = -1;
            dataGridHotel.DataSource = null;
            dataGridHotel.Update();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            DataTable respuesta = FiltrarHotel(textNombre.Text, textPais.Text, textCiudad.Text, comboEstrellas.SelectedIndex);
            dataGridHotel.DataSource = respuesta;
            if (respuesta != null)
            {
                dataGridHotel.Columns["telefono"].Visible = false;
                dataGridHotel.Columns["mail"].Visible = false;
                dataGridHotel.Columns["codHotel"].Visible = false;
            }
            dataGridHotel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridHotel.AutoResizeColumns();
            dataGridHotel.AutoResizeRows();
        }

        private void botonBaja_Click(object sender, EventArgs e)
        {
            if (dataGridHotel.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un Hotel a Inhabilitar.",
                "", MessageBoxButtons.OK);
                return;
            }
            int codHotel = Int32.Parse(dataGridHotel.CurrentRow.Cells["codHotel"].Value.ToString());
            string nombreHotel = dataGridHotel.CurrentRow.Cells["nombreHotel"].Value.ToString();            
            //Chequear que pueda inhabilitarse dentro de la otra ventana, necesitamos las fechas
            new NuevaInhabilitacion(codHotel, nombreHotel).Show();
            Globals.deshabilitarAnterior(this);
            
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridHotel.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un Hotel a modificar.",
                "", MessageBoxButtons.OK);
                return;
            }
            int codHotel = Int32.Parse(dataGridHotel.CurrentRow.Cells["codHotel"].Value.ToString());
            string nombreHotel = dataGridHotel.CurrentRow.Cells["nombreHotel"].Value.ToString();
            DialogResult dr = MessageBox.Show("Desea modificar el Hotel " + nombreHotel + "?", "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    //Nuevo Form que sele pasa el nombre de usuario a Modificar
                    ModificarHotel(codHotel);
                    break;
                case DialogResult.No: break;
            }
        }

        private DataTable FiltrarHotel(string nombre, string pais, string ciudad,int tipoEstrella)
        {
            DataTable tabla_habitacion = DAOHotel.obtenerTabla();
            var final_rol = "";
            var posFiltro = true;
            var filtrosBusqueda = new List<string>();

            if (nombre != "") filtrosBusqueda.Add("nombreHotel LIKE '%" + nombre + "%'");
            if (pais != "") filtrosBusqueda.Add("pais LIKE '%" + pais + "%'");
            if (ciudad != "") filtrosBusqueda.Add("ciudad LIKE '%"+ciudad+"%'");
            if (tipoEstrella != -1) filtrosBusqueda.Add("cantEstrellas = " + comboEstrellas.Items[tipoEstrella].ToString());


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

        private void BajaHotel(Inhabilitacion bajaInhab)
        {
            DAOHotel.borrar(bajaInhab);
            updateGrid();
        }

        private void ModificarHotel(int hotelElegido)
        {
            new HotelMod(hotelElegido).Show();
            Globals.deshabilitarAnterior(this);
        }   

        private void altaDeHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HotelAlta().Show();
            Globals.deshabilitarAnterior(this);
        }

        public void cleanGrid()
        {
            dataGridHotel.DataSource = null;
            dataGridHotel.Update();
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
