using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM.DAO;
using DOM.Dominio;
using DOM;
using System.Net.Mail;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class HotelAlta : Form
    {
        Hotel hotelNuevo = new Hotel();
        List<Regimen> regimenes;

        public HotelAlta()
        {
            InitializeComponent();
        }

        private void HotelAlta_Load(object sender, EventArgs e)
        {
            //Cargamos las estrellas
            for (int i = 1; i < 6; i++)
                comboCantEstrellas.Items.Add(i);
            comboCantEstrellas.SelectedIndex = 0;

            //Cargamos los regimenes
            regimenes = DAORegimen.obtenerTodos();

            foreach (Regimen reg in regimenes)
                if(reg.Estado)
                    listaRegimenes.Items.Add(reg.Descripcion);

            //Cargamos los paises
            comboPais.Items.AddRange(Globals.paises);
        }

        public void completarEstructura()
        {
            hotelNuevo.Nombre = textNombre.Text;
            hotelNuevo.Mail = textMail.Text;
            hotelNuevo.Telefono = Convert.ToInt32(textTelefono.Text);
            hotelNuevo.Direccion.calle_altura = Convert.ToInt32(textDirAltura.Text);
            hotelNuevo.Direccion.calle_direccion = textDirCalle.Text;
            hotelNuevo.Estrellas = Convert.ToInt32(comboCantEstrellas.SelectedItem);
            //La fecha de creacion del hotel es la fecha actual del sistema
            hotelNuevo.Fecha_creacion_struct = Globals.getFechaSistema(); //Asi se obtiene la fecha del sistema :P
            hotelNuevo.Ciudad = textCiudad.Text;
            hotelNuevo.Pais = (string) comboPais.SelectedItem;
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

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textNombre.Text = "";
            textMail.Text = "";
            textTelefono.Text = "";
            textDirCalle.Text = "";
            textDirAltura.Text = "";
            comboCantEstrellas.SelectedIndex = -1;
            textCiudad.Text = "";
            comboPais.SelectedIndex = -1;
            for (int item = 0; item < listaRegimenes.Items.Count; item++)
                listaRegimenes.SetItemChecked(item, false);
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (chequearCampos())
            {
                //Probamos en guardar el hotel
                completarEstructura();
                if (!DAOHotel.insertar(hotelNuevo))
                {
                    MessageBox.Show("Error al guardar el hotel en la Base de Datos. Por favor, intente nuevamente.","Error");
                    //botonLimpiar_Click(null,null);
                    return;
                }
                //Bien! El hotel se guardo, ahora guardemos los regimenes del hotel

                //Como el codHotel es autonumerico, necesitamos obtenerlo
                int codHotel = DAOHotel.obtener(hotelNuevo.Nombre).CodHotel;
                foreach (int index_reg in listaRegimenes.CheckedIndices)
                    if (!DAORegimen.insertarPorHotel(regimenes[index_reg].CodRegimen, codHotel))
                    {
                        //Hacemos un chequeo por si se nos rompe todo y quedamos solo con parte cargados en la DB
                        MessageBox.Show("Error al guardar los regimenes en la Base de Datos. Por favor, agregue los regimenes faltantes en la ventana de modificacion.", "Error");
                        ((HotelBajaMod)Globals.VentanaAnterior).updateGrid();
                        this.Close();
                    }
                //Todo cargado! Salimos y actualizamos la grid de hoteles de Baja/Mod
                ((HotelBajaMod)Globals.VentanaAnterior).updateGrid();
                this.Close();
            }
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

        private void textTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente numeros.", textTelefono, textTelefono.Location);
        }

        private void textDirAltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente numeros.", textDirAltura, textDirAltura.Location);
        }
    }
}
