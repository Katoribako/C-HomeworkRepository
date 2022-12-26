//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

double cube (double number)
{
    return Math.Pow(number, 3);
}

Console.WriteLine("Please input your number ");
double cubenumb = Convert.ToDouble(Console.ReadLine());
if (cubenumb == 0)
{
    Console.WriteLine("Please input correct number ");
}
else
{
    if (cubenumb <= 1)
    {
        double cur = 1;
        while (cur <= 1 && cur >= cubenumb)
        {
            Console.Write($"{cube(cur)} ");
            cur--;
        }
    }
    else
    {
        double current = 1;
        while (current <= cubenumb)
        {
            Console.Write($"{cube(current)} ");
            current++;
        }
    }
}