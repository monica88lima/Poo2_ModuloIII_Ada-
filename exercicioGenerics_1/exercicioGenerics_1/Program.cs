using System;
using System.Text.RegularExpressions;

namespace exercicioGenerics_1
{
    internal class Program
    {
        static void Main()
        {
            List<Dicionario> list = new List<Dicionario>();
            string path = @"C:\Users\rishi\source\repos\Poo2_ModuloIII_Ada-\exercicioGenerics_1\dic.txt ";
            using (StreamReader sr = File.OpenText(path))
            {

                while (!sr.EndOfStream)
                {
                    list.Add(new Dicionario(sr.ReadLine()));
                }
                
                foreach (Dicionario item in list)
                {
                    Console.WriteLine($"REFERENCIA: {item.Referencia}---- DEFINIÇÃO:{item.Definicao}");

                }
                Console.WriteLine("_____________________________________________________________________");
            }

            int retornoUsuario;

            do
            {
                Console.WriteLine("O que você deseja fazer:(1) Buscar Termos ou (2) Adicionar novos termos:");
                int.TryParse(Console.ReadLine(), out retornoUsuario);

            } while (retornoUsuario < 1 || retornoUsuario > 2);

            if (retornoUsuario == 1)
            {
                var termoPesquisar = ColetarTermo().ToLower();
                List<Dicionario> lisFiltrada = list.FindAll(x => x.Referencia.ToLower().Contains(termoPesquisar));
                foreach (var item in lisFiltrada)
                {
                    Console.WriteLine($"REFERENCIA: {item.Referencia.ToLower()}---- DEFINIÇÃO:{item.Definicao.ToLower()}");
                }
                if (lisFiltrada.Count == 0)
                {
                    Console.WriteLine("Nenhum termo encontrado");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Qual termo deseja adicionar?");
                string novaReferencia = Console.ReadLine();

                Console.WriteLine("Qual a definição deste termo");
                string novaDefinicao = Console.ReadLine();

                File.AppendAllText(path, $"{Environment.NewLine}{novaReferencia},{novaDefinicao}");
            }
            Console.Clear();
            Main();
        }
        public static string ColetarTermo()
        {
            Console.WriteLine("Digite o Termo para pesquisar:");
            string buscarPalavra = Console.ReadLine();

            bool somenteAlfabeto = Regex.IsMatch(buscarPalavra, @"^[a-zA-Z]+$");
            if (somenteAlfabeto)
            {
                return buscarPalavra;
            }
            return ColetarTermo();
        }


    }
}