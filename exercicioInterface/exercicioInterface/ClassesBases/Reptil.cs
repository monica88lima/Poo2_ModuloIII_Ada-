using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercicioInterface.ClassesBases;
using exercicioInterface.Interfaces;

namespace exercicioInterface.ClassesBases
{
    public class Reptil:Animal
    {
        public bool temEscamas { get; set; }
        public bool TemCasco { get; set; }
        public Reptil(string nome, DateTime dataNascimento, char genero, bool carnivoro, bool peconhento, bool temescamas, bool temcasco) : base(nome, dataNascimento, genero, carnivoro, peconhento)
        {
            this.TemCasco = temcasco;
            this.temEscamas = temescamas;
        }

        public override void ApresentarAnimal()
        {
            string mensagem = $"Animal: {Nome}\n" +
                $"Idade: {Idade}\nSexo:{Sexo}\nCarnivoro:{Carnivoro}\nPeconhento{Peconhento}\nTem Casco:{TemCasco}\nTem Escamas:{temEscamas}\n";
            base.ApresentarAnimal();
        }
    }
}
