/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int [,] CreateArray (int rc, int min, int max){
    Random rand = new Random();
    int [,] array = new int [rc, rc];
    for (int i = 0; i < rc; i++)
    {     
        for (int j = 0; j < rc; j++)
            {
            array[i,j] = rand.Next(min,max+1);
            }
    }
    return array;
}
int SumOfElements (int [] array){
    int Sum = 0;
    for (int i=0; i<array.Length;++i){
            Sum+=array[i];
        }
    return Sum;   
    }
     
int MinSum (int [,] arr){
    int [] arr2 = new int [arr.GetLength(1)];
    int MinSum = 100;
    int Count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr2[j] = arr[i,j];    
                
            }
            if (MinSum>SumOfElements(arr2)){
                    MinSum = SumOfElements(arr2);
                    Count = i;
                }      
        }
return Count;
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
int [,] array = CreateArray(5,0,10);
PrintArray(array); 
Console.WriteLine($"The row with the smallest sum of elements => {MinSum(array)+1}");
