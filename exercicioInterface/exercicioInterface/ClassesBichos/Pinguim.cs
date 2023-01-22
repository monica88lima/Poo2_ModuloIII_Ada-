using exercicioInterface.ClassesBases;
using exercicioInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioInterface.ClassesBichos
{
    public class Pinguim : Ave, IAquatico
    {
        private readonly IAquatico aquatico;
        public Pinguim(string nome, DateTime dataNascimento, char genero, bool carnivoro, bool peconhento, bool rapina, bool corpena, int altitude, double velocidade) : base(nome, dataNascimento, genero, carnivoro, peconhento, rapina, corpena)
        {
            
                
        }
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
    }
}
