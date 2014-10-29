using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM.DAO;
using DOM.Dominio;
using DOM;
namespace FrbaHotel.Login
{
    public partial class MainPanel : Form
    {
        
        List<Funcionalidad> funcsDelRolDelUser;
        Dictionary<String, Form> formularioXNombre;
        Usuario usuario;
        String hotelNombre;
      
        
        
        public MainPanel(Usuario usuario,String hotelNombre,String rolNombre)
        {                                                                      
            InitializeComponent();
            cargarFormularios();          
         funcsDelRolDelUser = DAOFuncionalidad.getFuncionalidad(rolNombre);
          foreach (Funcionalidad unFuncs in funcsDelRolDelUser)
              listFuncionalidades.Items.Add(unFuncs.Descripcion);
          
        }
        public MainPanel( )   ///Para invitados
        {
            InitializeComponent();
            ///cargar list funcionalidades para invitados
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            var funcionalidadElegida = listFuncionalidades.SelectedItem;
            if (funcionalidadElegida != null) 
                funcionalidadElegida.ToString();                
            else MessageBox.Show("Seleccione una funcionalidad", "Error no selecciono funcionalidad");
        }


        /// <summary>
        /// Se carga el diccionario de formularios,se deben completar las presentaciones
        /// </summary>
        public void cargarFormularios()
        {
            formularioXNombre.Add("ABM de Rol", new ABM_de_Rol.Presentacion(usuario));
            formularioXNombre.Add("ABM de Usuario", new ABM_de_Usuario.Presentacion(usuario, hotelNombre));
            formularioXNombre.Add("ABM de Huespedes",new ABM_de_Cliente.Presentacion(usuario,hotelNombre));
            formularioXNombre.Add("ABM de Hotel",new ABM_de_Hotel.Presentacion(usuario,hotelNombre));
            formularioXNombre.Add("ABM de Regimen",new ABM_de_Habitacion.Presentacion(usuario,hotelNombre));
            formularioXNombre.Add("Generar o Modificar una Reserva",new Generar_Modificar_Reserva.Presentacion(usuario,hotelNombre));
            formularioXNombre.Add("Cancelar Reserva",new Cancelar_Reserva.CancelarReserva(usuario,hotelNombre));
            formularioXNombre.Add("Registrar Estadia",new Registrar_Estadia.Presentacion(usuario,hotelNombre));
            formularioXNombre.Add("Registrar Consumibles",new Registrar_Consumible.RegistrarConsumibles());
           // formularioXNombre.Add("Facturar Estadia",new ); 
            formularioXNombre.Add("Listado Estadistico", new Listado_Estadistico.ListadoEstadistico());
        }





    }
}
