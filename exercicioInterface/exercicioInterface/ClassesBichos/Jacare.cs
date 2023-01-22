using exercicioInterface.ClassesBases;
using exercicioInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioInterface.ClassesBichos
{
    public class Jacare : Reptil, IAquatico
    {
        private readonly IAquatico aquatico;
        public bool ViveEmTerra { get ; set ; }
        public bool Mergulho { get ; set; }
        public bool AguaDoce { get; set; }
        public Jacare(string nome, DateTime dataNascimento, char genero, bool carnivoro, bool peconhento, bool temescamas, bool temcasco) : base(nome, dataNascimento, genero, carnivoro, peconhento, temescamas,temcasco)
        {

        }


        
    }
}
