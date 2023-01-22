using exercicioInterface.ClassesBases;
using exercicioInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioInterface.ClassesBichos
{
    public class DragaoKomodo : Reptil, IOviparo
    {
        private readonly IOviparo oviparo;

        public void Botar()
        {
            Console.WriteLine("Botando OVO");
        }
        public DragaoKomodo(string nome, DateTime dataNascimento, char genero, bool carnivoro, bool peconhento, bool temescamas, bool temcasco) : base(nome, dataNascimento, genero, carnivoro, peconhento, temescamas, temcasco)
        {
                
        }
        public void Chocar()
        {
            Console.WriteLine($"{Nome} está CHOCANDO O OVO");
        }
    }
}
