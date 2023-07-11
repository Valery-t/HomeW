/* Задача 60. ...Сформируйте двухмерный массив из неповторяющихся двузначных чисел. 
Массив размером 4 x 2 
66 25
34 41
27 90
26 55*/

int [,] CreateArray (int row, int column){
    int [,] array = new int [row, column];
    int [] Uarr = CreateRandomArray(10,90);
    int K = 0;
    for (int i = 0; i < row; i++)
    {     
        for (int j = 0; j < column; j++)
            {
            array[i,j] = Uarr[K];
            ++K;
            }
    }
    return array;
}
int[] CreateRandomArray(int minValue, int length)
    {
        Random rand = new Random();
        int[] array = new int[length];
        for (int i = 0; i < length; ++i)
        {
            bool isUnique;
            do
            {
                array[i] = rand.Next(minValue, minValue + length);
                isUnique = true;
                for (int j = 0; j < i; ++j)
                    if (array[i] == array[j])
                    {
                        isUnique = false;
                        break;
                    }
            } 
            while (!isUnique);
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
int [,] array = CreateArray(9,10);
PrintArray(array); 






