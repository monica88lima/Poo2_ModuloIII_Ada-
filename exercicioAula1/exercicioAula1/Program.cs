namespace exercicioAula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enunciado = "Crie uma Pessoa e faça ela Cumprimentar e Dizer Idade";
            Console.WriteLine(enunciado);

            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Ana";
            pessoa.Idade = 34;

            pessoa.Cumprimentar();
            pessoa.DizerIdade();

            Console.WriteLine("__________________________________");

            enunciado = "Crie um Aluno de 21 anos, e faça ele IrParaEscola, Cumprimentar e DizerIdade";
            Console.WriteLine(enunciado);

            Aluno aluno = new Aluno()
            {
                Nome = "Elsa",
                Idade = 21
            };

            aluno.IrParaEscola();
            aluno.Cumprimentar();
            aluno.DizerIdade();

            Console.WriteLine("__________________________________");
            enunciado = "Crie um Professor de 30 anos, e faça ele Cumprimentar, DizerIdade e Explicar sobre um determinado assunto.";
            Console.WriteLine(enunciado);

            Professor professor = new Professor()
            {
                Idade = 30,
                Nome = "Olaf"
            };
            professor.Cumprimentar();
            professor.DizerIdade();
            string explicacaoProfessor = professor.Explicar("Relevo");
            Console.WriteLine(explicacaoProfessor);

        }
    }
}