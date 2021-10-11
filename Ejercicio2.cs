using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo_web_ASP.NET_Core_Practica_4
{
    public delegate bool DelegateIsPar(int number);
    public delegate double DelegateCalcularITBIS(double precio);
    public delegate DateTime DelegateGetDate();
    public class Ejercicio2
    {
        public DelegateIsPar EsImpar = n => n % 2 != 0;

        public DelegateCalcularITBIS CalcularITBIS = (double precio) => precio * 0.18;

        public DelegateGetDate GetDate = () => DateTime.Now;

    }
}
