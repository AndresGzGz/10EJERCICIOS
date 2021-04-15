using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class actividad_1
    {
        public static void Ejercicio1()
        {
            //Definir vairiables
            int Numbero;
            Console.Clear();
            Console.WriteLine("Digite un numero");
            Numbero = Convert.ToInt32(Console.ReadLine());
            if (Numbero % 2 == 0)
                Console.WriteLine("El numero " + Numbero + " Es par");
            else 
                Console.WriteLine("El numero " + Numbero + " No es par");
        }
    }
}
