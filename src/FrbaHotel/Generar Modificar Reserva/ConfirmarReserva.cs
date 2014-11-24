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
using System.Net.Mail;

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
            if (!DAOReserva.agregar(datos_Reserva))
            {
                MessageBox.Show("Error al confirmar la reserva.",
                "", MessageBoxButtons.OK);
                return;
            }

            datos_Reserva.CodigoReserva = DAOReserva.obtener(datos_Reserva).CodigoReserva;

            //Agregamos los detalles de las habitaciones
            foreach (Detalle_Reserva detalle in datos_Reserva.detalles_reserva)
            {
                detalle.CodigoReserva = datos_Reserva.CodigoReserva;
                DAOReserva.agregarHabitacion(detalle);
            }
            MessageBox.Show("Reserva Realizada Correctamente.",
            "", MessageBoxButtons.OK);

            Globals.habilitarAnterior();
            Globals.VentanaAnterior.Dispose();
            this.Close();
        }

        private void buttonRegistrarCliente_Click(object sender, EventArgs e)
        {
            new ABM_de_Cliente.ClienteAlta().Show();
            Globals.deshabilitarAnterior(this);
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if(chequearDatos())
            {
            //Mostrar en DataGrid el Cliente
                dataGridClientes.DataSource = DAOHuesped.obtenerTabla(comboTipoDoc.SelectedItem.ToString(),Int32.Parse(textNroDoc.Text),textMail.Text);
                dataGridClientes.Columns["campoBaja"].Visible = false; 
                dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridClientes.AutoResizeColumns();
                dataGridClientes.AutoResizeRows();
            }
        }

        private bool chequearDatos()
        {
            if (comboTipoDoc.SelectedIndex == -1)
            {
                showToolTip("Ingrese un tipo de documento.", comboTipoDoc, comboTipoDoc.Location);
                return false;
            }
            if (textNroDoc.Text == "")
            {
                showToolTip("Ingrese un número de documento.", textNroDoc, textNroDoc.Location);
                return false;
            }
            else if (textMail.Text == "")
            {
                showToolTip("Ingrese un email.", textMail, textMail.Location);
                return false;
            }
            else
            {
                try
                {
                    new MailAddress(textMail.Text);
                }
                catch
                {
                    showToolTip("Ingrese un email válido.", textMail, textMail.Location);
                    return false;
                }
            }
            return true;
        }
        
        private double obtenerPrecio(int codRegimen, int cantPersonas)
        {
            Regimen reg = DAORegimen.obtener(codRegimen);
            
            return (reg.Precio*cantPersonas)+Globals.infoSesion.Hotel.Recargo;
        }      

        private void textNroDoc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese números solamente", textNroDoc, textNroDoc.Location);
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
