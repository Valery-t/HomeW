/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.456 -> 5
782 -> 8
918 -> 1
*/



   int getDigitNum (int num)
    {
       while (num>99 && num<1000)
       {
           int res = (num%100-num%10)/10;
           return res;
        }
    return 0;
    }
    string inputValidation (int n)
    {
        if (n>0)
        {
            string a = n.ToString();
            return a;
        }
        else 
        {
            return "incorrect input";
        }
    }

    Console.WriteLine("Enter a three-digit number");
    int DigitNum = Convert.ToInt32 (Console.ReadLine ());
    int result = getDigitNum (DigitNum);
    Console.WriteLine(inputValidation(result));
