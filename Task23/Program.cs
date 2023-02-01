//Задайте прямоугольный двумерный массив. Напишите программу, которая будет
//находить строку с наименьшей суммой элементов.

int[,] Create2drandomArray(int rows, int columns, int minValue, int maxValue)
{
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
int sumOfRows(int[,] array, int i)
{
    int sumRow = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumRow += array[i, j];
    }
    return sumRow;
}
Console.WriteLine("Please input a number of row ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input a number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input a number of minvalue ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input a number of maxvalue ");
int maxValue = Convert.ToInt32(Console.ReadLine());
if (rows % 2 == 0 && columns % 2 == 0)
{
    int[,] array = Create2drandomArray(rows, columns, minValue, maxValue);
    Show2dArray(array);
    int minSum = 0;
    int sumRow = sumOfRows(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int MemorySum = sumOfRows(array, i);
        if (sumRow > MemorySum)
        {
            sumRow = MemorySum;
            minSum = i;
        }
    }
    Console.WriteLine($"{minSum + 1} row with minimal sum {sumRow} of elements ");
}
else { Console.WriteLine("Please input an even number "); }
