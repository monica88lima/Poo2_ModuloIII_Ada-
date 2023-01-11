using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioAula1
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }


        public  void Cumprimentar()
        {
            string mensagem = "";
            DateTime dataAtual = DateTime.Now;
            int horadoDia = dataAtual.Hour;

            if(horadoDia < 12)
            {
                mensagem = "Olá, Bom dia!! Tudo bem?";
            }
            else if(horadoDia < 18)
            {
                mensagem = "Olá, Boa Tarde!! Tudo bem?";
            }
            else
            {
                mensagem = "Olá, Boa Noite!! Tudo bem?";
            }

            Console.WriteLine(mensagem,Environment.NewLine);
        }
        public void DizerIdade()
        {

            Console.WriteLine($"Eu tenho {Idade} anos");

        }
    }
}
