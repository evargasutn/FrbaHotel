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
            dataGridHotel.AutoResizeColumns();
            dataGridHotel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridHotel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridHotel.AutoResizeRows();
        }


        private DataTable FiltrarHotel(string nombre, string pais, string ciudad,int tipoEstrella)
        {
            DataTable tabla_habitacion = DAOHotel.obtenerTabla();
            var final_rol = "";
            var posFiltro = true;
            var filtrosBusqueda = new List<string>();

            if (nombre != "") filtrosBusqueda.Add("nombreHotel LIKE '%" + nombre + "%'");
            if (pais != "") filtrosBusqueda.Add("ubicacion LIKE '%" + pais + "%'");
            if (ciudad != "") filtrosBusqueda.Add("ciudad LIKE '%"+ciudad+"%");
            if (tipoEstrella != -1) filtrosBusqueda.Add("cantEstrellas=" + comboEstrellas.Items[tipoEstrella].ToString());


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

        private void HotelBajaMod_Load(object sender, EventArgs e)
        {
            comboEstrellas.Items.Add(1);
            comboEstrellas.Items.Add(2);
            comboEstrellas.Items.Add(3);
            comboEstrellas.Items.Add(4);
            comboEstrellas.Items.Add(5);
        }

        private void dataGridHotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string nombreHotel = dataGridHotel.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (e.ColumnIndex == 0)
            {

                ///preguntamos si se quiere dar de Baja
                DialogResult dr = MessageBox.Show("Desea Modificar el hotel " + nombreHotel.ToString() + "?",
            "", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        ///le paso el codigo de la habitacion, en tal caso deberia tener un parametro
                        ///para poder modificar
                        new HotelMod().Show(this);
                        botonBuscar_Click(null, null);
                        break;
                    case DialogResult.No: break;
                }

            }
            if (e.ColumnIndex == 1)
            {
                ///preguntamos si se quiere dar de alta
                DialogResult dr = MessageBox.Show("Desea dar de Baja al hotel " + nombreHotel.ToString() + "?",
            "", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        
                        botonBuscar_Click(null, null);
                        break;
                    case DialogResult.No: break;
                }
            }



        }

    }
}
