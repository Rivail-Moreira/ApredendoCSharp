using System;

namespace _7_Condicionais {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Executando projeto 9 - Escopo\n");

            int idadeJoao = 18;
          bool acompanhado = true;
            string msgAdd;

            if (acompanhado == true) {
                msgAdd = "João está acompanhado!";
            }
            else {
                msgAdd = "João não esta acompanhado";
            }           

            if (idadeJoao >= 18 || acompanhado == true) {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(msgAdd);
            }
            else {
                Console.WriteLine(msgAdd);
            }
        }
    }
}
