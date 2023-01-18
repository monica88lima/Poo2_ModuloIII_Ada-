using exercicioInterface.ClassesBases;
using exercicioInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioInterface.ClassesBichos
{
    public class Arara : Ave, IVoar
    {
        private readonly IVoar voar;
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }
        public Arara(string nome) : base(nome)
        {
                
        }
        public void Voar()
        {
            Console.WriteLine($"{Nome} está VOANDO ... ");
        }
    }
}
