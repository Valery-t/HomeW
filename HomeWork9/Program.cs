/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
 */

void Print (string text){
    Console.WriteLine(text);
}

int GetIntNum (){
    int numX = Convert.ToInt32(Console.ReadLine());
    return numX;
}

double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2 )
{
    double calc = Math.Sqrt(((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2))+(z1-z2)*(z1-z2));
    return calc;
}

Print("enter point coordinates x1, y1, z1, x2, y2, z2");
int corX1 = GetIntNum();
int corY1 = GetIntNum();
int corZ1 = GetIntNum();
int corX2 = GetIntNum();
int corY2 = GetIntNum();
int corZ2 = GetIntNum();

double res = FindDistance(corX1,corY1,corZ1,corX2,corY2,corZ2);
Print($"distance between two points -> {res.ToString("F" + 2)}"); 
