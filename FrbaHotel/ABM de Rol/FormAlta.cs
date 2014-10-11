using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class FormAlta : Form
    {
        public FormAlta()
        {

            InitializeComponent();
            List<object> primes = new List<object>();
            primes.Add("....");
            primes.Add("......");
            Class1.cargarEnComboBox(comboDeFuncionalidades,primes);
            List<object> estado = new List<object>();
            primes.Add("Activo");
            primes.Add("No Activo");
            Class1.cargarEnComboBox(comboDeEstado, estado);
            
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            if (textRol.Text == "" | comboDeFuncionalidades.SelectedItem == null)
            {
                MessageBox.Show("The data input are complete", "My Application",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            else {  
            ///Cargar Datos
            ///
            
            }
        }


        string _textComboBoxFuncional;

        private void comboDeFuncionalidades_TextChanged(object sender, EventArgs e)
        {
            // Called whenever text changes.
            _textComboBoxFuncional = comboDeFuncionalidades.Text;
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
