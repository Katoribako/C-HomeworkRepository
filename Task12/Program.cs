/*Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.*/
    int summ(int num)
{
    int sum = 0;
    for(int i = num; i != 0; i /= 10)
    {
        sum += i % 10;
    }
    return sum;
}
Console.WriteLine("Please input a number ");
int numb = Convert.ToInt32(Console.ReadLine());
int sum = summ(numb);
Console.WriteLine($"sum of all digits of a number {numb} is {sum}");
