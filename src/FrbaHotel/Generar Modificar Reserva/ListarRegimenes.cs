using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM.Dominio;
using DOM.DAO;
using DOM;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class ListarRegimenes : Form
    {
        public ListarRegimenes()
        {
            InitializeComponent();
        }

        private void ListarRegimenes_Load(object sender, EventArgs e)
        {
            dataGridRegimen.DataSource = DAORegimen.obtenerTabla();
            dataGridRegimen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridRegimen.AutoResizeColumns();
            dataGridRegimen.AutoResizeRows();
        }

        private void botonSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridRegimen.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un Régimen.",
                "", MessageBoxButtons.OK);
                return;
            }
            int codRegimen = Convert.ToInt32(dataGridRegimen.CurrentRow.Cells["codRegimen"].Value);

            ((GenerarReserva)Globals.VentanaAnterior).actualizarRegimen(codRegimen);
            this.Close();
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
