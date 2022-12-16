//Напишите программу, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.

Console.Write("Please input a first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input a second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input a third number: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
Console.Write("The max is ");
Console.WriteLine(max);