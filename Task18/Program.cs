//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

double FindAPointX(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}
double FindAPointY(double b1, double k1, double b2, double k2)
{
    return (k1 *(b2 - b1) / (k1 - k2) + b1);
}
void CrossingDetect(double b1, double k1, double b2, double k2)
{
    if ((k1 == k2) && (b1 == b2))
    Console.WriteLine("Direct match");
    if ((k1 == k2) && (b1 != b2))
    Console.WriteLine("Lines are parallel");
    else
    {
        double x = FindAPointX(b1, k1, b2, k2);
        double y = FindAPointY(b1, k1, b2, k2);
        Console.WriteLine(x + " " + y + " " + "intersection point");
    }
    
}
Console.Write("Input a b1 please ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a k1 please ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a b2 please ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a k2 please ");
double k2 = Convert.ToDouble(Console.ReadLine());

CrossingDetect(b1, k1, b2, k2);




