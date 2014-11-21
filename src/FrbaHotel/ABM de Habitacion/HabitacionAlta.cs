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

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class HabitacionAlta : Form
    {
        Hotel hotel = Globals.infoSesion.Hotel;
        List<Tipo_Habitacion> lista_tipos;

        public HabitacionAlta()
        {
            InitializeComponent();
        }

        private void HabitacionAlta_Load(object sender, EventArgs e)
        {
            comboUbicacion.Items.Add("S");
            comboUbicacion.Items.Add("N");
            comboUbicacion.SelectedIndex = 0;

            //Obtener los tipos de habitaciones :P
            lista_tipos = DAOHabitacion.obtenerTipoTodos();
            foreach(Tipo_Habitacion tipo in lista_tipos)
            {
                comboTipoHab.Items.Add(tipo.Descripcion);
            }
        }

        public Boolean camposCompletos(){

            if (textNumero.Text == "")
            {
                showToolTip("Ingrese un número de habitación.", textNumero, textNumero.Location);
                return false;
            }
            else if (textPiso.Text == "")
            {
                showToolTip("Ingrese un piso del hotel.", textPiso, textPiso.Location);
                return false;
            }
            else if (comboUbicacion.SelectedIndex == -1)
            {
                showToolTip("Seleccione una ubicación.", comboUbicacion, comboUbicacion.Location);
                return false;
            }
            else if (comboTipoHab.SelectedIndex == -1)
            {
                showToolTip("Seleccione un tipo de habitación.", comboTipoHab, comboTipoHab.Location);
                return false;
            }
            else if (textDescripcion.Text == "")
            {
                showToolTip("Ingrese una descripción.", textDescripcion, textDescripcion.Location);
                return false;
            }
            return true;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textDescripcion.Text = "";
            textNumero.Text = "";
            textPiso.Text = "";
            comboTipoHab.SelectedItem = null;
            comboUbicacion.SelectedItem = null;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (camposCompletos())
            {
                Habitacion nuevaHabitacion = new Habitacion();
                //Se completan Campos de Habitacion
                nuevaHabitacion.Id_Habitacion = Convert.ToInt32(textNumero.Text);
                nuevaHabitacion.CodHotel = hotel.CodHotel;
                nuevaHabitacion.Tipo_codigo = Tipo_Habitacion.getCodeByDescription(comboTipoHab.SelectedItem.ToString(),lista_tipos);
                nuevaHabitacion.Piso = Convert.ToInt32(textPiso.Text);
                nuevaHabitacion.Ubicacion = comboUbicacion.SelectedItem.ToString();
                nuevaHabitacion.Descripcion = textDescripcion.Text;
                    
                if (!DAOHabitacion.insertar(nuevaHabitacion))
                {
                    MessageBox.Show("Error al crear la habitación.", "Error al crear Nueva Habitación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Habitación Creada Correctamente.", "Nueva Habitación",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    ((HabitacionBajaMod)Globals.VentanaAnterior).updateGrid();
                    this.Close();
                }
            }
        }

        private void textNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solo números.", textNumero, textNumero.Location);
        }

        private void textPiso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solo números.", textPiso, textPiso.Location);
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
