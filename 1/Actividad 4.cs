using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Actividad_4
    {
        public static void Ejercicio4()
        {
            int Numero, Prim;
            Console.WriteLine("Digite el numero deseado");
            Numero = Convert.ToInt32(Console.ReadLine());
            Prim = Numero % 2;
            if (Prim != 0)
                Console.WriteLine("El numero " + Numero + " Es Primo");
            else
                Console.WriteLine("El numero " + Numero + " No es primo");
        }
    }
}