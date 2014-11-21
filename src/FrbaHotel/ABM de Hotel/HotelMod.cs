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
using System.Net.Mail;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class HotelMod : Form
    {
        Hotel hotel;
        List<Regimen> regimen_hotel;
        List<Regimen> regimenes;

        public HotelMod(int idHotel)
        {                  
            InitializeComponent();
            hotel = DAOHotel.obtener(idHotel);
            regimen_hotel = DAORegimen.obtenerByHotel(idHotel);
            regimenes = DAORegimen.obtenerTodos();
        }

        private void HotelMod_Load(object sender, EventArgs e)
        {
            //Cargamos las estrellas
            for (int i = 1; i < 6; i++)
                comboEstrellas.Items.Add(i);
            comboEstrellas.SelectedIndex = 0;

            //Cargamos los paises
            comboPais.Items.AddRange(Globals.paises);

            //Cargamos los Regimenes
            foreach (Regimen reg in regimenes)
                listaRegimenes.Items.Add(reg.Descripcion);
            for (int i = 0; i < listaRegimenes.Items.Count; i++)
                listaRegimenes.SetItemChecked(i, false);
            limpiarDatos();
        }

        private void limpiarDatos()
        {
            textNombre.Text = hotel.Nombre;
            textMail.Text = hotel.Mail;
            textTelefono.Text = hotel.Telefono.ToString();
            textDirCalle.Text = hotel.Direccion.calle_direccion;
            textDirAltura.Text = hotel.Direccion.calle_altura.ToString();
            textCiudad.Text = hotel.Ciudad;
            //Estrellas
            for (int i = 0; i < comboEstrellas.Items.Count; i++)
            {
                if(((int) comboEstrellas.Items[i]).CompareTo(hotel.Estrellas) == 0)
                    comboEstrellas.SelectedIndex = i;
            }
            //Pais
            comboPais.SelectedIndex = Globals.posPais(hotel.Pais);
            //Regimenes
            for (int i = 0; i < listaRegimenes.Items.Count; i++)
            {
                listaRegimenes.SetItemChecked(i, false);
                foreach (Regimen reg in regimen_hotel)
                    if (reg.Descripcion.Equals(listaRegimenes.Items[i]))
                        listaRegimenes.SetItemChecked(i, true);
            }
        }

        private void textTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente numeros.", textTelefono, textTelefono.Location);
        }

        private void textDirAltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente numeros.", textDirAltura, textDirAltura.Location);
        }

        private void showToolTip(string msj, Control ventana, Point pos)
        {
            toolTip.Hide(ventana);
            toolTip.SetToolTip(ventana, "Entrada Invalida");
            toolTip.Show(msj, ventana, 50, 10, 5000);
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (chequearCampos())
            {
                completarEstructura();
                if (!DAOHotel.actualizar(hotel))
                {
                    MessageBox.Show("Error al guardar el hotel en la Base de Datos. Por favor, intente nuevamente.", "Error");
                    //botonLimpiar_Click(null,null);
                    return;
                }
                bool estaChequeado;
                for(int i = 0; i< listaRegimenes.Items.Count; i++)
                {
                    estaChequeado = false;
                    foreach (int index in listaRegimenes.CheckedIndices)
                        if( i == index)
                            estaChequeado = true;
                    if (estaChequeado)
                        DAORegimen.insertarPorHotel(regimenes[i].CodRegimen, hotel.CodHotel);
                    else
                        DAORegimen.quitarPorHotel(regimenes[i].CodRegimen, hotel.CodHotel);
                }
                //Todo cargado! Salimos y actualizamos la grid de hoteles de Baja/Mod
                ((HotelBajaMod)Globals.VentanaAnterior).updateGrid();
                this.Close();
            }          
        }

        private Boolean chequearCampos()
        {
            // all field are obligatories
            if (textNombre.Text == "")
            {
                showToolTip("Ingrese un nombre valido.", textNombre, textNombre.Location);
                return false;
            }
            if (textMail.Text == "")
            {
                showToolTip("Ingrese un email.", textMail, textMail.Location);
                return false;
            }
            else
            {
                try //Chequeamos que el email sea valido
                {
                    new MailAddress(textMail.Text);
                }
                catch
                {
                    showToolTip("Ingrese un email valido.", textMail, textMail.Location);
                    return false;
                }
            }
            if (textTelefono.Text == "(   )    -")
            {
                showToolTip("Ingrese un telefono.", textTelefono, textTelefono.Location);
                return false;
            }
            if (textDirCalle.Text == "")
            {
                showToolTip("Ingrese una calle.", textDirCalle, textDirCalle.Location);
                return false;
            }
            if (textDirAltura.Text == "")
            {
                showToolTip("Ingrese una altura.", textDirAltura, textDirAltura.Location);
                return false;
            }
            if (textCiudad.Text == "")
            {
                showToolTip("Ingrese una ciudad.", textCiudad, textCiudad.Location);
                return false;
            }
            if (comboPais.SelectedIndex < 0)
            {
                showToolTip("Ingrese una pais.", comboPais, comboPais.Location);
                return false;
            }
            if (listaRegimenes.SelectedItems == null)
            {
                showToolTip("Ingrese al menos un régimen.", listaRegimenes, listaRegimenes.Location);
                return false;
            }
            return true;
        }

        public void completarEstructura()
        {
            hotel.Nombre = textNombre.Text;
            hotel.Mail = textMail.Text;
            hotel.Telefono = Convert.ToInt32(textTelefono.Text);
            hotel.Direccion.calle_altura = Convert.ToInt32(textDirAltura.Text);
            hotel.Direccion.calle_direccion = textDirCalle.Text;
            hotel.Estrellas = Convert.ToInt32(comboEstrellas.SelectedItem);
            //La fecha de creacion del hotel es la fecha actual del sistema
            hotel.Ciudad = textCiudad.Text;
            hotel.Pais = (string)comboPais.SelectedItem;
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
