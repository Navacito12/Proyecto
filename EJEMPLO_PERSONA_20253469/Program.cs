using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO_PERSONA_20253469
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PERSONA Personal=new PERSONA("Verdes", "187", "85", "V");
            Console.WriteLine("Descripcion de la persona: ");
            Console.WriteLine("Ojos: " + Personal.Ojos);
            Console.WriteLine("Altura: " + Personal.Altura);
            Console.WriteLine("Peso: " + Personal.Peso);
            Console.WriteLine("Sexo: " + Personal.Sexo);

            //Llamada a los metodos o acciones
            Personal.Hablar("Me llamo Navas");
            Console.WriteLine("Color de mis ojos: " + Personal.Ojos);
            Personal.correr(1000);
            Console.WriteLine(" Mi peso actual es: " + Personal.Peso);

            PERSONANADADORA PersonaL = new PERSONANADADORA("Verdes", "187", "85", "V");
            Console.WriteLine("Ojos: " + PersonaL1.Ojos);
            Console.WriteLine("Altura: " + PersonaL1.Altura);
            Console.WriteLine("Altura: " + PersonaL1.Peso);
            Console.WriteLine("Altura: " + PersonaL1.Sexo);

            Console.ReadKey();
        }
    }
}
