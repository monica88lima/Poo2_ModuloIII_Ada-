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

        public Mamifero(string nome):base(nome)
        {

        }
        public void Amamentar()
        {
            Console.WriteLine($"{Nome} está se AMAMENTANDO ... ");
        }
    }
}
