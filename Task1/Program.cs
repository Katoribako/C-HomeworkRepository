//Напишите программу, которая на вход принимает два числа
//и выдаёт, какое число большее, а какое меньшее.

Console.Write("Please input a first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input a second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB){Console.Write(numberA + " bigger than " + numberB);}
else{Console.Write(numberB + " bigger than " + numberA);}