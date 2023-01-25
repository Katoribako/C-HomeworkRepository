//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

double[,] RandomReal2DArray()
{
    Console.WriteLine("Please input a number of rows");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input a number of columns");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input number of MinValue");
    int MinValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input number of MaxValue ");
    int MaxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(MinValue, MaxValue + 1)
            + new Random().NextDouble();
        }
    }
    return array;

}
void Show2dArray(double[,] array)
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

double[,] newArray = RandomReal2DArray();
Show2dArray(newArray);
