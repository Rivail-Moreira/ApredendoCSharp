using System;

namespace _3_CriandoVariaveisPontoFlutuante {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Executando projeto 3 Criando variaveis ponto flutuante\n");

            double salario;
            salario = 1200.70;
            Console.WriteLine("Meu salário é "+ salario);

            double idade;
            idade = 15 / 2.0;
            Console.WriteLine("\n"+idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = "+idade);

            idade = 5.0 / 3;
            Console.WriteLine("\n5 / 2 = "+idade);

            int divisao = 5 / 2;
            Console.WriteLine("\nA divisão de 5 / 2 = " + divisao);

            double divisao2 = (5.0 / 2);
            Console.WriteLine("Na verdade a divisao 5 / 2 = "+ divisao2);

           
            Console.WriteLine("\nA execução acabou. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
