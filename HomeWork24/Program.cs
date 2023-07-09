/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int DIM = 2;
int[,] InitializationMatrix()
    {
        int [,] matrix = new int[DIM, DIM];

        Random rand = new Random();

        for (int i = 0; i < DIM; i++)
        {
            for (int j = 0; j < DIM; j++)
            {
                matrix[i, j] = rand.Next(1, 10);
            
            }
            
        }

        return matrix;
    }
int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
    {
        int [,] resultMatrix = new int[DIM, DIM];

        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < secondMatrix.GetLength(0); k++)
                {
                    resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
                
            }
            
        }

        return resultMatrix;
    }
void PrintArray (int[,] array){
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < row; i++)
     {
        Console.Write("[ ");
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i,j]}\t");
            
        }  
        Console.Write("]");
        Console.WriteLine();    
    }
}
int [,] A = InitializationMatrix();
int [,] B = InitializationMatrix();            
int [,] C = MultiplicationMatrix(A, B);
PrintArray(A);
Console.WriteLine();
PrintArray(B);
Console.WriteLine();
Console.WriteLine($"Resulting matrix: ");
PrintArray(C);