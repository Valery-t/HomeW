/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */


void Print (string text){
    Console.WriteLine(text);
}
int CheckMoreThanNull (int [] arr)
{
    int Count = 0; 
    foreach (int item in arr)
    {
        if (item>0)
        {
            Count+=1;
        }
    }
    return Count;
}
void SetMArray ()
{
    Console.Write("Size M-array is = ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"A[{i}] = ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    string g = string.Join(", ",arr);
    Print($"Array => {g}");
    Print($"check more than 0 => {CheckMoreThanNull(arr)}");
}
SetMArray();