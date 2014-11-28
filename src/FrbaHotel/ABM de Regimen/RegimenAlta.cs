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

namespace FrbaHotel.ABM_de_Regimen
{
    public partial class RegimenAlta : Form
    {
        public RegimenAlta()
        {
            InitializeComponent();
        }

        private void RegimenAlta_Load(object sender, EventArgs e)
        {
            comboEstado.Items.Add("No Activo");
            comboEstado.Items.Add("Activo");
            limpiar();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (chequearDatos())
            {
                Regimen regimen = new Regimen();
                regimen.Descripcion = textDescripcion.Text;
                regimen.Precio = Double.Parse(textPrecioBase.Text);
                if (comboEstado.SelectedIndex == 1)
                    regimen.Estado = true;
                else
                    regimen.Estado = false;
                if (!DAORegimen.insertar(regimen))
                {
                    MessageBox.Show("Error al crear el régimen.", "Error al crear Nuevo Régimen",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Régimen Creado Correctamente.", "Nuevo Régimen",
                MessageBoxButtons.OK, MessageBoxIcon.None);
                ((RegimenBajaMod)Globals.VentanaAnterior).updateGrid();
                this.Close();

            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private bool chequearDatos()
        {
            if(textDescripcion.Text == "")
            {
                showToolTip("Ingrese una descripción.", textDescripcion, textDescripcion.Location);
                return false;
            }
            if (textPrecioBase.Text == "")
            {
                showToolTip("Ingrese un precio base del régimen.", textPrecioBase, textPrecioBase.Location);
                return false;
            }
            if (comboEstado.SelectedIndex == -1)
            {
                showToolTip("Seleccione un estado.", comboEstado, comboEstado.Location);
                return false;
            }
            return true;
        }

        private void limpiar()
        {
            textDescripcion.Text = "";
            textPrecioBase.Text = "";
            comboEstado.SelectedIndex = 1;
        }

        private void textPrecioBase_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente números", textPrecioBase, textPrecioBase.Location);
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
