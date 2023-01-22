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
        public Arara(string nome, DateTime dataNascimento, char genero, bool carnivoro, bool peconhento, bool rapina, bool corpena, int altitude, double velocidade) : base(nome, dataNascimento, genero, carnivoro, peconhento, rapina,corpena)
        {
            this.AltitudeMaximaEmMetros = altitude;
            this.VelocidadeDoVoo = velocidade;
        }
        public void Voar()
        {
            Console.WriteLine($"{Nome} está VOANDO ... ");
        }

        public override void ApresentarAnimal()
        {
            string mensagem = $"Animal: {Nome}\n" +
                $"Idade: {Idade}\nSexo:{Sexo}\nCarnivoro:{Carnivoro}\nPeconhento{Peconhento}\n" +
                $"E de Rapina:{Rapina}\nPena tem Cor:{CorPena}\n Altitude do voo: {AltitudeMaximaEmMetros}\n" +
                $"Velocidade do Voo: {VelocidadeDoVoo}";
            base.ApresentarAnimal();
        }
    }
}
