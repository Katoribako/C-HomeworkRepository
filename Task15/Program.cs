/*Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.*/

int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];
    Random random = new Random(); 
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minVal, maxVal + 1);
    }
    return array;
}
void ShowArray(int[] array) 
{ 
    Console.Write("Your array is [ " ); 
    for (int i = 0; i < array.Length - 1; i++) 
        Console.Write(array[i] + " | "); 
    Console.Write($"{array[array.Length - 1]} ]"); 
    Console.WriteLine(); 
}
int UnEvenSum(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
Console.WriteLine("Please input a length of array");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input a min of array");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input a max of array");
int max = Convert.ToInt32(Console.ReadLine());
int [] arr = CreateRandomArray(size, min, max);
ShowArray(arr);
Console.WriteLine("");
Console.WriteLine($"Sum is {UnEvenSum(arr)}");
