using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioAula1
{
   public class Professor:Pessoa
    {
        public string Explicar (string assunto)
        {
            string mensagem = $"Texto explicativo sobre o tema {assunto}";
            return mensagem;
        }
    }
}
