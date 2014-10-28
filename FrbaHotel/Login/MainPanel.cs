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
        //para ¿usuarios se necesita el rol?
        ///Ver si no es mas necesario manejarse
        /// //con los objetos Rol y Hotel
        /// //en vez de usar los nombres 
        List<Funcionalidad> funcsDelRolDelUser; 


        public MainPanel(Usuario elUsuario,String hotelNombre,String rolNombre)
        {                                                                      
            InitializeComponent();
            ///Se carga list funcionalidades                                                  
         funcsDelRolDelUser = DAOFuncionalidad.getFuncionalidad(rolNombre);///devuelve una lista de funcionalidades por nmbre de rol
          foreach (Funcionalidad unFuncs in funcsDelRolDelUser)
              listFuncionalidades.Items.Add(unFuncs.Descripcion);
        }

        public MainPanel( )   ///Para invitados
        {
            InitializeComponent();
            ///cargar list funcionalidades
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            var funcionalidadElegida = listFuncionalidades.SelectedItem;
            if (funcionalidadElegida != null) 
                
                ;
            else MessageBox.Show("Seleccione una funcionalidad", "Error no selecciono funcionalidad");
            

        }


    }
}
