//Задайте двумерный массив. Напишите программу, которая упорядочит по
//убыванию элементы каждой строки двумерного массива.

int[,] Create2drandomArray()
{
    Console.WriteLine("Please input a number of row ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input a number of columns ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input a number of minvalue ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input a number of maxvalue ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void SortDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int memory = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = memory;
                }
            }
        }
    }
}

int[,] array = Create2drandomArray();
Show2dArray(array);
SortDescending(array);
Show2dArray(array);
