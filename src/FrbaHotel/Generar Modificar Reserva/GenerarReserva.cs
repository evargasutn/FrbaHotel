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
using DOM.DAO;
using DOM.Auxiliares;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class GenerarReserva : Form
    {
        Hotel hotel = Globals.infoSesion.Hotel;
        List<Regimen> lista_regimenes;
        List<Tipo_Habitacion> tipos_habitacion;
        Regimen regimen_elegido = null;

        public GenerarReserva()
        {
            InitializeComponent();
        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {
            lista_regimenes = DAORegimen.obtenerByHotel(hotel.CodHotel);
            tipos_habitacion = DAOHabitacion.obtenerTipoTodos();
            foreach (Tipo_Habitacion tipo in tipos_habitacion)
                comboTipoHab.Items.Add(tipo.Descripcion);
            foreach (Regimen reg in lista_regimenes)
                comboBoxTipoRegimen.Items.Add(reg.Descripcion);
            limpiar();
        }

        private void limpiar()
        {
            textFecha.Value = Globals.getFechaSistema();
            dateTimeEntrada.Value = Globals.getFechaSistema();
            dateTimeSalida.Value = Globals.getFechaSistema();
            comboBoxTipoRegimen.SelectedIndex = -1;
            comboTipoHab.SelectedIndex = -1;
            textCantHuespedes.Text = "";
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void botonReservar_Click(object sender, EventArgs e)
        {
            //Chequeo de cosas
            if (chequearDatos())
            {
                if (comboBoxTipoRegimen.SelectedIndex == -1)
                {
                    new ListarRegimenes().Show();
                    Globals.deshabilitarAnterior(this);
                    return;
                }
                regimen_elegido = lista_regimenes[comboBoxTipoRegimen.SelectedIndex];

                //Reservar con los datos validados

            }
        }

        private bool chequearDatos()
        {
            if (dateTimeEntrada.Value == null)
            {
                showToolTip("Seleccione una fecha de Entrada.", dateTimeEntrada, dateTimeEntrada.Location);
                return false;
            }
            if (dateTimeSalida.Value == null)
            {
                showToolTip("Seleccione una fecha de Salida.", dateTimeSalida, dateTimeSalida.Location);
                return false;
            }
            if (dateTimeEntrada.Value.CompareTo(dateTimeSalida.Value) >= 0)
            {
                showToolTip("Seleccione un rango de fechas válido.", dateTimeEntrada, dateTimeEntrada.Location);
                return false;
            }
            if (textFecha.Value.CompareTo(dateTimeEntrada.Value) >= 0)
            {
                showToolTip("Seleccione un rango de fechas válido.", dateTimeEntrada, dateTimeEntrada.Location);
                return false;
            }
            if (comboTipoHab.SelectedIndex == -1)
            {
                showToolTip("Seleccione un tipo de habitacion a reservar", comboTipoHab, comboTipoHab.Location);
                return false;
            }
            if (textCantHuespedes.Text == "")
            {
                showToolTip("Ingrese la cantidad de huéspedes de la reserva.", textCantHuespedes, textCantHuespedes.Location);
                return false;
            }
            int cantHuespedes = Int32.Parse(textCantHuespedes.Text);
            Tipo_Habitacion tipo_seleccionado = DAOHabitacion.obtenerTipo(Tipo_Habitacion.getCodeByDescription(comboTipoHab.SelectedItem.ToString(),tipos_habitacion));
            if (tipo_seleccionado.CantPersonas < cantHuespedes)
            {
                showToolTip("La cantidad ingresada excede la cantidad admitida por el tipo de habitación.", textCantHuespedes, textCantHuespedes.Location);
                return false;
            }
            return true;
        }

        public void actualizarRegimen(int codRegimen)
        {
            Regimen aux = DAORegimen.obtener(codRegimen);
            if (aux != null)
            {
                regimen_elegido = aux;
                for (int i = 0; i < comboBoxTipoRegimen.Items.Count; i++)
                    if (comboBoxTipoRegimen.Items[i].ToString() == regimen_elegido.Descripcion)
                        comboBoxTipoRegimen.SelectedIndex = i;
            }
            else
                MessageBox.Show("Error al seleccionar el régimen.",
                "", MessageBoxButtons.OK);
        }

        private void textCantHuespedes_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente números.", textCantHuespedes, textCantHuespedes.Location);
        }

        private void showToolTip(string msj, Control ventana, Point pos)
        {
            toolTip.Hide(ventana);
            toolTip.SetToolTip(ventana, "Entrada Invalida");
            toolTip.Show(msj, ventana, 50, 10, 5000);
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
