//Напишите программу, которая выводит третью цифру
//заданного числа или сообщает, что третьей цифры нет.

int cutnumber(int number)
{
    while (number > 999 || number < -999)
    {
    number = number / 10;
    }
    number = number % 10;
    return number;  
}
int plus(int number)
{
  while(number < 0)
  {
    number = -1 * number;
  }
  return number;
}
Console.WriteLine("Please input your number ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 100 || number <= -100 && number != 0)
{ 
    number = plus(number);
    Console.WriteLine($"Third number is {cutnumber(number)}");
}
else
{
    Console.WriteLine("Please input correct number");
}