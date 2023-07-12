/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int OutputRealDigit (int M,int N){
    
        int Sum = M;
        if (M == N){
            return Sum;
        } 
        return Sum + OutputRealDigit(M+1,N); 
    /* }
    else{
        Console.WriteLine($"Number \"{M}\" > {N}. Try again."); */
    }
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
void PrintAnswer (){
    int N=0;
    int M=0;
    do
    {
        M = GetNumber("Enter a first digit number");
        N = GetNumber("Enter a second digit number");
        if (N < M) Console.WriteLine($"First number should be less second number. Try again.");
    } while (N < M);
    Console.WriteLine($"The sum of natural elements between {M} and {N} is {OutputRealDigit(M,N)}");
}

PrintAnswer();