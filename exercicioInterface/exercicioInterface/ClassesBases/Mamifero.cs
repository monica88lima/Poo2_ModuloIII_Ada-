using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercicioInterface.ClassesBases;
using exercicioInterface.Interfaces;

namespace exercicioInterface.ClassesBases
{
    public class Mamifero:Animal
    {
        public int QtdMamas { get; set; }
        public bool Pelos { get; set; }
        public string CorPelo { get; set; }

        public Mamifero(string nome, DateTime dataNascimento, char genero, bool carnivoro, bool peconhento,int qtdMamas, bool pelo, string Corpelo) : base(nome, dataNascimento, genero, carnivoro, peconhento)
        {
            this.QtdMamas = qtdMamas;
            this.Pelos = pelo;
            this.CorPelo = Corpelo;

        }
        public void Amamentar()
        {
            Console.WriteLine($"{Nome} está  AMAMENTANDO ... ");
        }

        public override void ApresentarAnimal()
        {
            string mensagem = $"Animal: {Nome}\n" +
                $"Idade: {Idade}\nSexo:{Sexo}\nCarnivoro:{Carnivoro}\nPeconhento{Peconhento}\nQuabtidade de Mamas:{QtdMamas}\nPelos:{Pelos}\nCor do Pelo:{CorPelo}";
            base.ApresentarAnimal();
        }
    }
}
