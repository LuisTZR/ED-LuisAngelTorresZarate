using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Coche_y_Libro
{
    class Coche
    {
        private string _strMarca;
        private string _strModelo;
        private double _dblVelocidad;

        public string Marca
        {
            get { return _strMarca; }
            set { _strMarca = value; }
        }
        public string Modelo
        {
            get { return _strModelo; }
            set { _strModelo = value; }
        }
        public double Velocidad
        {
            get { return _dblVelocidad; }
            set { _dblVelocidad = value; }
        }
        //Metodos
        public void Acelerar()
        {
            Velocidad = Velocidad + 10;
        }
        public void Frenar()
        {
            Velocidad = 0;
        }
    }
}
