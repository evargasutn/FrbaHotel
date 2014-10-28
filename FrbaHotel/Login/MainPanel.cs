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

        public MainPanel(Usuario elUsuario,String hotelNombre,String rolNombre)
        {                                                                      
            InitializeComponent();                                             
            ///cargar list funcionalidades                                                  
        }

        public MainPanel( )   ///Para invitados
        {
            InitializeComponent();
            ///cargar list funcionalidades
        }


    }
}
