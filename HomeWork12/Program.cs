/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
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
 
 void GetSumDigInNum (){
        int n = GetNumber("Enter digit");
        int sum = 0;
        while(n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine(sum);
 }
    
   GetSumDigInNum();

