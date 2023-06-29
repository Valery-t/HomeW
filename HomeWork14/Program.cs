/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
 */

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
int CountEvenNumb (int [] arr){
   int Count = 0;
   foreach (int el in arr){
    Count += el%2 == 0 ? 1:0;
    }
    return Count;
}


int [] array = CreateArray(10,100,999);
int result = CountEvenNumb(array);
Console.WriteLine(print(array));
Console.WriteLine($"Number of even numbers => {result}");
