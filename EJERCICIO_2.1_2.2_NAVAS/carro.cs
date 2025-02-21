using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2._1_2._2_NAVAS
{
    public class carro 
    {
        public carro(string marca, string modelo, string velmax, string velac)
        {
            this.Marca = marca;
            this.Modelo= modelo;
            this.Velmax= velmax;
            this.Velac = velac;
        }

        public string Marca;
        public string Modelo;
        public string Velmax;
        public string Velac;

        public void Acelerar(int ac)
        {
            ac += 5;
            Console.WriteLine("Voy a acelerar" + ac + "km/h");
        }

        public void Desacelerar(int des) 
        {
            des -= 5;
            Console.WriteLine("Voy a desacelerar" + des + "km/h");
        }
    }
}
