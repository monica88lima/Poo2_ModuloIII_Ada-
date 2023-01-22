using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioGenerics_1
{
     class Dicionario
    {
        public string Referencia { get; set; }
        public string Definicao { get; set; }

        public Dicionario(string csvDicionario)
        {
            string[] vect = csvDicionario.Split(',');
            Referencia = vect[0];
            Definicao = vect[1];
        }

       
    }
}
