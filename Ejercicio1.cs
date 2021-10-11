using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo_web_ASP.NET_Core_Practica_4
{
    delegate bool IsPar(int number);
    public static class Ejercicio1
    {
        public static List<int> Pares(this List<int> list)
        {
            IsPar isPar = FuncionIspar;
            return list.FindAll(x => isPar(x));
        }

        private static bool FuncionIspar(int number)
        {
            return (number % 2 == 0);
        }
    }
}
