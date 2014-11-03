using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM;

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class FormModBajaUser : Form
    {
        public FormModBajaUser()
        {
            InitializeComponent();

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {

            //Limpiamos la DataGrid
            foreach (DataGridViewRow dgvr in dataGridUsuario.Rows)
                if (dgvr.Selected == true)
                    dataGridUsuario.Rows.Remove(dgvr);
            //Limiamos lo demas?
            textUsuario.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
            comboRol.SelectedItem = null;
            





        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            dataGridUsuario.DataSource = DAOUsuario.obtenerTabla("");
            for (int item = 6; item < dataGridUsuario.ColumnCount; item++)
            {
                dataGridUsuario.Columns[item].Visible = false;
            }
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            UsuarioAlta usrAlta = new UsuarioAlta();
            usrAlta.Show(this);
        }

        private void dataGridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridUsuario.Columns[e.ColumnIndex].HeaderText == "Modificar" )
            {
                FormModUser usrMod = new FormModUser();
                MessageBox.Show("Falta autocompletar con los datos del usr");
                usrMod.Show(this);
            }

            if (dataGridUsuario.Columns[e.ColumnIndex].HeaderText == "Baja")
            {
                string usrDelete = dataGridUsuario.Rows[e.RowIndex].Cells["usr"].FormattedValue.ToString();
                DialogResult dr = MessageBox.Show("Desea dar de Baja al usuario "+usrDelete+"?",
                      "", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes: 
                        DAOUsuario.borrar(usrDelete); 
                        break;
                    case DialogResult.No: break;
                }
                
            }
        }

        
    }
}
