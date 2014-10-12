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
    public partial class FormAlta : Form
    {
        public FormAlta()
        {
            InitializeComponent();
            List<Funcionalidad> funcionalidades = Program.global.FUNCIONALIDAD.getAllFuncionalidades();
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
            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Error al crear Nuevo Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        string _textComboBoxFuncional;

        private void comboDeFuncionalidades_TextChanged(object sender, EventArgs e)
        {
            // Called whenever text changes.
            _textComboBoxFuncional = comboFuncionalidades.Text;
        }
    
        

        private void FormAlta_Load(object sender, EventArgs e)
        {

        }

        private void comboDeEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboDeFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
 


    }
}
