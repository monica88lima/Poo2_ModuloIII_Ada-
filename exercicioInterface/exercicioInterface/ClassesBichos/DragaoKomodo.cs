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
        public DragaoKomodo(string nome):base(nome)
        {
                
        }
        public void Chocar()
        {
            Console.WriteLine($"{Nome} está CHOCANDO O OVO");
        }
    }
}
