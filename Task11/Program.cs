/*Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.*/

int power(int num, int pwr)
{
    int summ = 1;
    for(int current = 1; current <= pwr; current++)
    {
       summ *= num;
    }
    return summ;
}
Console.WriteLine("Write a loop that takes two numbers (A and B) as input");
Console.WriteLine("and raises A to the power of B.");
Console.WriteLine();
Console.WriteLine("Please input first number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input second number ");
int pwr = Convert.ToInt32(Console.ReadLine());
if (number != 0){int result = power(number, pwr);
Console.WriteLine($"Result is {result}");}
else{Console.WriteLine("Please input correct number");}


