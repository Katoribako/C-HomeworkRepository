//Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

int akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return akkerman(m - 1, 1);
    else
        return akkerman(m - 1, akkerman(m, n - 1));
}
Console.WriteLine("Please input M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input N ");
int n = Convert.ToInt32(Console.ReadLine());
int akkermanFunc = akkerman(m , n);
Console.WriteLine($"result of akkerman function is {akkermanFunc} ");