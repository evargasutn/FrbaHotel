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
    public partial class FormRolBaja : Form
    {//En el listado deben aparecer solo los activos
        //para dar la baja logica a no activo
        List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
        DataTable tabla = null;
        public FormRolBaja()
        {
            InitializeComponent();
            funcionalidades = Globals.FUNCIONALIDAD.getAllFuncionalidades();
            foreach (Funcionalidad func in funcionalidades)
                comboFuncionalidad.Items.Add(func.Descripcion);
            comboFuncionalidad.SelectedItem = comboFuncionalidad.Items[0];

        }

        private void textBoxNombreRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboDeFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewRol.Columns[e.ColumnIndex].Name == "CampoEstado")
            {
                Globals.ROL.deteleRol(Convert.ToString((tabla.Rows[e.RowIndex])["nombreRol"]));
                ////dar de Baja al rol()inhabilitar
            }

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string nombreRol;
            int id_funcionalidad = -1;
            //Buscamos segun criterios
            nombreRol = textRol.Text;
            if(comboFuncionalidad.SelectedItem != null)
                id_funcionalidad = funcionalidades[comboFuncionalidad.SelectedIndex].Id_funcionalidad;
            tabla = Globals.ROL.buscarRoles(nombreRol, id_funcionalidad);
            dataGridViewRol.DataSource = tabla;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiamos la DataGrid
            foreach (DataGridViewRow dgvr in dataGridViewRol.Rows)
                if (dgvr.Selected == true)
                    dataGridViewRol.Rows.Remove(dgvr);
            tabla = null;
            //Limiamos lo demas?
            textRol.Text = "";
            comboFuncionalidad.Text = "";
        }

        private void FormLsBaja_Load(object sender, EventArgs e)
        {

        }

    }
    
}
