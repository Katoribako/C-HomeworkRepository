//Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateArray(int length)
{
    int[] array = new int[length];

    for(int i = 0; i < length; i++)
    {
        Console.Write($"Input a {i + 1} element: ");
        array[i]= Convert.ToInt32(Console.ReadLine());
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
Console.WriteLine("Please input a length of array");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(m);
ShowArray(array);


