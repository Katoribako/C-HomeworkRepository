//Напишите программу, которая принимает на вход координаты
//двух точек и находит расстояние между ними в 3D пространстве.

double distance (double x1, double y1, double x2, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2)+ Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

Console.Write("Input a x1 please ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a y1 please ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a z1 please ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a x2 please ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a y2 please ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a z2 please ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The distance between the points is {Math.Round(distance(x1, y1, x2, y2, z1, z2),2)}");