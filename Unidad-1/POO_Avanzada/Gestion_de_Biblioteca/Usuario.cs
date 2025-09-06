using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Biblioteca
{
    public class Usuario : Persona, IRegistrable
    {
        public Usuario() { }

        public Usuario(string nombre, int id)
        {
            _strNombre = nombre;
            _intID = id;
        }

        public void Registrar()
        {

        }

        // Override para demostrar polimorfismo
        public override string MostrarInfo()
        {
            return $"Usuario: {Nombre} (ID: {ID})";
        }

        public override string ToString()
        {
            return MostrarInfo();
        }
    }
}
