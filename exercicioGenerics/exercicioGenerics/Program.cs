using OfficeOpenXml;



namespace exercicioGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var dics = LerArquivoBase.ReadXls();

            foreach(var d in dics)
            {
                Console.WriteLine(value: $"Referencia: {d.Referencia}\n E-mail: {d.Definicao}");
            }
        }
    }
}