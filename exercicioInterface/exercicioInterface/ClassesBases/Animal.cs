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

        public Animal(string nome, DateTime dataNascimento, char genero, bool carnivoro, bool peconhento)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Sexo = genero;
            this.Carnivoro = carnivoro;
            this.Peconhento = peconhento;
            VerificarIdade();
        }
        private void VerificarIdade()
        {
            this.Idade = DateTime.Now.Year - DataNascimento.Year;
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

        public virtual void ApresentarAnimal()
        {
            string mensagem = $"Animal: {Nome}\n" +
                $"Idade: {Idade}\nSexo:{Sexo}\nCarnivoro:{Carnivoro}\nPeconhento{Peconhento}\n";
            Console.WriteLine(mensagem);
        }
    }
}

