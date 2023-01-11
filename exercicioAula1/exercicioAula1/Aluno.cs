using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioAula1
{
    public class Aluno: Pessoa
    {
        
        public void IrParaEscola()
        {
            
            string AcaoDoAluno = $"Você deve Ir para Escola";

            Console.WriteLine(AcaoDoAluno);
        }
    }
}
