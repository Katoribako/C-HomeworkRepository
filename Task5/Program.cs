//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

int cutnumber(int number) 
{
 int ten = number / 10;
 int remainder = ten % 10;
 return remainder;
}
Console.WriteLine("Please input your number ");
int number = Convert.ToInt32(Console.ReadLine());
if((-999 <= number && number <= -100) || (number <= 999 && number >= 100 && number != 0))
{
    if (1 <= number && number <= 999)
    {
    Console.WriteLine($"Second number is " + (cutnumber(number)));
    }
    else
    {
    Console.WriteLine($"Second number is " + (-1 *(cutnumber(number))));
    }
}
else
{
    Console.WriteLine("Please input correct number");
}