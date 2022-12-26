// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

bool polidrome(int num)
{
    int reversivenum = 0;
    int memorynum = num;
    while (num > 0)
    {
        int lastnum = num % 10;
        reversivenum = reversivenum * 10 + lastnum;
        num = num / 10;
    }
    return reversivenum == memorynum;
}

Console.WriteLine("Please input your number ");
int num = Convert.ToInt32(Console.ReadLine());
if (polidrome(num))Console.WriteLine($"{num} is polidrome");
else Console.WriteLine($"{num} is not polidrome");
