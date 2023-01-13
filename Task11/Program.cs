/*Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.*/

double exponentiation (double num, double exp)
{
    double result = Math.Pow(num, exp);
    return result;
}
Console.WriteLine("Write a loop that takes two numbers (A and B) as input");
Console.WriteLine("and raises A to the power of B.");
Console.WriteLine();
Console.WriteLine("Please input first number ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input second number ");
double power = Convert.ToDouble(Console.ReadLine());
if (number != 0){double result = exponentiation(number, power);
Console.WriteLine($"Result is {result}");}
else{Console.WriteLine("Please input correct number");}


