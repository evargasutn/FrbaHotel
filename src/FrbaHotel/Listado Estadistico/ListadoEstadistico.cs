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

namespace FrbaHotel.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        List<string> tiposDeListados = null;
        List<int> trimestres = null;

        public ListadoEstadistico()
        {
            InitializeComponent();
            inicializarFuentes();

        }



        public void inicializarFuentes()
        {
            tiposDeListados = new List<string>();
            tiposDeListados.Add("Hoteles:Mayor cantidad de reservas canceladas");
            tiposDeListados.Add("Hoteles:Mayor cantidad de consumibles facturados");
            tiposDeListados.Add("Hoteles:Mayor cantidad de días fuera de servicio");
            tiposDeListados.Add("Habitaciones:Mayor cantidad de días y ocupaciones");
            tiposDeListados.Add("Clientes:Mayor cantidad de puntos");
            comboTipoDeListado.DataSource = tiposDeListados;
            trimestres = new List<int>();
            trimestres.Add(1);
            trimestres.Add(2);
            trimestres.Add(3);
            comboTrimestre.DataSource = trimestres;
        }

        public void reporte(string unReporte, int unTrimestre, int unAnio) 
        {
            switch (unReporte)
            {

                case "Hoteles:Mayor cantidad de reservas canceladas":
                    dataGridReportes.DataSource = DAOReportes.HotelesMayorCancelaciones(unTrimestre, unAnio);
                    break;

                case "Hoteles:Mayor cantidad de consumibles facturados":
                    dataGridReportes.DataSource = DAOReportes.HotelesMayorConsumiblesFacturados(unTrimestre, unAnio);
                    break;

                case "Hoteles:Mayor cantidad de días fuera de servicio":
                    dataGridReportes.DataSource = DAOReportes.HotelesMayorDiasInhabilitado(unTrimestre, unAnio);
                    break;

                case "Habitaciones:Mayor cantidad de días y ocupaciones":
                    dataGridReportes.DataSource = DAOReportes.HabitacionesMayorCantOcupadas(unTrimestre, unAnio);
                    break;

                case "Clientes:Mayor cantidad de puntos":
                    dataGridReportes.DataSource = DAOReportes.MejorCliente(unTrimestre, unAnio);
                    break;
            }
        }

        private void botonMostrarListado_Click(object sender, EventArgs e)
        {
            reporte(comboTipoDeListado.SelectedValue.ToString(), Int32.Parse(comboTrimestre.SelectedValue.ToString()), Int32.Parse(dateTimeAnioEstadistica.Value.Year.ToString()));
        }

    }
}
