using System;

namespace _13_ForEncadeado {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Projeto 13\n");
            // *
            //**
            //***
            // ****
            // *****
            //******
            //Fazendo o desho com asterisco o break
            for (int contLnh = 0; contLnh < 10; contLnh++) {
                for (int ctdClna = 0; ctdClna < 10; ctdClna++) {
                    Console.Write("*");
                    if (ctdClna >= contLnh)
                        break;
                }
                Console.WriteLine();


            }
            //Console.ReadLine();

            //*
            //**
            //***
            //****
            //*****
            //******
            //Outro jeito de fazer o desnho
            for (int contLnh = 0; contLnh < 10; contLnh++) {
                for (int ctdClna = 0; ctdClna <= contLnh; ctdClna++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

