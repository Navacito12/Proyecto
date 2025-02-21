using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2._3_
{
    internal class ordenador
    {
        public ordenador(string marca, string modelo, string memoria, string discoduro)
        {
            this.Marca=marca;
            this.Modelo=modelo;
            this.Memoria=memoria;
            this.Discoduro=discoduro;
        }

        public string Marca;
        public string Modelo;
        public string Memoria;
        public string Discoduro;

        public void MayorCapacidad(int MyCap)
        {
            MyCap += 100;
            Console.WriteLine("Voy a incrementar la capacidad del disco duro" + MyCap+ "Gb");
        }

        public void MenorCapacidad(int MenCap)
        {
            MenCap += 100;
            Console.WriteLine("Voy a disminuir la capacidad del disco duro " + MenCap + "Gb");
        }
    }
}