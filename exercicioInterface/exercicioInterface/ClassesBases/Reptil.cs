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
        public Reptil(string nome) : base(nome)
        {

        }
    }
}
