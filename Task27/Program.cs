//Задайте значение N. Напишите программу, которая выведет все натуральные
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNums(int number)
{
    if (number > 1)
    {
        Console.Write(number + ", ");
        ShowNums(number - 1);
    }
    if (number < 1)
    {
        Console.Write(number + ", ");
        ShowNums(number + 1);
    }
}
Console.WriteLine("Please input a number ");
int n = Convert.ToInt32(Console.ReadLine());
if(n == 1)
{
    Console.WriteLine("Please input a correct number ");
}
else ShowNums(n);