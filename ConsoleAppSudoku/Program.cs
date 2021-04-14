using System;
using System.Linq;

namespace ConsoleAppSudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            int contaLinha = 0 ,contaColuna = 0;
            string[,] matrix = new string[9, 9];
            string[] coluna = new string[9];
            while (true)
            {
                if (contaLinha == 9)
                    break;
                Console.WriteLine($"Entre com a {contaLinha + 1}° linha");
                string linhaDigitada = Console.ReadLine();
                string[] linhaSeparada = linhaDigitada.Split(" ");


                if (EhLinhaInvalida(linhaSeparada))
                {
                    Console.WriteLine("NAO");
                    break;
                }

                AdicionaLinhaNaMatriz(contaLinha, matrix, linhaSeparada);
                contaLinha++;
            }
            LerColuna(contaColuna, matrix, coluna);

            ////plota matriz
            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        Console.Write(matrix[i, j]); 
            //    }
            //    Console.WriteLine();
            //}

            Console.ReadLine();
        }

        private static void LerColuna(int contaColuna, string[,] matrix, string[] coluna)
        {
            while(contaColuna<9)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = contaColuna; j <= contaColuna; j++)
                    {
                        coluna[i] = matrix[i, j];
                    }
                }
                if (EhColunaInvalida(coluna))
                {
                    Console.WriteLine("NAO");
                    break;
                }
                contaColuna++;
            }
            
        }

        private static void AdicionaLinhaNaMatriz(int contaLinha, string[,] matrix, string[] linhaSeparada)
        {
            for (int i = contaLinha; i <= contaLinha; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matrix[i, j] = linhaSeparada[j];
                }
            }
            
        }

        private static bool EhLinhaInvalida(string[] separaLinha)
        {
            return separaLinha.Length - separaLinha.ToList().Distinct().Count() != 0;
        }
        private static bool EhColunaInvalida(string[] coluna)
        {
            return coluna.Length - coluna.ToList().Distinct().Count() != 0;
        }

    }
}
