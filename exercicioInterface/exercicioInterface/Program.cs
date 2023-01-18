using exercicioInterface.ClassesBichos;

namespace exercicioInterface
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

           Pinguim jojo = new Pinguim("Bento")
           {
               Idade = 2,
               ViveEmTerra = true,
               AguaDoce = false,
               Carnivoro = false,
               CorPena = true,
               Mergulho = true,
               Peconhento = false,
               Rapina = false,
               Sexo = 'M',
               

           };
            jojo.Alimentar();
            jojo.Chocar();
            jojo.Comunicar();

              
        }
    }
}