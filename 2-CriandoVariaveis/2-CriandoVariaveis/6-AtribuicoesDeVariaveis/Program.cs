using System;

namespace _6_AtribuicoesDeVariaveis {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Executando projet 6");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            string parcela1 = "10";
            string parcela2 = "20";
            Console.WriteLine(parcela1 + parcela2);
        }
    }
}
