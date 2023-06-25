/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */



void Print (string text){
    Console.WriteLine(text);
}

int GetIntNum (){
    int numX = Convert.ToInt32(Console.ReadLine());
    return numX;
}

string CheckPolindrom (string digit)
{
    for (int i=0; i < digit.Length/2; i++)
    {
        if (digit[i] != digit[digit.Length-i-1])
            {
                return "no";
            }
             
    }  
    return "yes";     
} 
Print("enter a five-digit number");
int N = GetIntNum();
string res = CheckPolindrom($"{N}");
Print($"{N} -> {res}");
