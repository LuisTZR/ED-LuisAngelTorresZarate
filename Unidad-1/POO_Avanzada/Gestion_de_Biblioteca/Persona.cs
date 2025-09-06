using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Biblioteca
{
    public abstract class Persona
    {
        protected string _strNombre;
        protected int _intID;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        public int ID
        {
            get { return _intID; }
            set { _intID = value; }
        }

        // Método virtual que puede ser sobrescrito por subclases 
        public virtual string MostrarInfo()
        {
            return $"Nombre: {Nombre}, ID: {ID}";
        }
    }

    // Interfaz sencilla para demostrar I/F
    public interface IRegistrable
    {
        void Registrar();
    }
}

