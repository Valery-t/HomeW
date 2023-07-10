/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
 */

 int [,] CreateArray (int rc){
    int minRow = 0; int maxRow = rc-1;
    int minCol = 0; int maxCol = rc-1;
    int Count = 1;
    int Max = rc*rc;
    int [,] array = new int [rc, rc];
    
    while(Count<=Max)
    {
        for (int i = minCol; i<=maxCol; ++i){
            array[minRow,i] = Count;
            Count+=1;
        }
        ++minRow;
        for (int i = minRow; i<=maxRow; ++i){
            array[i,maxCol] = Count;
            Count+=1;
        }
        --maxCol;
        for (int i = maxCol; i>=minCol; --i){
            array[maxRow,i] = Count;
            Count+=1;
        }
        --maxRow;
        for (int i = maxRow; i>=minRow; --i){
            array[i,minCol] = Count;
            Count+=1;
        }
        ++minCol; 
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
int [,] array = CreateArray(4);
PrintArray(array); 

