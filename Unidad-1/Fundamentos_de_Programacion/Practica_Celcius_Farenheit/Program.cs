using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Celcius_Farenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double dblValorCelcius = 0;
            double dblValorFarenheit = 0;
            Console.WriteLine("Ingrese un valor de grados en Celcius para convertir a grados Fareheit:");
            dblValorCelcius = double.Parse(Console.ReadLine());
            dblValorFarenheit = (dblValorCelcius * 1.8) + 32 ;
            Console.WriteLine($"El valor de {dblValorCelcius} grados Celcius tiene un valor de {dblValorFarenheit} grados en Farenheit.");
        }
    }
}
