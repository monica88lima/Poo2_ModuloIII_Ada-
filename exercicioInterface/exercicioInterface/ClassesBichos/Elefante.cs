using exercicioInterface.ClassesBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioInterface.ClassesBichos
{
    public class Elefante:Mamifero
    {
        public Elefante(string nome, DateTime dataNascimento, char genero, bool carnivoro, bool peconhento, int qtdMamas, bool pelo, string Corpelo) : base(nome, dataNascimento, genero, carnivoro, peconhento, qtdMamas, pelo, Corpelo)
        {

        }


        
    }
}
