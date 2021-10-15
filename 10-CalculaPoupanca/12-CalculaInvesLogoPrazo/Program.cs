using System;

namespace _11_CalculaPoupanca2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Executando o projeto 12\n");
            
            double VlrInvest = 1000;
            double fatRend = 1.0036;

            for (int contAno = 1; contAno <= 5; contAno++) {
                for (int cotMes = 1; cotMes <= 12 ; cotMes++) {
                    VlrInvest *= fatRend;
                }
                fatRend += 0.0010;
            }
            
            Console.WriteLine("Ao término do investimento, você terá R$ " + VlrInvest );
        }
    }
}
