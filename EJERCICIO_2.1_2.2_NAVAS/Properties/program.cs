using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2._1_2._2_NAVAS.Properties
{
    public class program
    {
        static void Main(string[] args)
        {
            // Crear un objeto 
            carro auto = new carro ("Toyota", "Corola 2024", "180", "120");
            Console.WriteLine("Marca: " + auto.Marca);
            Console.WriteLine("Modelo:" + auto.Modelo);
            Console.WriteLine("Velocidad Maxima: " + auto.Velmax);
            Console.WriteLine("Velocidad Actual" + auto.Velac);

            // Llamando los metodos de acción 
            Console.WriteLine("El auto acelera: ");
            auto.Acelerar(100);
            Console.WriteLine("El auto desacelera: ");
            auto.Desacelerar(100);

            //Instanciar 
            carroheredado carro1 = new carroheredado("Toyota", "Corola 2024", "180", "120");
            carro1.frenar(0);
            Console.ReadKey();
        }
    }
}
