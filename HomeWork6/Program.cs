/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int getDigitNum (int n)
    {
         int result = -1;
            if (n >99)
            {
                while (n > 999)
                {
                n =n / 10;
                }
                result =n % 10;
            }
            return result; 
    }

    string inputValidation (int n)
    {
        if (n!=-1)
        {
            string a = n.ToString();
            return a;
        }
        else 
        {
            return "the third digit is missing";
        }
    }

Console.WriteLine("Enter digit");
int DigitNum = Convert.ToInt32 (Console.ReadLine ());
int res = getDigitNum (DigitNum);
Console.WriteLine(inputValidation(res));
