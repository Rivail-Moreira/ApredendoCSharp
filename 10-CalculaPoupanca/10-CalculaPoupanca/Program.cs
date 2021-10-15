using System;

namespace _10_CalculaPoupanca {
    class Program {
        static void Main(string[] args) {

            double VlrInvest = 1000;
            int cont = 1;

            while (cont <= 12) {
                VlrInvest += VlrInvest * 0.0036;
                Console.WriteLine("Após "+ cont + " meses, você terá R$ "+ VlrInvest);
                cont++;
            }

        }
    }
}
