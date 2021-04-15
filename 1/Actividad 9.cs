using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Actividad_9
    {
        public static void Ejercicio9()
        {
            int Num1=0, Num2=1, Limite, x;
            Console.WriteLine("Digitar el limite de el ejercicio de Fibonacci");
            Limite =Convert.ToInt32 (Console.ReadLine());
            while (Num2 + Num1 <= Limite)
            {
                x = Num1;
                Num1 = Num2;
                Num2 = x + Num1;
                Console.WriteLine(Num2);
            }
            
        }
    }
}
