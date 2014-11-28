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

namespace FrbaHotel.ABM_de_Facturas
{
    public partial class FacturasAlta : Form
    {

        private bool datosMostrados = false;
        private int codReserva = -1;

        public FacturasAlta()
        {
            InitializeComponent();
        }

        private void FacturasAlta_Load(object sender, EventArgs e)
        {
            comboTipoPago.Items.Add("Efectivo");
            comboTipoPago.Items.Add("Tarjeta de Crédito/Débito");
            comboTipoPago.SelectedIndex = -1;
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (textEstadia.Text == "")
            {
                showToolTip("Ingrese un número de estadía.", textEstadia, textEstadia.Location);
                return;
            }
            Estadia estadia = DAOEstadia.obtener(Int32.Parse(textEstadia.Text));
            if (estadia != null)
            {

                //Buscar y rellenar los valores

                double precioBase = 0;
                double precioConsumibles = 0;
                mostrarDatos(precioBase, precioConsumibles);
                datosMostrados = true;
            }
            else
                showToolTip("Ingrese un número de estadía válido.", textEstadia, textEstadia.Location);
        }

        private void botonFacturar_Click(object sender, EventArgs e)
        {
            if (chequearDatos())
            {
                //Facturar
                if (DAOEstadia.facturar(codReserva, comboTipoPago.SelectedItem.ToString(), textTarjeta.Text))
                {
                    MessageBox.Show("Error al generar la Factura", "", MessageBoxButtons.OK);
                    return;
                }
                this.Close();
            }
        }

        private bool chequearDatos()
        {
            if (!datosMostrados)
            {
                showToolTip("Confirme primero el número de estadía.", botonFacturar, botonFacturar.Location);
                return false;
            }
            if (comboTipoPago.SelectedIndex == -1)
            {
                showToolTip("Seleccione un tipo de pago.", comboTipoPago, comboTipoPago.Location);
                return false;
            }
            if ((comboTipoPago.SelectedIndex == 1) && textTarjeta.Text == "")
            {
                showToolTip("Ingrese un nro de tarjeta.", comboTipoPago, comboTipoPago.Location);
                return false;
            }
            return true;
        }

        private void mostrarDatos(double precioBase, double consumibles)
        {
            textBase.Text = precioBase.ToString();
            textConsumibles.Text = consumibles.ToString();
            textTotal.Text = (precioBase + consumibles).ToString();
        }

        private void textEstadia_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese sólo números.", textEstadia, textEstadia.Location);
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
