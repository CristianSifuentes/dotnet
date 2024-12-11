using MathLibrary;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Matrix Operations Demo");

        double[,] matrixA = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        double[,] matrixB = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };

        Console.WriteLine("\nMatrix A:");
        MatrixOperations.PrintMatrix(matrixA);

        Console.WriteLine("\nMatrix B:");
        MatrixOperations.PrintMatrix(matrixB);

        Console.WriteLine("\nMatrix A + Matrix B:");
        var sum = MatrixOperations.Add(matrixA, matrixB);
        MatrixOperations.PrintMatrix(sum);

        Console.WriteLine("\nMatrix A * Matrix B:");
        var product = MatrixOperations.Multiply(matrixA, matrixB);
        MatrixOperations.PrintMatrix(product);
    }
}
