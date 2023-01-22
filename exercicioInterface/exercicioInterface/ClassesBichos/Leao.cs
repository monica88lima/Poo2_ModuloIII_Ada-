using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercicioInterface.ClassesBases;
using exercicioInterface.Interfaces;

namespace exercicioInterface.ClassesBichos
{
    public class Leao:Mamifero
    {
        public Leao(string nome, DateTime dataNascimento, char genero, bool carnivoro, bool peconhento, int qtdMamas, bool pelo, string Corpelo) : base(nome, dataNascimento, genero, carnivoro, peconhento, qtdMamas,pelo,Corpelo)
        {
                
        }
        
    }
}
