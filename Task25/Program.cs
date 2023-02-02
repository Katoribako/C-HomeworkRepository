//...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента.

void create3dArray(int[,,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int num;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        num = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    num = temp[i];
                }
                num = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = temp[count];
                count++;
            }
        }
    }
}
void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"row({i + 1}) column({j + 1}) ");
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"layer({k + 1})={array[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Please input a number of rows ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input a number of columns ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input a number of layers ");
int layer = Convert.ToInt32(Console.ReadLine());
int[,,] array3d = new int[row, column, layer];
create3dArray(array3d);
Console.WriteLine("3D array with non-repeating 2-digit integers is ");
Console.WriteLine();
Show3dArray(array3d);