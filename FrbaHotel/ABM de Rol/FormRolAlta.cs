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
    public partial class FormRolAlta : Form
    {
        public FormRolAlta()
        {
            InitializeComponent();
            List<Funcionalidad> funcionalidades = Globals.FUNCIONALIDAD.getAllFuncionalidades();
            foreach(Funcionalidad func in funcionalidades)
                comboFuncionalidades.Items.Add(func);
            comboEstado.Items.Add("Activo");
            comboEstado.Items.Add("No Activo");            
        }
        private bool todosCamposCompletos()
        {
            if (textRol.Text == "")
                return false;
            if (comboEstado.SelectedItem == null)
                return false;
            if (comboFuncionalidades.SelectedItem == null)
                return false;
            return true;
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            if (todosCamposCompletos())
            {
                //Crear Rol
                Rol rol = new Rol();
                rol.Nombre = textRol.Text;
                rol.Estado = (string) comboEstado.SelectedItem;

                Funcionalidad funcionalidad_elegida = (Funcionalidad) comboFuncionalidades.SelectedItem;
                //Transaccion
                bool respuesta = Globals.ROL.createRolConFuncionalidad(rol, funcionalidad_elegida.Id_funcionalidad);

                if (!respuesta)
                {
                    MessageBox.Show("Error al conectarse con la DB. No se ha creado el Rol.", "Error al crear Nuevo Rol",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Dispose();
            }
            else
                MessageBox.Show("Complete todos los campos", "Error al crear Nuevo Rol",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormRolAlta_Load(object sender, EventArgs e)
        {

        }
        

        
    }
}
