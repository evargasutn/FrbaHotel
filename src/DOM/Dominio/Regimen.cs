using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Dominio
{
    public class Regimen
    {
        #region Atributos
        private int codRegimen = -1;
        private string descripcion = "''";
        private double precio = -1;
        private bool estado = true;
        #endregion

        #region Getters&Setters
        public int CodRegimen
        {
            get { return codRegimen; }
            set { codRegimen = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        #endregion

    }
}
