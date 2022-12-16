//Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).

Console.Write("Please input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0){Console.Write(number + " is even number");}
else{Console.Write(number + " is not even number");}