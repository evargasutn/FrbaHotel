using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
namespace Utilidades
{
    public class DropDownListManager
    {
        public static void CargarCombo(ComboBox combo,object dataSource, string selectedValue, string displayMember, bool conTextoiDefault, string textoDefault)
        {
            
            if(conTextoiDefault)
            {
                // todo, hacer en algun momento;
                DataRow dr = ((DataTable)dataSource).NewRow();
                dr[selectedValue] = 0;
                if (textoDefault == string.Empty)
                {
                    dr[displayMember] = "Seleccione...";
                }
                else
                {
                    dr[displayMember] = 0;
                }
                ((DataTable)dataSource).Rows.InsertAt(dr,0);
            }
            

            if (displayMember.Length > 0)
            {
                combo.DisplayMember = displayMember;
            }
            if(selectedValue.Length > 0)
            {
                combo.ValueMember = selectedValue;
            }

            combo.DataSource = dataSource;
        }
        public static void CargarCombo(ComboBox cmb, DataSet list, string selectedValue, string displayMember, bool conTextoiDefault)
        {
            CargarCombo(cmb, list.Tables[0], selectedValue, displayMember, conTextoiDefault);
        }
        public static void CargarCombo(ComboBox cmb, DataTable list, string selectedValue, string displayMember, bool conTextoiDefault)
        {
            if (displayMember.Length > 0)
            {
                cmb.DisplayMember = displayMember;
            }
            if (selectedValue.Length > 0)
            {
                cmb.ValueMember = selectedValue;
            }
            cmb.DataSource = list;
        }
        public static void CargarCombo(ComboBox cmb, List<object> list, string selectedValue, string displayMember, bool conTextoiDefault)
        {
            CargarCombo(cmb, list, selectedValue, displayMember, conTextoiDefault, string.Empty);
        }

        public static int GetIntValue(ComboBox cmb)
        {
            return Convert.ToInt32(cmb.SelectedValue);
        }

        public static void SetIntValue(ComboBox cmb, int valor)
        {
            if (valor == 0)
            {
                if (cmb.Items.Count > 0)
                {
                    cmb.SelectedValue = 0;
                }
            }
            else
            {
                cmb.SelectedValue = valor;
            }
        }

        public static void CargarComboSiNo(ComboBox cmbEstado)
        {
            DataSet dsSiNo = new DataSet();
            DataTable dt = new DataTable();
            DataColumn dcValor = new DataColumn("valor", typeof(int));
            DataColumn dcTexto = new DataColumn("nombre", typeof(string));
            dt.Columns.Add(dcValor);
            dt.Columns.Add(dcTexto);
            DataRow drNo = dt.NewRow();
            drNo["valor"] = 0;
            drNo["nombre"] = "No";
            DataRow drSi = dt.NewRow();
            drSi["valor"] = 1;
            drSi["nombre"] = "Si";
            dt.Rows.Add(drNo);
            dt.Rows.Add(drSi);
            dsSiNo.Tables.Add(dt);
            DropDownListManager.CargarCombo(cmbEstado, dsSiNo.Tables[0], "valor", "nombre", false);
        }
    }
}
