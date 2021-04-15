using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Actividad_5
    {
        public static void Ejercicio5()
        {
            int[] Edad = { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
            int Auxiliar;

            Console.WriteLine("\n Arreglo Original ");
            foreach (int elemento in Edad)
            {
                Console.Write(" [ " + elemento + " ] ");
            }
            for(int ciclo =1; ciclo <= Edad.Length; ciclo++)
            for (int i = 0; i < Edad.Length -ciclo; i++)
            {
                if (Edad[i] < Edad[i + 1])
                {
                    Auxiliar = Edad[i];
                    Edad[i] = Edad[i + 1];
                        Edad[i + 1] = Auxiliar;
                }
            }
            Console.WriteLine("\n Arreglo Ordenado ");
            foreach (int elemento in Edad)
            {
                Console.Write(" [ " + elemento + " ] ");
            }
        }
    }
}
