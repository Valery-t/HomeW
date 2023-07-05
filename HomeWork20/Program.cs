/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

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

void CheckPosOfElement (){
    int [,] array = CreateArray(5,5,0,10);
    int PosRow = GetNumber("enter the position element of the row");
    int PosColumn = GetNumber("enter the position element of the column");
    if (PosRow > array.GetLength(0) || PosColumn > array.GetLength(1)){
        Console.WriteLine("no such element");
    }
    else{
        Console.WriteLine($"{PosRow} {PosColumn} => {array[PosRow-1,PosColumn-1]}");
    }
    PrintArray(array);
}
CheckPosOfElement();

