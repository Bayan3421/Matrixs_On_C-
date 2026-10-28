using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_HW_3
{
    internal class Program
    {
        //Создайте приложение, которое производит операции
        //над матрицами:
        //■ Умножение матрицы на число;
        //■ Сложение матриц;
        //■ Произведение матриц.
        static void Main(string[] args)
        {
            Console.Write("Введите колтчество строк матрицы 1: ");
            int rows1 = int.Parse(Console.ReadLine());

            Console.Write("Введите колтчество столбцов матрицы 1: ");
            int cols1 = int.Parse(Console.ReadLine());

            Console.Write("Введите колтчество строк матрицы 2: ");
            int rows2 = int.Parse(Console.ReadLine());

            Console.Write("Введите колтчество столбцов матрицы 2: ");
            int cols2 = int.Parse(Console.ReadLine());

            Console.Write("Введите число ");
            int num = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[rows1, cols1];
            int[,] matrix2 = new int[rows2, cols2];

            Console.WriteLine("Массив 1: ");
            PrintMatrix(matrix1);

            Console.WriteLine();

            Console.WriteLine("Массив 2: ");
            PrintMatrix(matrix2);

            Console.WriteLine();

            Console.WriteLine("Матрица 1 умноженное на число: ");
            int[,] multiMatrixOnSumResult1 = multiMatrixOnSum(matrix1, num);
            PrintMatrix(multiMatrixOnSumResult1);

            Console.WriteLine("Матрица 2 умноженное на число: ");
            int[,] multiMatrixOnSumResult2 = multiMatrixOnSum(matrix2, num);
            PrintMatrix(multiMatrixOnSumResult2);

            int[,] sumTwoMatrixs = sumMatrixs(matrix1, matrix2);
            Console.WriteLine("Матрица из суммы двух матриц: ");
            if(sumTwoMatrixs == null)
            {
                Console.WriteLine("Вычесление не вазможно");
            }
            else
            {
                PrintMatrix(sumTwoMatrixs);
            }

            int[,] multiTwoMatrixs = multiMatrixOnMatrix(matrix1, matrix2);
            Console.WriteLine("Произведение из двух матриц: ");
            if (multiTwoMatrixs == null)
            {
                Console.WriteLine("Вычесление не вазможно");
            }
            else
            {
                PrintMatrix(multiTwoMatrixs);
            }

        }

        public static void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] multiMatrixOnSum(int[,] matrix, int num)
        {
            int[,] multiMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    multiMatrix[i, j] = matrix[i, j] * num;
                }
            }

            return multiMatrix;
        }

        public static int[,] sumMatrixs(int[,] matrix1, int[,] matrix2)
        {

            if (matrix1.GetLength(0) != matrix2.GetLength(0) ||
                matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                return null;
            }

            int[,] sumMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return sumMatrix;
        }

        public static int[,] multiMatrixOnMatrix(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                return null;
            }

            int[,] multiMatrixs = new int[
                matrix1.GetLength(0),
                matrix2.GetLength(1)
            ];

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        multiMatrixs[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return multiMatrixs;
        }
    }
}
