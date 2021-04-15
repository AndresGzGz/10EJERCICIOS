using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Actividad_3
    {
        public static void Ejercicio3()
        {
			for (int i = 2; i <= 9; i++)
			{
				Console.WriteLine("Sigue");
				Console.WriteLine("Tabla de multiplicar del {0}", i);
				for (int j = 1; j <= 10; j++)
				{
					Console.WriteLine("{0} * {1} = {2}", i, j, (i * j));
				}
			}
		}
	}
}
