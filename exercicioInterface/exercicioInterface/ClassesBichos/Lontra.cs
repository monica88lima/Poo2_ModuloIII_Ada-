using exercicioInterface.ClassesBases;
using exercicioInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioInterface.ClassesBichos
{
    public class Lontra : Mamifero, IAquatico
    {
        private readonly IAquatico aquatico;
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
        public Lontra(string nome, DateTime dataNascimento, char genero, bool carnivoro, bool peconhento, int qtdMamas, bool pelo, string Corpelo) : base(nome, dataNascimento, genero, carnivoro, peconhento, qtdMamas, pelo, Corpelo)
        {
            
                
        }
    }
}
