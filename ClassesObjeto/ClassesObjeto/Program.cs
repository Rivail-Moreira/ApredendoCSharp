using ClassesObjeto;
using System;

namespace classesobjeto
{
    class program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var i = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }

                        alunos[i] = aluno;
                        i++;

                        break;
                    case "2":
                        foreach(var a in alunos)
                        {
                            if(! String.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"Aluno:{a.Nome} - Nota:{a.Nota}");
                            }
                           
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for (int j=0; j < alunos.Length; j++)
                        {
                            if (!string.IsNullOrEmpty(alunos[j].Nome))
                            {
                                notaTotal += alunos[j].Nota;
                                nrAlunos++;
                            }
                        }
                        var mediaGeral = notaTotal / nrAlunos;
                        Console.WriteLine($"Média Geral:{mediaGeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }

        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno:");
            Console.WriteLine("2- Listar alunos:");
            Console.WriteLine("3- Calcular média geral:");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
