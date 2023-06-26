/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


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

int GetPow (int a, int b){
    int ab = 1;
    for (int i = 1; i <= b; i ++){
        ab *=a;
    }
    return ab;
}
int a = GetNumber("Enter digit");
int b = GetNumber("Enter exponent for a number");
int ab = GetPow(a,b);
Console.WriteLine($"{a}^{b}={ab}");
