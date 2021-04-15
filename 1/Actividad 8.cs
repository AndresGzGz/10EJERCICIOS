using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Actividad_8
    {
		public static void Ejercicio8()
		{
			string palabra, ultimo, caracter;
			int i;
			Console.WriteLine("Escriba la palabra que desea saber si es palindroma o no");
			palabra =Convert.ToString(Console.ReadLine());
			i = palabra.Length;
			ultimo = "";
			for (int x = i - 1; x >= 0; x--)
            {
				caracter = palabra.Substring(x, 1);
				ultimo = ultimo + caracter;
            }
			if (palabra == ultimo)
			{
				Console.WriteLine("La palabra " + palabra + " es palindrome");

			}
			else
			{
				Console.WriteLine("La palabra '" + palabra + "' es palindrome");
			}
		}
	}
}
