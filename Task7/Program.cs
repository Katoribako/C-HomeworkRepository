// Напишите программу, которая принимает на вход цифру, обозначающую день
//недели, и проверяет, является ли этот день выходным.

bool hoilday(int numberofaday)
{
if (numberofaday > 7 || numberofaday <= 5 || numberofaday < 1) return false;
return true;
}

Console.Write("Please input a number of a day (1-7): ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine("Please input correct number");
}
else
{
    bool weekend = hoilday(number);
    if (weekend){Console.WriteLine("This is holiday!" );}
    else{Console.WriteLine("This is not holiday!");}
}


