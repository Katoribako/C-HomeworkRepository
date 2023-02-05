//Напишите программу, которая заполнит спирально массив 4 на 4.


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

Console.WriteLine("Please input a size of array ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = new int[n, n];

int memory = 1;
int i = 0;
int j = 0;

while (memory <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
    Matrix[i, j] = memory;
    memory++;
    if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= Matrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > Matrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

Show2dArray(Matrix);
