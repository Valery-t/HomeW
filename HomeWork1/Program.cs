using System;
class test {
  static void Main() 
  {
    Console.Write("Input first number ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second number ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a>b)
    {
        Console.WriteLine($" max = {a}"); 
    }
    else
    {
        Console.WriteLine($" max = {b}");
    }
      }
}
