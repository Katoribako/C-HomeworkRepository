//Задайте значения M и N. Напишите программу, которая найдёт
//сумму натуральных элементов в промежутке от M до N.

int naturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + naturalSum(m, n - 1);
}
Console.WriteLine("Please input M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input N ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = naturalSum(m, n);
Console.WriteLine($"Sum of natural elements is {sum} ");
