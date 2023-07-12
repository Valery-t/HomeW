/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

string OutputRealDigit (int Number){
    if (Number == 1) return Number.ToString();
    
    return Number + ", " + OutputRealDigit(Number-1);
     
}
int GetIntNum (){
    int numX = Convert.ToInt32(Console.ReadLine());
    return numX;
}
void Print (string text){
    Console.WriteLine(text);
}
void PrintAnswer (){
    Print("Enter a digit number");
    int N = GetIntNum();
    Console.WriteLine($"All natural numbers between {N} and 1");
    Console.WriteLine(OutputRealDigit(N));
}

PrintAnswer();
