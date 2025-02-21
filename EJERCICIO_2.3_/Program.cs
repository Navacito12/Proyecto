using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2._3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ordenador ord = new ordenador("HP", "Spectre", "12", "1024");
            Console.WriteLine("La marca es: " + ord.Marca);
            Console.WriteLine("El modelo es: " + ord.Modelo);
            Console.WriteLine("La memoria es de: " + ord.Memoria+"Gb");
            Console.WriteLine("El disco duro es de: " + ord.Discoduro+"Gb");

            Console.WriteLine("\nEl disco duro aumenta");
            ord.MayorCapacidad(1024);
            Console.WriteLine("\nEl disco duro duro disminuye");
            ord.MenorCapacidad(1024);

            Console.ReadKey();
        }
    }
}
