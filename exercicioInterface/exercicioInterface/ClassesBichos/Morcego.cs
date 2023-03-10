using exercicioInterface.ClassesBases;
using exercicioInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioInterface.ClassesBichos
{
    public class Morcego : Mamifero, IVoar
    {
        private readonly IVoar voar;
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }

        public Morcego(string nome, DateTime dataNascimento, char genero, bool carnivoro, bool peconhento, int qtdMamas, bool pelo, string Corpelo) : base(nome, dataNascimento, genero, carnivoro, peconhento, qtdMamas, pelo, Corpelo)
        {
            
                
        }
        public void Voar()
        {
            Console.WriteLine($"{Nome} está VOANDO ... ");
        }
    }
}
