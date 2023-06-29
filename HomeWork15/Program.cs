/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int [] CreateArray (int size, int min, int max){
    int [] array = new int [size];
    Random rand = new Random();
    for (int i=0; i<size; i++){
        array[i] = rand.Next(min,max+1);  
    }
    return array;
 }
string print (int [] array){
    return string.Join(", ", array);
 }
int CountOddPos (int [] arr){
   int Sum = 0;
   for (int i=0; i<arr.Length; i++){
    if (i%2 !=0){
        Sum += arr[i];
     }  
    }
    return Sum;
}

int [] array = CreateArray(5,-10,10);
int result = CountOddPos(array);
Console.WriteLine(print(array));
Console.WriteLine($"sum of odd position numbers => {result}");