using System;

namespace MathLibrary
{
    public static class MatrixOperations
    {
        // Matrix Addition
        public static double[,] Add(double[,] matrixA, double[,] matrixB)
        {
            if (matrixA.GetLength(0) != matrixB.GetLength(0) ||
                matrixA.GetLength(1) != matrixB.GetLength(1))
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }

            int rows = matrixA.GetLength(0);
            int cols = matrixA.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            return result;
        }

        // Matrix Multiplication
        public static double[,] Multiply(double[,] matrixA, double[,] matrixB)
        {
            if (matrixA.GetLength(1) != matrixB.GetLength(0))
            {
                throw new ArgumentException("Number of columns in Matrix A must match rows in Matrix B.");
            }

            int rows = matrixA.GetLength(0);
            int cols = matrixB.GetLength(1);
            int innerDim = matrixA.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    for (int k = 0; k < innerDim; k++)
                    {
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return result;
        }

        // Display Matrix
        public static void PrintMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],8:F2} ");
                }
                Console.WriteLine();
            }
        }
    }
}
