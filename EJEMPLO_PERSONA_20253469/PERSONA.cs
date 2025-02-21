using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO_PERSONA_20253469
{
    public class PERSONA
    {
        public PERSONA(string ojos, string altura, string peso, string sexo)
        {
            this.Ojos = ojos;
            this.Altura = altura;
            this.Peso = peso;
            this.Sexo = sexo;
        }

        public string Ojos;
        public string Altura;
        public string Peso;
        public string Sexo;

        public void Hablar(string texto)
        {
            // Se muestra la convivencia a decir
            Console.WriteLine("Voy a decir:" + texto);
        }

        public void Comer(double calorias)
        {
            // Se indican las calorias que se ganan al comer
            Console.WriteLine("Ganando" + calorias+"calorias");
            this.Peso += calorias / 1000;
        }

        public void correr(double calorias)
        {
            // Se indican las calorias que se pierden al correr
            Console.WriteLine("Perdiendo" + calorias + "calorias");
            this.Peso = Convert.ToString(calorias/1000);
         }
        
        }
            
    }

