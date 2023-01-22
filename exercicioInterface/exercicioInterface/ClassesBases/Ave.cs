using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercicioInterface.ClassesBases;
using exercicioInterface.Interfaces;


namespace exercicioInterface.ClassesBases
{
    public class Ave : Animal, IOviparo
    {
        private readonly IOviparo oviparo;
        public bool Rapina { get; set; }
        public bool CorPena { get; set; }
        public Ave(string nome, DateTime dataNascimento, char genero, bool carnivoro, bool peconhento, bool rapina, bool corpena) : base(nome, dataNascimento,genero,carnivoro,peconhento)
        {
            this.Rapina = rapina;
            this.CorPena = corpena;
        }

        public void Ciscar()
        {
            Console.WriteLine($"{Nome} está  CISCANDO ... ");
        }

        public void Botar()
        {
            Console.WriteLine($"{Nome} Botando OVO");
        }

        public void Chocar()
        {
            Console.WriteLine($"{Nome} está CHOCANDO O OVO");
        }

        public override void ApresentarAnimal()
        {
            string mensagem = $"Animal: {Nome}\n" +
                $"Idade: {Idade}\nSexo:{Sexo}\nCarnivoro:{Carnivoro}\nPeconhento{Peconhento}\n" +
                $"E de Rapina:{Rapina}\nPena tem Cor:{CorPena}";
            base.ApresentarAnimal();
        }
    }
}
