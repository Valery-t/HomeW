/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

void Print (string text){
    Console.WriteLine(text);
}

void SetAnArray (int [] arr)
{
    int min = 1;
    int max = 10;

    for (int i=0; i < arr.Length-1;i++){
        arr[i] = new Random().Next(min,max);
    }
    string g = string.Join(", ",arr);
    Print($"Array => {g}");
}
int [] array = new int[8];
SetAnArray(array);




