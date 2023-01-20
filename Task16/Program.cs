/*Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.*/

double[] CreateRandomArray(int length, int minValue, int maxValue) 
 { 
     double[] array = new double[length]; 

     for(int i = 0; i < length; i++) 
     { 
         array[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble(); 
     } 
     return array; 
 }
void ShowArray(double[] array) 
{ 
    Console.Write("Your array is [ " ); 
    for (int i = 0; i < array.Length - 1; i++)

        Console.Write(array[i] + " | "); 
    Console.Write($"{array[array.Length - 1]} ]"); 
    Console.WriteLine(); 
}
void MinMax(double[] array)
{
    double[] arr = array;
    Console.WriteLine($"Minimum number is {arr.Min()}");
    Console.WriteLine($"Maximum number is {arr.Max()}");
}
Console.WriteLine("Please input a length of array");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input a min of array");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input a max of array");
int max = Convert.ToInt32(Console.ReadLine());
double [] arr = CreateRandomArray(size, min, max);
ShowArray(arr);
Console.WriteLine("");
MinMax(arr);
