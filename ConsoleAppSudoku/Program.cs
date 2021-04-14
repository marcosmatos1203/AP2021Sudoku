using System;
using System.Linq;

namespace ConsoleAppSudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            int contaLinha = 0, contaColuna = 0;
            string[,] matrix = new string[9, 9];
            string[] coluna = new string[9];
            string[] linhaQuadrante = new string[9];
            while (true)
            {
                if (contaLinha == 9)
                    break;
                Console.WriteLine($"Entre com a {contaLinha + 1}° linha");
                string linhaDigitada = Console.ReadLine();
                string[] linhaSeparada = linhaDigitada.Split(" ");


                if (EhLinhaInvalida(linhaSeparada))
                {
                    Console.Clear();
                    Mensagem("NAO");
                    break;
                }

                AdicionaLinhaNaMatriz(contaLinha, matrix, linhaSeparada);
                contaLinha++;
            }
            while (true)
            {
                if (contaLinha != 9)
                {
                    break;
                }
                LerColuna(contaColuna, matrix, coluna);
                
                MontaQuadrante0(matrix, linhaQuadrante);
                if (EhQuadranteInvalida(linhaQuadrante))
                    break;
                MontaQuadrante1(matrix, linhaQuadrante);
                if (EhQuadranteInvalida(linhaQuadrante))
                    break;
                MontaQuadrante2(matrix, linhaQuadrante);
                if (EhQuadranteInvalida(linhaQuadrante))
                    break;
                MontaQuadrante3(matrix, linhaQuadrante);
                if (EhQuadranteInvalida(linhaQuadrante))
                    break;
                MontaQuadrante4(matrix, linhaQuadrante);
                if (EhQuadranteInvalida(linhaQuadrante))
                    break;
                MontaQuadrante5(matrix, linhaQuadrante);
                if (EhQuadranteInvalida(linhaQuadrante))
                    break;
                MontaQuadrante6(matrix, linhaQuadrante);
                if (EhQuadranteInvalida(linhaQuadrante))
                    break;
                MontaQuadrante7(matrix, linhaQuadrante);
                if (EhQuadranteInvalida(linhaQuadrante))
                    break;
                MontaQuadrante8(matrix, linhaQuadrante);
                if (EhQuadranteInvalida(linhaQuadrante))
                    break;
                Console.Clear();
                Mensagem("SIM");
                break;
            }

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

        private static void MontaQuadrante0(string[,] matrix, string[] quadrante)
        {
            int indiceLinhaQuadrante= 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    quadrante[indiceLinhaQuadrante] = matrix[i, j];
                    indiceLinhaQuadrante++;
                }
                
            }
            
        }
        private static void MontaQuadrante1(string[,] matrix, string[] quadrante)
        {
            int indiceLinhaQuadrante = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    quadrante[indiceLinhaQuadrante] = matrix[i, j];
                    indiceLinhaQuadrante++;
                }
                
            }

        }
        private static void MontaQuadrante2(string[,] matrix, string[] quadrante)
        {
            int indiceLinhaQuadrante = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 6; j < 9; j++)
                {
                    quadrante[indiceLinhaQuadrante] = matrix[i, j];
                    indiceLinhaQuadrante++;
                }
            }

        }
        private static void MontaQuadrante3(string[,] matrix, string[] quadrante)
        {
            int indiceLinhaQuadrante = 0;
            for (int i = 3; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    quadrante[indiceLinhaQuadrante] = matrix[i, j];
                    indiceLinhaQuadrante++;
                }
            }

        }
        private static void MontaQuadrante4(string[,] matrix, string[] quadrante)
        {
            int indiceLinhaQuadrante = 0;
            for (int i = 3; i < 6; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    quadrante[indiceLinhaQuadrante] = matrix[i, j];
                    indiceLinhaQuadrante++;
                }
            }

        }
        private static void MontaQuadrante5(string[,] matrix, string[] quadrante)
        {
            int indiceLinhaQuadrante = 0;
            for (int i = 3; i < 6; i++)
            {
                for (int j = 6; j < 9; j++)
                {
                    quadrante[indiceLinhaQuadrante] = matrix[i, j];
                    indiceLinhaQuadrante++;
                }
            }

        }
        private static void MontaQuadrante6(string[,] matrix, string[] quadrante)
        {
            int indiceLinhaQuadrante = 0;
            for (int i = 6; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    quadrante[indiceLinhaQuadrante] = matrix[i, j];
                    indiceLinhaQuadrante++;
                }
            }

        }
        private static void MontaQuadrante7(string[,] matrix, string[] quadrante)
        {
            int indiceLinhaQuadrante = 0;
            for (int i = 6; i < 9; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    quadrante[indiceLinhaQuadrante] = matrix[i, j];
                    indiceLinhaQuadrante++;
                }
            }

        }
        private static void MontaQuadrante8(string[,] matrix, string[] quadrante)
        {
            int indiceLinhaQuadrante = 0;
            for (int i = 6; i < 9; i++)
            {
                for (int j = 6; j < 9; j++)
                {
                    quadrante[indiceLinhaQuadrante] = matrix[i, j];
                    indiceLinhaQuadrante++;
                }
            }

        }

        private static void LerColuna(int contaColuna, string[,] matrix, string[] coluna)
        {
            while (contaColuna < 9)
            {
                MontaColuna(contaColuna, matrix, coluna);

                if (EhColunaInvalida(coluna))
                {
                    Console.Clear();
                    Mensagem("NAO");
                    break;
                }
                contaColuna++;
            }

        }

        private static void MontaColuna(int contaColuna, string[,] matrix, string[] coluna)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = contaColuna; j <= contaColuna; j++)
                {
                    coluna[i] = matrix[i, j];
                }
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

        private static void Mensagem(string mensagem)
        {
            Console.WriteLine("---");
            Console.WriteLine(mensagem);
            Console.WriteLine("---");
        }


        private static bool EhLinhaInvalida(string[] separaLinha)
        {
            return separaLinha.Length - separaLinha.ToList().Distinct().Count() != 0;
        }
        private static bool EhColunaInvalida(string[] coluna)
        {
            return coluna.Length - coluna.ToList().Distinct().Count() != 0;
        }
        private static bool EhQuadranteInvalida(string[] quadrante)
        {
            Console.Clear();
            Mensagem("NAO");
            return quadrante.Length - quadrante.ToList().Distinct().Count() != 0;
        }
    }
}
