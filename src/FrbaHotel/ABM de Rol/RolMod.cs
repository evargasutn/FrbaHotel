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

namespace FrbaHotel.ABM_de_Rol
{
    public partial class RolMod : Form
    {//En el listado deben aparecer solo los activos
        //para dar la baja logica a no activo
        List<Funcionalidad> funcionalidades;
        List<Funcionalidad> funcionalidadesRol;
        Rol rolSeleccionado;

        //Listas locas para stash de funcionalidades
        List<Funcionalidad> lista_baja = new List<Funcionalidad>();
        List<Funcionalidad> lista_alta = new List<Funcionalidad>();

        public RolMod(string nombreRol)
        {
            InitializeComponent();
            rolSeleccionado = DAORol.obtener(nombreRol);
            funcionalidadesRol = DAOFuncionalidad.obtenerPorRol(nombreRol);
            funcionalidades = DAOFuncionalidad.obtenerTodas();
            if (rolSeleccionado == null && funcionalidades == null && funcionalidadesRol == null)
            {
                MessageBox.Show("Error al conectarse a la DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }

            cargarDatos();
            
        }

        private void cargarDatos()
        {
            //Cargamos todas las funcionalidades
            foreach (Funcionalidad func in funcionalidades)
                comboFuncionalidad.Items.Add(func.Descripcion);

            //Cargamos los datos del Rol
            textRol.Text = rolSeleccionado.Nombre;
            comboEstado.Items.Add("Activo");
            comboEstado.Items.Add("No Activo");
            if (rolSeleccionado.Estado)
                comboEstado.SelectedIndex = 0;
            else
                comboEstado.SelectedIndex = 1;

            //Cargamos las funcionalidades del Rol
            foreach (Funcionalidad func in funcionalidadesRol)
                listBox.Items.Add(func.Descripcion);
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if(comboFuncionalidad.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una funcionalidad antes de poder agegarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Funcionalidad funcNueva = new Funcionalidad();
            funcNueva.Descripcion = (string) comboFuncionalidad.SelectedItem;
            funcNueva.matchFuncionalidadWithDescrp(funcionalidades);

            removerLista(lista_baja, funcNueva);
            lista_alta.Add(funcNueva);

            listBox.Items.Add(funcNueva.Descripcion);
        }

        private void botonQuitar_Click(object sender, EventArgs e)
        {
            if(listBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una funcionalidad antes de poder quitarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string descripcion = (string)listBox.SelectedItem;
            Funcionalidad funcNueva = new Funcionalidad();
            funcNueva.Descripcion = descripcion;
            funcNueva.matchFuncionalidadWithDescrp(funcionalidades);

            removerLista(lista_alta, funcNueva);
            lista_baja.Add(funcNueva);

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if ((string)listBox.Items[i] == descripcion)
                {
                    listBox.Items.RemoveAt(i);
                    return;
                }
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            rolSeleccionado.Nombre = textRol.Text;
            if ((string)comboEstado.SelectedItem == "Activo")
                rolSeleccionado.Estado = true;
            else
                rolSeleccionado.Estado = false;
            
            if (!DAORol.guardar(rolSeleccionado))
            {
                toolTip.Hide(textRol);
                toolTip.SetToolTip(textRol, "Entrada Invalida");
                toolTip.Show("Ingrese un nombre de Rol Válido.", textRol, 50, 10, 5000);
                return;
            }
            DAOFuncionalidad.updateFuncXRol(rolSeleccionado.Nombre, lista_alta, lista_baja);
            MessageBox.Show("Rol modificado satisfactoriamente.", "Modificar Rol",
                MessageBoxButtons.OK);

            ((RolBajaMod)Globals.VentanaAnterior).updateGrid();
            this.Close();
        }

        private void removerLista(List<Funcionalidad> lista, Funcionalidad funcNueva)
        {
            foreach (Funcionalidad f in lista)
            {
                if (f.Id_funcionalidad == funcNueva.Id_funcionalidad)
                {
                    lista.Remove(f);
                    return;
                }
            }
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
