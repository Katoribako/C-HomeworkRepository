//Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int SumCounterNum(int size) 
{ 
    int counter = 0;
    for (int i = 0; i < size; i++) 
    {
        Console.WriteLine($"Please input {i + 1} number ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0) counter ++;
    }
    return counter;
}
Console.WriteLine("Please enter the number of numbers you would like to enter ");
int numOfNum = Convert.ToInt32(Console.ReadLine());
if (numOfNum > 0){int sum = SumCounterNum(numOfNum);
    Console.WriteLine($"number of positive numbers is {sum}");}
else{Console.WriteLine("Please input correct number");}