using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Actividad_2
    {
        public static void Ejercicio2()
        {
            //Definir variables
            int Numero;
            int Resultado;
            Console.WriteLine("Que tabla quieres saber");
            Numero = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<= 10; i++)
            {
                Resultado = Numero * i;
                Console.WriteLine(Numero + "x" + i + "=" + Resultado);
            }
        }
    }
}