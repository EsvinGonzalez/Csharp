using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
     class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Suma de dos numeros");
            Console.Write("Ingresa numero 1:");

            string dato = Console.ReadLine();

            int n1 = int.Parse(dato);

            Console.Write("Ingresa numero 2:");
            dato = Console.ReadLine(); 
            int n2 = int.Parse(dato);
            int suma = n1 + n2;
            Console.WriteLine("El resultado es: {0}", suma);

        }
    }
}
