using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void Inicial_Load(object sender, EventArgs e)
        {

        }
/// <summary>
/// Para los restrictivos
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ///validar al usuario
            ///

            if (true)
            {
                Form2 formEspR= new Form2();
                formEspR.Show();
              
            }
            else {
               //mostrar error 
            }

        }
    }
}
