﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class FormLsBaja : Form
    {//En el listado deben aparecer solo los activos
        //para dar la baja logica a no activo
        public FormLsBaja()
        {
            InitializeComponent();
        }

        private void textBoxNombreRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboDeFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}