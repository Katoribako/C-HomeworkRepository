//Задайте две матрицы. Напишите программу, которая
// будет находить произведение двух матриц.

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

int columnsRowReplacer(int row, int column)
{
    int memory = column;
    column = row;
    row = memory;
    return row;
}

int rowColumnsReplacer(int row, int column)
{
    int memory = row;
    row = column;
    column = memory;
    return column;
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
void matrixMultiplication(int[,] firsMatrix, int[,] secMatrix, int[,] multiResult)
{
    for (int i = 0; i < multiResult.GetLength(0); i++)
    {
        for (int j = 0; j < multiResult.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firsMatrix.GetLength(1); k++)
            {
                sum += firsMatrix[i, k] * secMatrix[k, j];
            }
            multiResult[i, j] = sum;
        }
    }
}

Console.WriteLine("Please input a number of row ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input a number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input a number of minvalue ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input a number of maxvalue ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = Create2drandomArray(rows, columns, minValue, maxValue);
Console.WriteLine("First matrix is");
Show2dArray(firstMatrix);
int secRow = columnsRowReplacer(rows, columns);
int secColumn = rowColumnsReplacer(rows, columns);
int[,] secondMatrix = Create2drandomArray(secRow, secColumn, minValue, maxValue);
Console.WriteLine("Second matrix is");
Show2dArray(secondMatrix);
int[,] multiplyResultMatrix = new int[rows, secColumn];
matrixMultiplication(firstMatrix, secondMatrix, multiplyResultMatrix);
Console.WriteLine("Result of multiplcation of matrix is ");
Show2dArray(multiplyResultMatrix);
