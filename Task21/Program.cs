//Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.

int[,] Create2drandomArray(int rows, int columns, int MinValue, int MaxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(MinValue, MaxValue + 1);
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
void averageOfColumns(int[,] array)
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        sum /= array.GetLength(0);
Console.WriteLine($"AVG of {i} row is {sum}");
    }
}

Console.Write("Please input number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number of MinValue ");
int MinValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number of MaxValue ");
int MaxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2drandomArray(rows, columns, MinValue, MaxValue);
Show2dArray(array);
averageOfColumns(array);
