/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/



   int getDayNum (int num)
    {
       switch (num)
       {
        case 6: return 1;
        case 7: return 1;
        default: return 0;
       }
    }
    string inputValidation (int n)
    {
        if (n>0)
        {
            string a = n.ToString("Yes");
            return a;
        }
        else 
        {
            return "No";
        }
    }

    Console.WriteLine("Enter a Day Number");
    int DigitNum = Convert.ToInt32 (Console.ReadLine ());
    int result = getDayNum (DigitNum);
    Console.WriteLine(inputValidation(result));
