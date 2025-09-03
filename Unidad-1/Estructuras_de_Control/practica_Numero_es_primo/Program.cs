using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_Numero_es_primo
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNumero = 0;
            Console.WriteLine("Ingrese un numero entero:");
            intNumero = int.Parse(Console.ReadLine());
            if (EsPrimo(intNumero))
            {
                Console.WriteLine($"El numero {intNumero} es primo.");
            }
            else
            {
                Console.WriteLine($"El numero {intNumero} NO es primo.");
            }
        }

        static bool EsPrimo(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if( n % i == 0)
                    return false;
                
            }
            return true;
        }
    }
}
