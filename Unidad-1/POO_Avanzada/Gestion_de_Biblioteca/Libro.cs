using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Biblioteca
{
    public class Libro
    {
        private string _strTitulo;
        private string _strAutor;
        private string _strISBN;

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

        public string ISBN
        {
            get { return _strISBN; }
            set { _strISBN = value; }
        }

        public Libro() { }

        public Libro(string titulo, string autor, string isbn)
        {
            _strTitulo = titulo;
            _strAutor = autor;
            _strISBN = isbn;
        }

        public override string ToString()
        {
            return $"{Titulo} — {Autor} (ISBN: {ISBN})";
        }
    }
}
