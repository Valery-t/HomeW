/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

float GetNumber (string Description)
{
    float number;
    Console.Write($"{Description}=> ");
    while(true){
        string temp = Console.ReadLine();
        if (float.TryParse(temp, out number))
        {
            return number;
        }
        Console.WriteLine($"Number \"{temp}\" is wrong. Try again.");
    }
}

float b1 = GetNumber("Enter point value b1: ");
float k1 = GetNumber("Enter point value k1: ");
float b2 = GetNumber("Enter point value b2: ");
float k2 = GetNumber("Enter point value k2: ");

float y = (k2*b1-k1*b2)/(k2-k1);
float x = (b1-b2)/(k2-k1);
if (k1==k2)
{
    Console.Write("Straight lines are parallel");
}
else
Console.Write($"Intersection of lines in a coordinate: ({Math.Round(x,3)}, {Math.Round(y,3)})");