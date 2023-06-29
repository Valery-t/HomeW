/* Задача 38 Задайте массив вещественных чисел. Найдите разницу между максимальной 
и минимальной вещественной частью элементов массива. */


string print (double [] array){
    return string.Join(", ", array);
 } 

double [] CreateArray (int size, double min, double max){
    double [] array = new double [size];
    Random rand = new Random();
    for (int i=0; i<size; i++){
        array[i] = Math.Round((rand.NextDouble()*(max - min) + min),2);  
    }
    return array;
 }
double [] array = CreateArray(5,1.0,10.0);
 Console.WriteLine(print(array));

double CountOddPos (double [] arr){
   double max = 0.0;
    double min = arr[0];
   foreach (double el in arr){
    
        if (el>max){
            max = el;
            }
        if (el<min){
            min = el;
            }
    } 
    return max-min;
}
double result = CountOddPos(array);
Console.WriteLine($"the difference between the maximum and the minimum array elements => {result}"); 