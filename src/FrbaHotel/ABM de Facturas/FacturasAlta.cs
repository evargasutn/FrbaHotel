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
using DOM.Auxiliares;
using DOM.DAO;
using System.Net.Mail;



namespace FrbaHotel.ABM_de_Facturas
{
    public partial class FacturasAlta : Form
    {

        private bool datosMostrados = false;
        Reserva reserva;
        Estadia estadia;

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
            Factura factura = DAOEstadia.obtenerFactura(Int32.Parse(textEstadia.Text));
            if (factura != null)
            {
                MessageBox.Show("Factura ya generada anteriormente. Por favor, seleccione otra Reserva", "", MessageBoxButtons.OK);
                return;
            }
            estadia = DAOEstadia.obtener(Int32.Parse(textEstadia.Text));
            reserva = DAOReserva.obtener(Int32.Parse(textEstadia.Text));
            if (estadia != null)
            {

                //Buscar y rellenar los valores
                dataGridFacturaEstadia.DataSource = DAOConsumible.obtenerTablaByEstadia(Int32.Parse(textEstadia.Text));
                double precioConsumibles = dataGridFacturaEstadia.Rows.Cast<DataGridViewRow>().Sum(X => Convert.ToInt32(X.Cells[4].Value));

                int cantPersonas_originales = DAOHabitacion.obtenerCantHabitacionesByReserva(reserva.CodigoReserva);
                double precioBase = Globals.obtenerPrecio(reserva.CodigoRegimen, cantPersonas_originales,
                    Globals.infoSesion.Hotel.Recargo);

                mostrarDatos(precioBase, precioConsumibles);

                DateTime eIngreso = (DateTime) estadia.Fecha_Ingreso_struct;
                DateTime eEgreso = (DateTime) estadia.Fecha_Egreso_struct;
                DateTime rIngreso = (DateTime)reserva.Fecha_Inicio_struct;
                DateTime rEgreso = (DateTime)reserva.Fecha_Fin_struct;
                mostrarDatosEstadia(eIngreso, eEgreso, rIngreso, rEgreso);                
                
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
                if (!DAOEstadia.facturar(reserva.CodigoReserva, comboTipoPago.SelectedItem.ToString(), textTarjeta.Text))
                {
                    MessageBox.Show("Error al generar la Factura", "", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Factura Generada Correctamente.", "", MessageBoxButtons.OK);
                //Mandar a imprimir
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

        private void mostrarDatosEstadia(DateTime eIngreso, DateTime eEgreso, DateTime rIngreso, DateTime rEgreso)
        {
            textIngreso.Text = eIngreso.ToString("dd/MM/yyyy");
            textEgreso.Text = eEgreso.ToString("dd/MM/yyyy");
            textDias.Text = rEgreso.Subtract(eEgreso).Days.ToString();
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
