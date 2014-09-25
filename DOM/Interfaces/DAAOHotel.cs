using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Dominio;

namespace DOM.Interfaces
{
    interface DAAOHotel
    {
        List<Hotel> getAllHotel();
        Hotel addHotel(Hotel hotel);
        Hotel getHotel(string nombre);
        void updateHotel(Hotel hotel);
        void deteleHotel(string nombre);
    }
}
