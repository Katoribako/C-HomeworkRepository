//Задайте массив заполненный случайными положительными трёхзначными
//числами. Напишите программу, которая покажет количество чётных чисел
//в массиве.[345, 897, 568, 234] -> 2

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

int EvenSelector(int [] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) even++;
    }
    return even;
}


Console.WriteLine("Please input a length of array");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input a min of array");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input a max of array");
int max = Convert.ToInt32(Console.ReadLine());
if(min > 99 && min <= 999 && max > 99 && max <= 999 )
{
    int [] arr = CreateRandomArray(size, min, max);
    ShowArray(arr);
    Console.WriteLine("");
    Console.WriteLine($"The number of even numbers in the array is {EvenSelector(arr)}");

}
else
{
    Console.WriteLine("please enter correct numbers");
}



