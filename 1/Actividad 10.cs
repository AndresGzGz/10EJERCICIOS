using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Actividad_10
    {
        public static void Ejercicio10()
        {
            Console.WriteLine("Hola empleado");
            Console.WriteLine("Digite su salario, sin comas ni puntos por favor");
            int Salario;
            Double Parafiscales;
            Salario = Convert.ToInt32(Console.ReadLine());
            Parafiscales = Salario * 0.04;
            Console.WriteLine("Debe pagar de ParaFiscales: " + Parafiscales + " Con su salario de: " + Salario);
        }
    }
}
