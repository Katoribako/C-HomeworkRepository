//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Please input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;
while(current <= number)
{
    if(current % 2 == 0)
    {
    Console.Write(current + " ");
    current = current + 2;
    }
    else
    {
    current = current + 1;
    }
}