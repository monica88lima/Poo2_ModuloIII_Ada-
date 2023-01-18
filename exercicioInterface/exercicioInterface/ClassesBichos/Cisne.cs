using exercicioInterface.ClassesBases;
using exercicioInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioInterface.ClassesBichos
{
    public class Cisne:Ave,IAquatico, IVoar
    {
        private readonly IAquatico aquatico;
        private readonly IVoar voar;
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }
        public Cisne(string nome) : base(nome)
        {
                
        }
        public void Voar()
        {
            Console.WriteLine($"{Nome} está VOANDO ... ");
        }
    }
}
