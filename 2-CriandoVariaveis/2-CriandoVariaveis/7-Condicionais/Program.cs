using System;

namespace _7_Condicionais {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Executando projeto 7 - Condicionais\n");

            int idadeJoao = 16;
            int QtdPessoas = 2;

            if (idadeJoao >= 18) {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar.");
            }
            if (QtdPessoas >= 3) {
                Console.WriteLine("João não possui mais de 18 anos, \n" +
                    " mais esta acompanhado e pode entra!");
            }
            else {
                Console.WriteLine("João não possui mais de 18 anos, não pode entra!");
            }
        }
    }
}
