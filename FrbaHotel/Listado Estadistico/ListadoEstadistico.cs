using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
            inicializarFuentes();
        }



        public void inicializarFuentes()
        {
            List<Object> tiposDeListados = new List<Object>();
            tiposDeListados.Add("Hoteles:Mayor cantidad de reservas canceladas");
            tiposDeListados.Add("Hoteles:Mayor cantidad de consumibles facturados");
            tiposDeListados.Add("Hoteles:Mayor cantidad de días fuera de servicio");
            tiposDeListados.Add("Habitaciones:Mayor cantidad de días y ocupaciones");
            tiposDeListados.Add("Clientes:Mayor cantidad de puntos");
            Base.cargarEnComboBox(comboTipoDeListado, tiposDeListados);
            List<Object> treimestres = new List<Object>();
            treimestres.Add(1);
            treimestres.Add(2);
            treimestres.Add(3);
            Base.cargarEnComboBox(comboTrimestre, treimestres);
        }

    }
}
