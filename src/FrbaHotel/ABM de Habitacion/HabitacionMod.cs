using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM.DAO;
using DOM;
using DOM.Dominio;
using DOM.Auxiliares;
namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class HabitacionMod : Form
    {
        Hotel hotel = Globals.infoSesion.Hotel;
        Habitacion habitacion;
        List<Tipo_Habitacion> lista_tipos;

        public HabitacionMod(int codHabitacion)
        {
            InitializeComponent();
            habitacion = DAOHabitacion.obtener(codHabitacion, hotel.CodHotel);
            lista_tipos = DAOHabitacion.obtenerTipoTodos();
        }

        private void HabitacionMod_Load(object sender, EventArgs e)
        {
            comboUbicacion.Items.Add("N");
            comboUbicacion.Items.Add("S");
            comboEstado.Items.Add("Habilitado");
            comboEstado.Items.Add("Deshabilitado");
            foreach (Tipo_Habitacion tipo in lista_tipos)
                comboTipo.Items.Add(tipo.Descripcion);
            limpiarDatos();                
        }

        private void limpiarDatos()
        {
            textNumero.Text = habitacion.Id_Habitacion.ToString();
            textPiso.Text = habitacion.Piso.ToString();
            textDescripcion.Text = habitacion.Descripcion;

            //Combo Estado
            if (habitacion.CampoBaja)
                comboEstado.SelectedIndex = 1;
            else
                comboEstado.SelectedIndex = 0;

            //Seleccionar Ubicacion
            for (int i = 0; i < comboUbicacion.Items.Count; i++)
                if (comboUbicacion.Items[i].ToString() == habitacion.Ubicacion)
                    comboUbicacion.SelectedIndex = i;

            //Seleccionar Tipo
            for (int i = 0; i < lista_tipos.Count; i++)
                if (lista_tipos[i].TipoCodigo == habitacion.Tipo_codigo)
                    comboTipo.SelectedIndex = i;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (chequearDatos())
            {
                habitacion.Id_Habitacion = Int32.Parse(textNumero.Text);
                habitacion.Piso = Int32.Parse(textPiso.Text);
                habitacion.Descripcion = textDescripcion.Text;
                //Usa la descripcion el combo, entonces....
                habitacion.Tipo_codigo = Tipo_Habitacion.getCodeByDescription(comboTipo.SelectedItem.ToString(), lista_tipos);

                habitacion.Ubicacion = comboUbicacion.SelectedItem.ToString();
                if (comboEstado.SelectedIndex == 0)
                    habitacion.CampoBaja = false;
                else
                    habitacion.CampoBaja = true;
                
                if (!DAOHabitacion.actualizar(habitacion))
                {
                    MessageBox.Show("Error al modificar la habitación.", "Error al Modificar Habitación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Habitación Modificada Correctamente.", "Modificar Habitación",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    ((HabitacionBajaMod)Globals.VentanaAnterior).updateGrid();
                    this.Close();
                }
            }
        }

        private bool chequearDatos()
        {
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
            else if (comboTipo.SelectedIndex == -1)
            {
                showToolTip("Seleccione un tipo de habitación.", comboTipo, comboTipo.Location);
                return false;
            }
            else if (textDescripcion.Text == "")
            {
                showToolTip("Ingrese una descripción.", textDescripcion, textDescripcion.Location);
                return false;
            }
            else if (comboEstado.SelectedIndex == -1)
            {
                showToolTip("Seleccione un estado.", comboEstado, comboEstado.Location);
                return false;
            }
            return true;
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
