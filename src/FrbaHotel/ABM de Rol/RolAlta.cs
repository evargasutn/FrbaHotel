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

namespace FrbaHotel.ABM_de_Rol
{
    public partial class RolAlta : Form
    {
        private List<Funcionalidad> funcionalidades;

        public RolAlta()
        {
            InitializeComponent();
            funcionalidades = DAOFuncionalidad.obtenerTodas();
            foreach (Funcionalidad func in funcionalidades)
                comboFuncionalidades.Items.Add(func.Descripcion);
            comboEstado.Items.Add("Activo");
            comboEstado.Items.Add("No Activo");
            comboEstado.SelectedIndex = 0;
        }
        private bool todosCamposCompletos()
        {
            if (textRol.Text == "")
            {
                showToolTip("Ingrese un nombre.", textRol, textRol.Location);
                return false;
            }
            if (comboEstado.SelectedIndex == -1)
            {
                showToolTip("Seleccione un estado.", comboEstado, comboEstado.Location);
                return false;
            }
            if (comboFuncionalidades.SelectedIndex == -1)
            {
                showToolTip("Seleccione una funcionalidad", comboFuncionalidades, comboFuncionalidades.Location);
                return false;
            }
            return true;
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            if (todosCamposCompletos())
            {
                //Crear Rol
                Rol rol = new Rol();
                rol.Nombre = textRol.Text;
                if ((string)comboEstado.SelectedItem == "Activo")
                    rol.Estado = true;
                else
                    rol.Estado = false;
                Funcionalidad funcionalidad_elegida = funcionalidades[comboFuncionalidades.SelectedIndex];
                //Transaccion
                bool respuesta = DAORol.insertar(rol);
                if (!respuesta)
                {
                    MessageBox.Show("Error al conectarse con la DB. No se ha creado el Rol.", "Error al crear Nuevo Rol",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                respuesta = DAOFuncionalidad.agregarFuncionalidad(rol.Nombre, funcionalidad_elegida.Id_funcionalidad);
                if (!respuesta)
                {
                    MessageBox.Show("Error al conectarse con la DB. No se han agreado las funcionalidades. Por favor, agreguelas en Modificar Rol.", "Error al crear Carar Funcionalidades",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Dispose();
                }                //, funcionalidad_elegida.Id_funcionalidad);
                MessageBox.Show("Rol " + textRol.Text + " creado satisfactoriamente.", "Alta Rol",
                MessageBoxButtons.OK);
                ((RolBajaMod)Globals.VentanaAnterior).updateGrid();
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
        
    }
}
