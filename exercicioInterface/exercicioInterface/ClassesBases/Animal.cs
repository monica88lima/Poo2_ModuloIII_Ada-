using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercicioInterface.ClassesBases;
using exercicioInterface.Interfaces;

namespace exercicioInterface.ClassesBases
{
   public class Animal
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; } 
        public char Sexo { get; set; }

        public int Idade;
        public bool Carnivoro { get; set; }
        public bool Peconhento { get; set; }

        public Animal(string nome)
        {
            Nome = nome;     
        }

        public void Movimentar()
        {
            Console.WriteLine($"{Nome} está se MOVIMENTANDO ... ");
        }
        public void Comunicar()
        {
            Console.WriteLine($"{Nome} está emitindo sons, ele deseja COMUNICAR algo! ... ");
        }
        public void Alimentar()
        {
            Console.WriteLine($"{Nome} está com FOME ... ");
        }
    }
}

