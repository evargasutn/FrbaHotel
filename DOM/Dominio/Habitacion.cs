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
        private int id_habitacion;
        private int piso;
        private string ubicacion;
        private Tipo_Habitacion tipo_habitacion = new Tipo_Habitacion();
        private bool campoBaja = false;
        #endregion

        #region Getters&Setters
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
        public Tipo_Habitacion Tipo_habitacion
        {
            get { return tipo_habitacion; }
            set { tipo_habitacion = value; }
        }
        public bool CampoBaja
        {
            get { return campoBaja; }
            set { campoBaja = value; }
        }

        #endregion
    }
}
