/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
 */

 int OutputAckerman (int N,int M){ 

  if (N == 0)
    return M + 1;
  else
    if ((N != 0) && (M == 0))
      return OutputAckerman(N - 1, 1);
    else
      return OutputAckerman(N - 1, OutputAckerman(N, M - 1));

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
        if (N < 0 || M < 0) Console.WriteLine($" Numbers must be positive. Try again.");
    } while (N < 0 || M < 0);
    Console.WriteLine($"A({M},{N}) = {OutputAckerman(M,N)}");
}

PrintAnswer();