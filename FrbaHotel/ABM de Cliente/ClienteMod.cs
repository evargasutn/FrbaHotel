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

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class ClienteMod : Form
    {
        Huesped huesped_seleccionado;
        public ClienteMod(int idHuesped)
        {
            InitializeComponent();
            huesped_seleccionado = DAOHuesped.obtener(idHuesped);
            if (huesped_seleccionado == null)
            {
                MessageBox.Show("Error al cargar el cliente.", "Error al Modificar Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Globals.habilitarAnterior();
                this.Dispose();
            }
            cargarDatos();
        }

        private void cargarDatos()
        {
            textNombre.Text = huesped_seleccionado.Nombre;
            textApellido.Text = huesped_seleccionado.Apellido;
            //comboTipoDoc.SelectedIndex = huesped_seleccionado.TipoDocu;
            textNumDoc.Text = huesped_seleccionado.NroDocu.ToString();
            dateTimeNacimiento.Text = huesped_seleccionado.Fecha_nacimiento;
            textMail.Text = huesped_seleccionado.Mail;
            textTelefono.Text = huesped_seleccionado.Telefono.ToString();
            textDirCalle.Text = huesped_seleccionado.Direccion.calle_direccion;
            textDirAltura.Text = huesped_seleccionado.Direccion.calle_altura.ToString();
            textLocalidad.Text = huesped_seleccionado.Localidad;
            textPais.Text = huesped_seleccionado.Nacionalidad;
            if(huesped_seleccionado.Direccion.calle_dpto != "''")
                textDirDpto.Text = huesped_seleccionado.Direccion.calle_dpto;
            if(huesped_seleccionado.Direccion.calle_piso != -1)
                textDirPiso.Text = huesped_seleccionado.Direccion.calle_piso.ToString();
        }
    }
}
