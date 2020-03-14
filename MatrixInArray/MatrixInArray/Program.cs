using System;

namespace MatrixInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк и столбцов матрицы");
            int N = int.Parse(Console.ReadLine());
            
        }
        static int [,] InitMatrix(int N)
        {
            Random random = new Random();
            int[,] array = new int[N, N];
            for (int i=0; i<array.GetLength(0); i++)
            {
                for (int j=0; j< array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0,2);
                }
            }
            return array;
        }
        static void PrintMatrix(int [,] matrix)
        {
            for (int i=0; i<matrix.GetLength(0); i++)
            {
                for (int j=0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        static int[,] Summarize(int [,] arr, int [,] mas)
        {
            int[,] resultmatrix = new int[arr.GetLength(0), arr.GetLength(1)];
            for (int i=0; i<resultmatrix.GetLength(0); i++)
            {
                for (int j=0; j<resultmatrix.GetLength(1); j++)
                {
                    resultmatrix[i, j] = arr[i, j] + mas[i, j];
                }
            }
            return resultmatrix;
        }
        static int [,] Multiply(int [,] array, int [,] mas)
        {
            int[,] resultmatrix = new int[array.GetLength(1), mas.GetLength(0)];
            for (int i=0; i < resultmatrix.GetLength(0); i++)
            {
                for (int j=0; j < resultmatrix.GetLength(1); j++)
                {
                    for (int k=0; k<resultmatrix.GetLength(1); k++)
                    {
                        resultmatrix[i, j] += array[k, i] + mas[j, k];
                    }
                }
            }
            return resultmatrix;
        }
        static int [,] Transpose(int [,] mas)
        {
            for (int i=0; i<mas.GetLength(0); i++)
            {
                for (int j=i; j<mas.GetLength(1); j++)
                {
                    int temp = mas[i, j];
                    mas[i, j] = mas[j, i];
                    mas[j, i] = temp;
                }
            }
            return mas;
        }
    }
}
