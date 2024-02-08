namespace App3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input the size of the square matrix (less than 5):");
        var n = Convert.ToInt32(Console.ReadLine());
        
        int[,] firstMatrix = new int[n, n];
        int rows = firstMatrix.GetLength(0);
        int columns = firstMatrix.GetLength(1);

        Console.WriteLine("Input elements in the first matrix:");
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                Console.Write("element [" + i + ";" + j + "]: ");
                firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        int[,] secondMatrix = new int[n, n];
        Console.WriteLine("\nInput elements in the second matrix:");
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                Console.Write("element [" + i + ";" + j + "]: ");
                secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        int[,] additionMatrix = new int[n, n];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++)
                additionMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
        }
        
        Console.WriteLine("\nThe First matrix is:");
        PrintMatrix(firstMatrix, rows, columns);
        
        Console.WriteLine("\nThe second matrix is:");
        PrintMatrix(secondMatrix, rows, columns);
        
        Console.WriteLine("\nThe Addition of two matrix is:");
        PrintMatrix(additionMatrix, rows, columns);
    }

    private static void PrintMatrix(int[,] matrix, int rows, int columns) {
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}