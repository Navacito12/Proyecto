using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO_PERSONA_20253469
{
    public class PERSONANADADORA:PERSONA 
    {
        public PERSONANADADORA(string ojos, string altura, string peso, string sexo) : base(ojos, altura, peso, sexo) {
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando para volver al peso ideal");
            this.Peso = "85";

        }    

    }
}
