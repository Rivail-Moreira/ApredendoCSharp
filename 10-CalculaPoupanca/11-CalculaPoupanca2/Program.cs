using System;

namespace _11_CalculaPoupanca2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Executando o projeto 11\n");
            double VlrInvest = 1000;

            for (int contMes = 1; contMes <= 12; contMes++) {
                // VlrInvest += VlrInvest * (36 / 100);
                VlrInvest *= 1.0036;
                Console.WriteLine("Após "+ contMes + "meses, você terá "+ VlrInvest);

            }
        }
    }
}
