using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilidades
{
    public class DataGridViewColumnManager
    {
        public static void AddColumn(DataGridView grilla,string nombreCampoABindiar, string headText)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = nombreCampoABindiar;
            column.Name = nombreCampoABindiar;
            column.HeaderText = headText;
            column.Width = 100;
            
            grilla.Columns.Add(column);
        }
    }
}
