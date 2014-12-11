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

namespace FrbaHotel.Registrar_Consumible
{
    public partial class RegistrarConsumibles : Form
    {
        Reserva reserva; //Por no usar estadia....todavia no esta el DAO, entonces uso este :P
        public RegistrarConsumibles()
        {
            InitializeComponent();
        }

        private void RegistrarConsumibles_Load(object sender, EventArgs e)
        {
            dataGridConsumible.DataSource = DAOConsumible.obtenerTablaTodos();
            dataGridConsumible.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridConsumible.AutoResizeColumns();
            dataGridConsumible.AutoResizeRows();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (textEstadia.Text == "")
            {
                showToolTip("Ingrese un código de estadia.", textEstadia, textEstadia.Location);
                return;
            }
            reserva = DAOReserva.obtener(Int32.Parse(textEstadia.Text));
            if (reserva != null)
            {
                if (reserva.Estado == 6)
                {
                    dataGridEstadia.DataSource = DAOConsumible.obtenerTablaByEstadia(reserva.CodigoReserva);
                    dataGridEstadia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridEstadia.AutoResizeColumns();
                    dataGridEstadia.AutoResizeRows();
                }
                else
                    if (reserva.Estado <= 2) 
                        showToolTip("Reserva no efectivizada aún. Por favor, ingrese una reserva efectivizada.", textEstadia, textEstadia.Location);
                    else
                        showToolTip("Reserva Cancelada. Por favor, ingrese una reserva válida.", textEstadia, textEstadia.Location);
            }
            else
                showToolTip("Ingrese un código de estadia válido.", textEstadia, textEstadia.Location);
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            if (chequearDatos())
            {
                int _codConsumible = Convert.ToInt32(dataGridConsumible.CurrentRow.Cells["codConsumible"].Value);
                string _consumible = dataGridConsumible.CurrentRow.Cells["descripcion"].Value.ToString();
                int _cant = Int32.Parse(textCantidad.Text);
                DialogResult dr = MessageBox.Show("Desea agregar el consumible " + _consumible +
                    " con cantidad " + _cant + " a la estadia " + reserva.CodigoReserva + "?",
                    "", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        if(!DAOConsumible.insertarConsumibleXEstadia(reserva.CodigoReserva, _codConsumible, _cant))
                            MessageBox.Show("Error al registrar el consumible. Asegúrese que el consumible no se encuentre registrado.",
                                "Error", MessageBoxButtons.OK);
                        else
                            updateGrid();
                        break;
                    case DialogResult.No: break;
                }
            }
        }

        private void botonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridEstadia.CurrentRow == null)
            {
                showToolTip("Seleccione un consumible a remover.", botonRemover, botonRemover.Location);
                return;
            }
            string _detalleConsumible = Convert.ToString(dataGridEstadia.CurrentRow.Cells["DETALLE"].Value);
            Consumible _consumible = DAOConsumible.obtener(_detalleConsumible);
            DialogResult dr = MessageBox.Show("Desea remover el consumible " + _detalleConsumible + " de la reserva " + reserva.CodigoReserva + "?",
                "", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    if (!DAOConsumible.borrarConsumibleXEstadia(reserva.CodigoReserva, _consumible.Codigo))
                        MessageBox.Show("Error al remover el consumible.", "Error", MessageBoxButtons.OK);
                    else
                        updateGrid();
                    break;
                case DialogResult.No: break;
            }
        }
        private void updateGrid()
        {
            botonBuscar_Click(null, null);
        }

        private bool chequearDatos()
        {
            if (dataGridEstadia.DataSource == null)
            {
                showToolTip("Ingrese un código de estadia válido para poder registrar los consumibles.", textEstadia, textEstadia.Location);
                return false;
            }
            if (dataGridConsumible.CurrentRow == null)
            {
                showToolTip("Seleccione un consumible a registrar.", botonRegistrar, botonRegistrar.Location);
                return false;
            }
            if (textCantidad.Text == "")
            {
                showToolTip("Ingrese una cantidad a registrar.", textCantidad, textCantidad.Location);
                return false;
            }
            return true;
        }

        private void textCantidad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente números.", textCantidad, textCantidad.Location);
        }

        private void textEstadia_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente números.", textEstadia, textEstadia.Location);
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
