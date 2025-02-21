using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2._1_2._2_NAVAS
{
    public class carroheredado:carro
    {
        public carroheredado(string marca, string modelo, string velmax, string velac):base(marca, modelo, velmax, velac)
        {
            
        }

        public void frenar(int velocidad)
        {
            velocidad = 0;
            Console.WriteLine("Frenar");
            Console.WriteLine("La velocidad actual es: " + velocidad + "km");
        }
    }

}