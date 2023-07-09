/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
 */

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
int [] MakeSort (int [] array){
    int temp;
    for (int i=0; i<array.Length-1;++i){
        for (int j=i+1; j<array.Length;++j){
            if(array[i]<array[j]){
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        
    }
    return array; 
}
int [,] SortArray (int [,] arr){
    int [] arr2 = new int [arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr2[j] = arr[i,j];
            }
        arr2 = MakeSort(arr2);
        for (int k=0; k < arr2.Length; ++k)
            {
            arr[i,k] = arr2[k];
            } 
        }
return arr;
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
int [,] array = CreateArray(3,5,0,10);
PrintArray(array); 
SortArray(array);
Console.WriteLine();
PrintArray(array);

