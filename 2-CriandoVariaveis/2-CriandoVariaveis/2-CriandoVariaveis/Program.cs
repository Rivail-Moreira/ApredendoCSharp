using System;

namespace _2_CriandoVariaveis {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("\n\nExecutando projeto 2 - Criando Variaveis\n");
           
            int idade;
            idade = 32;

            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("\nSua idade é "+ idade + " !");

            Console.WriteLine("\nExecução finalizada. Tecle enter para sair....");
            Console.ReadLine();

        }
    }
}
