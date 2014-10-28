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
        public MainPanel(Usuario elUsuario,Hotel elHotel)//para ¿usuarios se necesita el rol?
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
