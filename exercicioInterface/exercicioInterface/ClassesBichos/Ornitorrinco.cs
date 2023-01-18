using exercicioInterface.ClassesBases;
using exercicioInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioInterface.ClassesBichos
{
    public class Ornitorrinco:Mamifero,IOviparo,IAquatico
    {
        private readonly IAquatico aquatico;
        private readonly IOviparo oviparo;
        public Ornitorrinco(string nome) : base(nome)
        {

        }
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
        public void Botar()
        {
            Console.WriteLine($"{Nome} está Botando OVO");
        }

        public void Chocar()
        {
            Console.WriteLine($"{Nome} está CHOCANDO O OVO");
        }
    }
}
