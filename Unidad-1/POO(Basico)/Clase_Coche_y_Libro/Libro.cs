using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Coche_y_Libro
{
    class Libro
    {
        private string _strTitulo;
        private string _strAutor;

        public string Titulo
        {
            get { return _strTitulo; }
            set { _strTitulo = value; }
        }
        public string Autor
        {
            get { return _strAutor; }
            set { _strAutor = value; }
        }

        public string MostrarInformacion()
        {
            return "Titulo del libro: " + Titulo + "; Autor del libro: " + Autor;
        }
    }
}
