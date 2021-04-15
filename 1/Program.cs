using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definir variables
            int opcion;
            //Entrada de datos (Menu)
            Console.WriteLine("Digite 1 para ejercicio 1");
            Console.WriteLine("Digite 2 para ejercicio 2");
            Console.WriteLine("Digite 3 para ejercicio 3");
            Console.WriteLine("Digite 4 para ejercicio 4");
            Console.WriteLine("Digite 5 para ejercicio 5");
            Console.WriteLine("Digite 6 para ejercicio 6");
            Console.WriteLine("Digite 7 para ejercicio 7");
            Console.WriteLine("Digite 8 para ejercicio 8");
            Console.WriteLine("Digite 9 para ejercicio 9");
            Console.WriteLine("Digite 10 para ejercicio 10");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    actividad_1.Ejercicio1();
                    break;
                case 2:
                    Actividad_2.Ejercicio2();
                    break;
                case 3:
                    Actividad_3.Ejercicio3();
                    break;
                case 4:
                    Actividad_4.Ejercicio4();
                    break;
                case 5:
                    Actividad_5.Ejercicio5();
                    break;
                case 6:
                    Actividad_6.Ejercicio6();
                    break;
                case 7:
                    Actividad_7.Ejercicio7();
                    break;
                case 8:
                    Actividad_8.Ejercicio8();
                    break;
                case 9:
                    Actividad_9.Ejercicio9();
                    break;
                case 10:
                    Actividad_10.Ejercicio10();
                    break;
            }
            Console.ReadKey();
        }
    }

}