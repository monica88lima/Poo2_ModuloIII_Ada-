using System.Runtime.Intrinsics.X86;
using System;
using System.Text;
using System.Reflection;
using System.Linq;

namespace exercicioReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Em seguida, na classe Program, crie um método chamado DisplayPublicProperties que,
            //usando Reflection, exiba todas as Propriedades Públicas da classe Student. No método
            //Main da classe Program, coloque uma chamada para o método DisplayPublicProperties.

            Console.WriteLine("Hello, World!");

            Student estudante = new Student();
            estudante.Name = "Ana";
            estudante.University = "Senac";
            estudante.RollNumber = 123456;

            DisplayPublicProperties(estudante);
            CreateInstance();
            

            //Agora, adicione na classe Program um outro método chamado CreateInstance que
            //Use Reflection para criar uma instância(objeto) da classe Student e, em seguida;
            //Use Reflection para preencher as propriedades públicas do objeto.Não é necessário
            //se preocupar com a adição de novas propriedades, isto é, sempre serão preenchidos apenas o Name, University e RollNumber.
        }
        public static void DisplayPublicProperties(object obj)
        {
            var tipo = obj.GetType();

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Nome da Classe:" + tipo.Name);

            foreach (var prop in tipo.GetProperties())
            {
                builder.AppendLine(prop.Name + ": " + prop.GetValue(obj));
            }
            ImprimirLog(builder.ToString());
        }
        public static void ImprimirLog(string texto)
        {
            Console.WriteLine(texto);
        }

        public static void CreateInstance()
        {
            
            Type sType = typeof(Student);   
            object sStudent = Activator.CreateInstance(sType);

            PropertyInfo nameProperty = sType.GetProperty("Name");
            PropertyInfo universityProperty = sType.GetProperty("University");
            PropertyInfo rollNumberProperty = sType.GetProperty("RollNumber");

            nameProperty.SetValue(sStudent, "Maria");
            universityProperty.SetValue(sStudent, "XUXU");
            rollNumberProperty.SetValue(sStudent, 7000);

            MethodInfo displayInfoMethod = sType.GetMethod("DisplayInfo");
            displayInfoMethod.Invoke(sStudent, null);

            DisplayPublicProperties(sStudent);

        }
      
        //Use Reflection para chamar o método DisplayInfo do objeto criado no item 2.1.

    }

}
