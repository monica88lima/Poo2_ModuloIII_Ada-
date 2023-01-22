using exercicioInterface.ClassesBichos;
using System.Globalization;

namespace exercicioInterface
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Arara arara = new Arara("Arara", new DateTime (2010, 8, 18), 'M', false, false, true, true, 14000, 50);

            arara.ApresentarAnimal();
            arara.Alimentar();

            Ornitorrinco orn = new Ornitorrinco("Ornitorrinco", new DateTime(2018,11, 29), 'F',true,false,6,false,"Preto");
            orn.AguaDoce = true;
            orn.ViveEmTerra = true;
            orn.QtdMamas = 6;
            orn.Mergulho = true;
            orn.ApresentarAnimal();
            orn.Alimentar();
            orn.Amamentar();
            orn.Botar();
            orn.Chocar();
            orn.Alimentar();
            
        }
    }
}