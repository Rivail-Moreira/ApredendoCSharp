using System;

namespace _4_ConversoesEoutrosTiposNumericos {
    class Program {
        static void Main(string[] args) {

            Console.Write("Executado o projeto 4:\n");

            double salario = 1270.50;
            int valor = (int) salario;
            Console.WriteLine(valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;

            Console.WriteLine(total);

            float pontoFlutuante = 3.14f;
            Console.WriteLine(pontoFlutuante);

            
        }
    }
}
