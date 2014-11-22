using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;

namespace DOM.Dominio
{
    public class Habitacion
    {
        #region Atributos
        private int codHotel = -1;
        private int id_habitacion = -1;
        private int piso = -1;
        private string ubicacion = "''";
        private int tipo_codigo = -1;
        private string descripcion = "''";
        private bool campoBaja = false;
        #endregion

        #region Getters&Setters
        public int CodHotel
        {
            get { return codHotel; }
            set { codHotel = value; }
        }
        public int Id_Habitacion
        {
            get { return id_habitacion; }
            set { id_habitacion = value; }
        }
        public int Piso
        {
            get { return piso; }
            set { piso = value; }
        }
        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        public int Tipo_codigo
        {
            get { return tipo_codigo; }
            set { tipo_codigo = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public bool CampoBaja
        {
            get { return campoBaja; }
            set { campoBaja = value; }
        }
        #endregion
    }
}
