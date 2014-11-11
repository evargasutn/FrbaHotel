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
         Hotel hotel = Globals.infoSesion.Hotel;
         Usuario usuario = Globals.infoSesion.User;
            
        public HabitacionBajaMod()
        {
            InitializeComponent();
      
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            ////////filtrar

            DataTable respuesta = FiltrarHuesped(textPiso.Text,textNumero.Text,comboUbicacion.SelectedIndex);
            dataGridHabitacion.DataSource = respuesta;
           if (respuesta != null)
            {
                dataGridHabitacion.Columns["codHotel"].Visible = false;
            }
            dataGridHabitacion.AutoResizeColumns();
            dataGridHabitacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridHabitacion.AutoResizeRows();
        }






        private DataTable FiltrarHuesped(string piso, string nroHabitacion,int tipoUbicacion)
        {
            DataTable tabla_habitacion = DAOHabitacion.obtenerTabla(-1, 2);            
            var final_rol = "";
            var posFiltro = true;
            var filtrosBusqueda = new List<string>();
            if (nroHabitacion != "") filtrosBusqueda.Add("habitacion = " + nroHabitacion + "");
            if (piso != "") filtrosBusqueda.Add("piso = " + piso+"" ); 
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

    }
}
