using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2_PooII
{
    public class Motorola:Smartphone
    {
        public Motorola(string numero, string modelo, string iMEI, int memoria):base(numero, modelo, iMEI, memoria)
        {

        }
        public override void InstalarAplicativo(string nome)
        {
            try
            {
                Console.WriteLine($"Instalando App {nome}");
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

    }
}
