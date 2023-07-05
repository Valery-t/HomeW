/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
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


int [,] CreateArray (int row, int column, int min, int max){
    Random rand = new Random();
    int [,] array = new int [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            {
            array[i,j] = rand.Next(min,max+1);
            }
        
    }
    return array;
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

void CalcArithAverage (){
   
    int Row = GetNumber("enter the position element of the row");
    int Column = GetNumber("enter the position element of the column");
    int [,] array = CreateArray(Row,Column,0,10);
    double average = 0;
    Console.WriteLine($"arithmetic average over columns:\t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average+= array[i,j];
        }
        average /= Row;
        Console.Write("{0:f1}" + "; ",average);
        average = 0;
    }
    
    Console.WriteLine();

    PrintArray(array);
}
CalcArithAverage();

