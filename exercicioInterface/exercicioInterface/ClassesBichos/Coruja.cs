using exercicioInterface.ClassesBases;
using exercicioInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioInterface.ClassesBichos
{
    public class Coruja : Ave, IVoar
    {
        private readonly IVoar voar;
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }
        public Coruja(string nome, DateTime dataNascimento, char genero, bool carnivoro, bool peconhento, bool rapina, bool corpena, int altitude, double velocidade) : base(nome, dataNascimento, genero, carnivoro, peconhento, rapina, corpena)
        {
            
                
        }
        public void Voar()
        {
            Console.WriteLine($"{Nome} está VOANDO ... ");
        }
    }
}
