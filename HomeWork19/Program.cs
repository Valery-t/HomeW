/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
int GetNumber (string Description)
{
    int number;
    Console.Write($"{Description}=> ");
    while(true){
        string temp = Console.ReadLine();
        if (int.TryParse(temp, out number))
        {
            return number;
        }
        Console.WriteLine($"Number \"{temp}\" is wrong. Try again.");
    }
}

double [,] CreateArray (int row, int column, int min, int max){
    Random rand = new Random();
    double [,] array = new double [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            {
            array[i,j] = Convert.ToDouble(rand.Next(min,max+1))/10;
            }
        
    }
    return array;
}

void PrintArray (double[,] array){
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < row; i++)
     {
        Console.Write("[ ");
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i,j]:f1}\t");
            
        }  
        Console.Write("]");
        Console.WriteLine();    
    }
}
int row = GetNumber("enter number of rows");
int column = GetNumber("enter number of columns");
double [,] array = CreateArray(row,column,-100,100);
PrintArray(array);
