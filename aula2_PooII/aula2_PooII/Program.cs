namespace aula2_PooII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Aula 2 - Classe Abstrata\n ");

            Iphone iphone = new Iphone("(11)1234-5678", "11Pro", "359132-03-057023-6", 16);
            iphone.InstalarAplicativo("Itau");

            Console.WriteLine($"Meu Celular: {iphone.Modelo}");


            Console.WriteLine("_______________________________________________________________________");

            Motorola motorola = new Motorola("(11)9876-4321", "MotoG", "458138-05-067024-9", 16);
            motorola.ReceberLigacao();

            Console.WriteLine($"Meu Celular:{motorola.Modelo}\n");
        }
    }
}