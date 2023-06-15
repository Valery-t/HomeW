/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

using System;
class test {
  static void Main() 
  {
    Console.Write("Input number ");
    Double n = Convert.ToDouble(Console.ReadLine());
    if (n % 2 == 0)
    {
        Console.WriteLine($"yes, {n} - number is even");
    }
    else
    {
        Console.WriteLine($"no, {n} - number is not even");
    }
    }
}
