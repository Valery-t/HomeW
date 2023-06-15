using System;
class test {
  static void Main() 
  {
    Console.Write("Input first number ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second number ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input third number ");
    int c = Convert.ToInt32(Console.ReadLine());
    int max = a;
    if (b>max)
    {
        max=b;
    }
    if (c>max)
    {
        max=c;
    }
        Console.WriteLine($" max = {max}");
    }
}
