using System;

namespace _7_Condicionais {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Executando projeto 7 - Condicionais\n");

            int idadeJoao = 18;
            int QtdPessoas = 2;

            bool acompanhado = QtdPessoas >= 2;

            if (idadeJoao >= 18 && acompanhado == true) {
                Console.WriteLine(" Pode entrar.");
            }
            else {
                Console.WriteLine("João não  pode entra!");
            }
        }
    }
}
