using System;

namespace SwitchCase {
    class Program {
        static void Main(string[] args) {
            int mes = 0;
            //Console.WriteLine("Digite o mês:");
            //mes =  int.Parse(Console.ReadLine());




            do {
                Console.WriteLine("Digite o mês:");
                mes = int.Parse(Console.ReadLine());

                switch (mes) {
                        case 1:
                        Console.WriteLine("Mês Janeiro!");
                        break;
                    case 2:
                        Console.WriteLine("Mês Fevereiro!");
                        break;
                    case 3:
                        Console.WriteLine("Mês Março!");
                        break;
                    case 4:
                        Console.WriteLine("Mês Abril!");
                        break;
                    case 5:
                        Console.WriteLine("Mês Maio!");
                        break;
                    case 6:
                        Console.WriteLine("Mês Junho!");
                        break;
                    case 7:
                        Console.WriteLine("Mês Julho!");
                        break;
                    case 8:
                        Console.WriteLine("Mês Agosto!");
                        break;
                    case 9:
                        Console.WriteLine("Mês Setembro!");
                        break;
                    case 10:
                        Console.WriteLine("Mês Outubro!");
                        break;
                    case 11:
                        Console.WriteLine("Mês Novembro!");
                        break;
                    case 12:
                        Console.WriteLine("Mês Dezembro!");
                        break;
                    default:
                        Console.WriteLine("Mês inválido!");
                       break;
                
                }
                
            } while(mes == 0 || mes >= 13);
        }
    }
}
