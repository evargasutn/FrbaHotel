using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM.Dominio;
using DOM;
using DOM.Auxiliares;
using DOM.DAO;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class ConfirmarReserva : Form
    {
        Reserva datos_Reserva;
        public ConfirmarReserva(Reserva reserva)
        {
            InitializeComponent();
            datos_Reserva = reserva;
        }

        private void ConfirmarReserva_Load(object sender, EventArgs e)
        {
            foreach (string tipo in Documento.string_docu)
                comboTipoDoc.Items.Add(tipo);
            double precio = obtenerPrecio(datos_Reserva.CodigoRegimen, datos_Reserva.tipo_habitacion.CantPersonas);
            textCostoReserva.Text = precio.ToString();
        } 

        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            //Efectuar Reserva
            if (dataGridClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un Cliente para confirmar la reserva.",
                "", MessageBoxButtons.OK);
                return;
            }
            int codHuesped = Convert.ToInt32(dataGridClientes.CurrentRow.Cells["idHuesped"].Value);

            datos_Reserva.Huesped = codHuesped;
            if (DAOReserva.agregar(datos_Reserva))
            {
                MessageBox.Show("Error al confirmar la reserva.",
                "", MessageBoxButtons.OK);
                return;
            }
            //Agregamos los detalles de las habitaciones
            foreach (Detalle_Reserva detalle in datos_Reserva.detalles_reserva)
                DAOReserva.agregarHabitacion(detalle);

            MessageBox.Show("Reserva Realizada Correctamente.",
            "", MessageBoxButtons.OK);

            Globals.VentanaAnterior.Dispose();
            Globals.habilitarAnterior();
            this.Close();
        }

        private void buttonRegistrarCliente_Click(object sender, EventArgs e)
        {
            new ABM_de_Cliente.ClienteAlta().Show();
            Globals.deshabilitarAnterior(this);
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            //Mostrar en DataGrid el Cliente
        }

        private double obtenerPrecio(int codRegimen, int cantPersonas)
        {
            Regimen reg = DAORegimen.obtener(codRegimen);
            
            return (reg.Precio*cantPersonas)+Globals.infoSesion.Hotel.Recargo;
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
