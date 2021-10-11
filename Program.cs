using System;
using System.Collections.Generic;

namespace Desarrollo_web_ASP.NET_Core_Practica_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio1
            List<int> list = new() { 2, 3, 5, 6, 7, 11, 44, 55, 77 };
            var numerosPares = Ejercicio1.Pares(list);
            foreach (var item in numerosPares)
            {
                Console.WriteLine(item);
            }
            #endregion 

            Console.WriteLine("\n");

            #region Ejercicio2
            Ejercicio2 ejercicio2 = new();
            Console.WriteLine($"33 es impar: {ejercicio2.EsImpar(33)}");
            Console.WriteLine($"ITEBIS de 400: {ejercicio2.CalcularITBIS(400)}");
            Console.WriteLine($"Fecha actual: {ejercicio2.GetDate()}");
            #endregion 
            
            Console.ReadLine();
        }
    }
}
