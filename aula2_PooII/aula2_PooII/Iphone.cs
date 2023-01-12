using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace aula2_PooII
{
    public class Iphone: Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, int memoria):base(numero, modelo, iMEI, memoria)
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
