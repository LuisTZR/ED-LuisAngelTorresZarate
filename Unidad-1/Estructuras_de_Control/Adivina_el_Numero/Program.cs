using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivina_el_Numero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int intNumeroSecreto = random.Next(1, 101); // Numero entre 1 y 100
            int intIntento = 0;
            bool blnAdivinado = false;

            Console.WriteLine("He pensado un numero entre 1 y 100. Trata de adivínarlo.");

            while (!blnAdivinado)
            {
                try
                {
                    Console.Write("Ingresa tu numero: ");
                    intIntento = int.Parse(Console.ReadLine());

                    if (intIntento < intNumeroSecreto)
                    {
                        Console.WriteLine("El numero secreto es mayor.");
                    }
                    else if (intIntento > intNumeroSecreto)
                    {
                        Console.WriteLine("El numero secreto es menor.");
                    }
                    else
                    {
                        Console.WriteLine("¡Felicidades! Numero adivinado.");
                        blnAdivinado = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Se debe ingresar un numero valido.");
                }
            }
        }
    }
}
