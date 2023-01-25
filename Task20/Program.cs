//Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

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
void ElementDetector(int[,] array, int rows, int columns, int numOfRow, int numOfColumn)
{
    if (numOfRow <= rows && numOfRow >= 0
    && numOfColumn <= columns && numOfColumn >= 0)
        Console.WriteLine($"the value of this element is {array[numOfRow, numOfColumn]}");
    else 
    Console.WriteLine("There is no element");
}
Console.Write("Please input number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number of MinValue ");
int MinValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number of MaxValue ");
int MaxValue = Convert.ToInt32(Console.ReadLine());

int[,] Array = Create2drandomArray(rows, columns, MinValue, MaxValue);
Show2dArray(Array);

Console.WriteLine("Please enter the row number you need ");
int numOfRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the column number you need ");
int numOfColumn = Convert.ToInt32(Console.ReadLine());

ElementDetector(Array, rows, columns, numOfRow, numOfColumn);
