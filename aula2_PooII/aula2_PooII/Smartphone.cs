using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2_PooII
{
    public abstract class Smartphone
    {
        private string Numero { get; set; }
        public string  Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Fazendo Chamada");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Celular Tocando");
        }

        public abstract void InstalarAplicativo(string nome);
        
            
        
    }
}
