using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace DOM
{
    public class Globals
    {
        #region Configuracion
        private static int _userID = 0;

        private static string connectionString = ConfigurationManager.ConnectionStrings["sqlserver2008"].ConnectionString;
        private static bool isLogged = false;

        public static int userID
        {
            get { return _userID; }
            set { _userID = value; }
        }
        public static string getConnectionString()
        {
            return connectionString;
        }

        public static DateTime getFechaSistema()
        {
            return Convert.ToDateTime(ConfigurationSettings.AppSettings["fechaSistema"]);
        }

        public static void setAdminLoggeado(bool status)
        {
            isLogged=status;
        }

        public static bool adminLoggeado()
        {
            return isLogged;
        }
        #endregion

        #region Singletons Ventanas
        private static Form ventanaAnterior;

        public static Form VentanaAnterior
        {
            get { return ventanaAnterior; }
            set { ventanaAnterior = value; }
        }

        public static void deshabilitarAnterior(Form vent)
        {
            ventanaAnterior = vent;
            vent.Enabled = false;
        }

        public static void habilitarAnterior()
        {
            ventanaAnterior.Enabled = true;
        }

        #endregion

        #region Paises array
        public static int posPais(string pais)
        {
            for (int i = 0; i < paises.Length; i++)
                if (paises[i].ToUpper().CompareTo(pais) == 0)
                    return i;
            return -1;
        }
        public static string[] paises = new string[] {  "Abjasia",
                                                        "Acrotiri y Dhekelia",
                                                        "Afganistán",
                                                        "Albania",
                                                        "Alemania",
                                                        "Andorra",
                                                        "Angola",
                                                        "Anguila",
                                                        "Antigua y Barbuda",
                                                        "Arabia Saudita",
                                                        "Argelia",
                                                        "Argentina",
                                                        "Armenia",
                                                        "Aruba",
                                                        "Australia",
                                                        "Austria",
                                                        "Azerbaiyán",
                                                        "Bahamas",
                                                        "Bangladés",
                                                        "Barbados",
                                                        "Baréin",
                                                        "Bélgica",
                                                        "Belice",
                                                        "Benín",
                                                        "Bermudas",
                                                        "Bielorrusia",
                                                        "Birmania",
                                                        "Bolivia",
                                                        "Bosnia y Herzegovina",
                                                        "Botsuana",
                                                        "Brasil",
                                                        "Brunéi",
                                                        "Bulgaria",
                                                        "Burkina Faso",
                                                        "Burundi",
                                                        "Bután",
                                                        "Cabo Verde",
                                                        "Caimán, Islas",
                                                        "Camboya",
                                                        "Camerún",
                                                        "Canadá",
                                                        "Catar",
                                                        "Centroafricana, República",
                                                        "Chad",
                                                        "Checa, República",
                                                        "Chile",
                                                        "China",
                                                        "Chipre",
                                                        "Chipre del Norte",
                                                        "Cocos, Islas",
                                                        "Colombia",
                                                        "Comoras",
                                                        "Congo, República del",
                                                        "Congo, República Democrática del",
                                                        "Cook, Islas",
                                                        "Corea del Norte",
                                                        "Corea del Sur",
                                                        "Costa de Marfil",
                                                        "Costa Rica",
                                                        "Croacia",
                                                        "Cuba",
                                                        "Curazao",
                                                        "Dinamarca",
                                                        "Dominica",
                                                        "Dominicana, República",
                                                        "Ecuador",
                                                        "Egipto",
                                                        "El Salvador",
                                                        "Emiratos Árabes Unidos",
                                                        "Eritrea",
                                                        "Eslovaquia",
                                                        "Eslovenia",
                                                        "España",
                                                        "Estado Islámico",
                                                        "Estados Unidos",
                                                        "Estonia",
                                                        "Etiopía",
                                                        "Feroe, Islas",
                                                        "Filipinas",
                                                        "Finlandia",
                                                        "Fiyi",
                                                        "Francia",
                                                        "Gabón",
                                                        "Gambia",
                                                        "Georgia",
                                                        "Ghana",
                                                        "Gibraltar",
                                                        "Granada",
                                                        "Grecia",
                                                        "Groenlandia",
                                                        "Guam",
                                                        "Guatemala",
                                                        "Guernsey",
                                                        "Guinea",
                                                        "Guinea Ecuatorial",
                                                        "Guinea-Bisáu",
                                                        "Guyana",
                                                        "Haití",
                                                        "Honduras",
                                                        "Hong Kong",
                                                        "Hungría",
                                                        "India",
                                                        "Indonesia",
                                                        "Irak",
                                                        "Irán",
                                                        "Irlanda",
                                                        "Islandia",
                                                        "Israel",
                                                        "Italia",
                                                        "Jamaica",
                                                        "Japón",
                                                        "Jersey",
                                                        "Jordania",
                                                        "Kazajistán",
                                                        "Kenia",
                                                        "Kirguistán",
                                                        "Kiribati",
                                                        "Kosovo",
                                                        "Kuwait",
                                                        "Laos",
                                                        "Lesoto",
                                                        "Letonia",
                                                        "Líbano",
                                                        "Liberia",
                                                        "Libia",
                                                        "Liechtenstein",
                                                        "Lituania",
                                                        "LTNA",
                                                        "Luxemburgo",
                                                        "Macao",
                                                        "Macedonia",
                                                        "Madagascar",
                                                        "Malasia",
                                                        "Malaui",
                                                        "Maldivas",
                                                        "Malí",
                                                        "Malta",
                                                        "Malvinas, Islas",
                                                        "Man, Isla de",
                                                        "Marianas del Norte, Islas",
                                                        "Marruecos",
                                                        "Marshall, Islas",
                                                        "Mauricio",
                                                        "Mauritania",
                                                        "México",
                                                        "Micronesia",
                                                        "Moldavia",
                                                        "Mónaco",
                                                        "Mongolia",
                                                        "Montenegro",
                                                        "Montserrat",
                                                        "Mozambique",
                                                        "Nagorno Karabaj",
                                                        "Namibia",
                                                        "Nauru",
                                                        "Navidad, Isla de",
                                                        "Nepal",
                                                        "Nicaragua",
                                                        "Níger",
                                                        "Nigeria",
                                                        "Niue",
                                                        "Norfolk, Isla",
                                                        "Noruega",
                                                        "Nueva Caledonia",
                                                        "Nueva Rusia",
                                                        "Nueva Zelanda",
                                                        "Omán",
                                                        "Osetia del Sur",
                                                        "Países Bajos",
                                                        "Pakistán",
                                                        "Palaos",
                                                        "Palestina",
                                                        "Panamá",
                                                        "Papúa Nueva Guinea",
                                                        "Paraguay",
                                                        "Perú",
                                                        "Pitcairn, Islas",
                                                        "Polinesia Francesa",
                                                        "Polonia",
                                                        "Portugal",
                                                        "Puerto Rico",
                                                        "Reino Unido",
                                                        "Ruanda",
                                                        "Rumania",
                                                        "Rusia",
                                                        "Sahara Occidental",
                                                        "Salomón, Islas",
                                                        "Samoa",
                                                        "Samoa Americana",
                                                        "San Bartolomé",
                                                        "San Cristóbal y Nieves",
                                                        "San Marino",
                                                        "San Martín",
                                                        "San Pedro y Miquelón",
                                                        "San Vicente y las Granadinas",
                                                        "Santa Elena, Ascensión y Tristán de Acuña",
                                                        "Santa Lucía",
                                                        "Santo Tomé y Príncipe",
                                                        "Senegal",
                                                        "Serbia",
                                                        "Seychelles",
                                                        "Sierra Leona",
                                                        "Singapur",
                                                        "Sint Maarten",
                                                        "Siria",
                                                        "Somalia",
                                                        "Somalilandia",
                                                        "Sri Lanka",
                                                        "Suazilandia",
                                                        "Sudáfrica",
                                                        "Sudán",
                                                        "Sudán del Sur",
                                                        "Suecia",
                                                        "Suiza",
                                                        "Surinam",
                                                        "Svalbard",
                                                        "Tailandia",
                                                        "Taiwán",
                                                        "Tanzania",
                                                        "Tayikistán",
                                                        "Timor Oriental",
                                                        "Togo",
                                                        "Tokelau",
                                                        "Tonga",
                                                        "Transnistria",
                                                        "Trinidad y Tobago",
                                                        "Túnez",
                                                        "Turcas y Caicos, Islas",
                                                        "Turkmenistán",
                                                        "Turquía",
                                                        "Tuvalu",
                                                        "Ucrania",
                                                        "Uganda",
                                                        "Uruguay",
                                                        "Uzbekistán",
                                                        "Vanuatu",
                                                        "Vaticano, Ciudad del",
                                                        "Venezuela",
                                                        "Vietnam",
                                                        "Vírgenes Británicas, Islas",
                                                        "Vírgenes de los Estados Unidos, Islas",
                                                        "Wallis y Futuna",
                                                        "Yemen",
                                                        "Yibuti",
                                                        "Zambia",
                                                        "Zimbabue" };
        #endregion
    }
}
